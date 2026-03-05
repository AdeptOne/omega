using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Omega.Infrastructure.Models;

[Table("Products")]
public class ProductModel
{
    [Key]
    public long ProductId { get; init; }
    
    [MaxLength(50)]
    public string? Name { get; init; }
    
    [MaxLength(255)]
    public string? Description { get; init; }
    
    public decimal Price { get; init; }
}