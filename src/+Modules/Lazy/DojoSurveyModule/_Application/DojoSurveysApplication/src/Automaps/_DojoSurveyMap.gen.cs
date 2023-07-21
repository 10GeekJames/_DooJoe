// ag=yes
namespace DojoSurveysApplication.Automaps; 
public partial class DojoSurveyMap : Profile
{ 
    public override string ProfileName => "DojoSurveyMap";
    
    public DojoSurveyMap()
    {
        CreateMap<DojoSurvey, DojoSurveyViewModel>()
        .ReverseMap();
    }
}