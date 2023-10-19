using FluentResults;
using Mediator;

namespace Buddy.Data.Commands;

public class FinaliseJourneyDataCommand : ICommand<Result>
{
    public Guid Id { get; set; }
}