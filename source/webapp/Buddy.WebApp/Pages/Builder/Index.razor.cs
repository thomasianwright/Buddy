using Microsoft.AspNetCore.Components;

namespace Buddy.WebApp.Pages.Builder;

public partial class Index : ComponentBase
{
    [Parameter]
    public Guid Id { get; set; } = Guid.Empty;
}