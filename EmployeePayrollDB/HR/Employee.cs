using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollDB.HR
{
    public abstract class Employee: IEmployee, IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        protected int rate_per_hour = 10;
        protected int hours_worked = 0;

        public Employee(int id, string firstName, string lastName, DateTime birthDate, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
        }

        public abstract string GeneratePayroll();

        public void Work() 
        {
            hours_worked++;
        }

        public void Work(int hours)
        {
            hours_worked+=hours;
        }

        public void ShowEmployeeData()
        {
            Console.WriteLine($"\nEmployee ID: {Id}\nFirstName: {FirstName}\nLastName: {LastName}\nBirthDate: {BirthDate.ToShortDateString()}\nEmail: {Email}\nHour(s) Worked: {hours_worked}\n");
        }

        public override string ToString()
        {
            return string.Format("ID: {0,-7} | FirstName: {1,-25} | LastName: {2,-15} | BirthDate: {3,-8} | Email: {4,-25} | Hour(s) worked: {5,-5}", Id, FirstName, LastName, BirthDate.ToShortDateString(), Email, hours_worked);
        }

        public int CompareTo(object obj)
        {
            Employee Temp = (Employee)obj;
            if (this.Id > Temp.Id)
                return 1;
            if (this.Id < Temp.Id)
                return -1;
            else
                return 0;
        }
    }
}
