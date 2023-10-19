using Buddy.Forms.Dtos;
using Mediator;

namespace Buddy.Forms.Queries;

public class GetSurveyQuery : IQuery<SurveyDto>
{
    public Guid Id { get; set; }
    public int? Page { get; set; }
}