namespace Buddy.Data.Dtos;

public class JourneyDataDto
{
    public Guid Id { get; set; }
    public Guid SchemaId { get; set; }

    public IDictionary<string, object> Values { get; set; } = new Dictionary<string, object>();
    
    public bool IsCompleted { get; set; }
}