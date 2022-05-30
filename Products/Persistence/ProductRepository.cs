using Microsoft.EntityFrameworkCore;
using Products.Domain;

namespace Products.Persistence;

public class ProductRepository : IProductRepository
{
    private readonly ProductsDbContext _context;

    public ProductRepository(ProductsDbContext context)
    {
        _context = context;
    }
    
    public async Task<ProductDto[]> GetAllAsync()
    {
        return await _context.Products
            .Select(ProductDto.Map)
            .ToArrayAsync();
    }

    public async Task<ProductDto> GetAsync(int id)
    {
        return await _context.Products
            .Select(ProductDto.Map)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}