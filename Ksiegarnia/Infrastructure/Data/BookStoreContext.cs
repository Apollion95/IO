using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Publisher> Publishers { get; set; }    
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Book> Store { get; set; }
        public DbSet<Subscriber> Subscribers  { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

    }
   
}
