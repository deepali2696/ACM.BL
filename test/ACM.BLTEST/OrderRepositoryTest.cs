using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTEST
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void retrieveValid()
        {

            //----Arrange

           var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderItems = 5,
                ShippingAddress = "Montreal",
               
            };

            //----Act

            var actual = orderRepository.Retrieve(1);

            //----Assert

            Assert.AreEqual(expected.ShippingAddress, actual.ShippingAddress);
            Assert.AreEqual(expected.OrderItems, actual.OrderItems);
        }
    }
}
