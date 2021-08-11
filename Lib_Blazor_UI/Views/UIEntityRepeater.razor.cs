using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

namespace Lib_Blazor_UI.Views
{
    public partial class UIEntityRepeater<TEntity>
    {
        [Parameter] public RenderFragment<TEntity> Entity { get; set; }
        [Parameter] public IEnumerable<TEntity> Entities { get; set; }
    }
}
