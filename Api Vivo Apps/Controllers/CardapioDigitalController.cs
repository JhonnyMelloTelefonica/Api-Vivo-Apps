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

using Shared_Static_Class.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using NuGet.Versioning;
using Microsoft.AspNetCore.OutputCaching;
using Shared_Razor_Components.FundamentalModels;

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

        [HttpGet("GetProductsNames")]
        [ProducesResponseType(typeof(Response<IEnumerable<dynamic>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = int.MaxValue, NoStore = false, Location = ResponseCacheLocation.Any)]
        [OutputCache(Duration = int.MaxValue, Tags = new string[] { "Product-Names" }, NoStore = false, VaryByHeaderNames = new string[] { "User-Agent" })]
        public JsonResult GetProductsNames()
        {
            try
            {
                var result = BD.PRODUTOS_CARDAPIO.IgnoreAutoIncludes()
                    .Select(x => new { Id = x.ID_PRODUTO, Name = x.Nome, Categoria = x.Categoria_Produto });

                return new JsonResult(new Response<IEnumerable<dynamic>>
                {
                    Data = result,
                    Succeeded = true,
                    Message = "Tudo certo."
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

        [HttpGet("Get")]
        [ProducesResponseType(typeof(Response<IEnumerable<PRODUTOS_CARDAPIO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Get()
        {
            try
            {
                //var result = BD.PRODUTOS_CARDAPIO
                //    .Include(x => x.Ficha)
                //    .Include(x => x.Imagens.First())
                //    .AsEnumerable();

                var result = BD.PRODUTOS_CARDAPIO
                    .Include(x => x.Avaliacao)
                    .Include(x => x.Argumentacao)
                    .Include(x => x.Ficha)
                    .Include(x => x.Imagens.Take(4))
                    .Take(10)
                    .AsEnumerable();

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

        [HttpGet("Get/{id}")]
        [ProducesResponseType(typeof(Response<PRODUTOS_CARDAPIO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Get(Guid id)
        {
            try
            {
                var result = BD.PRODUTOS_CARDAPIO
                    .Include(x => x.Ficha)
                    .Include(x => x.Avaliacao)
                    .Include(x => x.Argumentacao.OrderByDescending(y => y.DT_MODIFICACAO))
                        .ThenInclude(x => x.Responsavel)
                    .Include(x => x.Argumentacao)
                        .ThenInclude(x => x.Avaliacoes)
                    .IgnoreAutoIncludes()
                    .First(x => x.ID_PRODUTO == id);


                var countimages = BD.PRODUTO_IMAGENS
                    .Where(x => x.ID_PRODUTO == id)
                    .Select(x => x.ID_IMAGEM).ToArray();

                for (var i = 0; i < countimages.Count(); i++)
                {
                    result.Imagens.Add(new PRODUTO_IMAGEM
                    {
                        Imagem = null,
                        ID_IMAGEM = countimages[i],
                        ID_PRODUTO = id
                    });
                }

                return new JsonResult(new Response<PRODUTOS_CARDAPIO>
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

        [HttpGet("Image/{idImage}")]
        [ProducesResponseType(typeof(Response<PRODUTO_IMAGEM>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public IActionResult GetImages(Guid idImage)
        {
            var result = BD.PRODUTO_IMAGENS.Find(idImage);

            return Ok(result);
        }

        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Delete(Guid id)
        {
            try
            {
                var produto = BD.PRODUTOS_CARDAPIO.Find(id);
                var result = BD.PRODUTOS_CARDAPIO.Remove(produto);
                BD.SaveChangesAsync();

                return new JsonResult(new Response<string>
                {
                    Data = "Tudo certo",
                    Succeeded = true,
                    Message = $"O Produto {produto.Nome} e todas as informações complementares a ele foi excluído"
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

        [HttpPost("Post")]
        [ProducesResponseType(typeof(Response<PRODUTOS_CARDAPIO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Post([FromBody] PRODUTOS_CARDAPIO produto)
        {
            try
            {
                var result = BD.PRODUTOS_CARDAPIO.Add(produto);
                BD.SaveChangesAsync();

                return new JsonResult(new Response<PRODUTOS_CARDAPIO>
                {
                    Data = produto,
                    Succeeded = true,
                    Message = $"O Produto {produto.Nome} foi adicionado"
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

        [HttpPost("Post/Image")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Post([FromBody] PRODUTO_IMAGEM imagem)
        {
            try
            {
                var result = BD.PRODUTO_IMAGENS.Add(imagem);
                BD.SaveChangesAsync();

                return new JsonResult(new Response<string>
                {
                    Data = $"Tudo Certo",
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

        [HttpPut("Put")]
        [ProducesResponseType(typeof(Response<PRODUTOS_CARDAPIO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Put([FromBody] PRODUTOS_CARDAPIO produto)
        {
            try
            {
                var result = BD.PRODUTOS_CARDAPIO
                    .Include(x => x.Avaliacao)
                    .Include(x => x.Argumentacao)
                    .Include(x => x.Ficha)
                    .First(x => x.ID_PRODUTO == produto.ID_PRODUTO);

                #region Update Principais Info
                result.Nome = produto.Nome;
                result.Descrição = produto.Descrição;
                result.Avaliacao = produto.Avaliacao;

                result.Avaliacao.Avaliacao = produto.Avaliacao.Avaliacao;
                result.Avaliacao.IsInHotSpot = produto.Avaliacao.IsInHotSpot;
                result.Avaliacao.PositionInRank = produto.Avaliacao.PositionInRank;

                result.Categoria_Produto = produto.Categoria_Produto;
                result.Fabricante = produto.Fabricante;
                result.Cor = produto.Cor;
                result.IsOferta = produto.IsOferta;
                result.Valor = produto.Valor;
                result.MaxParcelas = produto.MaxParcelas;
                result.MaxParcelasSemJuros = produto.MaxParcelasSemJuros;
                #endregion

                #region Update Ficha Técina
                IEnumerable<FICHA_TECNICA> NovaFicha = result.Ficha.Union(produto.Ficha).ToList();
                /** Une os perfis que estão no banco e os inseridos pelo usuário em uma lista, dá o distinct automaticamente **/
                IEnumerable<FICHA_TECNICA> FichaExcluida = result.Ficha.ExceptBy(produto.Ficha.Select(x => x.ID_FICHA), x => x.ID_FICHA).ToList();
                /** Perfis que estão no banco e que não estão na união entre as 2 listas **/

                foreach (var ficha in NovaFicha)
                {
                    if (ficha.ID_FICHA == Guid.Empty)
                    { /* Caso não haja Id Adicionamos*/
                        BD.FICHA_TECNICA.Add(ficha);
                    }
                    else
                    {/* Caso haja Id Atualizamos sua propriedades*/
                        var fichainDB = BD.FICHA_TECNICA.Find(ficha.ID_FICHA);

                        fichainDB.Especificação = ficha.Especificação;
                        fichainDB.Valor = ficha.Valor;
                        fichainDB.IsImportant = ficha.IsImportant;
                        fichainDB.IsInfoAdicional = ficha.IsInfoAdicional;
                        fichainDB.Categoria_Especificação = ficha.Categoria_Especificação;
                    }
                }

                foreach (var ficha in FichaExcluida)
                {
                    /* Caso Esteja na lista é uma imagem deletada*/
                    BD.FICHA_TECNICA.Remove(ficha);
                }
                #endregion

                #region Update Argumentos

                IEnumerable<ARGUMENTACAO_OURO> NovaArgumentos = result.Argumentacao.Union(produto.Argumentacao).ToList();
                /** Une os perfis que estão no banco e os inseridos pelo usuário em uma lista, dá o distinct automaticamente **/
                IEnumerable<ARGUMENTACAO_OURO> ArgumentosExcluidos = result.Argumentacao.ExceptBy(produto.Argumentacao.Select(x => x.ID_ARGUMENTACAO), x => x.ID_ARGUMENTACAO).ToList();
                /** Perfis que estão no banco e que não estão na união entre as 2 listas **/

                foreach (var argumentos in NovaArgumentos)
                {
                    if (argumentos.ID_ARGUMENTACAO == Guid.Empty)
                    { /* Caso não haja Id Adicionamos*/
                        argumentos.ID_PRODUTO = produto.ID_PRODUTO;
                        BD.ARGUMENTACAO_OURO.Add(argumentos);
                    }
                    else
                    {/* Caso haja Id Atualizamos sua propriedades*/
                        var fichainDB = BD.ARGUMENTACAO_OURO.Find(argumentos.ID_ARGUMENTACAO);

                        fichainDB.Argumentacao = argumentos.Argumentacao;
                        fichainDB.MATRICULA_RESPONSAVEL = argumentos.MATRICULA_RESPONSAVEL;
                        fichainDB.IsBadCaracter = argumentos.IsBadCaracter;
                        fichainDB.DT_MODIFICACAO = argumentos.DT_MODIFICACAO;
                        fichainDB.IsGold = argumentos.IsGold;
                    }
                }

                foreach (var argumentos in ArgumentosExcluidos)
                {
                    /* Caso Esteja na lista é uma imagem deletada*/
                    BD.ARGUMENTACAO_OURO.Remove(argumentos);
                }
                #endregion

                var saida = BD.SaveChanges();

                return new JsonResult(new Response<PRODUTOS_CARDAPIO>
                {
                    Data = produto,
                    Succeeded = true,
                    Message = $"Os dados do produto {result.Nome} foi atualizado"
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

        [HttpDelete("Delete/Image")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Delete([FromBody] PRODUTO_IMAGEM imagem)
        {
            try
            {
                BD.PRODUTO_IMAGENS.Remove(imagem);

                BD.SaveChanges();

                return new JsonResult(new Response<string>
                {
                    Data = $"Tudo Certo",
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
        [HttpDelete("Post/Avaliacao/Argumento")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public IActionResult PostAvaliacaoToArgumento([FromBody] AVALIACAO_ARGUMENTACAO avaliacao)
        {
            try
            {
                if (BD.AVALIACAO_ARGUMENTACAO.Any(x => x.MATRICULA_RESPONSAVEL == avaliacao.MATRICULA_RESPONSAVEL && x.ID_ARGUMENTACAO == avaliacao.ID_ARGUMENTACAO))
                {
                    var result = BD.AVALIACAO_ARGUMENTACAO.Where(x => x.MATRICULA_RESPONSAVEL == avaliacao.MATRICULA_RESPONSAVEL && x.ID_ARGUMENTACAO == avaliacao.ID_ARGUMENTACAO).First();
                    result.DT_MODIFICACAO = DateTime.Now;
                    result.Avaliacao = result.Avaliacao;
                    result.IsUtil = result.IsUtil;
                }
                else
                {
                    BD.AVALIACAO_ARGUMENTACAO.Add(avaliacao);
                }

                BD.SaveChanges();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(true);
            }
        }


    }
}
