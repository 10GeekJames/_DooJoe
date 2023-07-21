// ag=yes
namespace DojoSurveysApplication.Shared.Requests; 
public partial class DojoCompletedSurveyRequest
{
    public static string Route = "/DojoCompletedSurvey/";

    public string BuildRouteFrom()
    {
        return DojoCompletedSurveyRequest.BuildRoute();
    }
    public static string BuildRoute() => Route;
}