namespace AccountModuleApplication.Shared.Requests;
public class KnownUserCreateByUserIdRequest : IRoutable
{
    public static string Route = "/KnownUser/CreateByUserId";
    public Guid KnownUserId { get; set; }
    public Guid KnownBusinessWebsiteId { get; set; }

    private KnownUserCreateByUserIdRequest()
    { }
    public KnownUserCreateByUserIdRequest(Guid knownUserId)
    {
        KnownUserId = Guard.Against.NullOrEmpty(knownUserId);
    }

    public string BuildRouteFrom() => KnownUserCreateByUserIdRequest.BuildRoute();

    public static string BuildRoute() => Route;
}
