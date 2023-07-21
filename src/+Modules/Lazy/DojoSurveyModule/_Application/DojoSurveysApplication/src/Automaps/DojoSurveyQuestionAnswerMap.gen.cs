// ag=yes
namespace DojoSurveysApplication.Automaps; 
public partial class DojoSurveyQuestionAnswerMap : Profile
{ 
    public override string ProfileName => "DojoSurveyQuestionAnswerMap";
    
    public DojoSurveyQuestionAnswerMap()
    {
        CreateMap<DojoSurveyQuestionAnswer, DojoSurveyQuestionAnswerViewModel>()
        .ReverseMap();
    }
}