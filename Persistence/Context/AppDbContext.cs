using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TOKAC;Database=EShoppingDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}
