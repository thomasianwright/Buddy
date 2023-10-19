namespace Buddy.Forms.Commands;

public class CreateFormCommand
{
    public string Name { get; set; } = null!;
    public Guid? CreatedById { get; set; }
}