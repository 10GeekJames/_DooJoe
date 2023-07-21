namespace DooJoe.Service.SignalR.Hubs;
public class DooJoeHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
