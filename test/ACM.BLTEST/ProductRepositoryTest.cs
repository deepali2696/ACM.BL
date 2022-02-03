using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTEST
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void retrieveValid()
        {

            //----Arrange

            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "car",
                CurrentPrice = 50
            };

            //----Act

            var actual = productRepository.Retrieve(1);

            //----Assert

           Assert.AreEqual(expected.ProductName, actual.ProductName);
           Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
