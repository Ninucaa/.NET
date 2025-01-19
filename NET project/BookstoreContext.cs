using Microsoft.EntityFrameworkCore;
using BookstoreAPI.Models;

namespace BookstoreAPI.Data
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(b => b.Id);
        }
    }
}