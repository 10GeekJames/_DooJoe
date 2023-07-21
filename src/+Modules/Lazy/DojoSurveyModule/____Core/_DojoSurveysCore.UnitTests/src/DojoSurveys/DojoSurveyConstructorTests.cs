namespace DojoSurveysCore.UnitTests;

public class DojoSurveyConstructorTests
{
    [Fact]
    public void BasicDojoSurveyWithValidValues()
    {
        // Given I have dojoSurvey start data
        var title = DojoSurveyTestData.MyFirstSurveyTitle;
        var description = DojoSurveyTestData.MyFirstSurveyDescription;
        var question1 = DojoSurveyQuestionTestData.AreYouHereQuestion;

        // When I create a dojoSurvey
        var dojoSurvey = new DojoSurvey(title, description, new List<DojoSurveyQuestion> { question1 });

        // Then I should have a dojoSurvey
        dojoSurvey.Should().NotBeNull();

        // And the dojoSurvey should have the start data
        dojoSurvey.Title.Should().Be(title);
        dojoSurvey.Description.Should().Be(description);

        // And the dojoSurvey should have a valid grid        
        dojoSurvey.DojoSurveyQuestions.Count().Should().BeGreaterThan(0);
    }
}