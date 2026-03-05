namespace Omega.Domain.Entities;

public class Product
{
    public long ProductId { get; private set; }
    
    public string? Name { get; private set; }
    
    public string? Description { get; private set; }
    
    public decimal Price { get; private set; }
}