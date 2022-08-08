using LiveLibUaVersionMVC.Models;

namespace LiveLibUaVersionMVC.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
