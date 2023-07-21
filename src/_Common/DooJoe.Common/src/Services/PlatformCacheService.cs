using AccountModuleCore.Entities;

namespace DooJoe.Common.Services;
public class PlatformCacheService
{
    private IAccountModuleDataService _accountModuleHttpClient;
    public PlatformCacheService(IAccountModuleDataService accountModuleDataService)
    {
        _accountModuleHttpClient = accountModuleDataService;
    }
    public KnownUserViewModel KnownUser { get; set; } = null;
    public bool HasInitRun { get; set; } = false;
    public bool IsOwner { get; private set; } = false;
    public bool IsCoHost { get; private set; } = false;

    private bool _userDataIsReady = false;
    private bool _appDataIsReady = false;

    private string _currentModule = "";
    private string _currentSubModule = "";

    public event Action OnChange;
    public event Action OnRoomChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
    private void NotifyOnRoomChange() => OnRoomChange?.Invoke();

    public bool UserDataIsReady
    {
        get => _userDataIsReady;
    }
    public bool AppDataIsReady
    {
        get => _appDataIsReady;
    }
    public void ResetMenuData()
    {
    }

    public async Task InitAppDataAsync(bool isAuthenticated)
    {
        if (isAuthenticated)
        {
            KnownUser = await _accountModuleHttpClient.KnownUserGetAsync(new());
            Console.WriteLine($"InitAppDataAsync user from api state > {KnownUser?.UserId}");
            if (KnownUser != null)
            {
                SetUserDataToReady();
                await Task.Delay(50);
            }
        }
        else if (!isAuthenticated)
        {
            throw new Exception("Must be authenticated");
        }
        SetAppDataToReady();
        await Task.Yield();
    }

    public bool AllIsInit
    {
        get => _appDataIsReady && _userDataIsReady;
    }
    private void SetUserDataToReady(bool value = true)
    {
        _userDataIsReady = value;
        NotifyStateChanged();
    }
    public void SetAppDataToReady(bool value = true)
    {
        _appDataIsReady = value;
        NotifyStateChanged();
    }

    public string CurrentModule => _currentModule;
    public string CurrentSubModule => _currentSubModule;

    public void SetCurrentModule(string module)
    {
        this._currentModule = module;
    }
    public void SetCurrentSubModule(string subModule)
    {
        this._currentSubModule = subModule;
    }
}
