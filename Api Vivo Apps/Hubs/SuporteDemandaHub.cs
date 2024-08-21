using AutoMapper;
using AutoMapper.QueryableExtensions;
using Blazorise;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Shared_Static_Class.Data;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Enums;
using Shared_Static_Class.Model_DTO;
using Shared_Static_Class.Converters;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
using TableDependency.SqlClient.Base.Messages;
using Vivo_Apps_API.Controllers;
using Shared_Static_Class.Model_DTO;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using StackExchange.Redis;
using System.Drawing;
using Microsoft.AspNetCore.OutputCaching;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using System.Security.Policy;

namespace Vivo_Apps_API.Hubs
{
    public interface ISuporteDemandaHub
    {
        Task GetTable(string? connectionId = null);
        Task NewNotification(string senderName, string title, string message, string link, string regional);
        Task NewNotificationByUser(int matricula, DEMANDA_CHAMADO content);
        Task ProgressMassivoTreinamento(int matricula, int porcentagem, string message);
        Task SendTableDemandas(int? matricula = null);
        /** Este metódo indica para o HUB que as demandas precisam ser atualizadas 
         * Caso seja passado o paramêtro de alguma matrícula, o HUB apenas notifica a matrícula em questão se ela estiver conectada 
        **/
        Task UpdateDemanda(DEMANDAS_CHAMADO_DTO data);
    }

    public class SuporteDemandaHub : Hub<ISuporteDemandaHub>, ISuporteDemandaHub
    {
        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext Demanda_BD;
        public IHubContext<SuporteDemandaHub> _context;
        private readonly IMapper _mapper;
        private readonly HttpClient _client;
        private readonly IOutputCacheStore _cache;
        private readonly DemandasController _service;
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _envirionment;
        public static IDictionary<string, ACESSOS_MOBILE_DTO> CurrentUsers = new Dictionary<string, ACESSOS_MOBILE_DTO>();
        public static IEnumerable<DEMANDA_DTO> data = new List<DEMANDA_DTO>();
        private string api_host_dev;
        private string api_host_production;
        public SuporteDemandaHub(
            IHubContext<SuporteDemandaHub> context,
            IDbContextFactory<DemandasContext> dbContextFactory,
            IOutputCacheStore cache, IConfiguration configuration, IWebHostEnvironment envirionment)
        {
            _client = new HttpClient();
            _cache = cache;
            DbFactory = dbContextFactory;
            Demanda_BD = DbFactory.CreateDbContext();
            _context = context;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DEMANDA_RELACAO_CHAMADO, DEMANDA_DTO>();
                cfg.CreateMap<DEMANDA_CHAMADO, PAINEL_DEMANDAS_CHAMADO_DTO>();

                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_DTO>()
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => (Cargos)src.CARGO)
                    )
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => (Canal)src.CANAL)
                    )
                .ForMember(
                    dest => dest.Perfis,
                    opt => opt.MapFrom(src => Demanda_BD.PERFIL_USUARIO.Where(x => x.MATRICULA == src.MATRICULA))
                    );

                cfg.CreateMap<DEMANDA_TIPO_FILA, DEMANDA_TIPO_FILA_DTO>();
                cfg.CreateMap<DEMANDA_SUB_FILA, PAINEL_DEMANDA_SUB_FILA_DTO>();
                cfg.CreateMap<DEMANDA_SUB_FILA, DEMANDA_SUB_FILA_DTO>()
                .ForMember(
                    dest => dest.Responsaveis,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE.Where(y =>
                        Demanda_BD.DEMANDA_RESPONSAVEL_FILA
                                .Where(x => x.ID_SUB_FILA == src.ID_SUB_FILA)
                                .Select(x => x.MATRICULA_RESPONSAVEL)
                                .Distinct()
                                .Contains(y.MATRICULA)))
                    );
                cfg.CreateMap<DEMANDA_CAMPOS_FILA, DEMANDA_CAMPOS_FILA_DTO>();

                cfg.CreateMap<DEMANDA_VALORES_CAMPOS_SUSPENSO, DEMANDA_VALORES_CAMPOS_SUSPENSO_DTO>();

                cfg.CreateMap<ACESSO, ACESSO_DTO>();

                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_DTO>()
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => (Cargos)src.CARGO)
                    )
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => (Canal)src.CANAL)
                    );

                cfg.CreateMap<DEMANDA_BD_OPERADORE, DEMANDA_BD_OPERADORES_DTO>()
                .ForMember(
                    dest => dest.MATRICULA,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE
                                .Where(x => x.MATRICULA == src.MATRICULA)
                                .FirstOrDefault()))
                .ForMember(
                    dest => dest.MATRICULA_MOD,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE
                                .Where(x => x.MATRICULA == src.MATRICULA_MOD)
                                .FirstOrDefault())
                    );
            });

            _mapper = config.CreateMapper();
            _config = configuration;
            _envirionment = envirionment;
            api_host_dev = _config.GetConnectionString("api_host_link");
            api_host_production = _config.GetConnectionString("api_host_link_production");
        }
        //private string GetBaseUrl(this HttpRequest request)
        //{
        //    // SSL offloading
        //    var scheme = request.Host.Host.Contains("localhost") ? request.Scheme : "https";
        //    return $"{scheme}://{request.Host}{request.PathBase}";
        //}
        protected async Task GetAllAsync(int? matricula = null)
        {
            var response = await _client.GetAsync((!_envirionment.IsDevelopment() ? api_host_production : api_host_dev) + "api/Demandas/GetAllChamados");
            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var listAnalistas = JsonConvert.DeserializeObject<IEnumerable<DEMANDA_DTO>>(responseString);
                if (listAnalistas != null)
                {
                    data = listAnalistas;
                    await Task.CompletedTask;
                }
            }
            await Task.CompletedTask;
        }

        public async Task SendTableDemandas(int? matricula = null)
        {
            await GetAllAsync(matricula);

            if (matricula != null)
            {
                var ids = CurrentUsers.Where(x => x.Value.MATRICULA == matricula);
                foreach (var item in ids)
                {
                    await GetTable(item.Key);
                }
            }
            else
            {
                foreach (var item in CurrentUsers)
                {
                    await GetTable(item.Key);
                }
            }
        }
        /** Neste método é onde enviamos para cada usuário online os novos valores da tabela  **/
        public async Task GetTable(string? connectionId = null)
        {
            if (connectionId != null)
            {
                CurrentUsers.TryGetValue(connectionId, out var user);
                if (user != null)
                {
                    switch (user.role)
                    {
                        /** Consulta para usuários básicos **/
                        case Controle_Demanda_role.BASICO:

                            var first20 = data.Where(x=> x.REGIONAL == user.REGIONAL)
                                .OrderByDescending(x => x.PRIORIDADE)
                                .ThenByDescending(x => x.PRIORIDADE_SEGMENTO)
                                .ThenBy(x => x.Sequence).Take(20);

                            var dataresp = data.Where(x => x.MATRICULA_SOLICITANTE == user.MATRICULA && x.REGIONAL == user.REGIONAL);

                            var datatotalbasico = dataresp.UnionBy(first20, x => x.ID_RELACAO);

                            await _context.Clients.Client(connectionId)
                                .SendAsync("TableDemandas", datatotalbasico);
                            break;

                        /** Consulta para analistas do suporte que não tratam solicitação de acessos terceiro **/
                        case Controle_Demanda_role.ANALISTA:

                            var list_ids = Demanda_BD.DEMANDA_RESPONSAVEL_FILA.Where(x => x.MATRICULA_RESPONSAVEL == user.MATRICULA ).Select(x => x.ID_SUB_FILA);

                            await _context.Clients.Group($"{user.REGIONAL}-{(int)user.role}")
                                .SendAsync("TableDemandas",
                                data.Where(x => x.Tabela == DEMANDA_RELACAO_CHAMADO.Tabela_Demanda.ChamadoRelacao
                                && list_ids.Contains(x.ChamadoRelacao.Fila.ID_SUB_FILA) && x.REGIONAL == user.REGIONAL));
                            break;

                        /** Consulta para analistas do suporte que tratam solicitação de acessos terceiro **/
                        case Controle_Demanda_role.ANALISTA_ACESSO:

                            var list_ids_user = Demanda_BD.DEMANDA_RESPONSAVEL_FILA.Where(x => x.MATRICULA_RESPONSAVEL == user.MATRICULA).Select(x => x.ID_SUB_FILA);

                            var datademandaanalistaacesso = data.Where(x => x.Tabela == DEMANDA_RELACAO_CHAMADO.Tabela_Demanda.ChamadoRelacao
                                && list_ids_user.Contains(x.ChamadoRelacao.Fila.ID_SUB_FILA) && x.REGIONAL == user.REGIONAL);

                            var dataacessoanalistaacesso = data.Where(x => x.Tabela == DEMANDA_RELACAO_CHAMADO.Tabela_Demanda.AcessoRelacao);

                            var datatotalanalistaacesso = datademandaanalistaacesso.UnionBy(dataacessoanalistaacesso, x => x.ID_RELACAO);

                            await _context.Clients.Group($"{user.REGIONAL}-{(int)user.role}").SendAsync("TableDemandas", datatotalanalistaacesso);
                            break;

                        /** Consulta para gerente do suporte **/
                        case Controle_Demanda_role.GERENTE:

                            await _context.Clients.Group($"{user.REGIONAL}-{(int)user.role}").SendAsync("TableDemandas", data.Where(x=> x.REGIONAL == user.REGIONAL));
                            break;
                    }
                }
            }
        }

        public async Task UpdateDemanda(DEMANDAS_CHAMADO_DTO data)
        {
            await _context.Clients.Group(data.ID.ToString()).SendAsync("Update-Demanda", data);
        }

        public async Task SetPriority(int matricula, IEnumerable<Guid> ids)
        {
            foreach (var item in data.Where(x => ids.Contains(x.ID_RELACAO)))
            {
                item.PRIORIDADE = !item.PRIORIDADE;
            }

            foreach (var item in Demanda_BD.DEMANDA_RELACAO_CHAMADO.Where(x => ids.Contains(x.ID_RELACAO)))
            {
                item.PRIORIDADE = !item.PRIORIDADE;

                item.Historico_Prioridade.Add(new CHAMADO_HISTORICO_PRIORIDADE
                {
                    MAT_RESPONSAVEL = matricula,
                    PRIORIDADE = item.PRIORIDADE,
                    DATA = DateTime.Now
                });
            }

            Demanda_BD.SaveChanges();

            await _context.Clients.All.SendAsync("PriorityChanged", ids);
        }

        public Task NewNotification(string senderName, string title, string message, string link, string regional)
        {
            _context.Clients.Group(regional).SendAsync("NewNotification", senderName, title, message, link);
            return Task.CompletedTask;
        }

        public Task ProgressMassivoTreinamento(int matricula, int porcentagem, string message)
        {
            if (CurrentUsers.Any(x => x.Value.MATRICULA == matricula))
            {
                foreach (var item in CurrentUsers.Where(x => x.Value.MATRICULA == matricula))
                {
                    _context.Clients.Client(item.Key).SendAsync("ProgressMassivoTreinamento", porcentagem, message);
                }
            }

            return Task.CompletedTask;
        }
        public Task NewNotificationByUser(int matricula, DEMANDA_CHAMADO content)
        {
            if (CurrentUsers.Any(x => x.Value.MATRICULA == matricula))
            {
                foreach (var item in CurrentUsers.Where(x => x.Value.MATRICULA == matricula))
                {
                    string message;
                    if (matricula == content.MATRICULA_SOLICITANTE)
                    {
                        message = $"Você acaba de abrir uma nova demanda com N° {content.ID}";
                    }
                    else
                    {
                        message = $"Uma demanda acaba de ser aberta onde você é o responsável com N° {content.ID}";
                    }

                    _context.Clients.Client(item.Key).SendAsync("NewNotificationByUser", matricula, message, $"/consultar/consultardemandasbyid/{content.ID}");
                }
            }

            return Task.CompletedTask;
        }

        public override async Task OnConnectedAsync()
        {
            try
            {
                var matricula = Context?.GetHttpContext()?.GetRouteValue("matricula") as string;

                if (matricula != string.Empty)
                {
                    var saida = Demanda_BD.ACESSOS_MOBILE
                        .Include(x => x.DemandasResponsavel)
                        .First(x => x.MATRICULA == int.Parse(matricula));

                    var user = _mapper.Map<ACESSOS_MOBILE_DTO>(saida);


                    var demandaid = Context?.GetHttpContext()?.GetRouteValue("demandaid") as string;

                    if (demandaid != string.Empty && demandaid != null)
                    {
                        await Groups.AddToGroupAsync(Context?.ConnectionId, $"{demandaid}");
                    }
                    else
                    {

                        var regional = Context?.GetHttpContext()?.GetRouteValue("regional") as string;
                        var rolestring = Context?.GetHttpContext()?.GetRouteValue("role") as string;
                        if (rolestring != string.Empty && regional != string.Empty)
                        {
                            var role = (Controle_Demanda_role)int.Parse(rolestring);
                            user.role = role;
                            if (user.role != Controle_Demanda_role.BASICO)
                            {
                                await Groups.AddToGroupAsync(Context?.ConnectionId, $"{regional}-{rolestring}");
                            }
                        }
                    }

                    CurrentUsers.Add(Context?.ConnectionId, user);
                }

                await SendTableDemandas(null);

                await _context.Clients.All.SendAsync("CurrentUsers", CurrentUsers);

                await base.OnConnectedAsync();
            }
            catch (Exception ex)
            {

            }
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            CurrentUsers.Remove(Context.ConnectionId);
            await _context.Groups.RemoveFromGroupAsync(Context?.ConnectionId, "NE");
            await _context.Clients.All.SendAsync("CurrentUsers", CurrentUsers);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
