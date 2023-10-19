using Buddy.Forms.Enums;

namespace Buddy.Features.Forms.Entities.Questions;

public class SelectQuestion : SurveyQuestion
{
    public IDictionary<int, string> Select { get; set; } = new Dictionary<int, string>();

    public SelectQuestionDisplayType SelectQuestionDisplayType { get; set; }
}