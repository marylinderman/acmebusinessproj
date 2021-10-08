using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //Arrange

            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size Set of 4 flowers",
                ProductName = "Sunflowers"
            };

            //Action

            var actual = productRepository.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }


        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 flowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // Act

            var actual = productRepository.Save(updatedProduct);

            // Assert
            // Confirms data was valid
            Assert.AreEqual(true, actual);


        }


        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                //Null current price
                ProductDescription = "Assorted Size Set of 4 flowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // Act

            var actual = productRepository.Save(updatedProduct);

            // Assert
            //confirms not valid
            Assert.AreEqual(false, actual);


        }






    }
}
