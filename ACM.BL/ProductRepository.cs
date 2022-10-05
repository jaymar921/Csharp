using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Create the instance of Customer class
            // Pass in the requested id
            Product product = new Product(productId);

            // Code that retrieves the defined customer

            // Temporary Hard-Coded values to return
            // a populated customer;
            if (productId == 1)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size set of 4 bright yellow mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;

        }

        public bool Save(Product customer)
        {
            return true;
        }
    }
}
