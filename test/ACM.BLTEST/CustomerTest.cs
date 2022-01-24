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

        public void StaticTest()
        {
            //-- Arrange

            var c1 = new Customer();
            c1.FirstName = "Deepali";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Chintan";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Hardik";
            Customer.InstanceCount += 1;

            //-- Act



            //-- Assert

            Assert.AreEqual(3, Customer.InstanceCount);
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
