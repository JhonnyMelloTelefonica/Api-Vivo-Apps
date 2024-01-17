using Shared_Class_Vivo_Apps.Data;
using Vivo_Apps_API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shared_Class_Vivo_Apps.Enums;
using Vivo_Apps_API.Hubs;
using Microsoft.AspNetCore.SignalR;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;

namespace Vivo_Apps_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrincipalVivoXController : ControllerBase
    {
        private Vivo_MaisContext _context = new();
        private readonly IHubContext<VivoXHub> _hubContext;
        private readonly ILogger<PrincipalVivoXController> _logger;

        public PrincipalVivoXController(IHubContext<VivoXHub> hubContext,
            ILogger<PrincipalVivoXController> logger)
        {
            _hubContext = hubContext;
            _logger = logger;
        }

        [HttpGet("GetFiltersDemandas")]
        public JsonResult GetFiltersDemandas(string regional)
        {
            try
            {

                var fila = _context.CONTROLE_DE_DEMANDAS_FILAs.Where(x => x.REGIONAL == regional)
                    .GroupBy(x => new { FILA = x.FILA, TIPO_FILA = x.TIPO_CHAMADO })
                    .Select(y => new
                    {
                        FILA = y.Key.FILA,
                        TIPO_FILA = y.Key.TIPO_FILA,
                    });
                var analistassuporte = _context.ACESSOs.Where(k => k.Regional == regional).Where(k =>
                    _context.CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILAs.Select(x => x.MATRICULA_RESPONSAVEL).Distinct().Contains(k.Login)
                    );
                var status = _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Select(k => k.STATUS).Distinct();

                return new JsonResult(new Response<object>
                {
                    Data = new
                    {
                        analistassuporte,
                        fila,
                        status
                    },
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpPost("BroadcastMessage")]
        public async Task<JsonResult> BroadcastMessage(string message,string name)
        {
            try
            {
                await _hubContext.Clients.All.SendAsync("broadcastMessage",name, message).ConfigureAwait(false);

                return new JsonResult(new Response<string>
                {
                    Data = "Tudo Certo",
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpGet("GetUserByMatricula")]
        [ProducesResponseType(typeof(Response<AcessoModel>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetUserByMatricula(string matricula)
        {
            AcessoModel user = _context.ACESSOS_MOBILEs.Where(x => x.MATRICULA == matricula)
                .Select(y => new AcessoModel
                {
                    ID = y.ID,
                    EMAIL = y.EMAIL,
                    MATRICULA = y.MATRICULA,
                    SENHA = y.SENHA,
                    REGIONAL = y.REGIONAL,
                    CARGO = (Cargos)Convert.ToInt32(y.CARGO),
                    CANAL = (Canal)Convert.ToInt32(y.CANAL),
                    PDV = y.PDV,
                    CPF = y.CPF,
                    NOME = y.NOME,
                    UF = y.UF,
                    STATUS = y.STATUS,
                    FIXA = y.FIXA,
                    TP_AFASTAMENTO = y.TP_AFASTAMENTO,
                    OBS = y.OBS,
                    UserAvatar = y.UserAvatar,
                    LOGIN_MOD = y.LOGIN_MOD,
                    DT_MOD = y.DT_MOD,
                    Perfil = _context.PERFIL_USUARIOs.Where(x => x.Login == y.MATRICULA).Select(k => new Perfil
                    {
                        ID = k.ID,
                        Login = k.Login,
                        Perfil_Plataforma = _context.PERFIL_PLATAFORMAS_VIVOs.Where(p=>p.ID_PERFIL == k.id_Perfil).First()
                    }).AsEnumerable()
                }).FirstOrDefault();

            if (user is not null)
            {
                return new JsonResult(new Response<AcessoModel>
                {
                    Data = user,
                    Succeeded = true,
                    Errors = null,
                    Message = "Usuário Encontrado"
                });
            }
            else
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao encontrar usuário",
                    Succeeded = false,
                    Message = "Não encontramos nenhum usuário com esta matrícula em nossa base do Vivo TASK"
                });
            }
        }

        //[HttpPost("GetDemandas")]
        //[ProducesResponseType(typeof(Response<GenericPagedResponse<IEnumerable<ACESSOS_DEMANDAS_MODEL>>>), 200)]
        //[ProducesResponseType(typeof(Response<string>), 500)]
        //public JsonResult GetDemandas([FromBody] PaginationDemandasModel filter)
        //{
        //    try
        //    {
        //        var pagedData = _context.CONTROLE_DE_DEMANDAS_CHAMADOs.AsQueryable();

        //        if (!string.IsNullOrEmpty(filter.matricula))
        //        {
        //            pagedData = pagedData.Where(x => x.MATRICULA_SOLICITANTE == filter.matricula);
        //        }
        //        if (filter.datas.Any())
        //        {
        //            pagedData = pagedData.Where(x => x.DATA_ABERTURA >= filter.datas.ElementAt(0) &&
        //            x.DATA_ABERTURA <= filter.datas.ElementAt(1));
        //        }
        //        if (filter.regional.Any())
        //        {
        //            pagedData = pagedData.Where(x => filter.regional.Contains(x.REGIONAL));
        //        }
        //        if (filter.status.Any())
        //        {
        //            pagedData = pagedData
        //                        .Where(c => filter.status.Contains(
        //                            _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
        //                                .Where(s => s.ID_STATUS_CHAMADO == c.ID_STATUS_CHAMADO)
        //                                .OrderByDescending(s => s.DATA)
        //                                .Select(s => s.STATUS)
        //                                .FirstOrDefault()));
        //        }
        //        if (filter.tipo_fila.Any())
        //        {
        //            pagedData = pagedData.Where(k =>
        //                _context.CONTROLE_DE_DEMANDAS_FILAs
        //                    .Where(postAndMeta => filter.tipo_fila.Contains(postAndMeta.TIPO_CHAMADO))
        //                    .Select(l => l.ID).Contains(k.ID_FILA_CHAMADO));

        //            if (filter.fila.Any())
        //            {
        //                pagedData = pagedData.Where(k =>
        //                _context.CONTROLE_DE_DEMANDAS_FILAs
        //                    .Where(postAndMeta => filter.fila.Contains(postAndMeta.FILA))
        //                    .Select(l => l.ID).Contains(k.ID_FILA_CHAMADO));
        //            }
        //        }
        //        if (filter.responsável.Any())
        //        {
        //            pagedData = pagedData.Where(x => filter.responsável.Contains(x.MATRICULA_RESPONSAVEL));
        //        }
        //        if (filter.id_demandas.Any())
        //        {
        //            pagedData = pagedData.Where(x => filter.id_demandas.Contains(x.ID));
        //        }

        //        var temporaryData = pagedData.OrderByDescending(x => x.ID)
        //       .Skip((filter.PageNumber - 1) * filter.PageSize)
        //       .Take(filter.PageSize)
        //       .ToList();

        //        var totalRecords = pagedData.Count();
        //        var totalPages = ((double)totalRecords / (double)filter.PageSize);

        //        IEnumerable<ACESSOS_DEMANDAS_MODEL> Data = temporaryData.Select(x => new ACESSOS_DEMANDAS_MODEL
        //        {
        //            ID = x.ID,
        //            ID_CAMPOS_CHAMADO = x.ID_CAMPOS_CHAMADO != null
        //            ? _context.CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADOs.Where(y => y.ID_CAMPOS_CHAMADO == x.ID_CAMPOS_CHAMADO)
        //            : null,
        //            ULTIMO_STATUS = x.ID_STATUS_CHAMADO != null
        //            ? _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Where(y => y.ID_STATUS_CHAMADO == x.ID_STATUS_CHAMADO).ToList().LastOrDefault()
        //            : null,
        //            FILA = _context.CONTROLE_DE_DEMANDAS_FILAs.Where(y => y.ID == x.ID_FILA_CHAMADO).ToList().FirstOrDefault(),
        //            RESPONSAVEL = _context.ACESSOs.Where(y => y.Login == x.MATRICULA_RESPONSAVEL).ToList().FirstOrDefault(),
        //            SOLICITANTE = x.MATRICULA_SOLICITANTE != null
        //            ? _context.ACESSOs.Where(y => y.Login == x.MATRICULA_SOLICITANTE).ToList().FirstOrDefault()
        //            : null,
        //            DATA_ABERTURA = x.DATA_ABERTURA.Value,
        //            DATA_FECHAMENTO = x.DATA_FECHAMENTO,
        //            MOTIVO_FECHAMENTO_SUPORTE = x.MOTIVO_FECHAMENTO_SUPORTE,
        //            PRIORIDADE = x.PRIORIDADE,
        //            REGIONAL = x.REGIONAL,
        //            PBI = x.PBI,
        //            EMAIL_SECUNDARIO = x.EMAIL_SECUNDARIO,
        //            RESPONSAVEL_OUTRA_AREA = x.RESPONSAVEL_OUTRA_AREA != null
        //            ? _context.ACESSOs.Where(y => y.Login == x.RESPONSAVEL_OUTRA_AREA).ToList().FirstOrDefault()
        //            : null,
        //            //SLA_PRIMEIRA_RESPOSTA = (
        //            //(x.ID_STATUS_CHAMADO != null && _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
        //            //.Where(y => y.ID_STATUS_CHAMADO == x.ID_STATUS_CHAMADO && y.STATUS != null)
        //            //.ToList().Count > 1)
        //            //? _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Where(y => y.ID_STATUS_CHAMADO == x.ID_STATUS_CHAMADO).ToArray()[1].DATA.Subtract(x.DATA_ABERTURA.Value)
        //            //: null)
        //            SLA_PRIMEIRA_RESPOSTA = (
        //            (
        //            x.ID_STATUS_CHAMADO != null
        //            //&& _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
        //            //   .Where(y => y.ID_STATUS_CHAMADO == x.ID_STATUS_CHAMADO && y.STATUS != null)
        //            //   .ToList().Count > 1
        //            && _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
        //               .Where(y => y.ID_STATUS_CHAMADO == x.ID_STATUS_CHAMADO && y.STATUS != null).Where(y => (_context.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs
        //                .Where(l => l.MATRICULA_RESPONSAVEL != x.MATRICULA_SOLICITANTE).Select(k => k.ID.ToString()).Contains(y.ID_RESPOSTA.ToString())))
        //                .FirstOrDefault() != null
        //            )
        //            ?
        //            _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
        //               .Where(y => y.ID_STATUS_CHAMADO == x.ID_STATUS_CHAMADO && y.STATUS != null).Where(y => (_context.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs
        //                .Where(l => l.MATRICULA_RESPONSAVEL != x.MATRICULA_SOLICITANTE).Select(k => k.ID.ToString()).Contains(y.ID_RESPOSTA.ToString())))
        //                .FirstOrDefault()
        //                .DATA.Subtract(x.DATA_ABERTURA.Value)
        //            : null)
        //        });

        //        return new JsonResult(
        //            new Response<GenericPagedResponse<IEnumerable<ACESSOS_DEMANDAS_MODEL>>>
        //            {
        //                Data = PagedResponse.CreatePagedReponse<ACESSOS_DEMANDAS_MODEL>(
        //                Data, filter, totalRecords),
        //                Succeeded = true,
        //                Message = "Tudo Certo"
        //            }

        //            );

        //    }
        //    catch (Exception ex)
        //    {
        //        return new JsonResult(new Response<string>
        //        {
        //            Data = "Erro ao encontrar buscar informações",
        //            Succeeded = false,
        //            Message = "Erro ao encontrar buscar informações"
        //        });
        //    }
        //}

        [HttpGet("GetDemandaById")]
        [ProducesResponseType(typeof(Response<HistoricoDemandasModel>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDemandaById(int IdDemanda)
        {
            try
            {
                var demanda = _context.CONTROLE_DE_DEMANDAS_CHAMADOs.Where(x => x.ID == IdDemanda).FirstOrDefault();
                var campos = _context.CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADOs.Where(x => x.ID_CAMPOS_CHAMADO == demanda.ID_CAMPOS_CHAMADO).ToList();
                var status = _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Where(x => x.ID_STATUS_CHAMADO == demanda.ID_STATUS_CHAMADO).ToList()
                    .Select(y => new StatusDemanda
                    {
                        ID_STATUS_CHAMADO = y.ID_STATUS_CHAMADO,
                        STATUS = y.STATUS,
                        DATA = y.DATA,
                        QUEM_REDIRECIONOU = _context.ACESSOs.Where(x => x.Login == y.MAT_QUEM_REDIRECIONOU).FirstOrDefault(),
                        ID = y.ID,
                        ID_RESPOSTA = y.ID_RESPOSTA.ToString(),
                    });

                var respostas = _context.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs.Where(x => x.ID_CHAMADO == IdDemanda).ToList()
                    .Select(y => new RespostaDemanda
                    {
                        ID = y.ID,
                        RESPOSTA = y.RESPOSTA,
                        ID_CHAMADO = y.ID_CHAMADO,
                        RESPONSAVEL = _context.ACESSOs.Where(x => x.Login == y.MATRICULA_RESPONSAVEL).FirstOrDefault(),
                        DATA_RESPOSTA = y.DATA_RESPOSTA,
                        ANEXOS = _context.CONTROLE_DE_DEMANDAS_ARQUIVOS_RESPOSTAs
                        .Where(k => k.ID_RESPOSTA == y.ID).ToList()
                    }).ToList();

                var retorno = new HistoricoDemandasModel
                {
                    ID = demanda.ID,
                    FILA = _context.CONTROLE_DE_DEMANDAS_FILAs.Where(x => x.ID == demanda.ID_FILA_CHAMADO).FirstOrDefault(),
                    SOLICITANTE = _context.ACESSOs.Where(x => x.Login == demanda.MATRICULA_SOLICITANTE).FirstOrDefault(),
                    RESPONSAVEL = _context.ACESSOs.Where(x => x.Login == demanda.MATRICULA_RESPONSAVEL).FirstOrDefault(),
                    DATA_FECHAMENTO = demanda.DATA_FECHAMENTO,
                    MOTIVO_FECHAMENTO_SUPORTE = demanda.MOTIVO_FECHAMENTO_SUPORTE,
                    REGIONAL = demanda.REGIONAL,
                    EMAIL_SECUNDARIO = demanda.EMAIL_SECUNDARIO,
                    RESPONSAVEL_OUTRA_AREA = _context.ACESSOs.Where(x => x.Login == demanda.RESPONSAVEL_OUTRA_AREA).FirstOrDefault(),
                    CAMPOS = campos,
                    STATUS = status,
                    RESPOSTAS = respostas,
                    ANEXOS_DEMANDA = _context.CONTROLE_DE_DEMANDAS_CHAMADO_ARQUIVOs.Where(x => x.ID_CHAMADO == demanda.ID)
                };

                return new JsonResult(
                  new Response<HistoricoDemandasModel>
                  {
                      Data = retorno,
                      Succeeded = true,
                      Message = "Tudo Certo"
                  });

            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao encontrar buscar informações",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace,
                        ex.Source
                    },
                    Message = "Erro ao encontrar buscar informações"
                });
            }
        }
    }
}
