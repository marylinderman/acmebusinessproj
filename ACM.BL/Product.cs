﻿using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product: EntityBase, ILoggable
    {
       

        public Product()
        {
        
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        //Backing variable
        private string _productName;
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
        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        //Override method on Object base class
        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null ) isValid = false;

            return isValid;
        }

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription}  Status: {EntityState.ToString()}";


    }

   
}
