using Libraly99.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Libraly99.Data
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext():base()
        {
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STUDENT20;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
