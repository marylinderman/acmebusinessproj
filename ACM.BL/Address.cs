using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Represents an address for a customer entity.
    /// </summary>
   public class Address : EntityBase
    {
        /// <summary>
        /// Initializes an instance of the Address class.
        /// </summary>
        public Address()
        {

        }
        /// <summary>
        /// Initializes an instance of the Address class with an address identifier.
        /// </summary>
        /// <param name="addressId">An integer representing an identifier for an address.</param>
        public Address(int addressId)
        {
            AddressId = addressId; 
        }


        /// <summary>
        /// Gets an integer value representing the identifier for an address.
        /// </summary>
        public int AddressId { get; private set; }
        /// <summary>
        /// Gets or sets an integer representing the address type.
        /// </summary>

        public int AddressType { get; set; }
        /// <summary>
        /// Gets or sets the a string representing the first line of an street address.
        /// </summary>
        public string StreetLine1 { get; set; }
        /// <summary>
        /// Gets or sets the a string representing the second line of an street address.
        /// </summary>
        public string StreetLine2 { get; set; }
        /// <summary>
        /// Gets or sets the a string representing a city.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the a string representing a state.
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Gets or sets the a string representing a postal code.
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// Gets or sets the a string representing a country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        ///  Determines whether the properties for an address are valid.
        /// </summary>
        /// <returns>Returns a Boolean value indicating whether the address is valid.</returns>
        /// 

        /// <example>
        /// The following code sample illustrates how to validate an address:
        /// <code lang="c#">
        ///  var address = new Address(1) {
        ///    AddressType = 1,
        ///    StreetLine1 = "Bag End",
        ///    StreetLine2 = "Bagshot row",
        ///    City = "Hobbiton",
        ///    Country = "Middle Earth",
        ///    State = "Shire",
        ///    PostalCode = "144",
        ///   };
        ///   
        ///   var validationResult = address.Validate();
        ///   </code></example>


        

        public override bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;

        }










    }
}
