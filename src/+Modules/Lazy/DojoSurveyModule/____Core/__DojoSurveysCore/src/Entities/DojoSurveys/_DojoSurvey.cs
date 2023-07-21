namespace DojoSurveysCore.Entities;

public class DojoSurvey : DojoSurveyKeyVO<Guid>, IAggregateRoot
{
    public string Title { get; private set; }
    public string? Description { get; private set; }

    private List<DojoSurveyQuestion> _dojoSurveyQuestions = new();
    public IEnumerable<DojoSurveyQuestion> DojoSurveyQuestions => _dojoSurveyQuestions.AsReadOnly();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private DojoSurvey() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public DojoSurvey(Guid id, string title, string description, IEnumerable<DojoSurveyQuestion>? dojoSurveyQuestions = null) : this(title, description, dojoSurveyQuestions)
    {
        Id = id;
    }
    public DojoSurvey(string title, string description, IEnumerable<DojoSurveyQuestion>? dojoSurveyQuestions = null)
    {
        Title = title;
        Description = description;
        if (dojoSurveyQuestions != null)
        {
            _dojoSurveyQuestions.AddRange(dojoSurveyQuestions);
        }
    }

    public void AddDojoSurveyQuestion(DojoSurveyQuestion dojoSurveyQuestion)
    {
        if (_dojoSurveyQuestions.Any(rs => rs.Title == dojoSurveyQuestion.Title))
            _dojoSurveyQuestions.Add(dojoSurveyQuestion);
    }
}
