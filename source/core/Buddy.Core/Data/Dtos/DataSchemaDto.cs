namespace Buddy.Data.Dtos;

public class DataSchemaDto
{
    public Guid Id { get; set; }
    public Guid SurveyId { get; set; }

    public IList<DataSchemaPropertyDto> Properties { get; set; } = new List<DataSchemaPropertyDto>();
}