// ag=yes
namespace DojoSurveysApplication.Shared.ViewModels; 
public partial class DojoCompletedSurveyQuestionAnswerViewModel : BaseViewModel<Guid>
{ 

     public DojoSurveyQuestionViewModel DojoSurveyQuestion { get; set; }
     public DojoSurveyQuestionAnswerViewModel DojoSurveyQuestionAnswer { get; set; }
     public string Content { get; set; } = String.Empty;
     public int Value { get; set; }

} 
        