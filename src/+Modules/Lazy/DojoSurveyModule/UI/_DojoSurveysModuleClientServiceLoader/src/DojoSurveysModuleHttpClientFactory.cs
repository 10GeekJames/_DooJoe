namespace DojoSurveysModuleClientServiceLoader
{
    public class DojoSurveysHttpClientFactory
    {
        private readonly IServiceProvider _services;

        public DojoSurveysHttpClientFactory(IServiceProvider services)
        {
            this._services = services;
        }

        public IDojoSurveysDataService Create()
        {
            return new DojoSurveysHttpDataService(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("DojoSurveysHttpClient"));
        }
        public IDojoSurveysDataServiceNotAuthed CreateNotAuthed()
        {
            return new DojoSurveysHttpDataService(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("DojoSurveysNotAuthedHttpClient"));
        }
    }
}