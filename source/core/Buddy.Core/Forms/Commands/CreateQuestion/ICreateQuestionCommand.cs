namespace Buddy.Forms.Commands;

public interface ICreateQuestionCommand
{
    Guid? CreatedById { get; }
    Guid SurveyId { get;}
    int PageNumber { get; }
    string DisplayText { get; }
    string VariableName { get; }
}