// ag=yes
namespace DojoSurveysApplication.Shared.ViewModels; 
public partial class DojoCompletedSurveyViewModel : BaseViewModel<Guid>
{ 

     public string UserName { get; set; } = String.Empty;
     public Guid UserId { get; set; }
     public DateTime StartedOn { get; set; }
     public DateTime? CompletedOn { get; set; } = null;
     public List<DojoCompletedSurveyQuestionAnswerViewModel> DojoCompletedSurveyQuestionAnswers { get; set; } = new();

} 
        