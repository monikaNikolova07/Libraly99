using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly99.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Author_ID { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }

        public Author Author { get; set; }

    }
}
