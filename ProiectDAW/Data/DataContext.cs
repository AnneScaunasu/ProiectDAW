using Microsoft.EntityFrameworkCore;

namespace ProiectDAW.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookType> BookTypes { get; set; }

        public DbSet<BookShelf> BookShelf { get; set; }
    }
}
  