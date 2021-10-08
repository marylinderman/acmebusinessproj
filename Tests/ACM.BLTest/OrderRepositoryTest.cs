using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetreiveTest()
        {
            //Arrange

            var orderRepository = new OrderRepository();

            var expected = new Order(3)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year,
                10,
                5,
                4,
                00,
                00,
                new TimeSpan(7, 0, 0))
            };

            //Action

            var actual = orderRepository.Retrieve(10);

            //Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            

        }

        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var orderRepository = new OrderRepository();

            var updatedOrder = new Order(3)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year,
                7,
                11,
                4,
                00,
                00,
                new TimeSpan(7, 0, 0)),
                HasChanges = true
            };

            // Act

            var actual = orderRepository.Save(updatedOrder);

            // Assert
            // Confirms data was valid
            Assert.AreEqual(true, actual);


        }


        [TestMethod]
        public void SaveTestMissingDate()
        {
            //Arrange
            var orderRepository = new OrderRepository();

            var updatedOrder = new Order(3)
            {
                //Null current date
                HasChanges = true
            };

            // Act

            var actual = orderRepository.Save(updatedOrder);

            // Assert
            //confirms not valid
            Assert.AreEqual(false, actual);


        }

    }
}
