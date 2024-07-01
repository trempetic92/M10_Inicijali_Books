using Books.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Books.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Author 1" },
                new Author { Id = 2, Name = "Author 2" },
                new Author { Id = 3, Name = "Author 3" },
                new Author { Id = 4, Name = "Author 4" },
                new Author { Id = 5, Name = "Author 5" }
            );

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Id = 1, Title = "Publisher 1" },
                new Publisher { Id = 2, Title = "Publisher 2" },
                new Publisher { Id = 3, Title = "Publisher 3" },
                new Publisher { Id = 4, Title = "Publisher 4" },
                new Publisher { Id = 5, Title = "Publisher 5" }
            );
        }

    }
}
