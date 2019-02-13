using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    // Extension methods allow us to add methods to an existing class
    // without changing its source code or creating a new class that inherits from it
    // Note that the creator of the String class (in this case it is Microsoft) can in the future
    // change String class implementation and they can create a "Shorten" method with exactly the same signature but different implementation
    // and then instance methods will get priority over your extension method so your code will never be executed
    // so use extension methods only when you HAVE to.
    public static class StringExtensions
    {
        /// <summary>
        /// This function takes a string and shortens it to a provided number of words
        /// </summary>
        /// <param name="str"></param>
        /// <param name="numberOfWords">provided number of words</param>
        /// <returns></returns>
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words should be greater than or equal to 0.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
