// ag=yes
namespace DojoSurveysInfrastructure.CommandQuery; 
public class DojoSurveyCreateNewCmdHandler : IRequestHandler<DojoSurveyCreateNewCmd, DojoSurvey>
{
    private IRepository<DojoSurvey> _repository;
    public DojoSurveyCreateNewCmdHandler(IRepository<DojoSurvey> repository) 
    {
        _repository = repository;
    }

    public async Task<DojoSurvey> Handle(DojoSurveyCreateNewCmd cmd, CancellationToken cancellationToken)
    {
        await _repository.AddAsync(cmd.DojoSurvey);
        return cmd.DojoSurvey;
    }
}