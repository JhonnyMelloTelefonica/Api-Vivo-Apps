using Newtonsoft.Json;
using DataTable = System.Data.DataTable;
using System.Data;
using Vivo_Apps_API.Models;
using Shared_Class_Vivo_Apps.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiController = System.Web.Http.ApiController;
using Shared_Class_Vivo_Apps.Enums;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Shared_Class_Vivo_Apps.Models;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Register : ControllerBase
    {
        private Vivo_MaisContext CD = new Vivo_MaisContext();

        private readonly ILogger<RandomFunctions> _logger;
        private readonly IMapper _mapper;

        public Register(ILogger<RandomFunctions> logger)
        {
            _logger = logger;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ACESSOS_MOBILE_PENDENTE, ControleUsuariosModel>()
                .ForMember(
                    dest => dest.Perfil,
                    opt => opt.MapFrom(src => CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == src.ID).Select(x => x.ID_PERFIL))
                );
            });

            _mapper = config.CreateMapper();
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

                if (UltimaSolicitacao is not null)
                {
                    var solicitacaoAndamento = (!string.Equals(UltimaSolicitacao.STATUS, "REPROVADO")
                                && !string.Equals(UltimaSolicitacao.STATUS, "FINALIZADO"));
                    // verifico se possui os Status não é finalizado nem reprovado, caso não seja nenhum dos 2 siginifica que ainda está em andamento

                    if (solicitacaoAndamento)
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
    }
}
