// ag=yes
namespace DojoSurveysApi.Controllers; 
public partial class DojoSurveysController : BaseController
{
    public DojoSurveysController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }
    [HttpPost]
    public async Task<IActionResult> GetAll(DojoSurveysGetAllQry qry)
    {
        var result = await _mediator.Send(qry);
        var response = _mapper.Map<List<DojoSurveyViewModel>>(result);
        return Ok(response);
    }

}
