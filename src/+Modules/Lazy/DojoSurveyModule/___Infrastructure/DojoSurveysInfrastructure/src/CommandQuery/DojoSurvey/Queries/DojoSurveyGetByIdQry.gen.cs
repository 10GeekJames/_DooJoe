// ag=yes
namespace DojoSurveysInfrastructure.CommandQuery; 
public partial class DojoSurveyGetByIdQry : IRequest<DojoSurvey>
{
    public Guid Id { get; set; }
    public DojoSurveyGetByIdQry() {}
    public DojoSurveyGetByIdQry(Guid id)
    {
        Id = id;
    }
}
