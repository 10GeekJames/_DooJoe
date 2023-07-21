// ag=yes
namespace DojoSurveysApplication.Shared.Services; 
public partial class DojoSurveysHttpDataService
{
    public async Task<List<DojoSurveyViewModel>?> DojoSurveysGetAllAsync(DojoSurveysGetAllRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(request.BuildRouteFrom(), request);

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<DojoSurveyViewModel>>();
    }

}
