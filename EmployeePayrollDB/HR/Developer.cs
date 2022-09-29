using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollDB.HR
{
    public class Developer: Employee
    {
        public Developer(int id, string firstName, string lastName, DateTime birthDate, string email): base(id, firstName, lastName, birthDate, email)
        {
            rate_per_hour = 250;
        }

        public override string GeneratePayroll()
        {
            // for developers, they will get Php 100 bonus when generating payroll
            int wage = rate_per_hour * hours_worked + 100;
            return $"wage of {hours_worked} hour(s) of work for {FirstName} is P{wage}";
        }
    }
}
