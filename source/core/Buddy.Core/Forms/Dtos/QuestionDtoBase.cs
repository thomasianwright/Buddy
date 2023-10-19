namespace Buddy.Forms.Dtos;

public class QuestionDtoBase
{
    public string DisplayText { get; set; } = null!;
    public string VariableName { get; set; } = null!;
    
    public int? CategoryId { get; set; }
    public int Order { get; set; }

    public Guid SurveyFormId { get; set; }
}