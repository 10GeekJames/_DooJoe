// ag=yes
namespace DojoSurveysApplication.Shared.ViewModels; 
public partial class DojoSurveyViewModel : BaseViewModel<Guid>
{ 

     public string Title { get; set; } = String.Empty;
     public string? Description { get; set; } = null;
     public List<DojoSurveyQuestionViewModel> DojoSurveyQuestions { get; set; } = new();

} 
        