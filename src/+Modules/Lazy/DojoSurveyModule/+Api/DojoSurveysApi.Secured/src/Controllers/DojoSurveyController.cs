namespace DojoSurveysApi.Secured.Controllers;

public class DojoSurveyController : BaseController
{
    public DojoSurveyController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var qry = new DojoSurveyGetAllQry();
        var result = await _mediator.Send(qry);
        var response = _mapper.Map<IEnumerable<DojoSurveyViewModel>>(result);
        return Ok(response);
    }
}
