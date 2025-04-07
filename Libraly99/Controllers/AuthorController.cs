using Libraly99.Data.Models;
using Libraly99.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly99.Controllers
{
    public class AuthorController
    {
        LibraryDBContext dbContext = new LibraryDBContext();

        public async Task AddAuthor(string first, string surname, string nation, List<Book> book)
        {
            Author author = new Author()
            {
                First_Name = first,
                Last_Name = surname,
                Nationality = nation,
                Books = book
            };
        }
    }
}
