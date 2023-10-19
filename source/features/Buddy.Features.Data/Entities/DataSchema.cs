using Buddy.Data.Models;
using Buddy.Features.Data.Models;

namespace Buddy.Features.Data.Entities;

public class DataSchema : EntityBase<Guid>
{
    public Guid SurveyId { get; set; }
    
    public IList<DataSchemaProperty> Properties { get; set; } = new List<DataSchemaProperty>();

    public virtual ICollection<JourneyData> Journeys { get; set; } = new List<JourneyData>();
}