using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        //Constructor chaining
        public Order(): this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        //Ids for customer and address illustrate composition by IDs
        public int ShippingAddressId { get; set; }
        public int CustomerId { get; set; }

        //Set of order items as defined by this list
        public List<OrderItem> OrderItems { get; set; }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;

        }

        public string Log() => $"{OrderId}: {OrderDate.Value.Date}  Status: {EntityState.ToString()}";


    }

}
