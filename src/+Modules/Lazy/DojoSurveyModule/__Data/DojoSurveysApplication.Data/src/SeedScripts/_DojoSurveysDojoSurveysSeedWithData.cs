namespace DojoSurveysApplication.Data.SeedScripts;
public class DojoSurveysSeedWithData : IDojoSurveysSeedScript
{
    public async Task PopulateDojoSurveysTestData(IServiceProvider serviceProvider)
    {
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<DojoSurveysSeedWithData>>();
        using var dbContext =
                new DojoSurveysDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<DojoSurveysDbContext>>(
                        ), mediator);
        
        foreach (var dojoSurvey in DojoSurveyTestData.AllDojoSurveys)
        {
            if (!dbContext.DojoSurveys.AsEnumerable().Any(rs => dojoSurvey.Id.Equals(rs.Id)))
            {
                dbContext.DojoSurveys.Add(dojoSurvey);
                logger?.LogInformation($"{dojoSurvey.Title} was created in the database.", dojoSurvey.Title);
            }
            else
            {
                logger?.LogInformation($"{dojoSurvey.Title} already exist in the database.", dojoSurvey.Title);
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
