using Delegates;
using Generics;
using Indexers;
using LINQ;
using System;
using Dynamic;
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
            // LINQ Examples
            // (without LINQ:)
            var books = new BookRepository().GetBooks();
            /*var cheapBooks = new List<Book>();

            foreach (Book book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }*/
            // (with LINQ extension methods)
            var cheapBooks = books
                                .Where((b) => (b.Price < 10))
                                .OrderBy(b => b.Title);
            var title = books.Select(b => b.Title);

            foreach (Book book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }
            // (with LINQ query operators)
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            var specificBook  = books.Single(b => b.Title == "JavaScript: the weird parts"); //not safe (seq. cont. no match)
            var specificBook2 = books.SingleOrDefault(b => b.Title == "JavaScript: the weird partss"); // safe
            var specificBook3 = books.First(b => b.Title == "Hadoop for beginners"); //not safe
            var specificBook4 = books.FirstOrDefault(b => b.Title == "Hadoop for beginners"); //safe
            var specificBook5 = books.Last(b => b.Title == "Hadoop for beginners"); //not safe
            var specificBook6 = books.LastOrDefault(b => b.Title == "Hadoop for beginners"); //safe
            var specificBooks = books.Skip(2).Take(3);
            var numberOfBooks = books.Count();
            var highestPrice = books.Max(b => b.Price);
            var lowestPrice = books.Min(b => b.Price);
            var cheapestBook = books.Where(b => b.Price == lowestPrice);
            var totalPrices = books.Sum(b => b.Price);
            var averagePrice = books.Average(b => b.Price);

            // Lambdas
            LambdaExpressions.LambdasTest.TestLambda();

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

            var number = new Generics.Nullable<int>();
            Console.WriteLine("Has value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var isAnimal = new Generics.Nullable<bool>();
            Console.WriteLine("Has value? " + isAnimal.HasValue);
            Console.WriteLine("Value: " + isAnimal.GetValueOrDefault());

            // Dynamic types:
            DynamicType dType = new DynamicType();
            dType.CheckType();

            dType.dynamicField = 4;
            int sum = dType.dynamicField + 17;
            Console.WriteLine("The sum is: " + sum);

            Console.ReadKey();
        }
    }

    public static class Globals
    {
        public static int ARRAY_SIZE = 5;
        public static string CHARS = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
    }
}