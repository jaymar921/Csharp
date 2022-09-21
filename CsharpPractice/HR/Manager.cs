using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice.HR
{
    public class Manager: Employee
    {
        public Manager(string first, string last, string em, DateTime bd, double? rate): base(first, last, em, bd, rate)
        { }

        public void AttendManagementMeeting(int hours)
        {
            NumberOfHoursWorked += hours;

            if(hours > 1)
                Console.WriteLine($"Manager {FirstName} {LastName} is now attending a {hours} hours meeting that could have been an email!");
            else
                Console.WriteLine($"Manager {FirstName} {LastName} is now attending a {hours} hour meeting that could have been an email!");
        }

        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 500!");
            else
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 250!");
        }

        public override double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;
            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}");

            NumberOfHoursWorked = 0;

            return Wage;
        }
    }
}
