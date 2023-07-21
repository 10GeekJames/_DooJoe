namespace DojoSurveysCore.DojoSurveysTestData.Entities;
public static class DojoSurveyTestData
{
    public static DojoSurvey MyFirstSurvey;
    public static string MyFirstSurveyTitle = "Awesome shared are you here survey!";
    public static string MyFirstSurveyDescription = "";
    public static Guid MyFirstSurveyId = new Guid("1bd736d2-da2d-48c0-b19f-a0ec98396d49");

    public static IEnumerable<DojoSurvey> AllDojoSurveys;

    static DojoSurveyTestData()
    {
        MyFirstSurvey = new DojoSurvey(MyFirstSurveyId, MyFirstSurveyTitle, MyFirstSurveyDescription, new List<DojoSurveyQuestion> { DojoSurveyQuestionTestData.AreYouHereQuestion });

        AllDojoSurveys = new List<DojoSurvey> {
           MyFirstSurvey
        };
    }
}
