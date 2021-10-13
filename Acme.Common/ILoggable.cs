using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common

{
    /// <summary>
    /// Exposes a method for logging messages.
    /// </summary>
   
  
    public interface ILoggable
    {

        /// <summary>
        /// Writes a log entry.
        /// </summary>
        /// <returns>A string containing a log message.</returns>

        /// <example>
        /// The following code sample illustrates how to implement a Log() method:
        /// <code lang="c#">
        /// public string Log() =>$"{CustomerId}: {FullName} Email: {EmailAddress}  Status: {EntityState.ToString()}";
        /// </code></example>


        string Log();
       
       
    }
}
