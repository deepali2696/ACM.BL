using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            // var customer = new Customer();

            Customer customer = new Customer
            {
                FirstName = "Deepali",
                LastName = "Patel",

            };

            string expected = "Patel,Deepali";


            //-- Act

            string actual = customer.FullName;


            //-- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            // var customer = new Customer();

            Customer customer = new Customer
            {

                LastName = "Patel",

            };

            string expected = "Patel";


            //-- Act

            string actual = customer.FullName;


            //-- Assert

            Assert.AreEqual(expected, actual);
        }



    }
}
