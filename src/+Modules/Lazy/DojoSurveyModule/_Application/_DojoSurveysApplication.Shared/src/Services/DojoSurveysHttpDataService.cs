namespace DojoSurveysApplication.Shared.Services;
public partial class DojoSurveysHttpDataService : IDojoSurveysDataService, IDojoSurveysDataServiceNotAuthed
{
    protected readonly HttpClient _httpClient;

    public DojoSurveysHttpDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
