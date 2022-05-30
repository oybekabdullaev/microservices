using System.Linq.Expressions;

namespace Products.Domain;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public static readonly Expression<Func<Product, ProductDto>> Map =
        p => new ProductDto {
            Id = p.Id,
            Name = p.Name,
            Price = p.Price
        };
}