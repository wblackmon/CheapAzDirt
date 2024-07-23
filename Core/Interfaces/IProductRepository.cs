using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository 
{
    Task<Product> GetProductByIdAsync(int it);
    Task<IReadOnlyList<Product>> GetProductsAsync(); 
}
