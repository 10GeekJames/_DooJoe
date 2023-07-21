namespace DojoSurveysApplication.Shared.Requests;

public class DojoSurveyGetByIdRequest : IRoutable
{
    protected readonly static string Route = "dojosurvey/getbyid?id={Guid:Id}";
    public Guid Id { get; set; }
    public DojoSurveyGetByIdRequest() {}
    public DojoSurveyGetByIdRequest(Guid id)
    {
        Id = id;
    }
    public string BuildRouteFrom() => DojoSurveyGetByIdRequest.BuildRoute(Id);
    public static string BuildRoute(Guid id) => Route.Replace("{Guid:Id}", id.ToString());
}
