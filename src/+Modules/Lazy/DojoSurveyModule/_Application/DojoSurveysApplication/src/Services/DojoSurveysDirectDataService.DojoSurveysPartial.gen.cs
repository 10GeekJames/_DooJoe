// ag=yes
namespace DojoSurveysApplication.Services; 
public partial class DojoSurveysDirectDataService
{
    public async Task<List<DojoSurveyViewModel>?> DojoSurveysGetAllAsync(DojoSurveysGetAllRequest request)
    {
        var qry = _mapper.Map<DojoSurveysGetAllQry>(request);
        return _mapper.Map<List<DojoSurveyViewModel>?>(await _mediator.Send(qry));
    }

}
