using Newtonsoft.Json;
using DataTable = System.Data.DataTable;
using System.Data;
using Vivo_Apps_API.Models;
using Shared_Static_Class.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiController = System.Web.Http.ApiController;
using Shared_Static_Class.Enums;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Shared_Razor_Components.FundamentalModels;
using Shared_Static_Class.Converters;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Register : ControllerBase
    {
        private Vivo_MaisContext CD = new Vivo_MaisContext();
        private DemandasContext Demanda = new DemandasContext();

        private readonly ILogger<RandomFunctions> _logger;
        private readonly IMapper _mapper;

        public Register(ILogger<RandomFunctions> logger, DemandasContext demanda)
        {
            _logger = logger;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ACESSOS_MOBILE_PENDENTE, SOLICITAR_USUARIO_MODEL>()
                .ForMember(
                    dest => dest.Perfil,
                    opt => opt.MapFrom(src => CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == src.ID).Select(x => x.ID_PERFIL))
                );
            });

            _mapper = config.CreateMapper();
            Demanda = demanda;
        }

        [HttpGet("VerifyCurrentUserExists")]
        [ProducesResponseType(typeof(Response<ACESSOS_MOBILE_PENDENTE?>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult VerifyCurrentUserExists(int matricula)
        {
            try
            {
                var UltimaSolicitacao = CD.ACESSOS_MOBILE_PENDENTEs
                    .Where(x => x.MATRICULA == matricula).OrderByDescending(x => x.ID).FirstOrDefault();
                // Busco a última solicitação para esta matrícula

                if (UltimaSolicitacao is not null && UltimaSolicitacao.TIPO != "ALTERAÇÃO")
                {
                    var solicitacaoAndamento = (string.Equals(UltimaSolicitacao.STATUS, STATUS_ACESSOS_PENDENTES.REPROVADO.Value)
                                                || string.Equals(UltimaSolicitacao.STATUS, STATUS_ACESSOS_PENDENTES.CANCELADO.Value)
                                                || string.Equals(UltimaSolicitacao.STATUS, STATUS_ACESSOS_PENDENTES.APROVADO.Value));
                    // verifico se possui o último status é finalizado ou reprovado ou aprovado,
                    // caso não seja nenhum dos 2 siginifica que ainda está em andamento

                    if (!solicitacaoAndamento ) 
                        //Caso a ultima solicitação não tenha nenhum destes status 
                        //significa que ainda está em andamento
                    {
                        var user = CD.ACESSOS_MOBILE_PENDENTEs.Where(x => x.MATRICULA == matricula).First();

                        return new JsonResult(new Response<ACESSOS_MOBILE_PENDENTE?>
                        {
                            // ele retorna um aviso que já existe uma solicitação em andamento
                            Data = user,
                            Succeeded = true,
                            Message = "solicitação em andamento, aguarde o retorno do responsável",
                            Errors = new string[] { "Matrícula existente!" },
                        });
                    }
                }

                return new JsonResult(new Response<ACESSOS_MOBILE_PENDENTE?>
                {
                    Data = new(),
                    Succeeded = true,
                    Message = "Você está habilitado a solicitação de acesso a ferramenta."
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }

        [HttpGet("GetUser")]
        [ProducesResponseType(typeof(Response<ACESSOS_MOBILE>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetUser(int matricula)
        {
            try
            {
                var result = Demanda.ACESSOS_MOBILE.Where(x => x.MATRICULA == matricula)
                    .Include(x=> x.DemandasResponsavel)
                    .Include(x=> x.DemandasSolicitadas).FirstOrDefault();

                return new JsonResult(new Response<ACESSOS_MOBILE>
                {
                    Data = result,
                    Succeeded = true,
                    Message = "Você está habilitado a solicitação de acesso a ferramenta."
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }
    }
}
