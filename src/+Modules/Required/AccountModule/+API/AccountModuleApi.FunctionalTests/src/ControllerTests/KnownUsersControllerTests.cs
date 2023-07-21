namespace AccountModuleApi.FunctionalTests.ControllerTests;

[Collection("Sequential")]
public class KnownUsersControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    public KnownUsersControllerTests(CustomWebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetAllAsyncResponse()
    {
        var response = await _client.GetAsync(new KnownUserGetAllRequest().BuildRouteFrom());
        response.EnsureSuccessStatusCode();

        var raw = await response.Content.ReadAsStringAsync();
        var result = await response
            .Content
            .ReadFromJsonAsync<List<KnownUserViewModel>>();
        
        result.Any().Should().BeTrue();
    }   
}
