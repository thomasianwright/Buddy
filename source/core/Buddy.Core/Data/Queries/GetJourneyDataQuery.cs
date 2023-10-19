using FluentResults;
using Mediator;

namespace Buddy.Data.Queries;

public class GetJourneyDataQuery : IQuery<Result<IDictionary<string, object>>>
{
    public Guid Id { get; set; }
}