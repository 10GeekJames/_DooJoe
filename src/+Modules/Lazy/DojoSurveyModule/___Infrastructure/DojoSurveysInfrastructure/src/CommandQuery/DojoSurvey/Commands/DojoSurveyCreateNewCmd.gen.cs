// ag=yes
namespace DojoSurveysInfrastructure.CommandQuery;
public partial class DojoSurveyCreateNewCmd : IRequest<DojoSurvey>
{
    public DojoSurvey DojoSurvey { get; set; }
    public DojoSurveyCreateNewCmd() { }
    public DojoSurveyCreateNewCmd(DojoSurvey dojoSurvey)
    {
        DojoSurvey = dojoSurvey;
    }
}
