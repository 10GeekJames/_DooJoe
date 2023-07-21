// ag=yes
namespace DojoSurveysApplication.Shared.Requests; 
public partial class DojoSurveysGetAllRequest
{
    public static string Route = "/DojoSurveys/GetAll";

    public string BuildRouteFrom()
    {
        return DojoSurveysGetAllRequest.BuildRoute();
    }
    public static string BuildRoute() => Route;
}