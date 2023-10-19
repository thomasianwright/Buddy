using Buddy.Data.Contracts;

namespace Buddy.Data.Models;

public class EntityBase<TKey> : IEntityBase<TKey> where TKey : struct
{
    public TKey Id { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}