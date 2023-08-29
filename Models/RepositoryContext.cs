using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product(){Id = 1, ProductName = "Computer", Price = 17_000},
                new Product(){Id = 2, ProductName = "Keyboard", Price = 7_000},
                new Product(){Id = 3, ProductName = "Mouse", Price = 500},
                new Product(){Id = 4, ProductName = "Monitor", Price = 7_000},
                new Product(){Id = 5, ProductName = "Speaker", Price = 1_000}
            );
        }
    }
}