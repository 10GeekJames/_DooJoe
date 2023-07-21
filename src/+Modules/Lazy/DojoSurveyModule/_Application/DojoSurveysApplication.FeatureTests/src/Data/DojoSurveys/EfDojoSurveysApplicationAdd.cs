namespace DojoSurveysApplication.FeatureTests.Data.DojoSurveys;
public class EfDojoSurveyApplicationAdd : BaseApplicationTestFixture
{
    [Fact]
    public async Task AddDojoSurvey()
    {

        var result = await _dataService.DojoSurveysGetAllAsync(new DojoSurveysGetAllQry());
        result!.Count.Should().Be(0, "because we haven't added any dojoSurveys yet");

        var cmd = new DojoSurveyAddCmd(DojoSurveyTestData.DojoSurveyAlfradoTheGreat);
        await _dataService.DojoSurveyAddAsync(cmd);

        var qry = new DojoSurveysGetAllQry();
        result = (await _dataService.DojoSurveysGetAllAsync(qry));
        var resultFirst = result!.FirstOrDefault();
        var resultFirstCopy = resultFirst?.DojoSurveyCopies.FirstOrDefault();

        result.Should().NotBeNull("because we just added a dojoSurvey");
        resultFirst!.DojoSurveyCopies.Count.Should().Be(1, "because we added a single dojoSurvey");
        // test more cool stuff
    }
}
