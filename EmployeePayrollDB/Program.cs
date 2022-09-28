using System;
using EmployeePayrollDB.Database;
using EmployeePayrollDB.HR;
using EmployeePayrollDB.Repository;

namespace EmployeePayrollDB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            LocalEmployeeRepository localRepository = new LocalEmployeeRepository();
            // load all data from db first
            using (var sql = new SQLConnect())
            {
                sql.LoadAllEmployeeData(localRepository);
            }

            Console.Clear();
            do
            {
                
                showMenu();
                try
                {
                    switch (Convert.ToInt16(Console.ReadLine()))
                    {
                        // show all data
                        case 1:
                            Console.Clear();
                            localRepository.DisplayAllData();
                            break;
                        // register new employee
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Register new Employee");
                            Console.Write("Enter Employee ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter FirstName: ");
                            string firstName = Console.ReadLine();
                            Console.Write("Enter LastName: ");
                            string lastName = Console.ReadLine();
                            Console.Write("Enter BirthDate (YYYY/MM/DD): ");
                            DateTime birthDate = DateTime.Parse(Console.ReadLine());
                            Console.Write("Enter Email: ");
                            string email = Console.ReadLine();
                            if (id < 1000)
                                localRepository.Register(new Developer(id, firstName, lastName, birthDate, email));
                            else localRepository.Register(new Manager(id, firstName, lastName, birthDate, email));
                            Console.WriteLine($"Registered Employee {id} to localRepository");
                            break;
                        // generate payroll
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Generating employee payroll");
                            Console.Write("Enter Employee Info [ID, Name]: ");
                            Employee emp = localRepository.GetEmployee(Console.ReadLine());
                            if (emp != null)
                            {
                                Console.Write("Enter Employee Work hours: ");
                                emp.Work(Convert.ToInt32(Console.ReadLine()));
                                emp.GeneratePayroll();
                            }
                            break;
                        // save employee data into the db
                        case 4:
                            Console.Clear();
                            using (var sql = new SQLConnect())
                            {
                                sql.SaveAllEmployeeData(localRepository);
                            }
                            break;
                        // load employee data from db
                        case 5:
                            Console.Clear();
                            using (var sql = new SQLConnect())
                            {
                                sql.LoadAllEmployeeData(localRepository);
                            }
                            break;
                        // exit program
                        case 6:
                            Console.Clear();
                            Console.WriteLine($"Program terminated...");
                            active = false;
                            break;
                    }
                }
                catch { }
                
            } while (active);
            
        }

        private static void showMenu()
        {
            Console.WriteLine("\n------[ EMPLOYEE PAYROLL ] ------");
            Console.WriteLine("1. Show All Employees");
            Console.WriteLine("2. Register Employee");
            Console.WriteLine("3. Generate Payroll");
            Console.WriteLine("4. Save Employee Data to DB");
            Console.WriteLine("5. Load Employee Data to DB");
            Console.WriteLine("6. Exit");
            Console.Write("Option --> ");
        }
    }
}
