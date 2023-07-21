namespace DojoSurveysCore.Entities;
public class DojoSurveysGetAllSpec : Specification<DojoSurvey>
{
    public DojoSurveysGetAllSpec()
    {
        Query
            .Include(rs => rs.DojoSurveyQuestions)
            .ThenInclude(rs => rs.DojoSurveyQuestionAnswers)
            .OrderBy(rs => rs.Title);
    }
}
