using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Provides functionality for adding <see cref="Product"/> objects to and retrieving them from a database.
    /// </summary>
    public class ProductRepository
    {

        /// <summary>
        /// Retreives a <see cref="Product"/> object from the database.
        /// </summary>
        /// <param name="productId">An integer representing the unique ID for a <see cref="Product"/> object.</param>
        /// <returns>Returns a <see cref="Product"/> object.</returns>
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
        /// <summary>
        /// Saves a <see cref="Product"/> object to the database.
        /// </summary>
        /// <param name="product">A <see cref="Product"/> object</param>
        /// <returns>Returns a Boolean value indicating whether save operation was successful.</returns>
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
