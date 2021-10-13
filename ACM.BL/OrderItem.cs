using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    ///  Represents an item added to an order.
    /// </summary>
   public class OrderItem
    {
        /// <summary>
        /// Initializes an instance of the OrderItem class.
        /// </summary>
        public OrderItem()
        {

        }
        /// <summary>
        /// Initializes an instance of the OrderItem class with an order item identifier.
        /// </summary>
        /// <param name="orderItemId">An integer representing an identifier for an order item.</param>
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        /// <summary>
        ///  Gets or sets an integer representing the product ID.
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        ///  Gets or sets an integer representing the quantity.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        ///  Gets or sets a decimal representing the purchase price. This value may be null.
        /// </summary>
        public decimal? PurchasePrice { get; set; }
        /// <summary>
        ///  Gets an integer representing the ID for an order item.
        /// </summary>
        public int OrderItemId { get; private set; }

        /// <summary>
        ///  Determines whether the properties for an order item are valid.
        /// </summary>
        /// <returns>Returns a Boolean value indicating whether the order item is valid.</returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <=0 ) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
        /// <summary>
        /// Retreives an order item from the database.
        /// </summary>
        /// <param name="orderItemId">An integer representing the unique ID for an order item.</param>
        /// <returns>Returns an OrderItem object.</returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        /// <summary>
        /// Saves an order item to the database.
        /// </summary>
        /// <returns>Returns a Boolean value indicating whether save operation was successful.</returns>
        public bool Save()
        {
            return true;
        }


    }
}
