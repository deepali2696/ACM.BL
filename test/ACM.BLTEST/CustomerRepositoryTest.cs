﻿using ACM.BL;
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

            var actual = customerRepository.Retrieve(1);


            //---Assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual (expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }

    }
}
