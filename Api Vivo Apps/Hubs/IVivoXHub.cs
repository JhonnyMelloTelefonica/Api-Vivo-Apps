using Shared_Class_Vivo_Mais.Model_DTO;

namespace Vivo_Apps_API.Hubs
{
    public interface IVivoXHub
    {
        Task BroadcastMessage(string name, string message);
        Task Echo(string name, string message);
        Task OnConnectedAsync();
        Task OnDisconnectedAsync(Exception exception);
        void SendNewBoletaToPdv(BOLETA_PALITAGEM_DTO newboleta);
        void UsersOnlineCount();
    }
}