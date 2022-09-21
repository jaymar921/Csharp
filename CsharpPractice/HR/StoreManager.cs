using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice.HR
{
    public class StoreManager: Employee
    {
        public StoreManager(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
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
