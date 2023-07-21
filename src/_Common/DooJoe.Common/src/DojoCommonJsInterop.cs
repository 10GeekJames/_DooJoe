namespace DooJoe.Common
{
    public class DojoCommonJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public DojoCommonJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/DooJoe.Common/js/DojoCommonJsInterop.js")
                .AsTask());

            _ = ImportCss();
            _ = ImportCommonJsInterop();
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        public async Task ImportCss()
        {
            var module = await moduleTask.Value;
            await module.InvokeAsync<string>("importCss");
        }

        public async Task ImportCommonJsInterop()
        {
            var module = await moduleTask.Value;
            await module.InvokeAsync<string>("importCommonJsInterop");
        }
        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}