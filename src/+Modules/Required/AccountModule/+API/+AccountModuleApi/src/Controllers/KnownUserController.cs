// ag=no
namespace AccountModuleApi;
public class KnownUserController : BaseController
{
    public KnownUserController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }

    [HttpGet, Authorize]
    public async Task<IActionResult> Get()
    {
        var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
        Guid? userId = new Guid(claimsIdentity?.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        KnownUser? knownUser = null;

        var referrer = "";
        referrer = Request?.GetTypedHeaders()?.Referer?.Host.ToString();
        //Console.WriteLine($"Current Host == {referrer}");

        if (userId.HasValue)
        {
            var knownUserGetByUserIdQry = new KnownUserGetByUserIdQry(userId.Value);
            knownUser = await _mediator.Send(knownUserGetByUserIdQry);
            if (knownUser == null)
            {
                var newUserCmd = new KnownUserCreateByUserIdCmd(userId.Value);
                knownUser = await _mediator.Send(newUserCmd);
            }
        }
        
        return Ok(_mapper.Map<KnownUserViewModel>(knownUser));
    }    
}

