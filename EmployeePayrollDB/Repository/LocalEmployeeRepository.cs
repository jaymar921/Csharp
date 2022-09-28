using System.Collections.Generic;
using EmployeePayrollDB.HR;
using System;

namespace EmployeePayrollDB.Repository
{
    public class LocalEmployeeRepository
    {
        private List<Employee> employees;

        public LocalEmployeeRepository()
        {
            employees = new List<Employee>();
        }

        public void Register(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee GetEmployee(string search)
        {
            foreach(Employee employee in employees)
            {
                if(employee.FirstName.Contains(search) || employee.LastName.Contains(search) || Convert.ToString(employee.Id).Contains(search))
                {
                    return employee;
                }
            }
            return null;
        }

        public void DisplayAllData() 
        {
            Console.WriteLine("\nShowing all employees");
            if (employees.Count == 0)
                Console.WriteLine("- none to show");
            foreach (Employee employee in employees)
            {
                employee.ShowEmployeeData();
            }
        }

        public void Remove(Employee employee)
        {
            employees.Remove(employee);
        }

        public void Clear()
        {
            employees.Clear();
        }

        public List<string> SaveQuery()
        {
            List<string> queries = new List<string>();
            foreach (Employee employee in employees)
                queries.Add($"INSERT INTO employee values ({employee.Id},'{employee.FirstName}','{employee.LastName}','{employee.BirthDate.Date.ToString("yyyy-MM-dd HH:mm:ss")}','{employee.Email}')");
            return queries;
        }
    }
}
