using Microsoft.AspNetCore.Components;

namespace Lib_Blazor_UI.Views
{
    public partial class AlertBox
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
