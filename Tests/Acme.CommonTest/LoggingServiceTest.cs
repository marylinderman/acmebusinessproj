using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using ACM.BL;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();


            var customer = new Customer(1)
            {

                EmailAddress = "fbaggins@shire.org",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                CurrentPrice = 6M,
                ProductDescription = "Garden Rake with Steel Head",
                ProductName = "Rake"
            };

            changedItems.Add(product);

            //Act

               LoggingService.WriteToFile(changedItems);

            //Assert 
            //nothing to assert
    }
    }
}
