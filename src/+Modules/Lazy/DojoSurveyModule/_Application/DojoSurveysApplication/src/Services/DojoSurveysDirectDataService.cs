namespace DojoSurveysApplication.Services;
public partial class DojoSurveysDirectDataService : IDojoSurveysDataService
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public DojoSurveysDirectDataService(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
}