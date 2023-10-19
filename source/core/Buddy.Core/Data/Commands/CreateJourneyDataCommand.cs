using Mediator;

namespace Buddy.Data.Commands;

public class CreateJourneyDataCommand : ICommand<Guid>
{
    public Guid SurveyId { get; set; }
}