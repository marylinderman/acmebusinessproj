using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //Require a repo class for addresses because used by others.
    public class AddressRepository
    {
        public Address Retrieve (int addressId)
        {
            Address address = new Address(addressId);

            //temp code
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.Country = "Middle Earth";
                address.State = "Shire";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {

            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                Country = "Middle Earth",
                State = "Shire",
                PostalCode = "144",
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                //StreetLine2 = "Bagshot row",
                City = "Bywater",
                Country = "Middle Earth",
                State = "Shire",
                PostalCode = "146",
            };

            addressList.Add(address);
            return addressList;
        }

     public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                //Calls overriden Valid method
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        //Call an insert stored procedure
                    }
                    else
                    {
                        //Call an update stored procedure
                    }
                }

                else
                {
                    success = false;
                }

            }
            return success;
        }





    }
}
