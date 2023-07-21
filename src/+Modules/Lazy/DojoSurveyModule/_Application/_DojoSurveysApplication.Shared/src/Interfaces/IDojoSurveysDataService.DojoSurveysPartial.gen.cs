// ag=yes
namespace DojoSurveysApplication.Shared.Interfaces; 
public partial interface IDojoSurveysDataService
{
    Task<List<DojoSurveyViewModel>?> DojoSurveysGetAllAsync(DojoSurveysGetAllRequest request);

}