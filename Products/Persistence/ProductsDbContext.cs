using Microsoft.EntityFrameworkCore;
using Products.Domain;

namespace Products.Persistence;

public class ProductsDbContext : DbContext
{
    public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options) { }
    
    public DbSet<Product> Products { get; set; }
}