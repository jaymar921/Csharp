using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollDB.HR
{
    public class Manager: Employee
    {
        public Manager(int id, string firstName, string lastName, DateTime birthDate, string email) : base(id, firstName, lastName, birthDate, email)
        {
            rate_per_hour = 250;
        }

        public override string GeneratePayroll()
        {
            // for managers, they will get Php 120 bonus when generating payroll
            int wage = rate_per_hour * hours_worked + 120;
            return $"wage of {hours_worked} hour(s) of work for {FirstName} is P{wage}";
        }
    }
}
