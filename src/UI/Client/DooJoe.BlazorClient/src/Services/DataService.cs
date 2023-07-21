

namespace DooJoe.BlazorClient.Services
{
    public class DataService : IDataService, IDisposable
    {
        private KnownUserViewModel? _knownUser = null;
        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
        private readonly HttpClient _httpClient;

        public DataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<KnownUserViewModel> KnownUserGet()
        {
            var response = await _httpClient.GetAsync(KnownUserGetRequest.BuildRoute());

            response.EnsureSuccessStatusCode();
            
            _knownUser = await response.Content.ReadFromJsonAsync<KnownUserViewModel?>();

            if (_knownUser == null)
            {
                throw new Exception("InvalidReferralAccountException");
            }
            NotifyStateChanged();
            return _knownUser;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}