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
}
