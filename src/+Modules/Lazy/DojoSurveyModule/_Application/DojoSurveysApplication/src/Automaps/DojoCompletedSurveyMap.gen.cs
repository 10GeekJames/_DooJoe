// ag=yes
namespace DojoSurveysApplication.Automaps; 
public partial class DojoCompletedSurveyMap : Profile
{ 
    public override string ProfileName => "DojoCompletedSurveyMap";
    
    public DojoCompletedSurveyMap()
    {
        CreateMap<DojoCompletedSurvey, DojoCompletedSurveyViewModel>()
        .ReverseMap();
    }
}