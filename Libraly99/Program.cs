using Libraly99.Data.Models;
using Libraly99.Data;

namespace Libraly99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new LibraryDBContext();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\n Книги с цена от 20 до 25 лева:");
            var priceFiltered = db.Books
                .Where(b => b.Price >= 20 && b.Price <= 25)
                .Select(b => b.Title)
                .ToList();

            foreach (var title in priceFiltered)
                Console.WriteLine($"- {title}");

            Console.WriteLine("\n Книги с по-малко от 10 символа:");
            var shortTitles = db.Books
                .Where(b => b.Title.Length < 10)
                .Select(b => b.Title)
                .ToList();

            foreach (var title in shortTitles)
                Console.WriteLine($"- {title}");

            Console.WriteLine("\n Български автори:");
            var bgAuthors = db.Author
                .Where(a => a.Nationality == "България")
                .Select(a => $"{a.First_Name} {a.Last_Name}")
                .ToList();

            foreach (var author in bgAuthors)
                Console.WriteLine($"- {author}");

            Console.Write("\nВъведи издателство: ");
            var publisherInput = Console.ReadLine();

            var publisherBooks = db.Books
                .Where(b => b.Publisher == publisherInput)
                .Select(b => b.Title)
                .ToList();

            Console.WriteLine($"\n Книги от '{publisherInput}':");
            foreach (var title in publisherBooks)
                Console.WriteLine($"- {title}");

            Console.Write("\nВъведи националност: ");
            var nationInput = Console.ReadLine();

            var nationAuthors = db.Author
                .Where(a => a.Nationality == nationInput)
                .Select(a => $"{a.First_Name} {a.Last_Name}")
                .ToList();

            Console.WriteLine($"\n Автори с националност '{nationInput}':");
            foreach (var author in nationAuthors)
                Console.WriteLine($"- {author}");

            Console.Write("\nВъведи фамилия на автор: ");
            var surnameInput = Console.ReadLine();

            var booksByAuthor = db.Books
                .Where(b => b.Author.Last_Name == surnameInput)
                .Select(b => b.Title)
                .ToList();

            Console.WriteLine($"\n Книги от автор с фамилия '{surnameInput}':");
            foreach (var title in booksByAuthor)
                Console.WriteLine($"- {title}");

            Console.WriteLine("\n Готово!");
        }
    }
}
    }
}