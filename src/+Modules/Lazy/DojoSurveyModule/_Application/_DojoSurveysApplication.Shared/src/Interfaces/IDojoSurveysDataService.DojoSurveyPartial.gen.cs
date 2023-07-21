// ag=yes
namespace DojoSurveysApplication.Shared.Interfaces; 
public partial interface IDojoSurveysDataService
{
    Task<DojoSurveyViewModel?> DojoSurveyCreateNewAsync(DojoSurveyCreateNewRequest request);
    Task<DojoSurveyViewModel?> DojoSurveyGetByIdAsync(DojoSurveyGetByIdRequest request);

}