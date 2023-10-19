using Buddy.Data.Enums;

namespace Buddy.Features.Data.Models;

public class DataSchemaProperty
{
    public string Name { get; set; } = null!;
    public DataSchemaPropertyType Type { get; set; }
}