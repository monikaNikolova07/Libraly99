using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly99.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Nationality { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
