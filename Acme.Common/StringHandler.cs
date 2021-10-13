using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    /// <summary>
    /// Provides functionality for formatting strings with spaces.
    /// </summary>
    public static class StringHandler
    {
        /// <summary>
        /// Inserts a space before each capital letter in a string.
        /// </summary>
        /// <param name="source">A string to be formatted.</param>
        /// <returns>A string formatted with a space preceding each capital letter.</returns>
        /// <example>
        /// The following code sample illustrates how to call the InsertSpaces() method:
        /// <code lang="c#">
        ///  var sourceString = "SonicScrewdriver";
        ///  var formattedString = sourceString.InsertSpaces();
        /// </code></example>

        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            //Strings contains something process it.
            //If null or whitespace, don't process it.
            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            return result.Trim();
        }


    }
}
