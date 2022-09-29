using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeePayrollDB.Database;
using EmployeePayrollDB.HR;
using EmployeePayrollDB.Repository;
using System.Text.RegularExpressions;

namespace EmployeePayrollWinForm
{
    public partial class Form1 : Form
    {
        private LocalEmployeeRepository localRepository;

        public Form1()
        {
            InitializeComponent();
            localRepository = new LocalEmployeeRepository();
            using (var sql_db = new SQLConnect())
            {
                sql_db.LoadAllEmployeeData(localRepository);
            }
            label_error.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadListBoxData();
        }

        private void employeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get selected item
            Employee employee = (Employee)employeeListBox.SelectedItem;
            if (employee != null)
            {
                textbox_id.Text = employee.Id.ToString();
                textbox_fn.Text = employee.FirstName;
                textbox_ln.Text = employee.LastName;
                date_time_birthdate.Value = employee.BirthDate;
                textbox_em.Text = employee.Email;
                gen_payrol.Visible = true;
                hours_worked_textbox.Text = "0";
                hours_worked_textbox.Visible = true;
                hours_worked_label.Visible = true;
                gen_payroll_btn.Visible = true;
                result_payroll.Visible = true;
                result_payroll.Text = "";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // allow only numbers to id
            string id_pattern = @"^[0-9]+$";
            string id_number = textbox_id.Text;
            Match id_match = Regex.Match(id_number, id_pattern);
            if (!id_match.Success)
            {
                label_error.Text = "ID must be a number";
                return;
            }

            // getting employee details
            string firstname = textbox_fn.Text;
            string lastname = textbox_ln.Text;
            string email = textbox_em.Text;
            DateTime birthdate = date_time_birthdate.Value;

            if (localRepository.GetEmployee(id_number) != null)
                localRepository.Remove(localRepository.GetEmployee(id_number));

            if (Convert.ToInt32(id_number) < 1000)
            {
                localRepository.Register(new Developer(Convert.ToInt32(id_number), firstname, lastname, birthdate, email));
            }
            else
            {
                localRepository.Register(new Manager(Convert.ToInt32(id_number), firstname, lastname, birthdate, email));
            }

            loadListBoxData();
            label_error.Text = "";
        }

        private void loadListBoxData() 
        {
            employeeListBox.DataSource = null;
            localRepository.GetData().Sort();
            employeeListBox.DataSource = localRepository.GetData();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textbox_id.Text = "";
            textbox_fn.Text = "";
            textbox_ln.Text = "";
            date_time_birthdate.Value = DateTime.Now;
            textbox_em.Text = "";
            gen_payrol.Visible = false;
            hours_worked_textbox.Text = "0";
            hours_worked_textbox.Visible = false;
            hours_worked_label.Visible = false;
            gen_payroll_btn.Visible = false;
            result_payroll.Visible = false;
        }

        private void gen_payroll_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)employeeListBox.SelectedItem; 
            if(employee != null)
            {
                // allow only numbers to id
                string hours_pattern = @"^[0-9]+$";
                string hours_pattern_number = hours_worked_textbox.Text;
                Match hour_match = Regex.Match(hours_pattern_number, hours_pattern);
                if (!hour_match.Success)
                {
                    result_payroll.Text = "Hours must be a number";
                    return;
                }
                employee.Work(Convert.ToInt32(hours_pattern_number));
                loadListBoxData();
                result_payroll.Text = employee.GeneratePayroll();
                
            }
        }

        private void save_db_Click(object sender, EventArgs e)
        {
            using (var sql_connection = new SQLConnect())
                sql_connection.SaveAllEmployeeData(localRepository);
        }
    }
}
