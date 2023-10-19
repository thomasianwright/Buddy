using Buddy.Data.Models;

namespace Buddy.Features.Forms.Entities;

public class SurveyForm : EntityBase<Guid>
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public Guid? SchemaId { get; set; }
    
    public virtual ICollection<SurveyQuestion> Questions { get; set; } = null!;

    public DateTimeOffset? PublishedAt { get; set; }
}