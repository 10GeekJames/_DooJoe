// ag=yes
namespace DojoSurveysApplication.Shared.Requests; 
public partial class DojoSurveyRequest
{
    public static string Route = "/DojoSurvey/";

    public string BuildRouteFrom()
    {
        return DojoSurveyRequest.BuildRoute();
    }
    public static string BuildRoute() => Route;
}