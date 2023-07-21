namespace DojoSurveysCore.Entities;

public class DojoSurveyQuestion : DojoSurveyQuestionKeyVO<Guid>
{
    public string Title { get; private set; }
    public string? Description { get; private set; }
    public string? Section { get; private set; } = "General";
    public DojoQuestionTypes DojoQuestionType { get; private set; }
    public int AllowedAnswerCount { get; private set; }

    private List<DojoSurveyQuestionAnswer> _dojoSurveyQuestionAnswers = new();
    public IEnumerable<DojoSurveyQuestionAnswer> DojoSurveyQuestionAnswers => _dojoSurveyQuestionAnswers.AsReadOnly();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private DojoSurveyQuestion() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public DojoSurveyQuestion(Guid id, string title, string description, DojoQuestionTypes dojoQuestionType, int allowedAnswerCount, string section = "", IEnumerable<DojoSurveyQuestionAnswer>? dojoSurveyQuestionAnswers = null) : this(title, description, dojoQuestionType, allowedAnswerCount, section, dojoSurveyQuestionAnswers)
    {
        Id = id;
    }
    public DojoSurveyQuestion(string title, string description, DojoQuestionTypes dojoQuestionType, int allowedAnswerCount, string section = "", IEnumerable<DojoSurveyQuestionAnswer>? dojoSurveyQuestionAnswers = null)
    {
        Title = title;
        Description = Description;
        DojoQuestionType = dojoQuestionType;
        AllowedAnswerCount = allowedAnswerCount;
        if (section != "")
        {
            Section = section;
        }

        if (dojoSurveyQuestionAnswers != null)
        {
            _dojoSurveyQuestionAnswers.AddRange(dojoSurveyQuestionAnswers);
        }
    }

    public void AddDojoSurveyQuestionAnswer(DojoSurveyQuestionAnswer dojoSurveyQuestionAnswer)
    {
        if (_dojoSurveyQuestionAnswers.Any(rs => rs.Content == dojoSurveyQuestionAnswer.Content))
            _dojoSurveyQuestionAnswers.Add(dojoSurveyQuestionAnswer);
    }
}
