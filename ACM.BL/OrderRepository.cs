using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            // Create the instance of Customer class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined customer

            // Temporary Hard-Coded values to return
            // a populated customer;
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;

        }

        public bool Save(Order customer)
        {
            return true;
        }
    }
}
