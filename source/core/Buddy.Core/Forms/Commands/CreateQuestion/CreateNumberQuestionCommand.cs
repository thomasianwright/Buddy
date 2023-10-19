namespace Buddy.Forms.Commands;

public class CreateNumberQuestionCommand : ICreateQuestionCommand
{
    public decimal? MaxValue { get; set; }
    public decimal? MinValue { get; set; }
    
    public string? MaxValueErrorMessage { get; set; }
    public string? MinValueErrorMessage { get; set; }
    
    public Guid? CreatedById { get; set; }
    public Guid SurveyId { get; set; }
    public int PageNumber { get; set; }
    public string DisplayText { get; set; }
    public string VariableName { get; set; }
}