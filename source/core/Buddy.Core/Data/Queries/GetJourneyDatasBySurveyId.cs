using Buddy.Data.Dtos;
using FluentResults;

namespace Buddy.Data.Queries;

public class GetJourneyDatasBySurveyId : Result<IEnumerable<JourneyDataDto>>
{
    public Guid Id { get; set; }
    public int Page { get; set; }
    public int Limit { get; set; }
}