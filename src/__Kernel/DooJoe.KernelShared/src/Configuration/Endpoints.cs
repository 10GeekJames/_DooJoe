namespace DooJoe.KernelShared.Configuration;
public class Endpoints
{
    public string IdentityEndpointUrl { get; set; } = "";
    public string IdentityValidIssuer { get; set; } = "";

    public string PubsubEndpointUrl { get; set; } = "";

    public string AccountAdminApiUrl { get; set; } = "";
    public string AccountAdminApiVersion { get; set; } = "";
    public string AccountAdminApiName { get; set; } = "dojoSurveys_admin_api";
    
    public string DojoSurveysApiUrl { get; set; } = "";
    public string DojoSurveysApiVersion { get; set; } = "";
    public string DojoSurveysApiName { get; set; } = "dojoSurveys_api";
    
    public string DojoSurveysAdminApiUrl { get; set; } = "";
    public string DojoSurveysAdminApiVersion { get; set; } = "";
    public string DojoSurveysAdminApiName { get; set; } = "dojoSurveys_admin_api";

    
}
