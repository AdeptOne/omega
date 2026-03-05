using System.ComponentModel.DataAnnotations;

namespace Omega.QuantiX.Infrastructure.Postgres.Models.Common;

public abstract class ItemModel
{
    [Key]
    public Guid ItemId { get; set; } = Guid.CreateVersion7();
}