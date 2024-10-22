using Newtonsoft.Json;
using DataTable = System.Data.DataTable;
using System.Data;
using System.Data.SqlClient;
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

using Shared_Static_Class.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using NuGet.Versioning;
using Microsoft.AspNetCore.OutputCaching;
using Shared_Razor_Components.FundamentalModels;
using Shared_Static_Class.Model_DTO;
using Shared_Static_Class.Model_DTO.FilterModels;
using static Shared_Static_Class.Data.DEMANDA_RELACAO_CHAMADO;
using System.Linq;
using Shared_Static_Class.Model_ForumRTCZ_Context;
using NuGet.Protocol.Core.Types;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForumRTCZController : ControllerBase
    {
        private ForumRTCZContext BD = new ForumRTCZContext();
        private IDbContextFactory<ForumRTCZContext> DbFactory;

        private readonly ILogger<ForumRTCZController> _logger;
        private readonly IMapper _mapper;
        public ForumRTCZController(ILogger<ForumRTCZController> logger, IDbContextFactory<ForumRTCZContext> dbFactory)
        {
            _logger = logger;
            DbFactory = dbFactory;
            BD = DbFactory.CreateDbContext();
        }

        [HttpGet("GetTemas")]
        [ProducesResponseType(typeof(Response<IEnumerable<IEnumerable<JORNADA_BD_TEMAS_SUB_TEMA>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetTemas()
        {
            try
            {
                var data = BD.JORNADA_BD_TEMAS_SUB_TEMA.AsEnumerable();

                return new JsonResult(new Response<IEnumerable<JORNADA_BD_TEMAS_SUB_TEMA>>
                {
                    Data = data,
                    Message = "Sucessfull",
                    Errors = [],
                    Succeeded = true
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }
        [HttpGet("GetTemas/{matricula}")]
        [ProducesResponseType(typeof(Response<IEnumerable<IEnumerable<JORNADA_BD_TEMAS_SUB_TEMA>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetTemas(int matricula)
        {
            try
            {
                List<int> ids = BD.RESPONSAVEL_TEMA.Where(x => x.MATRICULA_RESPONSAVEL == matricula).Select(x => x.SUB_TEMA).ToList();
                var data = BD.JORNADA_BD_TEMAS_SUB_TEMA.Where(x => ids.Contains(x.ID_SUB_TEMAS)).AsEnumerable();

                return new JsonResult(new Response<IEnumerable<JORNADA_BD_TEMAS_SUB_TEMA>>
                {
                    Data = data,
                    Message = "Sucessfull",
                    Errors = [],
                    Succeeded = true
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }

        [HttpPost("Get")]
        [ProducesResponseType(typeof(Response<IEnumerable<PUBLICACAO_SOLICITACAO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult SearchByFilters([FromBody] GenericPaginationModel<PainelForumRTCZ> filter)
        {
            try
            {
                IQueryable<PUBLICACAO_SOLICITACAO> lista = null;
                var data = BD.PUBLICACAO_SOLICITACAO.AsSplitQuery().Where(x => x.Respostas.Any());

                if (!string.IsNullOrEmpty(filter.Value.search))
                {
                    data = data.Where(x => EF.Functions.Like(x.TEXT_PUBLICACAO, $"%{filter.Value.search}%") || (x.Respostas.Any() && EF.Functions.Like(x.Respostas.First().TEXT_PUBLICACAO, $"%{filter.Value.search}%")));
                }

                if (filter.Value.avaliacao != 0)
                {
                    data = data.Where(x => x.Avaliacao.Average(x => x.AVALIACAO) == filter.Value.avaliacao);
                }

                if (filter.Value.tema.Any())
                {
                    data = data.Where(x => filter.Value.tema.Contains(x.Tema.ID_TEMAS ?? 0));
                }

                if (filter.Value.subtema.Any())
                {
                    data = data.Where(x => filter.Value.subtema.Contains(x.Tema.ID_SUB_TEMAS));
                }

                lista = data.OrderByDescending(x => x.HORA)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize);

                var totalRecords = data.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                var Data = lista
                    .Include(x => x.Avaliacao)
                    .Include(x => x.Responsavel)
                    .Include(x => x.Respostas.Take(1))
                        .ThenInclude(x => x.Solicitante)
                    .Include(x => x.Respostas.Take(1))
                        .ThenInclude(x => x.Avaliacao)
                    .Include(x => x.Tema)
                    .Select(x => new PUBLICACAO_SOLICITACAODTO(x, false, false))
                    .AsEnumerable();

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<PUBLICACAO_SOLICITACAODTO>>>
                {
                    Data = PagedResponse.CreatePagedReponse(Data, filter, totalRecords),
                    Message = "Sucessfull",
                    Errors = [],
                    Succeeded = true
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }

        [HttpPost("Get/{matricula}")]
        [ProducesResponseType(typeof(Response<IEnumerable<PUBLICACAO_SOLICITACAO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult SearchByFiltersByUser([FromBody] GenericPaginationModel<PainelForumRTCZ> filter, int matricula)
        {
            try
            {
                IQueryable<PUBLICACAO_SOLICITACAO> lista = null;
                var data = BD.PUBLICACAO_SOLICITACAO.AsSplitQuery().Where(x => x.MAT_RESPONSAVEL == matricula);

                if (!string.IsNullOrEmpty(filter.Value.search))
                {
                    data = data.Where(x => EF.Functions.Like(x.TEXT_PUBLICACAO, $"%{filter.Value.search}%") || (x.Respostas.Any() && EF.Functions.Like(x.Respostas.First().TEXT_PUBLICACAO, $"%{filter.Value.search}%")));
                }

                if (filter.Value.avaliacao != 0)
                {
                    data = data.Where(x => x.Avaliacao.Average(x => x.AVALIACAO) == filter.Value.avaliacao);
                }

                if (filter.Value.tema.Any())
                {
                    data = data.Where(x => filter.Value.tema.Contains(x.Tema.ID_TEMAS ?? 0));
                }

                if (filter.Value.subtema.Any())
                {
                    data = data.Where(x => filter.Value.subtema.Contains(x.Tema.ID_SUB_TEMAS));
                }

                lista = data.OrderByDescending(x => x.HORA)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize);

                var totalRecords = data.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                var Data = lista
                    .Include(x => x.Avaliacao)
                    .Include(x => x.Responsavel)
                    .Include(x => x.Respostas.Take(1))
                        .ThenInclude(x => x.Solicitante)
                    .Include(x => x.Respostas.Take(1))
                        .ThenInclude(x => x.Avaliacao)
                    .Include(x => x.Tema)
                    .Select(x => new PUBLICACAO_SOLICITACAODTO(x, false, false))
                    .AsEnumerable();

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<PUBLICACAO_SOLICITACAODTO>>>
                {
                    Data = PagedResponse.CreatePagedReponse(Data, filter, totalRecords),
                    Message = "Sucessfull",
                    Errors = [],
                    Succeeded = true
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }

        [HttpPost("GetPublicacoesPendentes/{matricula}")]
        [ProducesResponseType(typeof(Response<IEnumerable<PUBLICACAO_SOLICITACAO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult SearchByFiltersByAnalista(GenericPaginationModel<PainelForumRTCZ> filter, int matricula)
        {
            try
            {
            
                IQueryable<PUBLICACAO_SOLICITACAO> lista = null;

                List<int> ids = BD.RESPONSAVEL_TEMA.Where(x => x.MATRICULA_RESPONSAVEL == matricula).Select(x => x.SUB_TEMA).ToList();
                var data = BD.PUBLICACAO_SOLICITACAO.Where(x => !x.Respostas.Any() && ids.Contains(x.SUB_TEMA)).AsSplitQuery();

                if (!string.IsNullOrEmpty(filter.Value.search))
                {
                    data = data.Where(x => EF.Functions.Like(x.TEXT_PUBLICACAO, $"%{filter.Value.search}%") || (x.Respostas.Any() && EF.Functions.Like(x.Respostas.First().TEXT_PUBLICACAO, $"%{filter.Value.search}%")));
                }

                if (filter.Value.avaliacao != 0)
                {
                    data = data.Where(x => x.Avaliacao.Average(x => x.AVALIACAO) == filter.Value.avaliacao);
                }

                lista = data.OrderByDescending(x => x.HORA)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize);

                var totalRecords = data.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                var Data = lista
                    .Include(x => x.Avaliacao)
                    .Include(x => x.Responsavel)
                    .Include(x => x.Respostas.Take(1))
                        .ThenInclude(x => x.Solicitante)
                    .Include(x => x.Respostas.Take(1))
                        .ThenInclude(x => x.Avaliacao)
                    .Include(x => x.Tema)
                    .Select(x => new PUBLICACAO_SOLICITACAODTO(x, false, false))
                    .AsEnumerable();

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<PUBLICACAO_SOLICITACAODTO>>>
                {
                    Data = PagedResponse.CreatePagedReponse(Data, filter, totalRecords),
                    Message = "Sucessfull",
                    Errors = [],
                    Succeeded = true
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }

        [HttpPost("publicacao/post")]
        [ProducesResponseType(typeof(Response<IEnumerable<PUBLICACAO_SOLICITACAO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult PostPublicacao([FromBody] PUBLICACAO_SOLICITACAO data)
        {
            try
            {
                BD.PUBLICACAO_SOLICITACAO.Add(new PUBLICACAO_SOLICITACAO
                {
                    TEXT_PUBLICACAO = data.TEXT_PUBLICACAO,
                    SUB_TEMA = data.SUB_TEMA,
                    MAT_RESPONSAVEL = data.MAT_RESPONSAVEL,
                    HORA = data.HORA
                });

                BD.SaveChanges();

                return new JsonResult(new Response<bool>
                {
                    Data = true,
                    Message = "Publicação enviada com sucesso!",
                    Errors = [],
                    Succeeded = true
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<bool>
                {
                    Data = false,
                    Message = "Algum erro Ocorreu",
                    Errors = [ex.Message, ex.InnerException?.Message ?? ""],
                    Succeeded = false
                });
            }
        }
        [HttpPost("publicacao/resposta/post")]
        [ProducesResponseType(typeof(Response<IEnumerable<RESPOSTA_PUBLICACAODTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult PostRespostaPublicacao([FromBody] RESPOSTA_PUBLICACAODTO data)
        {
            try
            {
                BD.RESPOSTA_PUBLICACAO.Add(new RESPOSTA_PUBLICACAO
                {
                    ID_SOLICITACAO_PUBLICACAO = data.ID_SOLICITACAO_PUBLICACAO,
                    HORA = data.HORA,
                    MAT_SOLICITANTE = data.MAT_SOLICITANTE,
                    TEXT_PUBLICACAO = data.TEXT_PUBLICACAO
                });

                BD.SaveChanges();

                return new JsonResult(new Response<bool>
                {
                    Data = true,
                    Message = "Resposta para a publicação enviada com sucesso!",
                    Errors = [],
                    Succeeded = true
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<bool>
                {
                    Data = false,
                    Message = "Algum erro Ocorreu",
                    Errors = [ex.Message, ex.InnerException?.Message ?? ""],
                    Succeeded = false
                });
            }
        }

        [HttpPost("Post/Avaliacao/Publicacao")]
        [ProducesResponseType(typeof(Response<IEnumerable<PUBLICACAO_SOLICITACAO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult PostAvaliacaoPublicacao([FromBody] AVALIACAO_PUBLICACAO data)
        {
            try
            {
                if (BD.AVALIACAO_PUBLICACAO.Where(x => x.MATRICULA_RESPONSAVEL == data.MATRICULA_RESPONSAVEL && x.ID_PUBLICACAO == data.ID_PUBLICACAO).Any())
                {
                    var saida = BD.AVALIACAO_PUBLICACAO.Where(x => x.MATRICULA_RESPONSAVEL == data.MATRICULA_RESPONSAVEL && x.ID_PUBLICACAO == data.ID_PUBLICACAO).First();
                    saida.AVALIACAO = data.AVALIACAO;
                }
                else
                {
                    BD.AVALIACAO_PUBLICACAO.Add(new AVALIACAO_PUBLICACAO
                    {
                        ID_PUBLICACAO = data.ID_PUBLICACAO,
                        MATRICULA_RESPONSAVEL = data.MATRICULA_RESPONSAVEL,
                        AVALIACAO = data.AVALIACAO
                    });
                }

                BD.SaveChanges();

                return new JsonResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException?.Message ?? ex.StackTrace);
                return new JsonResult(false);
            }
        }

    }
}
