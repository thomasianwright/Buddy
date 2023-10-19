namespace Buddy.Forms.Dtos.Questions;

public class NumberQuestionDto : QuestionDtoBase
{
    public decimal? MaxValue { get; set; }
    public decimal? MinValue { get; set; }
    
    public string? MaxValueErrorMessage { get; set; }
    public string? MinValueErrorMessage { get; set; }
}