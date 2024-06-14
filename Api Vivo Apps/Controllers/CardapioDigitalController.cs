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
using Shared_Static_Class.Models;
using Shared_Static_Class.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardapioDigitalController : ControllerBase
    {
        private CardapioDigitalContext BD = new CardapioDigitalContext();
        private IDbContextFactory<CardapioDigitalContext> DbFactory;

        private readonly ILogger<CardapioDigitalController> _logger;
        private readonly IMapper _mapper;


        public CardapioDigitalController(ILogger<CardapioDigitalController> logger, IDbContextFactory<CardapioDigitalContext> dbFactory)
        {
            _logger = logger;

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<ACESSOS_MOBILE_PENDENTE, SOLICITAR_USUARIO_MODEL>()
            //    .ForMember(
            //        dest => dest.Perfil,
            //        opt => opt.MapFrom(src => CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == src.ID).Select(x => x.ID_PERFIL))
            //    );
            //});

            //_mapper = config.CreateMapper();
            DbFactory = dbFactory;
            BD = DbFactory.CreateDbContext();
        }


        [HttpGet("Get")]
        [ProducesResponseType(typeof(Response<IEnumerable<PRODUTOS_CARDAPIO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Get()
        {
            try
            {
                var result = BD.PRODUTOS_CARDAPIO.Include(x => x.Ficha).AsEnumerable();

                return new JsonResult(new Response<IEnumerable<PRODUTOS_CARDAPIO>>
                {
                    Data = result,
                    Succeeded = true,
                    Message = "Você está habilitado a solicitação de acesso a ferramenta."
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles 
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
