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
using Shared_Static_Class.Model_DTO;

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
                        ex.InnerException?.Message ?? "no InnerException",
                        ex.Message,
                        ex.StackTrace ?? "no StackTrace"
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
                        ex.InnerException?.Message ?? "no InnerException",
                        ex.Message,
                        ex.StackTrace ?? "no StackTrace"
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
                var Getbyid = BD.PRODUTOS_CARDAPIO
                    .AsSplitQuery()
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
                    Getbyid.Imagens.Add(new PRODUTO_IMAGEM
                    {
                        Imagem = null,
                        ID_IMAGEM = countimages[i],
                        ID_PRODUTO = id
                    });
                }

                var Model = new CreateProdutoDTO
                {
                    Nome = Getbyid.Nome,
                    Descrição = Getbyid.Descrição,
                    Avaliacao = Getbyid.Avaliacao is not null ? new AvaliacaoDTO(Getbyid.Avaliacao.Avaliacao, Getbyid.Avaliacao.PositionInRank) : new(0, 0),
                    Categoria = Getbyid.Categoria_Produto,
                    Fabricante = Getbyid.Fabricante,
                    Cor = Getbyid.Cor,
                    IsOferta = Getbyid.IsOferta,
                    Valor = Getbyid.Valor,
                    MaxParcelas = Getbyid.MaxParcelas,
                    MaxParcelasSemJuros = Getbyid.MaxParcelasSemJuros,
                    Ficha = Getbyid.Ficha
                        .Select(x => new FichaTecnicaDTO(
                            x.Especificação,
                            x.Valor,
                            x.IsImportant,
                            x.IsInfoAdicional,
                            x.Categoria_Especificação)
                        ).ToList(),
                    Argumentacao = Getbyid.Argumentacao
                        .Select(x => new ArgumentacaoDTO(x.Argumentacao, x.DT_MODIFICACAO, x.SetAvaliacaoArgumentacaoGeral(), x.IsGold, x.IsBadCaracter, x.ID_ARGUMENTACAO,
                        x.Responsavel is not null ? new ACESSOS_MOBILE_DTO(x.Responsavel.EMAIL,
                        x.Responsavel.MATRICULA,
                        x.Responsavel.TELEFONE,
                        x.Responsavel.REGIONAL,
                        (Cargos)x.Responsavel.CARGO,
                        (Canal)x.Responsavel.CANAL,
                        x.Responsavel.PDV,
                        x.Responsavel.NOME,
                        x.Responsavel.UserAvatar) : null)).ToList(),
                    Imagens = Getbyid.Imagens.Select(x => new ProdutoImageDTO(x.Imagem, true, x.ID_IMAGEM)).ToList(),
                };

                return new JsonResult(new Response<CreateProdutoDTO>
                {
                    Data = Model,
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
                        ex.InnerException?.Message ?? "no InnerException",
                        ex.Message,
                        ex.StackTrace ?? "no StackTrace"
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
                        ex.InnerException?.Message ?? "no InnerException",
                        ex.Message,
                        ex.StackTrace ?? "no StackTrace"
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
                        ex.InnerException?.Message ?? "no InnerException",
                        ex.Message,
                        ex.StackTrace ?? "no StackTrace"
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
                        ex.InnerException?.Message ?? "no InnerException",
                        ex.Message,
                        ex.StackTrace ?? "no StackTrace"
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

                //IEnumerable<ARGUMENTACAO_OURO> NovaArgumentos = result.Argumentacao.Union(produto.Argumentacao.Where(x => x.ID_ARGUMENTACAO == Guid.Empty)).ToList();
                /** Une os perfis que estão no banco e os inseridos pelo usuário em uma lista, dá o distinct automaticamente **/
                IEnumerable<ARGUMENTACAO_OURO> ArgumentosExcluidos = result.Argumentacao.Where(x => !produto.Argumentacao.Where(y => y.ID_ARGUMENTACAO != Guid.Empty).Select(y => y.ID_ARGUMENTACAO).Contains(x.ID_ARGUMENTACAO)).ToList();
                /** Perfis que estão no banco e que não estão na união entre as 2 listas **/

                foreach (var argumentos in produto.Argumentacao)
                {
                    if (argumentos.ID_ARGUMENTACAO == Guid.Empty)
                    { /* Caso não haja Id Adicionamos*/
                        argumentos.ID_PRODUTO = produto.ID_PRODUTO;
                        BD.ARGUMENTACAO_OURO.Add(argumentos);
                    }
                    else
                    {/* Caso haja Id Atualizamos sua propriedades*/
                        var fichainDB = BD.ARGUMENTACAO_OURO.Find(argumentos.ID_ARGUMENTACAO);
                        if (fichainDB.Argumentacao != argumentos.Argumentacao)
                        {
                            fichainDB.Argumentacao = argumentos.Argumentacao;
                            fichainDB.MATRICULA_RESPONSAVEL = argumentos.MATRICULA_RESPONSAVEL;
                            fichainDB.DT_MODIFICACAO = argumentos.DT_MODIFICACAO;
                        }
                        fichainDB.IsBadCaracter = argumentos.IsBadCaracter;
                        fichainDB.IsGold = argumentos.IsGold;
                    }
                }

                foreach (var argumentos in ArgumentosExcluidos)
                {
                    //Exclui
                    BD.AVALIACAO_ARGUMENTACAO.RemoveRange(BD.AVALIACAO_ARGUMENTACAO.Where(x => x.ID_ARGUMENTACAO == argumentos.ID_ARGUMENTACAO));
                    BD.ARGUMENTACAO_OURO.Remove(argumentos);
                }

                #endregion

                var saida = BD.SaveChanges();

                return new JsonResult(new Response<PRODUTOS_CARDAPIO>
                {
                    Data = produto,
                    Succeeded = true,
                    Message = $"As informações do produto {result.Nome} foram atualizados"
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
                        ex.InnerException?.Message ?? "no InnerException",
                        ex.Message,
                        ex.StackTrace ?? "no StackTrace"
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
                         ex.InnerException?.Message ?? "no InnerException",
                        ex.Message,
                        ex.StackTrace ?? "no StackTrace"
                    },
                });
            }
        }
        [HttpPost("Post/Avaliacao/Argumento")]
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
                    result.Avaliacao = avaliacao.Avaliacao;
                    result.IsUtil = avaliacao.IsUtil;
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
