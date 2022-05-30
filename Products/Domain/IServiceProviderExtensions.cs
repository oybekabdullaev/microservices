using Microsoft.EntityFrameworkCore;
using Products.Persistence;

namespace Products.Domain;

public static class IServiceProviderExtensions
{
    public static void SeedDatabase(this IServiceProvider serviceProvider)
    {
        var options = serviceProvider.GetRequiredService<DbContextOptions<ProductsDbContext>>();
        using var context = new ProductsDbContext(options);
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product { Id = 1, Name = "Keyboard", Price = 20 },
                new Product { Id = 2, Name = "Mouse", Price = 5 },
                new Product { Id = 3, Name = "Monitor", Price = 150 },
                new Product { Id = 4, Name = "CPU", Price = 200 });
            context.SaveChanges();
        }
    }
}