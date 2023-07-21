namespace AccountModuleApplication.FeatureTests.Data.KnownUsers;
public class EfKnownUserApplicationAdd : BaseApplicationTestFixture
{
    [Fact]
    public async Task AddKnownUser()
    {

        var result = await _dataService.KnownUserAllAsync();
        result!.Should().NotBeNull("because an empty result should be created");
        result!.Count.Should().Be(0, "because we haven't added any known accounts yet");

        /* var cmd = new KnownUserAddCmd(KnownUserTestData.KnownUserAlfradoTheGreat);
        await _dataService.KnownUserAddAsync(cmd);

        var qry = new KnownUsersGetAllQry();
        result = (await _dataService.KnownUsersGetAllAsync(qry));
        var resultFirst = result!.FirstOrDefault();
        var resultFirstCopy = resultFirst?.KnownUserCopies.FirstOrDefault();

        result.Should().NotBeNull("because we just added a known account");         */
    }
}
