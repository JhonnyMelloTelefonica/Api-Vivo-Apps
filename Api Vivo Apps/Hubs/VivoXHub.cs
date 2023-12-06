using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Shared_Class_Vivo_Apps.Data;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using Shared_Class_Vivo_Apps.Enums;
using Shared_Class_Vivo_Apps.Model_DTO;
using System.Linq;
using Vivo_Apps_API.Controllers;

namespace Vivo_Apps_API.Hubs
{
    public class VivoXHub : Hub
    {
        public VivoXHub()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_CHAT_DTO>()
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => ((Cargos)int.Parse(src.CARGO)))
                ).ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => ((Canal)int.Parse(src.CARGO)))
                );
            });

            _mapper = config.CreateMapper();

        }
        private readonly IMapper _mapper;

        public Vivo_MAISContext CD;
        public static int _connectionCount = 0;
        public static IDictionary<string, ACESSOS_MOBILE_CHAT_DTO> Users = new Dictionary<string, ACESSOS_MOBILE_CHAT_DTO>();

        public void MessageToUserChat(string mat_remetente, string mat_destinatario, string message)
        {
            foreach (var UserConnected in Users.Where(x => x.Value.MATRICULA == mat_destinatario))
            {
                Clients.Client(UserConnected.Key).SendAsync("MessageToUserChat",
                    mat_remetente, mat_destinatario, message);
            }
        }

        public void NewNotification(string senderName, string title, string message, string link)
        {
            var id = Context?.GetHttpContext()?.GetRouteValue("PDV") as string;
            Clients.Group(id).SendAsync("NewNotification", senderName, title, message, link);
        }

        public void UsersOnlineCount()
        {
            Clients.All.SendAsync("UsersOnlineCount", Users.Count.ToString());
            Clients.All.SendAsync("UsersConnected", Users);
        }

        //public void SendNewBoletaToPdv(BOLETA_PALITAGEM_DTO newboleta)
        //{
        //    var id = Context?.GetHttpContext()?.GetRouteValue("PDV") as string;
        //    Clients.Group(id).SendAsync("SendNewBoletaToPdv", newboleta);
        //}
        //public void UpdateStatusBoleta(BOLETA_PALITAGEM_DTO newboleta)
        //{
        //    var id = Context?.GetHttpContext()?.GetRouteValue("PDV") as string;
        //    Clients.Group(id).SendAsync("UpdateStatusBoleta", newboleta);
        //}

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
        }

        public void SendUserInfo(string jsonuserinfo)
        {
            if (!string.IsNullOrEmpty(jsonuserinfo))
            {
                Users.Add(Context.ConnectionId, JsonConvert.DeserializeObject<ACESSOS_MOBILE_CHAT_DTO>(jsonuserinfo));
            }
            UsersOnlineCount();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            _connectionCount--;
            Users.Remove(Context.ConnectionId);
            UsersOnlineCount();
        }
    }
}
