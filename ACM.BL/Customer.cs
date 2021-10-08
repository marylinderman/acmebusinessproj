using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable 

    {
        //Constructor chaining
        //Default constructor now calls constructor with list in it.
        //Default constructor call parameterized constructor with default value of 0.
        public Customer():this (0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }

        //add a type property rather than inheritance in this case
        public int CustomerType { get; set; }

        //Use propg snippet in VS
        public int CustomerId { get; private set; }

        //Use prop snippet in VS
        public string EmailAddress { get; set; }
               
        //Shortcut syntax for property
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }

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
        public override string ToString() => FullName;

        public static int InstanceCount { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log() =>$"{CustomerId}: {FullName} Email: {EmailAddress}  Status: {EntityState.ToString()}";
           
        
      
    }
}
