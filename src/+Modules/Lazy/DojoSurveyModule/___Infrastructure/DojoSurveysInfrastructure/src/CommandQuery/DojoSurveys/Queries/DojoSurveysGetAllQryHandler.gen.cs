// ag=yes
namespace DojoSurveysInfrastructure.CommandQuery; 
public partial class DojoSurveysGetAllQryHandler : IRequestHandler<DojoSurveysGetAllQry, List<DojoSurvey>>
{
    private IRepository<DojoSurvey> _repository;
    public DojoSurveysGetAllQryHandler(IRepository<DojoSurvey> repository) 
    {
        _repository = repository;
    }

    public async Task<List<DojoSurvey>> Handle(DojoSurveysGetAllQry qry, CancellationToken cancellationToken)
    {
        var spec = new DojoSurveysGetAllSpec();
        return await _repository.ListAsync(spec, cancellationToken);
    }
}