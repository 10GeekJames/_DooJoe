namespace DooJoe.Common
{
    public class DojoCommonClientCachingJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public DojoCommonClientCachingJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/DooJoe.Common/js/dojoCommonClientCachingJsInterop.js")
                .AsTask());

            _ = ImportClientCachingJsInterop();
        }

        public async Task ImportClientCachingJsInterop()
        {
            var module = await moduleTask.Value;
            await module.InvokeAsync<string>("importClientCachingJsInterop");
        }

        public async Task<bool> GetDarkMode()
        {
            var module = await moduleTask.Value;
            var darkMode = await module.InvokeAsync<string>("getDarkMode");
            return darkMode == "true";
        }

        public async Task SetDarkMode(bool isDarkMode)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("setDarkMode", isDarkMode.ToString());
        }

        public async Task<string> GetAppCulture(string defaultIfEmpty = "")
        {
            var module = await moduleTask.Value;
            var culture = await module.InvokeAsync<string>("getAppCulture");
            if (culture == "" && defaultIfEmpty != "")
            {
                return defaultIfEmpty;
            }
            return culture;
        }
        
        public async Task SetAppCulture(string appCulture)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("setAppCulture", appCulture);
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