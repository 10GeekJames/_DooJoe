using System.Reflection;
using Module = Autofac.Module;

namespace DooJoe.ConsoleUI;
public class DooJoeConsoleModule : Module
{
    private readonly bool _isDevelopment = false;
    private readonly List<Assembly> _assemblies = new List<Assembly>();

    public DooJoeConsoleModule(bool isDevelopment, Assembly? callingAssembly = null)
    {
        _isDevelopment = isDevelopment;
        var coreAssembly = Assembly.GetAssembly(typeof(DojoSurveysCoreModule));
        var infrastructureAssembly = Assembly.GetAssembly(typeof(DojoSurveysInfrastructureModule));
        var applicationAssembly = Assembly.GetAssembly(typeof(DojoSurveysApplicationModule));
        var consoleAssembly = Assembly.GetAssembly(typeof(DooJoeConsoleModule));

        _assemblies.Add(coreAssembly!);
        _assemblies.Add(infrastructureAssembly!);
        _assemblies.Add(applicationAssembly!);
        _assemblies.Add(consoleAssembly);

        if (callingAssembly != null)
        {
            _assemblies.Add(callingAssembly);
        }
    }

    protected override void Load(ContainerBuilder builder)
    {
        if (_isDevelopment)
        {
            RegisterDevelopmentOnlyDependencies(builder);
        }
        else
        {
            RegisterProductionOnlyDependencies(builder);
        }
        RegisterCommonDependencies(builder);
    }

    private void RegisterCommonDependencies(ContainerBuilder builder)
    {
        var services = new ServiceCollection();
        services.AddAutoMapper(typeof(DojoSurveyMap).GetTypeInfo().Assembly);
        builder.Populate(services);

        // register misc
        /*
        builder.RegisterType<EmailSender>().As<IEmailSender>()
            .InstancePerLifetimeScope();
        */
    }

    private void RegisterDevelopmentOnlyDependencies(ContainerBuilder builder)
    {
        // TODO: Add development only services
    }

    private void RegisterProductionOnlyDependencies(ContainerBuilder builder)
    {
        // TODO: Add production only services
    }

}
