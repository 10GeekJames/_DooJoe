// ag=yes
namespace AccountModuleApplication.Shared.Requests; 
public partial class KnownUserRequest
{
    public static string Route = "/KnownUser/";

    public string BuildRouteFrom()
    {
        return KnownUserRequest.BuildRoute();
    }
    public static string BuildRoute() => Route;
}