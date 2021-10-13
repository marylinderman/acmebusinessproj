using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{   /// <summary>
///  Provides functionality for adding <see cref="Order"/> objects to and retrieving them from a database.
/// </summary>
    public class OrderRepository
    {

        /// <summary>
        ///  Retreives a <see cref="Order"/> object from the database.
        /// </summary>
        /// <param name="orderId">An integer representing the unique ID for a <see cref="Order"/> object.</param>
        /// <returns>Returns a <see cref="Order"/> object.</returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            //temp data
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 5, 4, 00, 00, new TimeSpan(7, 0, 0));
            }

           Console.WriteLine($"Order: {order.ToString()}");

            return order;
        }
        /// <summary>
        /// Saves a <see cref="Order"/> object to the database.
        /// </summary>
        /// <param name="order">A <see cref="Order"/> object</param>
        /// <returns>Returns a Boolean value indicating whether save operation was successful.</returns>
        public bool Save( Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                //Calls overriden Valid method
                if (order.IsValid)
                {
                    if (order.IsNew)
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
