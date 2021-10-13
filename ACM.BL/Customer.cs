using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    /// <summary>
    /// Represents a customer.
    /// </summary>
    public class Customer : EntityBase, ILoggable 

    {
        /// <summary>
        /// Initializes an instance of the Customer class.
        /// </summary>
        //Constructor chaining
        //Default constructor now calls constructor with list in it.
        //Default constructor call parameterized constructor with default value of 0.
        public Customer():this (0)
        {

        }
        /// <summary>
        /// Initializes an instance of the Customer class with an identifier.
        /// </summary>
        /// <param name="customerId">An integer representing an identifier for a customer</param>
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        /// <summary>
        ///  Gets or sets a list of <see cref="Address"/> objects assoicated with the customer.
        /// </summary>
        public List<Address> AddressList { get; set; }
        /// <summary>
        /// Gets an integer representing the type associated with the customer.
        /// </summary>
        //add a type property rather than inheritance in this case
        public int CustomerType { get; set; }
        /// <summary>
        /// Gets an integer representing the identifier associated with the customer.
        /// </summary>
        //Use propg snippet in VS
        public int CustomerId { get; private set; }
        /// <summary>
        /// Gets or sets a string representing the email address.
        /// </summary>
        //Use prop snippet in VS
        public string EmailAddress { get; set; }
        ///<summary>
        ///Gets or sets a string representing the first name of the customer.
        /// </summary>


        //Shortcut syntax for property
        public string FirstName { get; set; }
       
        private string _lastName;
        /// <summary>
        /// Gets or sets a string representing the last name of the customer.
        /// </summary>
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        /// <summary>
        /// Gets or sets a string representing the full name of the customer.
        /// </summary>
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }

        //Override method on Object base class and use lambda expression

        /// <summary>
        /// Formats the product information as a string.
        /// </summary>
        /// <returns>A string with customer information</returns>
        public override string ToString() => FullName;
        /// <summary>
        /// Stores the number Customer objects created in the application.
        /// </summary>
        public static int InstanceCount { get; set; }
        /// <summary>
        /// Determines whether the order properties are valid.
        /// </summary>
        /// <returns>A Boolean value indicating whether the order is valid.</returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
        /// <summary>
        /// Returns a log message about the customer status.
        /// </summary>
        /// <returns>A string containing a log message.</returns>
        public string Log() =>$"{CustomerId}: {FullName} Email: {EmailAddress}  Status: {EntityState.ToString()}";
    

    }
}
