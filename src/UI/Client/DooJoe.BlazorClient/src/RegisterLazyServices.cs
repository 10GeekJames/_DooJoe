namespace DooJoe.BlazorClient;
public static class RegisterLazyServices
{
    public static void RegisterModules(WebAssemblyHostBuilder builder)
    {
        static void RegisterLazyServices(WebAssemblyHostBuilder builder)
        {
            RegisterLazyServicesDojoSurveys.RegisterModules(builder);
        }
    }
}