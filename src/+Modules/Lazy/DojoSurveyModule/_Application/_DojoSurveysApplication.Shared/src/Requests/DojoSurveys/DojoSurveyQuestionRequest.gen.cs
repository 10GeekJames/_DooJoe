// ag=yes
namespace DojoSurveysApplication.Shared.Requests; 
public partial class DojoSurveyQuestionRequest
{
    public static string Route = "/DojoSurveyQuestion/";

    public string BuildRouteFrom()
    {
        return DojoSurveyQuestionRequest.BuildRoute();
    }
    public static string BuildRoute() => Route;
}