// ag=yes
namespace DojoSurveysApplication.Automaps; 
public partial class DojoCompletedSurveyQuestionAnswerMap : Profile
{ 
    public override string ProfileName => "DojoCompletedSurveyQuestionAnswerMap";
    
    public DojoCompletedSurveyQuestionAnswerMap()
    {
        CreateMap<DojoCompletedSurveyQuestionAnswer, DojoCompletedSurveyQuestionAnswerViewModel>()
        .ReverseMap();
    }
}