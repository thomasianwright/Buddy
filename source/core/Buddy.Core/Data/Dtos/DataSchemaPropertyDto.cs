using Buddy.Data.Enums;

namespace Buddy.Data.Dtos;

public class DataSchemaPropertyDto
{
    public string Name { get; set; } = null!;
    public DataSchemaPropertyType Type { get; set; }
}