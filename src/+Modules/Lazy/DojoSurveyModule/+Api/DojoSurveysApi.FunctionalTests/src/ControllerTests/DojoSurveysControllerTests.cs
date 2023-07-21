namespace DojoSurveysApi.FunctionalTests.ControllerTests;

[Collection("Sequential")]
public class DojoSurveysControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    public DojoSurveysControllerTests(CustomWebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ReturnsAllDojoSurveys()
    {
        var response = await _client.GetAsync(new DojoSurveysGetAllRequest().BuildRouteFrom());
        response.EnsureSuccessStatusCode();

        var raw = await response.Content.ReadAsStringAsync();
        var result = await response
            .Content
            .ReadFromJsonAsync<IEnumerable<DojoSurveyViewModel>>();

        result.Should().HaveCount(DojoSurveyTestData.AllDojoSurveys.Count());
        // Assert.Contains(result, i => i.Name == SeedDojoSurveyData.TestDojoSurvey1.Name);
    }

    [Fact]
    public async Task ReturnsDojoSurveySearchResults()
    {
        var response = await _client.GetAsync(new DojoSurveysFindByTitleRequest("a").BuildRouteFrom());
        response.EnsureSuccessStatusCode();

        var raw = await response.Content.ReadAsStringAsync();
        var result = await response
            .Content
            .ReadFromJsonAsync<IEnumerable<DojoSurveyViewModel>>();

        result.Should().HaveCountGreaterThan(0);
        // Assert.Contains(result, i => i.Name == SeedDojoSurveyData.TestDojoSurvey1.Name);
    }
}
