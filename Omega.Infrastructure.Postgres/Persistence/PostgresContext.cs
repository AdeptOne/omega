using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Omega.Infrastructure.Models;

namespace Omega.Infrastructure.Persistence;

public class PostgresContext : DbContext
{
    private readonly string? _connectionString;
    
    public PostgresContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Postgres");
    }
    
    public DbSet<ProductModel> Products { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }
}