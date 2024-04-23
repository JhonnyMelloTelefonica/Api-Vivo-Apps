using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Shared_Static_Class.Data;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Enums;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Model_DTO;
using Shared_Static_Class.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RakingController : ControllerBase
    {
        private readonly ILogger<RakingController> _logger;
        private readonly IDistributedCache _cache;
        private static Vivo_MaisContext CD;
        private readonly IMapper _mapper;
        public RakingController(ILogger<RakingController> logger
            , Vivo_MaisContext bd_context
            , IDistributedCache cache)
        {
            CD = bd_context;
            _cache = cache;
            _logger = logger;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_DTO>();

                cfg.CreateMap<JORNADA_BD_ANSWER_AVALIACAO, RakingJornada>()
                .ForMember(
                    dest => dest.User,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.FirstOrDefault(x => x.MATRICULA == src.RE_AVALIADO))
                    );
            });
            _mapper = config.CreateMapper();
        }

        [HttpGet("GetActualRanking")]
        [ProducesResponseType(typeof(IEnumerable<RakingJornada>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetActualRanking()
        {
            try
            {
                var Avaliacoes = CD.JORNADA_BD_ANSWER_AVALIACAOs
                    .Where(x => x.TP_FORMS.Equals("Jornada") && x.ID_PROVA != null && x.RE_AVALIADO != 0)
                    .Where(x => x.DT_AVALIACAO.HasValue && x.DT_AVALIACAO.Value.Year == 2024)
                    .AsEnumerable();

                /* total te questões respondidas em total provas respondidas = Num / 100 = Nota total possivel
                  Peso * Total de questões acertadas */

                var Agrupadorank = Avaliacoes.GroupBy(x => x.RE_AVALIADO.Value);


                var rank = Avaliacoes.GroupBy(x => x.RE_AVALIADO.Value)
                    .OrderByDescending(x => x.Sum(y => y.NOTA.Value))
                    .Select((x, i) => new RakingJornada
                    {
                        User = CD.ACESSOS_MOBILEs.ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider).First(y => y.MATRICULA == x.Key),
                        Pontuação = (double)x.Sum(y => y.NOTA.Value),
                        Classificação = i + 1,
                        Media = (double)x.Sum(y => y.NOTA.Value) / x.Count(),
                    }).Take(20).AsEnumerable();

                return new JsonResult(rank);

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
        public class RakingFilter
        {
            public IEnumerable<int> matdivisao { get; set; } = new List<int>();
            public IEnumerable<Cargos> cargos { get; set; } = new List<Cargos>();
            public IEnumerable<string> uf { get; set; } = new List<string>();
            public IEnumerable<Canal> canal { get; set; } = new List<Canal>();
        }
        public class RakingJornada
        {
            public ACESSOS_MOBILE_DTO? User { get; set; } = null;
            public int Classificação { get; set; }
            public double Pontuação { get; set; }
            public double Media { get; set; }
        }

    }
}
