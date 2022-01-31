using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void retrieveValid()
        {
            //---Arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "abcd@gmail.com",
                FirstName = "Deepali",
                LastName = "Patel"
            };



            //---Act




            //---Assert
        }

    }
}
