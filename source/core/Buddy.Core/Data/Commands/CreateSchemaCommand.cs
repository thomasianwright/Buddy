using Buddy.Data.Dtos;
using Mediator;

namespace Buddy.Data.Commands;

public class CreateSchemaCommand : ICommand<Guid>
{
    public Guid SurveyId { get; set; }
    public IList<DataSchemaDto> Properties { get; set; } = new List<DataSchemaDto>();
}