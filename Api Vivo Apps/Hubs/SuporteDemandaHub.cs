﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Blazorise;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Shared_Class_Vivo_Apps.Data;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using Shared_Class_Vivo_Apps.Enums;
using Shared_Class_Vivo_Apps.Model_DTO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
using TableDependency.SqlClient.Base.Messages;
using Vivo_Apps_API.Controllers;

namespace Vivo_Apps_API.Hubs
{
    public interface ISuporteDemandaHub
    {
        Task GetTable(string? regional);
        Task NewNotification(string senderName, string title, string message, string link, string regional);
        Task NewNotificationByUser(int matricula, DEMANDA_CHAMADO content);
        Task SendTableDemandas();
        Task UpdateDemanda(DEMANDAS_CHAMADO_DTO data);
    }

    public class SuporteDemandaHub : Hub<ISuporteDemandaHub>, ISuporteDemandaHub
    {
        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext Demanda_BD;
        public IHubContext<SuporteDemandaHub> _context;
        private readonly IMapper _mapper;
        public static IDictionary<string, ACESSOS_MOBILE_DTO> CurrentUsers = new Dictionary<string, ACESSOS_MOBILE_DTO>();
        public static IEnumerable<PAINEL_DEMANDAS_CHAMADO_DTO> data = new List<PAINEL_DEMANDAS_CHAMADO_DTO>();

        public SuporteDemandaHub(IHubContext<SuporteDemandaHub> context, IDbContextFactory<DemandasContext> dbContextFactory)
        {
            DbFactory = dbContextFactory;
            Demanda_BD = DbFactory.CreateDbContext();
            _context = context;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DEMANDA_CHAMADO, PAINEL_DEMANDAS_CHAMADO_DTO>();

                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_DTO>()
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => (Cargos)src.CARGO)
                    )
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => (Canal)src.CANAL)
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
                                .Contains(y.MATRICULA.Value)))
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
        }

        protected async void GetAllAsync()
        {
            try
            {
                var dataBeforeFilter = Demanda_BD.DEMANDA_CHAMADO
                    .Where(x => x.DATA_ABERTURA >= DateTime.Now.AddYears(-1) && x.DATA_ABERTURA <= DateTime.Now)
                    .IgnoreAutoIncludes()
                    .AsNoTracking();

                var saida = dataBeforeFilter
                    .Include(x => x.Campos)
                    .Include(x => x.Status)
                    .Include(x => x.Fila)
                    .Include(x => x.Responsavel)
                    .Include(x => x.Solicitante)
                    .ProjectTo<PAINEL_DEMANDAS_CHAMADO_DTO>(_mapper.ConfigurationProvider)
                    .AsAsyncEnumerable();

                //List<PAINEL_DEMANDAS_CHAMADO_DTO> result = new();

                //foreach (var item in saida)
                //{
                //    result.Add(_mapper.Map<PAINEL_DEMANDAS_CHAMADO_DTO>(item));
                //}

                data = saida.ToBlockingEnumerable();
            }
            catch (Exception ex)
            {
            }
        }

        public async Task SendTableDemandas()
        {
            GetAllAsync();
            await GetTable(null);
        }
        public async Task GetTable(string? regional)
        {
            if (string.IsNullOrEmpty(regional))
            {
                await _context.Clients.All.SendAsync("TableDemandas", data);
            }
            else
            {
                await _context.Clients.Group(regional).SendAsync("TableDemandas", data);
            }
        }

        public async Task UpdateDemanda(DEMANDAS_CHAMADO_DTO data)
        {
            await _context.Clients.Group(data.ID.ToString()).SendAsync("Update-Demanda", data);
        }

        public async Task SetPriority(int matricula, string prioridade, int id)
        {
            var item = data.Where(x => x.ID == id).FirstOrDefault();
            item.PRIORIDADE = prioridade;

            var demanda = Demanda_BD.DEMANDA_CHAMADO.Find(id);
            demanda.PRIORIDADE = prioridade;
            demanda.Historico_Prioridade.Add(new DEMANDA_HISTORICO_PRIORIDADE
            {
                MAT_RESPONSAVEL = matricula,
                PRIORIDADE = prioridade,
                DATA = DateTime.Now
            });

            Demanda_BD.SaveChanges();

            await _context.Clients.All.SendAsync("TableDemandas", data);
        }

        public Task NewNotification(string senderName, string title, string message, string link, string regional)
        {
            _context.Clients.Group(regional).SendAsync("NewNotification", senderName, title, message, link);
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
                        .First(x => x.MATRICULA == int.Parse(matricula));

                    var user = _mapper.Map<ACESSOS_MOBILE_DTO>(saida);

                    CurrentUsers.Add(Context?.ConnectionId, user);
                }

                var demandaid = Context?.GetHttpContext()?.GetRouteValue("demandaid") as string;

                if (demandaid != string.Empty && demandaid != null)
                {
                    await Groups.AddToGroupAsync(Context?.ConnectionId, $"{demandaid}");
                }
                else
                {
                    var regional = Context?.GetHttpContext()?.GetRouteValue("regional") as string;

                    if (regional != string.Empty)
                    {
                        await Groups.AddToGroupAsync(Context?.ConnectionId, $"{regional}");
                    }
                }



                if (!data.Any())
                {
                    GetAllAsync();
                }

                await _context.Clients.All.SendAsync("CurrentUsers", CurrentUsers);
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