namespace Products.Domain;

public interface IProductRepository
{
    Task<ProductDto[]> GetAllAsync();
    Task<ProductDto> GetAsync(int id);
}