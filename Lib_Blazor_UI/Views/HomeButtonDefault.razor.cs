using Microsoft.AspNetCore.Components;

namespace Lib_Blazor_UI.Views
{
    public partial class HomeButtonDefault
    {
        [Parameter] public string UrlParameter { get; set; } = string.Empty;
    }
}
