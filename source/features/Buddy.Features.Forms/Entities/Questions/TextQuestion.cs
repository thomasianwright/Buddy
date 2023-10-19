namespace Buddy.Features.Forms.Entities.Questions;

public class TextQuestion : SurveyQuestion
{
    public int? MinLength { get; set; }
    public int? MaxLength { get; set; }
    public string? Regex { get; set; }

    public string? MinLengthErrorMessage { get; set; }
    public string? MaxLengthErrorMessage { get; set; }
    public string? RegexErrorMessage { get; set; }
}