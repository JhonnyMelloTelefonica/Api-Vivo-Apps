
using Microsoft.AspNetCore.SignalR;
using Api_Vivo_Apps.Data;

namespace Vivo_Apps_API.Hubs
{
    public class VivoXHub : Hub
    {
        protected int _connectionCount = 0;
        public async Task Upadate_ACESSOS_MOBILE(ACESSOS_MOBILE aCESSOS)
        {
            await Clients.All.SendAsync("UPDATE_ACESSOS", aCESSOS);
        }

        public Task BroadcastMessage(string name, string message) =>
    Clients.All.SendAsync("broadcastMessage", name, message);

        public Task Echo(string name, string message) =>
            Clients.Client(Context.ConnectionId)
                   .SendAsync("echo", name, $"{message} (echo from server)");


        public override Task OnConnectedAsync()
        {
            this._connectionCount++;
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            this._connectionCount--;
            return base.OnDisconnectedAsync(exception);
        }
    }
}
