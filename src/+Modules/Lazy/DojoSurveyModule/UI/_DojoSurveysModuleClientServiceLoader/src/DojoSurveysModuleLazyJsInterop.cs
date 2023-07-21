namespace DojoSurveysModuleClientServiceLoader
{
    public class DojoSurveysModuleLazyJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public DojoSurveysModuleLazyJsInterop(IJSRuntime jsRuntime)
        {
            System.Console.WriteLine("Trying to import the css");
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./_content/DojoSurveysBlazorModule/js/dojoSurveysModuleLazyJsInterop.js").AsTask());            
            
            ImportCss().GetAwaiter().GetResult();
            System.Console.WriteLine("Have imported the CSS");
            Prompt("hello").GetAwaiter().GetResult();
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        public async Task ImportCss(){
            var module = await moduleTask.Value;
            await module.InvokeAsync<string>("importCss");
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