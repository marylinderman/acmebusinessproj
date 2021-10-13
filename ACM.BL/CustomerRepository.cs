using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{   /// <summary>
    /// Provides functionality for adding <see cref="Customer"/> objects to and retrieving them from a database.
    /// </summary>
    public class CustomerRepository
    {

        //Customer repo uses address repo
        //Collaborative relationship bewteen the repos
        /// <summary>
        /// Initializes an instance of the CustomerRepository class.
        /// </summary>
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        /// <summary>
        ///  Retreives a <see cref="Customer"/> object from the database.
        /// </summary>
        /// <param name="customerId">An integer representing the unique ID for a <see cref="Customer"/> object</param>
        /// <returns>A <see cref="Customer"/> object</returns>
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
        /// <summary>
        /// Saves a <see cref="Customer"/> object to the database.
        /// </summary>
        /// <param name="customer">A <see cref="Customer"/> object</param>
        /// <returns>A Boolean value indicating whether save operation was successful</returns>
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
