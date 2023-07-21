// ag=yes
namespace DojoSurveysInfrastructure.CommandQuery; 
public partial class DojoSurveyGetByIdQryHandler : IRequestHandler<DojoSurveyGetByIdQry, DojoSurvey>
{
    private IRepository<DojoSurvey> _repository;
    public DojoSurveyGetByIdQryHandler(IRepository<DojoSurvey> repository) 
    {
        _repository = repository;
    }

    public async Task<DojoSurvey> Handle(DojoSurveyGetByIdQry qry, CancellationToken cancellationToken)
    {
        var spec = new DojoSurveyGetByIdSpec(qry.Id);
        var rs = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
        return rs;
    }
}