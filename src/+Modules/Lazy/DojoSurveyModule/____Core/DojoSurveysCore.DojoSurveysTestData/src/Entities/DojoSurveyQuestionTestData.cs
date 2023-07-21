namespace DojoSurveysCore.DojoSurveysTestData.Entities;
public static class DojoSurveyQuestionTestData
{
    public static DojoSurveyQuestion AreYouHereQuestion;       
    public static Guid AreYouHereQuestionId = new Guid("1bd736d2-da2d-48c0-b19f-a0ec98396d49");



    public static IEnumerable<DojoSurveyQuestion> AllDojoSurveyQuestions;

    static DojoSurveyQuestionTestData()
    {
        AreYouHereQuestion = new DojoSurveyQuestion("Are you here?", "", DojoQuestionTypes.MultiChoice, 1, "", new List<DojoSurveyQuestionAnswer> { new("yes"), new("no"), new("unsure") });

        AllDojoSurveyQuestions = new List<DojoSurveyQuestion> {
           AreYouHereQuestion
        };
    }
}
