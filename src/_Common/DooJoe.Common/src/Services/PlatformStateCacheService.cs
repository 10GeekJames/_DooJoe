namespace DooJoe.Common.Services
{
    public class PlatformStateCacheService
    {
        private string? _appCulture;
        private bool _isDarkMode = true;

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

        private DojoCommonClientCachingJsInterop _dojoCommonClientCachingJsInterop;

        public string AppCulture
        {
            get => _appCulture ?? "";
            set
            {
                _appCulture = value;
                _dojoCommonClientCachingJsInterop.SetAppCulture(value);
                NotifyStateChanged();
            }
        }
        public bool IsDarkMode
        {
            get { return _isDarkMode; }
            set
            {
                if (_isDarkMode != value)
                {
                    Console.WriteLine($"Dark mode has changed {value}");
                    _isDarkMode = value;
                    _dojoCommonClientCachingJsInterop.SetDarkMode(value);

                    NotifyStateChanged();
                }
            }
        }

        public PlatformStateCacheService(DojoCommonClientCachingJsInterop dojoCommonClientCachingJsInterop)
        {
            _dojoCommonClientCachingJsInterop = dojoCommonClientCachingJsInterop;

            Task.Run(async () => await InitStateFromCache());
        }

        private async Task InitStateFromCache()
        {
            _appCulture = await _dojoCommonClientCachingJsInterop.GetAppCulture("en-US");
            _isDarkMode = await _dojoCommonClientCachingJsInterop.GetDarkMode();
        }
    }
}