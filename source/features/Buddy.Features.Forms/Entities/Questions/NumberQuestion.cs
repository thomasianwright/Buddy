namespace Buddy.Features.Forms.Entities.Questions;

public class NumberQuestion : SurveyQuestion
{
    public decimal? MaxValue { get; set; }
    public decimal? MinValue { get; set; }
    
    public string? MaxValueErrorMessage { get; set; }
    public string? MinValueErrorMessage { get; set; }
}