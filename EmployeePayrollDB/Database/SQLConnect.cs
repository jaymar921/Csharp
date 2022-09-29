using System;
using MySql.Data.MySqlClient;
using EmployeePayrollDB.HR;
using EmployeePayrollDB.Repository;

namespace EmployeePayrollDB.Database
{
    public class SQLConnect: IDisposable
    {
        private MySqlConnection _connection;
        private const string ConnectionString = "server=localhost;user=root;database=csharp_practice;port=3306;";

        /*
         * Initialize the MySqlConnection, once opened,
         * you can commit queries
         */
        public SQLConnect()
        {
            _connection = new MySqlConnection(ConnectionString);
            try
            {

                Console.WriteLine("Connecting to database...");
                _connection.Open();
                Console.WriteLine("Connected to database...");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                _connection = null;
            }
        }

        public bool SaveAllEmployeeData(LocalEmployeeRepository employeeRepository)
        {
            if (_connection is null)
            {
                Console.WriteLine($"Could not SaveAllEmployeeData from database because {nameof(_connection)} is null");
                return false;
            }

            try
            {
                // clear the database
                new MySqlCommand("DELETE FROM employee", _connection).ExecuteNonQuery();
                foreach(string query in employeeRepository.SaveQuery())
                {
                    new MySqlCommand(query, _connection).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            Console.WriteLine($"SaveAllEmployeeData from database was successful");
            return true;
        }

        public bool LoadAllEmployeeData(LocalEmployeeRepository employeeRepository)
        {
            if (_connection is null)
            {
                Console.WriteLine($"Could not LoadAllEmployeeData from database because {nameof(_connection)} is null");
                return false;
            }

            employeeRepository.Clear();

            try
            {
                string query = "SELECT * FROM employee";
                MySqlCommand command = new MySqlCommand(query, _connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = null;
                    if (Convert.ToInt32(reader[0]) < 1000)
                    {
                        employee = new Developer(
                            Convert.ToInt32(reader[0]),
                            Convert.ToString(reader[1]),
                            Convert.ToString(reader[2]),
                            Convert.ToDateTime(Convert.ToString(reader[3])),
                            Convert.ToString(reader[4])
                        );
                    }
                    else
                    {
                        employee = new Manager(
                            Convert.ToInt32(reader[0]),
                            Convert.ToString(reader[1]),
                            Convert.ToString(reader[2]),
                            Convert.ToDateTime(Convert.ToString(reader[3])),
                            Convert.ToString(reader[4])
                        );
                    }
                    if (employee != null)
                    {
                        // only add the employee from database to localRepository when is not registered
                        if(employeeRepository.GetEmployee(employee.FirstName) == null)
                            employeeRepository.Register(employee);
                    }
                        
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            Console.WriteLine($"LoadAllEmployeeData from database was successful");
            return true;
        }

        public void Dispose()
        {
            if (_connection is null)
                return;
            _connection.Close();
            _connection = null;
        }
    }

}
