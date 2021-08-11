using Interfaces;

using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace Lib_Blazor_UI.Views
{
    public partial class Sort : CoreComponent
    {
        [CascadingParameter(Name = nameof(SelectParameterValue))] public ISelect SelectCascadingParameter { get; set; }
        [CascadingParameter(Name = nameof(PositionCssClassParameterValue))] public string PositionCssClassCascadingParameter { get; set; }


        private async Task ApplySort(ChangeEventArgs eventArgs)
        {
            if(eventArgs.Value.ToString() == "-1") { return; }

            await this.OnSortChanged.InvokeAsync(eventArgs.Value.ToString());
        }
    }
}

//<svg xmlns="http://www.w3.org/2000/svg" width="100" height="50"><polygon points="0,0 100,0 50,50" /></svg>
