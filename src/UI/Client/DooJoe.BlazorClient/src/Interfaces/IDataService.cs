namespace DooJoe.BlazorClient.Interfaces
{
    public interface IDataService : IDisposable
    {
        public event Action OnChange;
        Task<KnownUserViewModel> KnownUserGet();        
    }
}