using System;
using System.Threading.Tasks;

using Microsoft.JSInterop;

namespace Lib_Blazor_UI
{
    public class NavigationJSI : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public NavigationJSI(IJSRuntime jsRuntime)
        {
            this.moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Lib_Blazor_UI/js/NavigationJSI.js").AsTask());
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await this.moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        public async ValueTask OnCloseSidebar(string element)
        {
            var module = await this.moduleTask.Value;
            await module.InvokeVoidAsync("onCloseSidebar", element);
        }

        public async ValueTask OnToggleSidebar(string element)
        {
            var module = await this.moduleTask.Value;
            await module.InvokeVoidAsync("onToggleSidebar", element);
        }

        public async ValueTask LoadNavigation()
        {
            var module = await this.moduleTask.Value;
            await module.InvokeVoidAsync("loadNavigation");
        }

        public async ValueTask DisposeAsync()
        {
            if(this.moduleTask.IsValueCreated)
            {
                var module = await this.moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
