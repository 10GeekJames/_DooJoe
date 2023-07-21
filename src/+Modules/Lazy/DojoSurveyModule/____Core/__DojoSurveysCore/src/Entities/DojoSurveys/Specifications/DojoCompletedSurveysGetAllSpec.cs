namespace DojoSurveysCore.Entities;
public class DojoCompletedSurveysGetAllSpec : Specification<DojoCompletedSurvey>
{
    public DojoCompletedSurveysGetAllSpec()
    {
        Query
            .Include(rs => rs.DojoCompletedSurveyQuestionAnswers)
            .OrderBy(rs => rs.Id);
    }
}
