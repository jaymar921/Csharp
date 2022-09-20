using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice.HR
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private DateTime birthDay;

        private EmployeeType employeeType;
        public static double taxRate = 0.15;
        private const double maxAmountHoursWorked = 800;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int NumberOfHoursWorked { get { return numberOfHoursWorked; } set { numberOfHoursWorked = value; } }
        public double Wage { get { return wage; } set { wage = value > 0 ? value : 0; } }
        public double HourlyRate { get { return hourlyRate; } set { hourlyRate = value > 0 ? value : 0; } }
        public DateTime BirthDay { get { return birthDay; } set { birthDay = value; } }
        public EmployeeType EmployeeType { get { return employeeType; } set { employeeType = value; } }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType, double? rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            EmployeeType = empType;
            HourlyRate = rate ?? 10; // if the rate is null, set the value to 10
        }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType): this(first, last, em, bd, empType, 0)
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

        public double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;
            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}");

            NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}" +
                $"\nEmployee Type: {EmployeeType}\nTax Rate: {taxRate}\n");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }
    }
}
