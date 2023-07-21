namespace DojoSurveysBlazorModule;
public class DojoSurveysServiceWrapper
{
    public IDojoSurveysDataService? _dojoSurveysService;
    public IDojoSurveysDataService? IDojoSurveysDataService { get => _dojoSurveysService; set { _dojoSurveysService = value; } }
}