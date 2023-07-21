// ag=yes
namespace DojoSurveysApplication.Shared.ViewModels;
public partial class DojoSurveyQuestionAnswerViewModel : BaseViewModel<Guid>
{

    public string Content { get; set; } = String.Empty;
    public int Value { get; set; }
    public int SortOrder { get; set; }

}
