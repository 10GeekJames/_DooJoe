namespace DooJoe.ConsoleUI;

public class App
{   
    private IDojoSurveysDataService _dojoSurveysDataService;
    public App(IDojoSurveysDataService dojoSurveysDataService) {
        _dojoSurveysDataService = dojoSurveysDataService;
    }

    public async Task RunAsync()
    {
        Console.WriteLine("I LIVE!");
        var DojoSurveyQry = new DojoSurveysFindQry("a");
        var DojoSurveys = await _dojoSurveysDataService.DojoSurveysFindAsync(DojoSurveyQry);
        foreach(var DojoSurvey in DojoSurveys) {
            Console.WriteLine($"{DojoSurvey.Title}");
        }
    }
}