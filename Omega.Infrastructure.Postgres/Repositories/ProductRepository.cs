using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Omega.Domain.Common.Interfaces;
using Omega.Domain.Entities;
using Omega.Infrastructure.Models;
using Omega.Infrastructure.Persistence;

namespace Omega.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly PostgresContext _context;
    private readonly IMapper _mapper;

    public ProductRepository(PostgresContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<Product?> GetProductById(long id)
    {
        var dataModel = await _context.Products
            .FirstOrDefaultAsync(x => x.ProductId == id);
        
        if (dataModel is null)
            return null;
        
        return _mapper.Map<ProductModel, Product>(dataModel);
    }

    public async Task<Product> AddProduct(Product product)
    {
        var dataModel = _mapper.Map<Product, ProductModel>(product);
        var entry = await _context.AddAsync(dataModel);
        await _context.SaveChangesAsync();
        
        return _mapper.Map<ProductModel, Product>(entry.Entity);
    }
}