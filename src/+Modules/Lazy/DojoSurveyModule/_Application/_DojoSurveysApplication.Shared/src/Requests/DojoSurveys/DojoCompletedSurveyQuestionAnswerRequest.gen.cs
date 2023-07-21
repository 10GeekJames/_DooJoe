// ag=yes
namespace DojoSurveysApplication.Shared.Requests; 
public partial class DojoCompletedSurveyQuestionAnswerRequest
{
    public static string Route = "/DojoCompletedSurveyQuestionAnswer/";

    public string BuildRouteFrom()
    {
        return DojoCompletedSurveyQuestionAnswerRequest.BuildRoute();
    }
    public static string BuildRoute() => Route;
}