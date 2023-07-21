namespace DojoSurveysApplication.Data.Interfaces;

public interface IDojoSurveysSeedScript
{
    Task PopulateDojoSurveysTestData(IServiceProvider serviceProvider);
}