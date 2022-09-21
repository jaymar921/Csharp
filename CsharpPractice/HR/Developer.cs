using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice.HR
{
    /*
        The sealed keyword will not allow any class to be derived
        from the sealed class
     */
    public sealed class Developer: Employee
    {
        public Developer(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        { }

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
