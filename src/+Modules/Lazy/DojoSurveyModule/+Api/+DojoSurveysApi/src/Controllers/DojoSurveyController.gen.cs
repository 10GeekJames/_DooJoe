// ag=yes
using DojoSurveysApplication.Shared.Requests;
using DojoSurveysCore.Entities;

namespace DojoSurveysApi.Controllers; 
public partial class DojoSurveyController : BaseController
{
    public DojoSurveyController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }
    [HttpPost]
    public async Task<IActionResult> CreateNew(DojoSurveyCreateNewRequest request)
    {
        var dojoSurvey = _mapper.Map<DojoSurvey>(request.DojoSurvey);
        var cmd = new DojoSurveyCreateNewCmd(dojoSurvey);
        var result = await _mediator.Send(cmd);
        var response = _mapper.Map<DojoSurveyViewModel>(result);
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> GetById(DojoSurveyGetByIdQry qry)
    {
        var result = await _mediator.Send(qry);
        var response = _mapper.Map<DojoSurveyViewModel>(result);
        return Ok(response);
    }

}
