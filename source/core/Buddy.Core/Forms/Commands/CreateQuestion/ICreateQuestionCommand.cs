namespace Buddy.Forms.Commands;

public interface ICreateQuestionCommand
{
    Guid? CreatedById { get; }
    string DisplayText { get; }
    string VariableName { get; }
}