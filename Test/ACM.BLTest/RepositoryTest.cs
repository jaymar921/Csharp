using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepo = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "jayharronabejar@email.com",
                FirstName = "Jayharron Mar",
                LastName = "Abejar"
            };
            //--Act
            var actual = customerRepo.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FullName, actual.FullName);
        }
    }
}
