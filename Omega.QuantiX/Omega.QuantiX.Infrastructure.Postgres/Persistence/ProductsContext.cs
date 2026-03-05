using Microsoft.EntityFrameworkCore;
using Omega.QuantiX.Infrastructure.Postgres.Models;

namespace Omega.QuantiX.Infrastructure.Postgres.Persistence;

public class ProductsContext(DbContextOptions<ProductsContext> options) : DbContext(options)
{
    public DbSet<ProductModel> Products { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}