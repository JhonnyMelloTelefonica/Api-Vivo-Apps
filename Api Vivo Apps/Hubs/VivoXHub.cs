
using Microsoft.AspNetCore.SignalR;
using Shared_Class_Vivo_Mais.Data;
using Shared_Class_Vivo_Mais.Model_DTO;

namespace Vivo_Apps_API.Hubs
{
    public class VivoXHub : Hub
    {
        public static int _connectionCount = 0;

        public Task BroadcastMessage(string name, string message) => Clients.All.SendAsync("broadcastMessage", name, message);

        public Task Echo(string name, string message) => Clients.Client(Context.ConnectionId).SendAsync("echo", name, $"{message} (echo from server)");

        public void NewNotification(string senderName,string title, string message, string link)
        {
            var id = Context?.GetHttpContext()?.GetRouteValue("PDV") as string;
            Clients.Group(id).SendAsync("NewNotification", senderName, title, message, link);
        }

        public void UsersOnlineCount()
        {
            Clients.All.SendAsync("UsersOnlineCount", _connectionCount.ToString());
        }
        public void SendNewBoletaToPdv(BOLETA_PALITAGEM_DTO newboleta)
        {
            var id = Context?.GetHttpContext()?.GetRouteValue("PDV") as string;
            Clients.Group(id).SendAsync("SendNewBoletaToPdv", newboleta);
        }
        public void UpdateStatusBoleta(BOLETA_PALITAGEM_DTO newboleta)
        {
            var id = Context?.GetHttpContext()?.GetRouteValue("PDV") as string;
            Clients.Group(id).SendAsync("UpdateStatusBoleta", newboleta);
        }

        public override async Task OnConnectedAsync()
        {
            var id = Context?.GetHttpContext()?.GetRouteValue("PDV") as string;
            var idBoleta = Context?.GetHttpContext()?.GetRouteValue("idBoleta") as string;
            if (idBoleta is not null)
            {
                await Groups.AddToGroupAsync(Context?.ConnectionId, $"{id}/{idBoleta}");
            }
            else
            {
                await Groups.AddToGroupAsync(Context?.ConnectionId, $"{id}");
            }
            _connectionCount++;
            UsersOnlineCount();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            _connectionCount--;
            UsersOnlineCount();
        }
    }
}
