using Buddy.Data.Models;

namespace Buddy.Features.Forms.Entities;

public class SurveyQuestion : EntityBase<Guid>
{
    public string DisplayText { get; set; } = null!;
    
    public int? CategoryId { get; set; }
    public int Order { get; set; }

    public Guid SurveyFormId { get; set; }
    public SurveyForm SurveyForm { get; set; } = null!;
}