namespace DooJoe.ConsoleUI;
using System.Reflection;
public class Startup
{
    public AutofacServiceProvider ServiceProvider { get; set; }
    public Startup()
    {
        IServiceCollection services = new ServiceCollection();
        string environment = "development";
        IConfigurationRoot configuration =
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",
                optional: false,
                reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        bool useSqlite = configuration.GetValue<bool>(nameof(useSqlite));

       

        // DojoSurveyModule
        string dojoSurveysConnectionString =
            configuration.GetConnectionString("ActiveDojoSurveys") ?? "";

        var appSettings = configuration.Get<AppSettings>();

        services
            .AddSingleton<AppSettings>(appSettings!);

        services
            .AddDojoSurveysDbContext(dojoSurveysConnectionString);

        services.AddSingleton<IDojoSurveysDataService, DojoSurveysDirectDataService>();
        // \DojoSurveyModule

        services.AddLogging().BuildServiceProvider();

        services.AddSingleton<App>();

        
        var containerBuilder = new ContainerBuilder();
        containerBuilder.Populate(services);

        //containerBuilder.RegisterModule(new SpyderFootScansCoreModule());
        //containerBuilder.RegisterModule(new SpyderFootScansInfrastructureModule(true));

        //containerBuilder.RegisterModule(new ScanModulesCoreModule());
        //containerBuilder.RegisterModule(new ScanModulesInfrastructureModule(true));


        var container = containerBuilder;
        var isInDevelopment = true; //_env.EnvironmentName == "Development";
        container.RegisterModule(new DojoSurveysCoreModule());
        container.RegisterModule(new DojoSurveysInfrastructureModule(isInDevelopment));
        container.RegisterModule(new DojoSurveysApplicationModule(isInDevelopment));
        container.RegisterModule(new DooJoeConsoleModule(isInDevelopment, typeof(App).GetTypeInfo().Assembly));
        var builtContainer = container.Build();
        ServiceProvider = new AutofacServiceProvider(builtContainer);
    }

    /* public void ConfigureContainer(ContainerBuilder builder)
    {
        var isInDevelopment = true; //_env.EnvironmentName == "Development";
        builder.RegisterModule(new DojoSurveysCoreModule());
        builder.RegisterModule(new DojoSurveysInfrastructureModule(isInDevelopment));
        builder.RegisterModule(new DojoSurveysApplicationModule(isInDevelopment));
        builder.RegisterModule(new DooJoeConsoleModule(isInDevelopment, typeof(App).GetTypeInfo().Assembly));
    } */
}
