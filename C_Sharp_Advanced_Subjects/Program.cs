using Delegates;
using Generics;
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
            // Delegates:
            Func<decimal, decimal, decimal> operationsHandler = Operations.Sum;
            operationsHandler += Operations.Substruct;

            Calculation.Calculate(15.5m, 0.6m, operationsHandler);

            // Indexers:
            Person person = new Person("Senior Developer", "Johnny", 48, "CodeOasis");

            person[0] = "מר.";

            person[1] = "גברת";

            person[2] = "סיר";

            // Generics:
            GenericArray<int> intArray = new GenericArray<int>(Globals.ARRAY_SIZE);
            Random rand = new Random();
            for (int i = 0; i < Globals.ARRAY_SIZE; i++)
            {
                intArray.SetItem(rand.Next(1, 9), i);
                Console.WriteLine(intArray.GetItem(i));
            }

            GenericArray<char> charArray = new GenericArray<char>(Globals.ARRAY_SIZE);
            for (int i = 0; i < Globals.ARRAY_SIZE; i++)
            {
                int randomIndex = rand.Next(0, Globals.CHARS.Length);
                charArray.SetItem(Globals.CHARS[randomIndex], i);
                Console.WriteLine(charArray.GetItem(i));
            }

        }
    }

    public static class Globals
    {
        public static int ARRAY_SIZE = 5;
        public static string CHARS = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
    }
}