using System.Reflection;
using Module = Autofac.Module;

namespace DojoSurveysApplication.Shared;
public class DojoSurveysApplicationSharedModule : Module
{
    private readonly bool _isDevelopment = false;
    private readonly List<Assembly> _assemblies = new List<Assembly>();

    public DojoSurveysApplicationSharedModule(bool isDevelopment, Assembly? callingAssembly = null)
    {
        _isDevelopment = isDevelopment;
        var coreAssembly = Assembly.GetAssembly(typeof(DojoSurveysCoreModule));
        var infrastructureAssembly = Assembly.GetAssembly(typeof(DojoSurveysInfrastructureModule));
        var applicationAssembly = Assembly.GetAssembly(typeof(DojoSurveysApplicationSharedModule));

        _assemblies.Add(coreAssembly!);
        _assemblies.Add(infrastructureAssembly!);
        _assemblies.Add(applicationAssembly!);

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
        builder.RegisterGeneric(typeof(EfRepository<>))
            .As(typeof(IRepository<>))
            .As(typeof(IReadRepository<>))
            .InstancePerLifetimeScope();

        builder
            .RegisterType<Mediator>()
            .As<IMediator>()
            .InstancePerLifetimeScope();

        var services = new ServiceCollection();        
        builder.Populate(services);

        var mediatrOpenTypes = new[]
        {
                typeof(IRequestHandler<,>),
                typeof(IRequestExceptionHandler<,,>),
                typeof(IRequestExceptionAction<,>),
                typeof(INotificationHandler<>),
            };

        foreach (var mediatrOpenType in mediatrOpenTypes)
        {
            builder
            .RegisterAssemblyTypes(_assemblies.ToArray())
            .AsClosedTypesOf(mediatrOpenType)
            .AsImplementedInterfaces();
        }

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
