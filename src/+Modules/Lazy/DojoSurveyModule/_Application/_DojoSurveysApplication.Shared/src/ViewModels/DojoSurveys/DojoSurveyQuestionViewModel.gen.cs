// ag=yes
namespace DojoSurveysApplication.Shared.ViewModels; 
public partial class DojoSurveyQuestionViewModel : BaseViewModel<Guid>
{ 

     public string Title { get; set; } = String.Empty;
     public string? Description { get; set; } = null;
     
     public string? Section {get; set; } = "General";
     public DojoSurveyQuestionTypesEnum DojoQuestionType { get; set; }
     public int AllowedAnswerCount { get; set; }
     public List<DojoSurveyQuestionAnswerViewModel> DojoSurveyQuestionAnswers { get; set; } = new();

} 