using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // Create the instance of Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary Hard-Coded values to return
            // a populated customer;
            if(customerId == 1)
            {
                customer.EmailAddress = "jayharronabejar@email.com";
                customer.FirstName = "Jayharron Mar";
                customer.LastName = "Abejar";
            }
            return customer;

        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
