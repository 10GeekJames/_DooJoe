
namespace DojoSurveysCore.UnitTests;

public class DojoCompletedSurveyConstructorTests
{
    [Fact]
    public void BasicDojoCompletedSurvey()
    {
        // Given I have dojoSurvey start data
        var title = "Awesome shared are you here survey!";
        var description = "";
        var question1 = new DojoSurveyQuestion("Are you here?", "", DojoQuestionTypes.MultiChoice, 1, new List<DojoSurveyQuestionAnswer> { new("yes"), new("no"), new("unsure") });

        // And I am a user
        var userName = "Barry";
        var startedOn = DateTime.UtcNow;

        // When I create a dojoSurvey
        var dojoSurvey = new DojoSurvey(title, description, new List<DojoSurveyQuestion> { question1 });

        // And a I complete the dojoSurvey
        var dojoCompletedSurvey = new DojoCompletedSurvey(userName, startedOn, null);

        // Then I should have a dojoSurvey
        dojoCompletedSurvey.Should().NotBeNull();

        // And the dojoCompletedSurvey should have the start data
        dojoCompletedSurvey.UserName.Should().Be(userName);
        dojoCompletedSurvey.StartedOn.Should().Be(startedOn);
    }

    [Fact]
    public void BasicDojoCompletedSurveyCanAnswerQuestions()
    {
        // Given I have dojoSurvey start data
        var title = DojoSurveyTestData.MyFirstSurveyTitle;
        var description = DojoSurveyTestData.MyFirstSurveyDescription;
        var question1 = DojoSurveyQuestionTestData.AreYouHereQuestion;
        var userName = "Barry";
        var startedOn = DateTime.UtcNow;
        var dojoSurvey = new DojoSurvey(title, description, new List<DojoSurveyQuestion> { question1 });

        // and have begun a completedSurvey
        var dojoCompletedSurvey = new DojoCompletedSurvey(userName, startedOn, null);

        // When I answer a question
        dojoCompletedSurvey.DojoCompletedSurveyQuestionAnswers.Count().Should().Be(0);
        dojoCompletedSurvey.AddDojoCompletedSurveyQuestion(new DojoCompletedSurveyQuestionAnswer(question1, question1.DojoSurveyQuestionAnswers.First(), question1.DojoSurveyQuestionAnswers.First().Content));

        // Then the dojoCompletedSurvey should have the answer
        dojoCompletedSurvey.UserName.Should().Be(userName);
        dojoCompletedSurvey.StartedOn.Should().Be(startedOn);

        dojoCompletedSurvey.DojoCompletedSurveyQuestionAnswers.Count().Should().BeGreaterThan(0);
        dojoCompletedSurvey.DojoCompletedSurveyQuestionAnswers.Any(rs => rs.DojoSurveyQuestion.Id == question1.Id).Should().BeTrue();

        // And the completed date should not be set
        dojoCompletedSurvey.CompletedOn.Should().BeNull();
    }
}