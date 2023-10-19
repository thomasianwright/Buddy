namespace Buddy.Data.Contracts;

public interface IEntityBase<TKey> where TKey : struct
{
    TKey Id { get; set; }
    
    DateTimeOffset CreatedAt { get; set; }
    DateTimeOffset UpdatedAt { get; set; }
}