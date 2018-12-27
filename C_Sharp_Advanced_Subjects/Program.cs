using Indexers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Advanced_Subjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Senior Developer", "Johnny", 48, "CodeOasis");

            person[0] = "מר.";

            person[1] = "גברת";

            person[2] = "סיר";

        }
    }
}