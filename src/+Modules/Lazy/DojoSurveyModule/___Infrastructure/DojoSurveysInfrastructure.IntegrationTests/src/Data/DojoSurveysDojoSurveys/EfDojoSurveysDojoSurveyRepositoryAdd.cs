namespace DojoSurveysInfrastructure.IntegrationTests.Data.DojoSurveyss;
public class EfDojoSurveyRepositoryAdd : BaseTestFixture
{
    [Fact]
    public async Task AddsDojoSurveysSetsId()
    {
        var repository = DojoSurveysRepository();
        var DojoSurveys = DojoSurveyTestData.MyFirstSurvey;

        await repository.AddAsync(DojoSurveys);

        var newDojoSurveys = (await repository.ListAsync())
                        .FirstOrDefault();

        Assert.NotNull(newDojoSurveys?.Id);
    }
}
