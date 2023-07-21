namespace AccountModuleInfrastructure.CommandQuery; 
public class KnownUserCreateByUserIdCmdHandler : IRequestHandler<KnownUserCreateByUserIdCmd, KnownUser>
{
    private readonly IRepository<KnownUser> _knownUserRepository;
    public KnownUserCreateByUserIdCmdHandler(IRepository<KnownUser> knownUserRepository)
    {
        _knownUserRepository = knownUserRepository;    
    }
    public async Task<KnownUser> Handle(KnownUserCreateByUserIdCmd cmd, CancellationToken cancellationToken)
    {
        var newKnownUser = new KnownUser(cmd.KnownUserId);
        return await _knownUserRepository.AddAsync(newKnownUser, cancellationToken);
    }
}