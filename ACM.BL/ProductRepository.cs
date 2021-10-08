using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            //temp code
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 flowers";
                product.CurrentPrice = 15.96M;
            }

            //Miscellaneous object code
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");


            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                //Calls overriden Valid method
                if (product.IsValid)
                {
                    if (product.IsNew)
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
