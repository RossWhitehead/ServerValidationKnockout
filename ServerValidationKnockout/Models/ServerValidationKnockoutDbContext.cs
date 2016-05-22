using System.Data.Entity;

namespace ServerValidationKnockout.Models
{
    public class ServerValidationKnockoutDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}