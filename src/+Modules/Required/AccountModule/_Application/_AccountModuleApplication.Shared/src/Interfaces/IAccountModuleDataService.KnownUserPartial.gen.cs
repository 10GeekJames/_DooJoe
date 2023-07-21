// ag=yes
namespace AccountModuleApplication.Shared.Interfaces; 
public partial interface IAccountModuleDataService
{
    Task<KnownUserViewModel?> KnownUserCreateByUserIdAsync(KnownUserCreateByUserIdRequest request);
    Task<KnownUserViewModel?> KnownUserGetByUserIdAsync(KnownUserGetByUserIdRequest request);
    Task<KnownUserViewModel?> KnownUserGetAsync(KnownUserGetRequest request);
    Task<KnownUserViewModel?> KnownUserUpdateAccountAsync(KnownUserUpdateAccountRequest request);

}