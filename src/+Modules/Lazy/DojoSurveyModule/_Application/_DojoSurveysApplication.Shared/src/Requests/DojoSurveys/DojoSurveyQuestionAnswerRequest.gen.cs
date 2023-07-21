// ag=yes
namespace DojoSurveysApplication.Shared.Requests; 
public partial class DojoSurveyQuestionAnswerRequest
{
    public static string Route = "/DojoSurveyQuestionAnswer/";

    public string BuildRouteFrom()
    {
        return DojoSurveyQuestionAnswerRequest.BuildRoute();
    }
    public static string BuildRoute() => Route;
}