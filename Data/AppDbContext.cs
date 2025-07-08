using Microsoft.EntityFrameworkCore;
using unimarket_backend.Models;

namespace unimarket_backend.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // Define DbSets for your entities here, e.g.:
            public DbSet<Item> Items { get; set; }
        // public DbSet<Product> Products { get; set; }
        // public DbSet<Category> Categories { get; set; }
    }
}
