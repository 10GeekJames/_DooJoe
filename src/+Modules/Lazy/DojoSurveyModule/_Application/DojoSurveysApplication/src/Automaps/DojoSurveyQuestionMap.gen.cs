// ag=yes
namespace DojoSurveysApplication.Automaps; 
public partial class DojoSurveyQuestionMap : Profile
{ 
    public override string ProfileName => "DojoSurveyQuestionMap";
    
    public DojoSurveyQuestionMap()
    {
        CreateMap<DojoSurveyQuestion, DojoSurveyQuestionViewModel>()
        .ReverseMap();
    }
}