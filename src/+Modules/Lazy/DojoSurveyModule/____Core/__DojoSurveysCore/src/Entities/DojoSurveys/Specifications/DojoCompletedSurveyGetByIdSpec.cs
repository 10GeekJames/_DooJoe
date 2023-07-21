namespace DojoSurveysCore.Entities;
public class DojoCompletedSurveyGetByIdSpec : Specification<DojoCompletedSurvey>, ISingleResultSpecification
{
    public DojoCompletedSurveyGetByIdSpec(Guid id)
    {
        Query
            .Include(rs => rs.DojoCompletedSurveyQuestionAnswers)
            .Where(rs => rs.Id.Equals(id))
            .OrderBy(rs => rs.Id);
    }
}
