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
                    opt => opt.MapFrom(src => ((Cargos)src.CARGO))
                ).ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => ((Canal)src.CARGO))
                );
            });

            _mapper = config.CreateMapper();

        }
        private readonly IMapper _mapper;

        public Vivo_MaisContext CD;
        public static int _connectionCount = 0;
        public static IDictionary<string, ACESSOS_MOBILE_CHAT_DTO> Users = new Dictionary<string, ACESSOS_MOBILE_CHAT_DTO>();
        public static List<ACESSOS_MOBILE_CHAT_DTO> AllUsersConnected = new List<ACESSOS_MOBILE_CHAT_DTO>();

        public void MessageToUserChat(int mat_remetente, int mat_destinatario, string message)
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
            Clients.All.SendAsync("UsersOnlineCount", AllUsersConnected.Where(x => x.Connected = true).Count().ToString());
            Clients.All.SendAsync("UsersConnected", Users, AllUsersConnected);
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
            var newuser = JsonConvert.DeserializeObject<ACESSOS_MOBILE_CHAT_DTO>(jsonuserinfo);

            if (!string.IsNullOrEmpty(jsonuserinfo))
            {
                if (AllUsersConnected.Any(x => x.MATRICULA == newuser.MATRICULA && x.Connected == false)) // Caso o usuário já tenha se conectado anteriormente
                {
                    AllUsersConnected.Where(x => x.MATRICULA == newuser.MATRICULA).First().Connected = true; //Apenas coloca como Conectado
                    Users.Add(Context.ConnectionId, newuser);
                }
                else if (AllUsersConnected.Any(x => x.MATRICULA == newuser.MATRICULA && x.Connected == true)) // Se o usuário existe mas já tem outra aba conectada
                {
                    Users.Add(Context.ConnectionId, newuser);
                }
                else if (!AllUsersConnected.Any(x => x.MATRICULA == newuser.MATRICULA)) // Se o usuário ainda não se conectou nenhuma vez a aplicação
                {
                    AllUsersConnected.Add(newuser); //Adiciona a lista de AllConnected
                    Users.Add(Context.ConnectionId, newuser);
                }
            }
            UsersOnlineCount();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            _connectionCount--;
            var matriculaoff = Users[Context.ConnectionId].MATRICULA;
            Users.Remove(Context.ConnectionId);

            if (AllUsersConnected.Any(x =>  Users.Where(y=>y.Value.MATRICULA == matriculaoff).Select(y=>y.Value.MATRICULA).Contains(x.MATRICULA))) // Verifica se após a remoção ainda existe alguma aba aberta para esse mesmo usuário, caso exista não pode informar que o usuário está offline
            {
                AllUsersConnected.Where(x => x.Equals(Users[Context.ConnectionId])).First().Connected = false;
            }

            UsersOnlineCount();
        }
    }
}
