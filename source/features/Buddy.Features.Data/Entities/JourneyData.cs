using Buddy.Data.Models;

namespace Buddy.Features.Data.Entities;

public class JourneyData : EntityBase<Guid>
{
    public Guid SchemaId { get; set; }
    public DataSchema Schema { get; set; } = null!;

    public IDictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
}