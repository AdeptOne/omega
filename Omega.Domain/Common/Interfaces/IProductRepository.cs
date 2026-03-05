using Omega.Domain.Entities;

namespace Omega.Domain.Common.Interfaces;

public interface IProductRepository
{
    public Task<Product?> GetProductById(long id);
    
    public Task<Product> AddProduct(Product product);
}