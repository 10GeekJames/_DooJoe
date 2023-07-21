namespace DojoSurveysCore.Entities;

public class DojoCompletedSurveyQuestionAnswer : BaseEntityTracked<Guid>
{
    public DojoSurveyQuestion DojoSurveyQuestion { get; init; }
    public DojoSurveyQuestionAnswer DojoSurveyQuestionAnswer { get; init; }
    public string Content { get; init; }
    public int Value { get; init; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private DojoCompletedSurveyQuestionAnswer() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public DojoCompletedSurveyQuestionAnswer(Guid id, DojoSurveyQuestion dojoSurveyQuestion, DojoSurveyQuestionAnswer dojoSurveyQuestionAnswer, string content = "", int value = -1) : this(dojoSurveyQuestion, dojoSurveyQuestionAnswer, content, value)
    {
        Id = id;
    }
    public DojoCompletedSurveyQuestionAnswer(DojoSurveyQuestion dojoSurveyQuestion, DojoSurveyQuestionAnswer dojoSurveyQuestionAnswer, string content = "", int value = -1)
    {
        DojoSurveyQuestion = dojoSurveyQuestion;
        DojoSurveyQuestionAnswer = dojoSurveyQuestionAnswer;
        Content = content;
    }
}
