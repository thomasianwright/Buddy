﻿namespace Buddy.Forms.Commands;

public class CreateQuestionCommandCommand : ICreateQuestionCommand
{
    public Guid? CreatedById { get; set; }
    public string DisplayText { get; set; } = null!;
    public string VariableName { get; set; } = null!;

    public int? MinLength { get; set; }
    public int? MaxLength { get; set; }
    public string? Regex { get; set; }

    public string? MinLengthErrorMessage { get; set; }
    public string? MaxLengthErrorMessage { get; set; }
    public string? RegexErrorMessage { get; set; }
}