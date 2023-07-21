namespace DooJoe.BlazorClient;
public static class RegisterLazyServicesDojoSurveys
{
    public static void RegisterModules(WebAssemblyHostBuilder builder)
    {
        RegisterDojoSurveysLazyServices(builder);
        
        static void RegisterDojoSurveysLazyServices(WebAssemblyHostBuilder builder)
        {
            var appSettings = builder.Configuration.Get<AppSettings>();

            // add the logged in users client endpoint for DojoSurveys
            
        }        
    }
}