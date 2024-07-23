using Core.Entities;
using Core.Interfaces;

namespace Infrastructure;

public class ProductRepository : IProductRepository
{
    public Task<Product> GetProductByIdAsync(int it)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Product>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }
}
