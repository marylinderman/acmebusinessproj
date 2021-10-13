using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Represents a product entity.
    /// </summary>
    public class Product: EntityBase, ILoggable
    {

        /// <summary>
        /// Initializes an instance of the Product class.
        /// </summary>
        public Product()
        {
        
        }
        /// <summary>
        /// Initializes an instance of the Product class with an identifier.
        /// </summary>
        /// <param name="productId">An integer representing an identifier for a product.</param>
        public Product(int productId)
        {
            ProductId = productId;
        }
        /// <summary>
        /// Gets an integer representing the ID for a product.
        /// </summary>
        public int ProductId { get; private set; }

        //Backing variable
        private string _productName;

        /// <summary>
        /// Gets or sets a string for the product name.
        /// </summary>
        public string ProductName {
            get
            {

                //return StringHandler.InsertSpaces(_productName);
                //Extension method for InsertSpaces
                return _productName.InsertSpaces();
            }


            set
            {

                _productName = value;
            }
        }
        /// <summary>
        ///  Gets or sets a string for the product description.
        /// </summary>
        public string ProductDescription { get; set; }
        /// <summary>
        ///  Gets or sets a decimal representing the current price. This value may be null.
        /// </summary>
        public decimal? CurrentPrice { get; set; }
        /// <summary>
        /// Formats the product name.
        /// </summary>
        /// <returns>A formatted string with product information.</returns>
        //Override method on Object base class
        public override string ToString() => ProductName;
        /// <summary>
        /// Determines whether the product properties are valid.
        /// </summary>
        /// <returns>Returns a Boolean value indicating whether the product is valid.</returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null ) isValid = false;

            return isValid;
        }
        /// <summary>
        ///  Returns a log message about the product status.
        /// </summary>
        /// <returns>A string containing a log message.</returns>
        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription}  Status: {EntityState.ToString()}";


    }

   
}
