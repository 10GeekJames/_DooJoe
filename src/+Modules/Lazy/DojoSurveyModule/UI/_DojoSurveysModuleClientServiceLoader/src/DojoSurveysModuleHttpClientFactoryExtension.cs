namespace DojoSurveysModuleClientServiceLoader
{
    public static class DojoSurveysHttpClientFactoryExtension
    {
        public static void AddDojoSurveysHttpDataService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDojoSurveysDataService, DojoSurveysHttpDataService>();
            serviceCollection.AddSingleton<IDojoSurveysDataServiceNotAuthed, DojoSurveysHttpDataService>();
        }
    }
}