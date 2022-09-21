using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice.HR
{
    public class EmployeeTester
    {
        public static void Test() 
        {
            Developer developer = new Developer("Jayharron Mar", "Abejar", "jay@email.com", new DateTime(2000, 09, 21), 32);
            Manager manager = new Manager("Pia", "Abellana", "pia@email.com", new DateTime(2001, 11, 9), 30);
            JuniorResearcher juniorResearcher = new JuniorResearcher("Rey", "de los Reyes", "rey@email.com", new DateTime(2000, 1, 1), 12);
            Researcher researcher = new Researcher("Harold", "Cuico", "harold@email.com", new DateTime(2000, 1, 1), 27);
            StoreManager storeManager = new StoreManager("Trisha", "Cempron", "trisha@email.com", new DateTime(2000, 1, 1), 28);

            //Employee.DisplayTaxRate();

            //developer.DisplayEmployeeDetails();
            //developer.PerformWork();
            //developer.PerformWork();
            //developer.PerformWork();
            //developer.PerformWork();
            //developer.PerformWork();
            //developer.PerformWork();
            //developer.PerformWork();
            //developer.PerformWork();
            //developer.StopWorking();
            //developer.ReceiveWage();



            //manager.DisplayEmployeeDetails();
            //manager.AttendManagementMeeting(2);
            //manager.PerformWork();
            //manager.PerformWork();
            //manager.AttendManagementMeeting(4);
            //manager.ReceiveWage();

            //juniorResearcher.DisplayEmployeeDetails();
            //juniorResearcher.PerformWork();
            //juniorResearcher.PerformWork();
            //juniorResearcher.ResearchNewPieTastes(6);
            //juniorResearcher.ReceiveWage();

            //Console.WriteLine("\nGiving bonus to employees!");
            //developer.GiveBonus();
            //manager.GiveBonus();
            //juniorResearcher.GiveBonus();

            developer.Id = 5;
            manager.Id = 4;
            juniorResearcher.Id = 3;
            researcher.Id = 2;
            storeManager.Id = 1;

            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(developer);
            employees.Add(manager);
            employees.Add(juniorResearcher);
            employees.Add(researcher);
            employees.Add(storeManager);

            employees.Sort();

            foreach (Employee employee in employees)
            {
                employee.PerformWork();

                if (employee.GetType() == typeof(Manager))
                    ((Manager)employee).AttendManagementMeeting(new Random().Next(1, 5));

                employee.ReceiveWage();
                employee.DisplayEmployeeDetails();
                employee.GiveBonus();

                Console.WriteLine("----------------------------------------------------------");
            }
        }
    }
}
