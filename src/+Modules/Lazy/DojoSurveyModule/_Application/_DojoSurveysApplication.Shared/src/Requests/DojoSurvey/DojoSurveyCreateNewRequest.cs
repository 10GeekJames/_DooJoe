namespace DojoSurveysApplication.Shared.Requests;

public class DojoSurveyCreateNewRequest : IRoutable
{
    protected readonly static string Route = "dojosurvey/createnew";
    public DojoSurveyViewModel DojoSurvey { get; set; }
    public DojoSurveyCreateNewRequest() { }
    public DojoSurveyCreateNewRequest(DojoSurveyViewModel dojoSurvey)
    {
        DojoSurvey = dojoSurvey;
    }
    public string BuildRouteFrom() => DojoSurveyCreateNewRequest.BuildRoute();
    public static string BuildRoute() => Route;
}
