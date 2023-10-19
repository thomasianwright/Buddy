using Buddy.Forms.Enums;

namespace Buddy.Features.Forms.Entities.Questions;

public class SelectQuestion : SurveyQuestion
{
    public IDictionary<int, string> Select { get; set; } = new Dictionary<int, string>();
    
    public int DefaultSelection { get; set; } = 0;
    public int MaxSelections { get; set; } = 1;

    public SelectQuestionDisplayType SelectQuestionDisplayType { get; set; }
}