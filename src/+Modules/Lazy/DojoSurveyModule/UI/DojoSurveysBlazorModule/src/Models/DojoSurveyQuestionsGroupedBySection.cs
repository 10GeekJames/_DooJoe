namespace DojoSurveysBlazorModule;
public class DojoSurveyQuestionsGroupedBySection
{
    public string Section { get; set; }
    public List<DojoSurveyQuestionViewModel> DojoSurveyQuestions { get; set; }

    public DojoSurveyQuestionsGroupedBySection(string section, List<DojoSurveyQuestionViewModel> dojoSurveyQuestions)
    {
        Section = section;
        DojoSurveyQuestions = dojoSurveyQuestions;
    }
}
