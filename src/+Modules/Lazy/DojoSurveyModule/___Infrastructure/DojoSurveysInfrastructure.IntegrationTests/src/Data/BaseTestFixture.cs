namespace DojoSurveysInfrastructure.IntegrationTests.Data;
public abstract class BaseTestFixture
{
    protected DojoSurveysDbContext? _dbContext;
    
    protected static DbContextOptions<DojoSurveysDbContext> CreateNewContextOptions()
    {
        // Create a fresh service provider, and therefore a fresh
        // InMemory database instance.
        var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

        // Create a new options instance telling the context to use an
        // InMemory database and the new service provider.
        var builder = new DbContextOptionsBuilder<DojoSurveysDbContext>();
        builder.UseInMemoryDatabase("DojoSurveysDb")
               .UseInternalServiceProvider(serviceProvider);

        return builder.Options;
    }

    protected EfRepository<DojoSurvey> DojoSurveysRepository()
    {
        var options = CreateNewContextOptions();
        var mockMediator = new Mock<IMediator>();

        _dbContext = new DojoSurveysDbContext(options, mockMediator.Object);
        return new EfRepository<DojoSurvey>(_dbContext);
    }    
}
