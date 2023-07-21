// ag=yes
namespace DojoSurveysApplication.Services; 
public partial class DojoSurveysDirectDataService
{
    public async Task<DojoSurveyViewModel?> DojoSurveyCreateNewAsync(DojoSurveyCreateNewRequest request)
    {
        var cmd = _mapper.Map<DojoSurveyCreateNewCmd>(request);
        return _mapper.Map<DojoSurveyViewModel?>(await _mediator.Send(cmd));
    }
    public async Task<DojoSurveyViewModel?> DojoSurveyGetByIdAsync(DojoSurveyGetByIdRequest request)
    {
        var qry = _mapper.Map<DojoSurveyGetByIdQry>(request);
        return _mapper.Map<DojoSurveyViewModel?>(await _mediator.Send(qry));
    }

}
