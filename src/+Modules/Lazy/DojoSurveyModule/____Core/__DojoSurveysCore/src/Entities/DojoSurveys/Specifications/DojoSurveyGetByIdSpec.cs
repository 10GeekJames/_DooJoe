namespace DojoSurveysCore.Entities;
public class DojoSurveyGetByIdSpec : Specification<DojoSurvey>, ISingleResultSpecification
{
    public DojoSurveyGetByIdSpec(Guid id)
    {
        Query
            .Include(rs => rs.DojoSurveyQuestions)
            .ThenInclude(rs => rs.DojoSurveyQuestionAnswers)
            .Where(rs => rs.Id.Equals(id))
            .OrderBy(rs => rs.Title);
    }
}
