using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// LINQ - Language Integrated Query
/// Gives us the capability to query objects
/// With LINQ we can query objects in memory (collections), databases, XML, ADO.NET 
/// </summary>
namespace LINQ
{
    public class LanguageIntegratedQuery
    {
        public static void LINQ()
        {
            // without LINQ:
            var books = new BookRepository().GetBooks();

            // with LINQ extension methods
            var cheapBooks = books
                                .Where((b) => (b.Price < 10))
                                .OrderBy(b => b.Title);
            var title = books.Select(b => b.Title);

            foreach (Book book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }

            // with LINQ query operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            var specificBook = books.Single(b => b.Title == "JavaScript: the weird parts"); //not safe (seq. cont. no match)
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
        }
    }
}

public class Book
{
    public string Title { get; set; }
    public float Price { get; set; }
}

public class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>
            {
                new Book { Title = "ASP .NET Core Cookbook", Price = 5 },
                new Book { Title = "Core Java Volume I--Fundamentals (10th Edition)", Price = 9.99f },
                new Book { Title = "Essentials of NodeJS 2018", Price = 12 },
                new Book { Title = "JavaScript: the weird parts", Price = 7 },
                new Book { Title = "Hadoop for beginners", Price = 9 },
                new Book { Title = "Hadoop for beginners", Price = 9.5f }
            };
    }
}
