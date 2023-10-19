namespace Buddy.Forms.Commands;

public class CreateSelectQuestionCommandCommand : ICreateQuestionCommand
{
    public IDictionary<int, string> Select { get; set; } = new Dictionary<int, string>();

    public int DefaultSelection { get; set; } = 0;
    public int MaxSelection { get; set; } = 1;

    public Guid? CreatedById { get; set; }
    public Guid SurveyId { get; set; }
    public int PageNumber { get; set; }

    public string DisplayText { get; set; } = null!;
    public string VariableName { get; set; } = null!;
}