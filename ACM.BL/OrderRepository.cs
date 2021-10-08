using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

       
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
