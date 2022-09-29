
namespace EmployeePayrollWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_fn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_ln = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_em = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.date_time_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label_error = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.gen_payrol = new System.Windows.Forms.Label();
            this.hours_worked_textbox = new System.Windows.Forms.TextBox();
            this.hours_worked_label = new System.Windows.Forms.Label();
            this.result_payroll = new System.Windows.Forms.Label();
            this.gen_payroll_btn = new System.Windows.Forms.Button();
            this.save_db = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 15;
            this.employeeListBox.Location = new System.Drawing.Point(12, 37);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(776, 199);
            this.employeeListBox.TabIndex = 0;
            this.employeeListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(651, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Details";
            // 
            // textbox_fn
            // 
            this.textbox_fn.Location = new System.Drawing.Point(86, 317);
            this.textbox_fn.Name = "textbox_fn";
            this.textbox_fn.Size = new System.Drawing.Size(228, 23);
            this.textbox_fn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee data form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Firstname";
            // 
            // textbox_ln
            // 
            this.textbox_ln.Location = new System.Drawing.Point(86, 346);
            this.textbox_ln.Name = "textbox_ln";
            this.textbox_ln.Size = new System.Drawing.Size(228, 23);
            this.textbox_ln.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birthdate";
            // 
            // textbox_id
            // 
            this.textbox_id.Location = new System.Drawing.Point(86, 288);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.Size = new System.Drawing.Size(228, 23);
            this.textbox_id.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee ID";
            // 
            // textbox_em
            // 
            this.textbox_em.Location = new System.Drawing.Point(86, 404);
            this.textbox_em.Name = "textbox_em";
            this.textbox_em.Size = new System.Drawing.Size(228, 23);
            this.textbox_em.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(25, 464);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(137, 51);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // date_time_birthdate
            // 
            this.date_time_birthdate.Location = new System.Drawing.Point(86, 375);
            this.date_time_birthdate.Name = "date_time_birthdate";
            this.date_time_birthdate.Size = new System.Drawing.Size(228, 23);
            this.date_time_birthdate.TabIndex = 15;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(86, 445);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(31, 16);
            this.label_error.TabIndex = 16;
            this.label_error.Text = "Error";
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_button.Location = new System.Drawing.Point(168, 464);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(137, 51);
            this.clear_button.TabIndex = 17;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // gen_payrol
            // 
            this.gen_payrol.AutoSize = true;
            this.gen_payrol.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gen_payrol.Location = new System.Drawing.Point(388, 249);
            this.gen_payrol.Name = "gen_payrol";
            this.gen_payrol.Size = new System.Drawing.Size(160, 25);
            this.gen_payrol.TabIndex = 18;
            this.gen_payrol.Text = "Generate Payroll";
            this.gen_payrol.Visible = false;
            // 
            // hours_worked_textbox
            // 
            this.hours_worked_textbox.Location = new System.Drawing.Point(445, 288);
            this.hours_worked_textbox.Name = "hours_worked_textbox";
            this.hours_worked_textbox.Size = new System.Drawing.Size(103, 23);
            this.hours_worked_textbox.TabIndex = 19;
            this.hours_worked_textbox.Visible = false;
            // 
            // hours_worked_label
            // 
            this.hours_worked_label.AutoSize = true;
            this.hours_worked_label.Location = new System.Drawing.Point(358, 291);
            this.hours_worked_label.Name = "hours_worked_label";
            this.hours_worked_label.Size = new System.Drawing.Size(81, 15);
            this.hours_worked_label.TabIndex = 20;
            this.hours_worked_label.Text = "Hours worked";
            this.hours_worked_label.Visible = false;
            // 
            // result_payroll
            // 
            this.result_payroll.AutoSize = true;
            this.result_payroll.Location = new System.Drawing.Point(348, 428);
            this.result_payroll.Name = "result_payroll";
            this.result_payroll.Size = new System.Drawing.Size(39, 15);
            this.result_payroll.TabIndex = 21;
            this.result_payroll.Text = "Result";
            this.result_payroll.Visible = false;
            // 
            // gen_payroll_btn
            // 
            this.gen_payroll_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gen_payroll_btn.Location = new System.Drawing.Point(388, 464);
            this.gen_payroll_btn.Name = "gen_payroll_btn";
            this.gen_payroll_btn.Size = new System.Drawing.Size(137, 51);
            this.gen_payroll_btn.TabIndex = 22;
            this.gen_payroll_btn.Text = "Generate";
            this.gen_payroll_btn.UseVisualStyleBackColor = true;
            this.gen_payroll_btn.Visible = false;
            this.gen_payroll_btn.Click += new System.EventHandler(this.gen_payroll_Click);
            // 
            // save_db
            // 
            this.save_db.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_db.Location = new System.Drawing.Point(651, 313);
            this.save_db.Name = "save_db";
            this.save_db.Size = new System.Drawing.Size(137, 51);
            this.save_db.TabIndex = 23;
            this.save_db.Text = "Save DB";
            this.save_db.UseVisualStyleBackColor = true;
            this.save_db.Click += new System.EventHandler(this.save_db_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.save_db);
            this.Controls.Add(this.gen_payroll_btn);
            this.Controls.Add(this.result_payroll);
            this.Controls.Add(this.hours_worked_label);
            this.Controls.Add(this.hours_worked_textbox);
            this.Controls.Add(this.gen_payrol);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.date_time_birthdate);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox_em);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_ln);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_fn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeListBox);
            this.Name = "Form1";
            this.Text = "Employee Payroll GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_fn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_ln;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_em;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker date_time_birthdate;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label gen_payrol;
        private System.Windows.Forms.TextBox hours_worked_textbox;
        private System.Windows.Forms.Label hours_worked_label;
        private System.Windows.Forms.Label result_payroll;
        private System.Windows.Forms.Button gen_payroll_btn;
        private System.Windows.Forms.Button save_db;
    }
}

