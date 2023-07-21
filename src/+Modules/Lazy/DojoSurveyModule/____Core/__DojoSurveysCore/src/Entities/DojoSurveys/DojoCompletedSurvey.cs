using System;
namespace DojoSurveysCore.Entities;

public class DojoCompletedSurvey : DojoCompletedSurveyKeyVO<Guid>
{
    public string UserName { get; private set; }
    public Guid UserId { get; private set; }
    public DateTime StartedOn { get; private set; }
    public DateTime? CompletedOn { get; private set; }


    private List<DojoCompletedSurveyQuestionAnswer> _dojoCompletedSurveyQuestionAnswers = new();
    public IEnumerable<DojoCompletedSurveyQuestionAnswer> DojoCompletedSurveyQuestionAnswers => _dojoCompletedSurveyQuestionAnswers.AsReadOnly();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private DojoCompletedSurvey() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public DojoCompletedSurvey(string userName, DateTime? startedOn, DateTime? endedOn = null)
    {
        UserName = userName;
        StartedOn = startedOn ?? DateTime.UtcNow;
        CompletedOn = endedOn;
    }
    public void CompleteSurvey()
    {
        CompletedOn = DateTime.UtcNow;
    }

    public void AddDojoCompletedSurveyQuestion(DojoCompletedSurveyQuestionAnswer dojoCompletedSurveyQuestionAnswer)
    {
        if (!_dojoCompletedSurveyQuestionAnswers.Any(rs => rs.DojoSurveyQuestion.Id.Equals(dojoCompletedSurveyQuestionAnswer.Id)))
            _dojoCompletedSurveyQuestionAnswers.Add(dojoCompletedSurveyQuestionAnswer);
    }
}
