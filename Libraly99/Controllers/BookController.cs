using Libraly99.Data.Models;
using Libraly99.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly99.Controllers
{
    public class BookController
    {
        LibraryDBContext dbContext = new LibraryDBContext();

        public async Task AddBook(string title, string publisher, decimal price, Author author)
        {
            Book book = new Book()
            {
                Title = title,
                Publisher = publisher,
                Price = price,
                Author = author
            };
        }
    }
}