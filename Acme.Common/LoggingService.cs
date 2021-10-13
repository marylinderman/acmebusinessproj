using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    /// <summary>
    /// Represents a service used to write log messages to a file.
    /// </summary>
    public static class LoggingService
    {   /// <summary>
        /// Writes a log message based on information from the caller to a file.
        /// </summary>
        /// <param name="itemsToLog"> A list of strings containing log messages.</param>
        /// <example>
        /// The following code sample illustrates how to write log messages to a file:
        /// <code lang="c#">
        /// <![CDATA[
        /// var changedItems = new List<ILoggable>();
        /// var customer = new Customer(1)
        ///   {
        ///     EmailAddress = "fbaggins@shire.org",
        ///     FirstName = "Frodo",
        ///     LastName = "Baggins",
        ///     AddressList = null
        ///   };
        ///   
        ///   changedItems.Add(customer);
        ///    
        ///  var product = new Product(2)
        ///   {
        ///     CurrentPrice = 6M,
        ///     ProductDescription = "Garden Rake with Steel Head",
        ///     ProductName = "Rake"
        ///   };
        ///   
        ///   changedItems.Add(product);
        ///   
        ///   LoggingService.WriteToFile(changedItems);]]>
        ///</code></example>
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
               Console.WriteLine(item.Log());


               
            }
        }
    }
}
