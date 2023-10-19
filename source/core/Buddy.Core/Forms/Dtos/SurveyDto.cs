namespace Buddy.Forms.Dtos;

public class SurveyDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public IList<QuestionDtoBase> Questions { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
}