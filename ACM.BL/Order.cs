using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{/// <summary>
/// Represents a customer order.
/// </summary>
    public class Order : EntityBase, ILoggable
    {
        /// <summary>
        /// Initializes an instance of the Order class.
        /// </summary>
        //Constructor chaining
        public Order(): this(0)
        {

        }
        /// <summary>
        /// Initializes an instance of the Order class with an identifier.
        /// </summary>
        /// <param name="orderId">An integer representing an identifier for an order</param>
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        /// <summary>
        ///  Gets or set the integer value representing the identifier assoicated with an <see cref="Address"/> object. 
        /// </summary>
        //Ids for customer and address illustrate composition by IDs
        public int ShippingAddressId { get; set; }
        /// <summary>
        ///  Gets or set the integer value representing the identifier assoicated with a <see cref="Customer"/> object.
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Gets or sets a list items on the order.
        /// </summary>
        //Set of order items as defined by this list
        public List<OrderItem> OrderItems { get; set; }
        /// <summary>
        /// Gets or sets the date and time of an order.
        /// </summary>

        public DateTimeOffset? OrderDate { get; set; }
        /// <summary>
        /// Gets an integer representing the ID for an order.
        /// </summary>
        public int OrderId { get; private set; }
        /// <summary>
        /// Formats the order information as a string.
        /// </summary>
        /// <returns>A string with order information</returns>
        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }


        /// <summary>
        /// Determines whether the order properties are valid.
        /// </summary>
        /// <returns>A Boolean value indicating whether the order is valid</returns>
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;

        }
        /// <summary>
        /// Returns a log message about the order status.
        /// </summary>
        /// <returns>A string containing a log message</returns>
        public string Log() => $"{OrderId}: {OrderDate.Value.Date}  Status: {EntityState.ToString()}";


    }

}
