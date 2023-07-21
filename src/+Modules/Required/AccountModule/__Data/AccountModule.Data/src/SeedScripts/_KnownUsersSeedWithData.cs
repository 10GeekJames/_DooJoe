namespace AccountModule.Data.SeedScripts;
public class KnownUsersSeedWithData : IDojoSurveysSeedScript
{
    public async Task PopulateDojoSurveysTestData(IServiceProvider serviceProvider)
    {
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<KnownUserSeedWithData>>();
        using var dbContext =
                new DojoSurveysDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<DojoSurveysDbContext>>(
                        ), mediator);
        
        foreach (var knownUser in KnownUserTestData.AllKnownUsers)
        {
            if (!dbContext.KnownUsers.AsEnumerable().Any(rs => knownUser.Isbn.Equals(rs.Isbn)))
            {
                dbContext.KnownUsers.Add(knownUser);
                logger?.LogInformation("{knownUser.Title} was created in the database.", knownUser.Title);
            }
            else
            {
                logger?.LogInformation("{knownUser.Title} already exist in the database.", knownUser.Title);
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
