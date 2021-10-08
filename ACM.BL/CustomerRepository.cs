using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        //Customer repo uses address repo
        //Collaborative relationship bewteen the repos
        
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        public Customer Retrieve(int customerId)
        {
            var customer =  new Customer(customerId);

            //temp code to return customer object
            //retrieve customer and its assoicated addresses

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@shire.org";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(1).ToList();
            }


            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                //Calls overriden Valid method
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
