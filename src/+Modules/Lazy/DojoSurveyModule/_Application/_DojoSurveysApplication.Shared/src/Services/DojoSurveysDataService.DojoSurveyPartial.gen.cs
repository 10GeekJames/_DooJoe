// ag=yes
namespace DojoSurveysApplication.Shared.Services; 
public partial class DojoSurveysHttpDataService
{
    public async Task<DojoSurveyViewModel?> DojoSurveyCreateNewAsync(DojoSurveyCreateNewRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(request.BuildRouteFrom(), request);

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<DojoSurveyViewModel>();
    }
    public async Task<DojoSurveyViewModel?> DojoSurveyGetByIdAsync(DojoSurveyGetByIdRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(request.BuildRouteFrom(), request);

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<DojoSurveyViewModel>();
    }

}
