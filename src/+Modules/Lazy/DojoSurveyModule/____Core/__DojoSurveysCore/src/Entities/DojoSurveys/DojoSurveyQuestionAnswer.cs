namespace DojoSurveysCore.Entities;

public class DojoSurveyQuestionAnswer : DojoSurveyQuestionAnswerKeyVO<Guid>
{
    public string Content { get; init; }
    public int Value { get; init; }
    public int SortOrder { get; private set; } = 999;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private DojoSurveyQuestionAnswer() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public DojoSurveyQuestionAnswer(Guid id, string content) : this(content)
    {
        Id = id;
    }
    public DojoSurveyQuestionAnswer(string content)
    {
        Content = content;
    }
}
