using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class AddressRepositoryTest
    {
        [TestMethod]
       
        public void RetrieveTest()
        {
            //Arrange

            var addressRepository = new AddressRepository();

            var expected = new Address(1)
            {
                AddressType = 1,
           StreetLine1 = "Bag End",
           StreetLine2 = "Bagshot row",
            City = "Hobbiton",
           Country = "Middle Earth",
            State = "Shire",
           PostalCode = "144"
           };

            //Action

            var actual = addressRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.AddressType, actual.AddressType);
            Assert.AreEqual(expected.StreetLine1, actual.StreetLine1);
            Assert.AreEqual(expected.StreetLine2, actual.StreetLine2);
            Assert.AreEqual(expected.City, actual.City);
            Assert.AreEqual(expected.Country, actual.Country);
            Assert.AreEqual(expected.State, actual.State);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);

        }









      

        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var addressRepository = new AddressRepository();

            var updatedAddress = new Address(1)
            {
               
            PostalCode = "60601", 
            HasChanges = true


        };

            // Act

            var actual = addressRepository.Save(updatedAddress);

            // Assert
            // Confirms data was valid
            Assert.AreEqual(true, actual);


        }


        [TestMethod]
        public void SaveTestMissingPostalCode()
        {
            //Arrange
            var addressRepository = new AddressRepository();

            var updatedAddress = new Address(1)
            {
                //Null current postal code
                HasChanges = true
            };

            // Act

            var actual = addressRepository.Save(updatedAddress);

            // Assert
            //confirms not valid
            Assert.AreEqual(false, actual);


        }


    }
}
