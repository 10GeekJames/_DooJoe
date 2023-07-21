// ag=yes
namespace AccountModuleInfrastructure.CommandQuery; 
public partial class KnownUserCreateByUserIdCmd : IRequest<KnownUser>
{
    public Guid KnownUserId { get; set; }
    public Guid KnownBusinessWebsiteId { get; set; }
    private KnownUserCreateByUserIdCmd()
    { }
    public KnownUserCreateByUserIdCmd(Guid knownUserId)
    {
        KnownUserId = Guard.Against.NullOrEmpty(knownUserId);
    }
}
