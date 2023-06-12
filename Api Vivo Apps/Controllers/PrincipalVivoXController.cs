using Vivo_Apps_API.Data;
using Vivo_Apps_API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Drawing;

namespace Vivo_Apps_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrincipalVivoXController : ControllerBase
    {
        private Vivo_MAISContext _context = new();
        private readonly ILogger<PrincipalVivoXController> _logger;

        public PrincipalVivoXController(
            ILogger<PrincipalVivoXController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetUserByMatricula")]
        public JsonResult GetUserByMatricula(string matricula)
        {
            var user = _context.ACESSOs.Where(x => x.Login == matricula).FirstOrDefault();
            if (user is not null)
            {

                return new JsonResult(new Response<ACESSO>
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
                    Message = "Não foi encontrado nenhum usuário com esta matricula"
                });
            }
        }

        [HttpPost("GetDemandas")]
        public JsonResult GetDemandas([FromBody] PaginationDemandasModel filter)
        {
            try
            {
                var pagedData = _context.CONTROLE_DE_DEMANDAS_CHAMADOs.AsQueryable();

                var temporaryData = pagedData.OrderByDescending(x => x.ID)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToList();

                var totalRecords = pagedData.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                IEnumerable<ACESSOS_DEMANDAS_MODEL> Data = temporaryData.Select(x => new ACESSOS_DEMANDAS_MODEL
                {
                    ID = x.ID,
                    ID_CAMPOS_CHAMADO = x.ID_CAMPOS_CHAMADO != null
                    ? _context.CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADOs.Where(y => y.ID_CAMPOS_CHAMADO == x.ID_CAMPOS_CHAMADO)
                    : null,
                    ULTIMO_STATUS = x.ID_STATUS_CHAMADO != null
                    ? _context.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Where(y => y.ID_STATUS_CHAMADO == x.ID_STATUS_CHAMADO).ToList().LastOrDefault()
                    : null,
                    FILA = _context.CONTROLE_DE_DEMANDAS_FILAs.Where(y => y.ID == x.ID_FILA_CHAMADO).ToList().FirstOrDefault(),
                    RESPONSAVEL = _context.ACESSOs.Where(y => y.Login == x.MATRICULA_RESPONSAVEL).ToList().FirstOrDefault(),
                    SOLICITANTE = x.MATRICULA_SOLICITANTE != null
                    ? _context.ACESSOs.Where(y => y.Login == x.MATRICULA_SOLICITANTE).ToList().FirstOrDefault()
                    : null,
                    DATA_ABERTURA = x.DATA_ABERTURA.Value,
                    DATA_FECHAMENTO = x.DATA_FECHAMENTO,
                    MOTIVO_FECHAMENTO_SUPORTE = x.MOTIVO_FECHAMENTO_SUPORTE,
                    PRIORIDADE = x.PRIORIDADE,
                    REGIONAL = x.REGIONAL,
                    PBI = x.PBI,
                    EMAIL_SECUNDARIO = x.EMAIL_SECUNDARIO,
                    RESPONSAVEL_OUTRA_AREA = x.RESPONSAVEL_OUTRA_AREA != null
                    ? _context.ACESSOs.Where(y => y.Login == x.RESPONSAVEL_OUTRA_AREA).ToList().FirstOrDefault()
                    : null
                });

                return new JsonResult(
                    new Response<GenericPagedResponse<IEnumerable<ACESSOS_DEMANDAS_MODEL>>>
                    {
                        Data = PagedResponse.CreatePagedReponse<ACESSOS_DEMANDAS_MODEL>(
                        Data, filter, totalRecords),
                        Succeeded = true,
                        Message = "Tudo Certo"
                    }

                    );

            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao encontrar buscar informações",
                    Succeeded = false,
                    Message = "Erro ao encontrar buscar informações"
                });
            }
        }

        [HttpGet("GetDemandaById")]
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
                        ID_RESPOSTA = y.ID_RESPOSTA,
                    });
                var respostas = _context.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs.Where(x => x.ID_CHAMADO == IdDemanda).ToList()
                    .Select(y => new RespostaDemanda
                    {
                        ID = y.ID,
                        RESPOSTA = y.RESPOSTA,
                        ID_CHAMADO = y.ID_CHAMADO,
                        RESPONSAVEL = _context.ACESSOs.Where(x => x.Login == y.MATRICULA_RESPONSAVEL).FirstOrDefault(),
                        DATA_RESPOSTA = y.DATA_RESPOSTA,
                    });

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
