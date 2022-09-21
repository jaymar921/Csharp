using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice.HR
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private DateTime birthDay;

        public static double taxRate = 0.15;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int NumberOfHoursWorked { get { return numberOfHoursWorked; } set { numberOfHoursWorked = value; } }
        public double Wage { get { return wage; } set { wage = value > 0 ? value : 0; } }
        public double HourlyRate { get { return hourlyRate; } set { hourlyRate = value > 0 ? value : 0; } }
        public DateTime BirthDay { get { return birthDay; } set { birthDay = value; } }

        public Employee(string first, string last, string em, DateTime bd, double? rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            HourlyRate = rate ?? 10; // if the rate is null, set the value to 10
        }

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0)
        {
        }

        public void PerformWork() {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working");
        }

        public abstract double ReceiveWage();
        

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}" +
                $"\nTax Rate: {taxRate}\n");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        /*
         * The virtual keyword is used to modify a method, property, indexer,
         * or event declaration and allow for it to be overridden in a derived class.
         * For example, this method can be overridden by any class that inherits it
         */
        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }
    }
}
