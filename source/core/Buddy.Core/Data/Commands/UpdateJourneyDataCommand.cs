using Mediator;

namespace Buddy.Data.Commands;

public class UpdateJourneyDataCommand : ICommand<Guid>
{
    public Guid JourneyId { get; set; }

    public IDictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
}