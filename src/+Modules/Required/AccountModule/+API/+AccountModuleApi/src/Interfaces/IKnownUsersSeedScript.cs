namespace AccountModuleApi.Interfaces;
public interface IKnownUsersSeedScript
{
    Task Initialize(IServiceProvider serviceProvider, IMediator mediator);
    Task PopulateTestData(AccountModuleDbContext dbContext);
}
