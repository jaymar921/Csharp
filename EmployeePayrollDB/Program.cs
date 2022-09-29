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
                        // remove employee
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Remove Employee");
                            Console.Write("Enter Employee details [search]: ");
                            string search = Console.ReadLine();
                            Employee employee_found = localRepository.GetEmployee(search);
                            if(employee_found != null)
                            {
                                Console.Write($"Would you like to remove {employee_found.FirstName}? y/n: ");
                                if (option()) 
                                {
                                    localRepository.Remove(employee_found);
                                    Console.WriteLine("Removed {0}", employee_found.FirstName);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Could not find {0}", search);
                            }
                            Console.ReadKey();
                            break;
                        // generate payroll
                        case 4:
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
                        case 5:
                            Console.Clear();
                            using (var sql = new SQLConnect())
                            {
                                sql.SaveAllEmployeeData(localRepository);
                            }
                            break;
                        // load employee data from db
                        case 6:
                            Console.Clear();
                            using (var sql = new SQLConnect())
                            {
                                sql.LoadAllEmployeeData(localRepository);
                            }
                            break;
                        // exit program
                        case 7:
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
            Console.WriteLine("3. Remove Employee");
            Console.WriteLine("4. Generate Payroll");
            Console.WriteLine("5. Save Employee Data to DB");
            Console.WriteLine("6. Load Employee Data to DB");
            Console.WriteLine("7. Exit");
            Console.Write("Option --> ");
        }

        private static bool option() {
            try
            {
                string option = Console.ReadLine();
                return option.ToLowerInvariant().Contains("y");
            }
            catch
            {
                return false;
            }
        }
    }
}
