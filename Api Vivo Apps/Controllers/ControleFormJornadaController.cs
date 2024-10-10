using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Vivo_Apps_API.Models;
using Shared_Static_Class.Data;
using System.Drawing;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Shared_Static_Class.Enums;
using Microsoft.AspNetCore.Components.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System;
using AutoMapper;
using static Shared_Static_Class.Model_DTO.JORNADA_DTO;
using AutoMapper.QueryableExtensions;
using Shared_Static_Class.Converters;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using static Vivo_Apps_API.Models.Converters.Converters;

using Shared_Class_Vivo_Apps.ModelDTO;
using Microsoft.Extensions.Caching.Distributed;
using DocumentFormat.OpenXml.Office2010.Excel;
using Blazorise;
using Shared_Razor_Components.FundamentalModels;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControleFormJornadaController : ControllerBase
    {
        private Vivo_MaisContext CD = new Vivo_MaisContext();

        private readonly ILogger<ControleFormJornadaController> _logger;
        private readonly IMapper _mapper;

        public ControleFormJornadaController(ILogger<ControleFormJornadaController> logger)
        {
            _logger = logger;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JORNADA_BD_AVALIACAO_RETORNO, AVALIACAO_RETORNO_DTO>()
                .ForMember(
                    dest => dest.ID_SUB_TEMAS,
                    opt => opt.MapFrom(src =>
                    CD.JORNADA_BD_TEMAS_SUB_TEMAs
                        .Where(x => x.ID_SUB_TEMAS == src.ID_SUB_TEMAS.Value)
                        .FirstOrDefault().SUB_TEMAS
                        ));

                cfg.CreateMap<JORNADA_BD_QUESTION_HISTORICO, PROVA_REALIZADA_DTO>()
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => src.CANAL.HasValue ? (Canal)src.CANAL.Value : Canal.ADM))
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => src.CARGO.HasValue ? (Cargos)src.CARGO.Value : Cargos.ADM))
                .ForMember(
                    dest => dest.ID_CRIADOR,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.First(x => x.MATRICULA == src.ID_CRIADOR))
                    //)
                    //.ForMember(
                    //    dest => dest.Qtd_Respostas,
                    //    opt => opt.MapFrom(src => CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(y => y.ID_PROVA == src.ID_PROVA).Count()))
                    //.ForMember(
                    //    dest => dest.Qtd_Perguntas,
                    //    opt => opt.MapFrom(src => CD.JORNADA_BD_QUESTION_HISTORICOs.Where(y => y.ID_PROVA == src.ID_PROVA).Count()))
                    //.ForMember(
                    //    dest => dest.Sum_nota,
                    //    opt => opt.MapFrom(src => CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(y => y.ID_PROVA == src.ID_PROVA).Select(x => x.NOTA).Sum())
                    );


                cfg.CreateMap<JORNADA_BD_QUESTION_HISTORICO, DETALHADO_PROVA_CRIADA_DTO>()
                .ForMember(
                    dest => dest.Questions,
                    opt => opt.MapFrom(src => CD.JORNADA_BD_QUESTIONs.Where(x =>
                                CD.JORNADA_BD_QUESTION_HISTORICOs.Where(y => y.ID_PROVA == src.ID_PROVA)
                                .Select(y => y.ID_QUESTION).Contains(x.ID_QUESTION)
                                )))
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => ((Canal)src.CANAL)))
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => ((Cargos)src.CARGO)))
                .ForMember(
                    dest => dest.ID_CRIADOR,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == src.ID_CRIADOR).FirstOrDefault()));

                cfg.CreateMap<JORNADA_BD_QUESTION, JORNADA_QUESTION_DTO>()
                .ForMember(
                    dest => dest.Alternativas,
                    opt => opt.MapFrom(src => CD.JORNADA_BD_ANSWER_ALTERNATIVAs
                                            .Where(x => x.ID_QUESTION == src.ID_QUESTION)))
                .ForMember(
                    dest => dest.TEMA,
                    opt => opt.MapFrom(src => CD.JORNADA_BD_TEMAS_SUB_TEMAs
                                            .Where(x => x.ID_TEMAS.Value == src.ID_TEMAS.Value)
                                            .FirstOrDefault().TEMAS))
                .ForMember(
                    dest => dest.SUB_TEMA,
                    opt => opt.MapFrom(src => CD.JORNADA_BD_TEMAS_SUB_TEMAs
                                            .Where(x => x.ID_SUB_TEMAS == src.ID_SUB_TEMAS.Value)
                                            .FirstOrDefault().SUB_TEMAS))
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => ConvertStringToEnumList<Cargos>(src.CARGO)))
                .ForMember(
                    dest => dest.TP_FORMS,
                    opt => opt.MapFrom(src => ConvertStringToStringList(src.TP_FORMS)));

                //cfg.CreateMap<JORNADA_BD_QUESTION, JORNADA_ANSWER_USER>()
                //.ForMember(
                //    dest => dest.Alternativas,
                //    opt => opt.MapFrom(src => CD.JORNADA_BD_ANSWER_ALTERNATIVAs
                //                            .Where(x => x.ID_QUESTION == src.ID_QUESTION)));

                cfg.CreateMap<JORNADA_BD_QUESTION_HISTORICO, AVALIADOS_PROVA_DTO>()
                .ForMember(
                    dest => dest.UsersAvaliados,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.Where(k =>
                                CD.JORNADA_BD_ANSWER_AVALIACAOs
                                .Where(y => y.ID_PROVA == src.ID_PROVA)
                                .Select(y => y.RE_AVALIADO)
                                .Contains(k.MATRICULA)).Select(x => new ACESSOS_MOBILE_AVALIACAO
                                {
                                    ID = x.ID,
                                    EMAIL = x.EMAIL,
                                    MATRICULA = x.MATRICULA,
                                    PDV = x.PDV,
                                    NOME = x.NOME,
                                    UserAvatar = x.UserAvatar,
                                    PROVA_REALIZADA = CD.JORNADA_BD_ANSWER_AVALIACAOs
                                        .Where(y => y.RE_AVALIADO == x.MATRICULA && y.ID_PROVA == src.ID_PROVA)
                                        .FirstOrDefault()
                                })));

                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_AVALIACAO>();
            });

            _mapper = config.CreateMapper();
        }

        [HttpGet("GetDataCriarFormulario")]
        [ProducesResponseType(typeof(Response<IEnumerable<Option<int>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetDataCriarFormulario()
        {
            try
            {
                var list = new List<Cargos>() {
                    Cargos.Gerente_Senior_Territorial,
                    Cargos.Coordenador_Suporte_Vendas,
                    Cargos.Gerente_Suporte_Vendas,
                    Cargos.Diretora,
                    Cargos.Consultor_Gestão_Vendas,
                    Cargos.Analista_Suporte_Vendas_Senior,
                    Cargos.Analista_Suporte_Vendas_Pleno,
                    Cargos.Analista_Suporte_Vendas_Junior,
                    Cargos.Estagiário,
                    Cargos.Gerente_Senior_Gestão_Vendas,
                    Cargos.Gerente_Senior_Territorial,
                    Cargos.Gerente_Vendas_B2C,
                    Cargos.ADM
                };

                IEnumerable<Option<int>> cargos = Enum.GetValues(typeof(Cargos))
                    .Cast<Cargos>().ToList().Where(x => !list.Contains(x))
                    .Select(x => new Option<int>(Convert.ToInt32(x), x.GetDisplayName()));

                return new JsonResult(new Response<IEnumerable<Option<int>>>
                {
                    Data = cargos,
                    Succeeded = true,
                    Message = "Tudo certo, alteração solicitada com sucesso!",
                    Errors = null,
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

        [HttpGet("Get_Qtd_Tema")]
        [ProducesResponseType(typeof(Response<int>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> Get_Qtd_Tema(
                string TIPO_PROVA,
                int CARGO,
                bool FIXA,
                string REGIONAL,
                int TEMA)
        {
            try
            {
                if (TIPO_PROVA == "Jornada Gestor")
                {
                    TIPO_PROVA = "Jornada";
                }

                var dadosDoBanco = CD.JORNADA_BD_QUESTIONs.ToList();

                int qtd = dadosDoBanco
                           .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                           .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(TIPO_PROVA))
                           .Where(k => (FIXA == false ? k.FIXA == FIXA : k.FIXA != null))
                           .Where(x => x.REGIONAL == REGIONAL)
                           .Where(x => x.ID_TEMAS.Value == TEMA)
                           .Where(x => x.STATUS_QUESTION == true)
                           .Count();

                return new JsonResult(new Response<int>
                {
                    Data = qtd,
                    Succeeded = true,
                    Message = "Tudo Certo!"
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

        [HttpGet("Get_Qtd_SubTema")]
        [ProducesResponseType(typeof(Response<int>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> Get_Qtd_SubTema(
                string TIPO_PROVA,
                int CARGO,
                bool FIXA,
                string REGIONAL,
                int SUB_TEMA)
        {
            try
            {
                if (TIPO_PROVA == "Jornada Gestor")
                {
                    TIPO_PROVA = "Jornada";
                }

                var dadosDoBanco = CD.JORNADA_BD_QUESTIONs.ToList();

                int qtd = dadosDoBanco
                           .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                           .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(TIPO_PROVA))
                           .Where(k => (FIXA == false ? k.FIXA == FIXA : k.FIXA != null))
                           .Where(x => x.ID_TEMAS.Value == SUB_TEMA)
                           .Where(x => x.REGIONAL == REGIONAL)
                           .Where(x => x.STATUS_QUESTION == true)
                           .Count();

                return new JsonResult(new Response<int>
                {
                    Data = qtd,
                    Succeeded = true,
                    Message = "Tudo Certo!"
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

        [HttpGet("GetTemasCriarFormulario")]
        [ProducesResponseType(typeof(Response<IEnumerable<TEMA_SUB_TEMA_QTD>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetTemasCriarFormulario(
                string TIPO_PROVA,
                string REGIONAL,
                int CARGO,
                bool FIXA)
        {
            try
            {
                if (TIPO_PROVA == "Jornada Gestor")
                {
                    TIPO_PROVA = "Jornada";
                }

                var dadosDoBanco = CD.JORNADA_BD_QUESTIONs.AsEnumerable();

                // Parte 1: Consulta executada no banco de dados
                var dadosDoBancoFiltrados = dadosDoBanco
                    .Where(x => x.STATUS_QUESTION.Value == true)
                    .Where(x => x.CARGO.Split(new[] { ';' }).Contains(CARGO.ToString()))
                    .Where(y => y.TP_FORMS.Split(new[] { ';' }).Contains(TIPO_PROVA))
                    .Where(k => (FIXA == false ? k.FIXA == FIXA : k.FIXA != null))
                    .Where(k => k.REGIONAL == REGIONAL)
                    .ToList(); // Aqui trazemos os dados do banco para a memória

                List<int> temas_id = dadosDoBancoFiltrados
                            .Select(x => x.ID_TEMAS.Value)
                            .ToList();

                // Parte 2: Consulta executada no lado do cliente (em memória)
                IEnumerable<TEMA_SUB_TEMA_QTD> temas = CD.JORNADA_BD_TEMAS_SUB_TEMAs
                    .Where(x => temas_id.Contains(x.ID_TEMAS.Value)).ToList()
                    .Select(x => new TEMA_SUB_TEMA_QTD
                    {
                        ID_SUB_TEMAS = x.ID_SUB_TEMAS,
                        SUB_TEMAS = x.SUB_TEMAS,
                        ID_TEMAS = x.ID_TEMAS,
                        TEMAS = x.TEMAS,
                        QTD_TEMA = dadosDoBancoFiltrados
                            .Where(f => f.ID_TEMAS == x.ID_TEMAS)
                            .Count(),
                        QTD_SUB_TEMA = dadosDoBancoFiltrados
                            .Where(f => f.ID_SUB_TEMAS == x.ID_SUB_TEMAS)
                            .Count()
                    })
                    .ToList();

                if (temas.Any())
                {
                    return new JsonResult(new Response<IEnumerable<TEMA_SUB_TEMA_QTD>>
                    {
                        Data = temas,
                        Succeeded = true,
                        Message = "Tudo certo, alteração solicitada com sucesso!",
                        Errors = null,
                    });
                }
                else
                {
                    return new JsonResult(new Response<IEnumerable<TEMA_SUB_TEMA_QTD>>
                    {
                        Data = temas,
                        Succeeded = false,
                        Message = "Não encontramos nenhum tema ou sub-tema correspondente aos seus filtros!",
                        Errors = new string[]
                        {
                            "tema não encontrado"
                        },
                    });
                }
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

        [HttpGet("GetTemasCriarFormularioDetalhado")]
        [ProducesResponseType(typeof(Response<IEnumerable<TEMA_SUB_TEMA_QTD>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetTemasCriarFormularioDetalhado(
            string Tipo_prova,
            bool? Elegiveis,
            Cargos Cargo,
            bool? Fixa,
            bool? Banco_Completo,
            string regional)
        {
            try
            {
                if (Tipo_prova == "Jornada Gestor")
                {
                    Tipo_prova = "Jornada";
                }

                var dadosDoBanco = CD.JORNADA_BD_QUESTIONs.ToList();

                // Parte 1: Consulta executada no banco de dados
                var dadosDoBancoFiltrados = dadosDoBanco
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains((int)Cargo))
                    .Where(y => y.TP_FORMS.Split(new[] { ';' }).Contains(Tipo_prova))
                    .Where(k => (Fixa.HasValue ? k.FIXA == Fixa.Value : k.FIXA != null));

                if (Banco_Completo.HasValue)
                {
                    if (!Banco_Completo.Value)
                    {
                        dadosDoBancoFiltrados = dadosDoBancoFiltrados
                            .Where(k => k.REGIONAL == regional); // Aqui trazemos os dados do banco para a memória
                    }

                }

                IEnumerable<int> temas_id = dadosDoBancoFiltrados
                            .Select(x => x.ID_TEMAS.Value);

                // Parte 2: Consulta executada no lado do cliente (em memória)
                IEnumerable<TEMA_SUB_TEMA_QTD> temas = CD.JORNADA_BD_TEMAS_SUB_TEMAs
                    .Where(x => temas_id.Contains(x.ID_TEMAS.Value))
                    .Select(x => new TEMA_SUB_TEMA_QTD
                    {
                        ID_SUB_TEMAS = x.ID_SUB_TEMAS,
                        SUB_TEMAS = x.SUB_TEMAS,
                        ID_TEMAS = x.ID_TEMAS,
                        TEMAS = x.TEMAS,
                        QTD_TEMA = dadosDoBancoFiltrados
                            .Where(f => f.ID_TEMAS == x.ID_TEMAS)
                            .Count(),
                        QTD_SUB_TEMA = dadosDoBancoFiltrados
                            .Where(f => f.ID_SUB_TEMAS == x.ID_SUB_TEMAS)
                            .Count()
                    })
                    .ToList();

                if (temas.Any())
                {
                    return new JsonResult(new Response<IEnumerable<TEMA_SUB_TEMA_QTD>>
                    {
                        Data = temas,
                        Succeeded = true,
                        Message = "Tudo certo, alteração solicitada com sucesso!",
                        Errors = null,
                    });
                }
                else
                {
                    return new JsonResult(new Response<IEnumerable<TEMA_SUB_TEMA_QTD>>
                    {
                        Data = temas,
                        Succeeded = false,
                        Message = "Não encontramos nenhum tema ou sub-tema correspondente aos seus filtros!",
                        Errors = new string[]
                        {
                            "tema não encontrado"
                        },
                    });
                }
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

        [HttpGet("GetQuestionsBySubTema")]
        [ProducesResponseType(typeof(Response<IEnumerable<JORNADA_QUESTION_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetQuestionsBySubTema(
            int subtema)
        {
            try
            {
                var questions = CD.JORNADA_BD_QUESTIONs
                    .Where(x => x.ID_SUB_TEMAS == subtema)
                    .ProjectTo<JORNADA_QUESTION_DTO>(_mapper.ConfigurationProvider);

                return new JsonResult(new Response<IEnumerable<JORNADA_QUESTION_DTO>>
                {
                    Data = questions,
                    Succeeded = true,
                    Message = "Tudo Certo!",
                    Errors = null,
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

        [HttpPost("CreateFormulario")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> CreateFormulario(
               [FromBody] List<TEMAS_QTD>? TEMAS_QUANTIDADE,
               string TIPO_PROVA,
               int CARGO,
               bool FIXA,
               string REGIONAL,
               int MATRICULA,
               string DT_INIT,
               string? DT_FINAL,
               int QTD_TOTAL_SOLICITADA,
               bool ELEGIVEL
           )
        {
            try
            {
                List<JORNADA_BD_QUESTION> Formulario = new List<JORNADA_BD_QUESTION>(); // LISTA ONDE SERÁ INSERIDA AS PERGUNTAS
                var matricula = MATRICULA;
                string rota = TIPO_PROVA;
                Random random = new Random();
                bool FormularioExistente;
                bool QuestoesRepetidas = false;
                int proximocaderno = 0;

                if (rota.Equals("Rota Cruzada"))
                {
                    FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
                        .Where(x => x.CARGO == CARGO)
                        .Where(x => x.ID_CRIADOR == matricula)
                        .Where(x => x.REGIONAL == REGIONAL)
                        .Where(x => x.TP_FORMS == rota)
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        var maxcaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                            .Where(x => x.CARGO == CARGO)
                            .Where(x => x.ID_CRIADOR == matricula)
                            .Where(x => x.REGIONAL == REGIONAL)
                            .Where(x => x.TP_FORMS == "Rota Cruzada")
                            .Where(x => x.FIXA == FIXA)
                            .Select(y => y.CADERNO).Max());

                        //vai buscar a ultima prova com os parametros passados
                        var datafinal = CD.JORNADA_BD_QUESTION_HISTORICOs
                            .Where(x => x.CARGO == CARGO)
                            .Where(x => x.ID_CRIADOR == matricula)
                            .Where(x => x.TP_FORMS == "Rota Cruzada")
                            .Where(x => x.REGIONAL == REGIONAL)
                            .Where(x => x.FIXA == FIXA)
                            .Where(x => x.CADERNO == maxcaderno)
                            .Select(x => x.DT_FINALIZACAO).FirstOrDefault();

                        if (!datafinal.HasValue) //significa que o formulário não está finalizado logo há um fomulário do mesmo tipo ativo
                        {
                            return new JsonResult(new Response<string>
                            {
                                Data = "Tentativa de criação de formulário repetido",
                                Succeeded = false,
                                Message = "Desculpe já existe uma prova com os mesmos filtros associados ao seu usuário onde ainda não foi finalizada, por favor finalize a prova e tente novamente",
                                Errors = null,
                            });
                        }

                        proximocaderno = maxcaderno + 1;
                    }
                    else
                    {
                        proximocaderno = 1;
                    }
                    for (int i = 0; i < TEMAS_QUANTIDADE.Count; i++)
                    {
                        InsertQuestionsRotaCruzadaIntoForm(REGIONAL, TEMAS_QUANTIDADE, CARGO, FIXA, QuestoesRepetidas, Formulario, FormularioExistente, matricula, random, i);
                    }
                }
                else if (rota.Equals("Jornada"))
                {
                    if (DT_FINAL is null)
                    {
                        DT_FINAL = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                    }

                    FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
                        .Where(x => x.CARGO == CARGO)
                        .Where(x => x.TP_FORMS == rota)
                        .Where(x => x.REGIONAL == REGIONAL)
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                            .Where(x => x.CARGO == CARGO)
                            .Where(x => x.TP_FORMS == rota)
                            .Where(x => x.REGIONAL == REGIONAL)
                            .Where(x => x.FIXA == FIXA)
                            .Select(y => y.CADERNO).Max() + 1);
                    }
                    else
                    {
                        proximocaderno = 1;
                    }

                    for (int i = 0; i < TEMAS_QUANTIDADE.Count(); i++)
                    {
                        InsertQuestionsJornadaIntoForm(REGIONAL, TEMAS_QUANTIDADE, CARGO, FIXA, QuestoesRepetidas, Formulario, FormularioExistente, rota, random, i);
                    }
                }
                else if (rota.Equals("Jornada Gestor"))
                {
                    if (DT_FINAL is null)
                    {
                        DT_FINAL = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                    }

                    FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
                        .Where(x => x.CARGO == CARGO)
                        .Where(x => x.TP_FORMS == rota)
                        .Where(x => x.REGIONAL == REGIONAL)
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                            .Where(x => x.CARGO == CARGO)
                            .Where(x => x.TP_FORMS == rota)
                            .Where(x => x.REGIONAL == REGIONAL)
                            .Where(x => x.FIXA == FIXA)
                            .Select(y => y.CADERNO).Max() + 1);
                    }
                    else
                    {
                        proximocaderno = 1;
                    }

                    for (int i = 0; i < TEMAS_QUANTIDADE.Count(); i++)
                    {
                        InsertQuestionsJornadaGestorIntoForm(REGIONAL, TEMAS_QUANTIDADE, CARGO, FIXA, QuestoesRepetidas, Formulario, FormularioExistente, rota, random, i);
                    }
                }


                if (Formulario.Count() <= 0 || Formulario is null)
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Algum erro ocorreu",
                        Succeeded = false,
                        Message = "Não foi encontrado nenhuma pergunta com esses filtros para o formulário",
                        Errors = new string[]
                        {
                            "Lista de perguntas retornou vazia"
                        },
                    });
                }

                if (Formulario.Count() < QTD_TOTAL_SOLICITADA)
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Algum erro ocorreu",
                        Succeeded = false,
                        Message = "A quantidade total de perguntadas encontradas não foi suficiente para o preenchimento do formulário",
                        Errors = new string[]
                        {
                            "Lista de perguntas retornou vazia"
                        },
                    });
                }

                InsertQuestionsIntoForm(REGIONAL, TIPO_PROVA, CARGO, FIXA, MATRICULA, DT_INIT, DT_FINAL, Formulario, proximocaderno);

                await CD.SaveChangesAsync();

                if (QuestoesRepetidas)
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Tudo certo!",
                        Succeeded = true,
                        Message = "Você excedeu a quantidade total de questões disponíveis para formulários com estes parâmetros, foi necessário repetir questões mas o formulário foi criado corretamente",
                        Errors = null,
                    });
                }
                else
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Tudo certo!",
                        Succeeded = true,
                        Message = "O formulário foi criado corretamente",
                        Errors = null,
                    });
                }
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

        [HttpGet("GetFormsRotaByUser")]
        [ProducesResponseType(typeof(Response<IEnumerable<JORNADA_BD_QUESTION_HISTORICO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetFormsRotaByUser(int CARGO, int MATRICULA, bool FIXA, string REGIONAL)
        {
            try
            {
                List<JORNADA_BD_QUESTION_HISTORICO> questionsjornada;
                bool resposta;

                List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor;

                List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestorDivisao;

                List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGA;

                List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGGP;

                List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGV;

                var userGet = CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == MATRICULA).FirstOrDefault();

                IEnumerable<Cargos> CargosProvaGa = new List<Cargos> // Cargos que iram ver prova de GA
                {
                    Cargos.Vendedor_PAP,
                    Cargos.Supervisor_PAP,
                    Cargos.Vendedor_Revenda,
                    Cargos.Gerente_Revenda,
                    Cargos.Gerente_de_area_PAP,
                    Cargos.Representante_de_vendas
                };

                IEnumerable<Cargos> CargosProvaGGP = new List<Cargos> // Cargos que iram ver prova de GGP
                {
                    Cargos.Vendedor_PAP,
                    Cargos.Supervisor_PAP,
                    Cargos.Vendedor_Revenda,
                    Cargos.Gerente_Revenda,
                    Cargos.Gerente_Área,
                    Cargos.Gerente_de_area_PAP,
                    Cargos.Representante_de_vendas
                };

                IEnumerable<Cargos> CargosProvaGV = new List<Cargos> // Cargos que iram ver prova de GV
                {
                    Cargos.Vendedor_PAP,
                    Cargos.Supervisor_PAP,
                    Cargos.Vendedor_Revenda,
                    Cargos.Gerente_Revenda,
                    Cargos.Gerente_Área,
                    Cargos.Gerente_Geral,
                    Cargos.Gerente_Operações,
                    Cargos.Consultor_Negócios,
                    Cargos.Consultor_Tecnológico,
                    Cargos.Gerente_de_area_PAP,
                    Cargos.Representante_de_vendas
                };

                IEnumerable<Cargos> CargosProvaDivisao = new List<Cargos> // Cargos que iram ver prova de Divisão
                {
                    Cargos.Vendedor_PAP,
                    Cargos.Supervisor_PAP,
                    Cargos.Vendedor_Revenda,
                    Cargos.Gerente_Revenda,
                    Cargos.Gerente_Área,
                    Cargos.Gerente_Geral,
                    Cargos.Gerente_Operações,
                    Cargos.Gerente_Parceiros,
                    Cargos.Consultor_Negócios,
                    Cargos.Consultor_Tecnológico,
                    Cargos.Gerente_Vendas_B2C,
                    Cargos.Gerente_de_area_PAP,
                    Cargos.Representante_de_vendas
                };

                IEnumerable<Cargos> CargosProvaJornadaGestorDireto = new List<Cargos> // Cargos que iram ver prova de Gestor Direto
                {
                    Cargos.Vendedor_PAP,
                    Cargos.Supervisor_PAP,
                    Cargos.Vendedor_Revenda,
                    Cargos.Gerente_Revenda,
                    Cargos.Gerente_Operações,
                    Cargos.Consultor_Negócios,
                    Cargos.Consultor_Tecnológico,
                    Cargos.Representante_de_vendas
                };

                // Busca Provas de Rota
                List<JORNADA_BD_QUESTION_HISTORICO> questions = GetListaProvasRotaCruzadaDisponiveis(MATRICULA);

                // Busca Provas de Jornada Regional
                GetListaProvasJornadaDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, out questionsjornada, out resposta);

                if (CargosProvaJornadaGestorDireto.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada 1-1 em PDV
                    GetListaProvasJornadaGestorDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, out questionsjornadaGestor);
                }
                else
                {
                    questionsjornadaGestor = new();
                }

                if (CargosProvaDivisao.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada por Divisão
                    GetListaProvasJornadaGestorDivisaoDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, out questionsjornadaGestorDivisao);
                }
                else
                {
                    questionsjornadaGestorDivisao = new();
                }

                if (CargosProvaGa.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada por GA
                    GetListaProvasJornadaGestorGADisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, out questionsjornadaGA);
                }
                else
                {
                    questionsjornadaGA = new();
                }
                if (CargosProvaGGP.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada por GGP
                    GetListaProvasJornadaGestorGGPDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, out questionsjornadaGGP);
                }
                else
                {
                    questionsjornadaGGP = new();
                }
                if (CargosProvaGV.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada por GV
                    GetListaProvasJornadaGestorGVDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, out questionsjornadaGV);
                }
                else
                {
                    questionsjornadaGV = new();
                }

                if (!resposta)
                {
                    questions.AddRange(questionsjornada);
                }

                if (questionsjornadaGestor is not null)
                {
                    if (questionsjornadaGestor.Any())
                    {
                        questions.AddRange(questionsjornadaGestor);
                    }
                }

                if (questionsjornadaGestorDivisao.Any())
                {
                    questions.AddRange(questionsjornadaGestorDivisao);
                }

                if (questionsjornadaGA.Any())
                {
                    questions.AddRange(questionsjornadaGA);
                }
                if (questionsjornadaGGP.Any())
                {
                    questions.AddRange(questionsjornadaGGP);
                }
                if (questionsjornadaGV.Any())
                {
                    questions.AddRange(questionsjornadaGV);
                }

                return new JsonResult(new Response<IEnumerable<JORNADA_BD_QUESTION_HISTORICO>>
                {
                    Data = questions,
                    Succeeded = true,
                    Message = "Tudo certo, alteração solicitada com sucesso!",
                    Errors = null,
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

        [HttpGet("FinalizarForm")]
        [ProducesResponseType(typeof(Response<IEnumerable<JORNADA_BD_QUESTION_HISTORICO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult FinalizarForm(
            string ID_CRIADOR
            , int CARGO
            , int CADERNO
            , string TP_FORMS
            , bool FIXA)
        {

            try
            {
                IEnumerable<JORNADA_BD_QUESTION_HISTORICO> questionatualizada = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(x => x.ID_CRIADOR == int.Parse(ID_CRIADOR))
                    .Where(x => x.FIXA == FIXA)
                    .Where(x => x.CARGO == CARGO)
                    .Where(x => x.TP_FORMS == TP_FORMS)
                    .Where(x => x.CADERNO == CADERNO).AsEnumerable();

                foreach (var item in questionatualizada)
                {
                    item.DT_FINALIZACAO = DateTime.Now;
                }

                CD.SaveChanges();

                return new JsonResult(new Response<IEnumerable<JORNADA_BD_QUESTION_HISTORICO>>
                {
                    Data = questionatualizada,
                    Succeeded = true,
                    Message = "Tudo certo, O Formulário foi finalizado com sucesso!",
                    Errors = null,
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

        [HttpPost("GetForm")]
        [ProducesResponseType(typeof(Response<List<QUESTIONS>>), 200)]
        public JsonResult GetForm(int ID_PROVA)
        {
            try
            {
                var questions = CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.ID_PROVA == ID_PROVA).Select(x => x.ID_QUESTION).ToList();

                var data = CD.JORNADA_BD_QUESTIONs.Where(x => questions.Contains(x.ID_QUESTION))
                .Select(x => new QUESTIONS
                {
                    ID_QUESTION = x.ID_QUESTION,
                    TEMA = CD.JORNADA_BD_TEMAS_SUB_TEMAs.Where(y => y.ID_TEMAS == x.ID_TEMAS).ToList(),
                    TP_FORMS = x.TP_FORMS,
                    TP_QUESTAO = x.TP_QUESTAO,
                    PERGUNTA = x.PERGUNTA,
                    PESO = x.PESO,
                    CANAL = x.CANAL,
                    CARGO = x.CARGO,
                    STATUS_QUESTION = x.STATUS_QUESTION,
                    FIXA = x.FIXA,
                    SUB_TEMA = x.ID_SUB_TEMAS.Value,
                    DT_MOD = x.DT_MOD.Value,
                    LOGIN_MOD = x.LOGIN_MOD.Value,
                    ALTERNATIVAS = CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Where(y => y.ID_QUESTION == x.ID_QUESTION)
                    .Select(y => new ALTERNATIVAS
                    {
                        ID_ALTERNATIVA = y.ID_ALTERNATIVA,
                        ALTERNATIVA = y.ALTERNATIVA,
                        ID_QUESTION = y.ID_QUESTION,
                        STATUS_ALTERNATIVA = y.STATUS_ALTERNATIVA,
                        PESO = y.PESO,
                        RESPOSTA_CORRETA = y.RESPOSTA_CORRETA
                    }).ToList(),
                }).ToList();

                return new JsonResult(new Response<List<QUESTIONS>>
                {
                    Data = data,
                    Succeeded = true,
                    Message = "Tudo certo, O Formulário foi finalizado com sucesso!",
                    Errors = null,
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

        [HttpGet("GetDataCarteira")]
        [ProducesResponseType(typeof(Response<IEnumerable<JORNADA_BD_HIERARQUIum>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDataCarteira(string regional)
        {

            try
            {
                var questions = CD.JORNADA_BD_HIERARQUIAs.Where(x => x.REGIONAL == regional).Where(x => x.STATUS == true);

                return new JsonResult(new Response<IEnumerable<JORNADA_BD_HIERARQUIum>>
                {
                    Data = questions,
                    Succeeded = true,
                    Message = "Tudo certo, O Formulário foi finalizado com sucesso!",
                    Errors = null,
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

        [HttpGet("GetDataCarteiraNoRegional")]
        [ProducesResponseType(typeof(Response<IEnumerable<JORNADA_BD_HIERARQUIum>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDataCarteiraNoRegional()
        {

            try
            {
                var questions = CD.JORNADA_BD_HIERARQUIAs.Where(x => x.STATUS == true);

                return new JsonResult(new Response<IEnumerable<JORNADA_BD_HIERARQUIum>>
                {
                    Data = questions,
                    Succeeded = true,
                    Message = "Tudo certo, O Formulário foi finalizado com sucesso!",
                    Errors = null,
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

        [HttpPost("InsertRespostasQuestion")]
        [ProducesResponseType(typeof(Response<IEnumerable<JORNADA_BD_AVALIACAO_RETORNO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult InsertRespostasQuestion([FromBody] IEnumerable<JORNADA_BD_AVALIACAO_RETORNO> data)
        {
            try
            {
                foreach (var item in data.Distinct())
                {
                    CD.JORNADA_BD_AVALIACAO_RETORNOs.Add(new JORNADA_BD_AVALIACAO_RETORNO
                    {
                        ID_QUESTION = item.ID_QUESTION,
                        ID_PROVA_RESPONDIDA = item.ID_PROVA_RESPONDIDA,
                        TEMAS = item.TEMAS,
                        TP_FORMS = item.TP_FORMS,
                        PESO = item.PESO,
                        PUBLICO_CANAL = item.PUBLICO_CANAL,
                        PUBLICO_CARGO = item.PUBLICO_CARGO,
                        DT_AVALIACAO = item.DT_AVALIACAO,
                        MATRICULA_APLICADOR = item.MATRICULA_APLICADOR,
                        CADERNO = item.CADERNO,
                        RESPOSTA_USER = item.RESPOSTA_USER,
                        REDE_AVALIADA = item.REDE_AVALIADA,
                        DDD_AVALIADO = item.DDD_AVALIADO,
                        PDV_AVALIADO = item.PDV_AVALIADO,
                        RE_AVALIADO = item.RE_AVALIADO,
                        ID_PROVA = item.ID_PROVA,
                        STATUS_RESPOSTA = item.STATUS_RESPOSTA,
                        ID_SUB_TEMAS = item.ID_SUB_TEMAS,
                        REGIONAL = item.REGIONAL
                    });
                }

                CD.SaveChanges();

                return new JsonResult(new Response<IEnumerable<JORNADA_BD_AVALIACAO_RETORNO>>
                {
                    Data = data,
                    Succeeded = true,
                    Message = "Tudo certo, O Formulário foi finalizado com sucesso!",
                    Errors = null,
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

        [HttpPost("InsertResultadoProva")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult InsertResultadoProva([FromBody] JORNADA_BD_ANSWER_AVALIACAO data)
        {
            try
            {
                var entidade = CD.JORNADA_BD_ANSWER_AVALIACAOs.Add(new JORNADA_BD_ANSWER_AVALIACAO
                {
                    ID_TEMAS = data.ID_TEMAS,
                    TP_FORMS = data.TP_FORMS,
                    PUBLICO_CANAL = data.PUBLICO_CANAL,
                    PUBLICO_CARGO = data.PUBLICO_CARGO,
                    DT_AVALIACAO = data.DT_AVALIACAO,
                    MATRICULA_APLICADOR = data.MATRICULA_APLICADOR,
                    NOME_APLICADOR = data.NOME_APLICADOR,
                    CADERNO = data.CADERNO,
                    NOTA = data.NOTA,
                    REDE_AVALIADA = data.REDE_AVALIADA,
                    DDD_AVALIADO = data.DDD_AVALIADO,
                    PDV_AVALIADO = data.PDV_AVALIADO,
                    RE_AVALIADO = data.RE_AVALIADO,
                    ID_SUB_TEMAS = data.ID_SUB_TEMAS,
                    REGIONAL = data.REGIONAL,
                    ID_PROVA = data.ID_PROVA,
                }).Entity;

                CD.SaveChanges();

                return new JsonResult(new Response<string>
                {
                    Data = entidade.ID_PROVA_RESPONDIDA.ToString(),
                    Succeeded = true,
                    Message = "Tudo certo, O Formulário foi finalizado com sucesso!",
                    Errors = null,
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

        [HttpGet("Get_List_Resultado_Prova")]
        [ProducesResponseType(typeof(Response<IEnumerable<ListaAvaliacaoModel>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult Get_List_Resultado_Prova(string matricula)
        {
            try
            {
                var lista = CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(x => x.MATRICULA_APLICADOR == int.Parse(matricula) || x.RE_AVALIADO == int.Parse(matricula)).AsEnumerable();
                var listaavaliacoes = lista.Select(x => new ListaAvaliacaoModel
                {
                    ID_PROVA_RESPONDIDA = x.ID_PROVA_RESPONDIDA,
                    ID_PROVA = x.ID_PROVA,
                    TEMA = x.ID_TEMAS,
                    TP_FORMS = x.TP_FORMS,
                    PUBLICO_CANAL = (Canal)x.PUBLICO_CANAL,
                    PUBLICO_CARGO = (Cargos)x.PUBLICO_CARGO,
                    DT_AVALIACAO = x.DT_AVALIACAO.Value,
                    MATRICULA_AVALIADOR = x.MATRICULA_APLICADOR.Value,
                    NOME = x.NOME_APLICADOR,
                    CADERNO = x.CADERNO.ToString(),
                    NOTA = Convert.ToDouble(x.NOTA),
                    REDE_AVALIADA = x.REDE_AVALIADA,
                    DDD_AVALIADO = x.DDD_AVALIADO.ToString(),
                    PDV_AVALIADO = x.PDV_AVALIADO,
                    RE_AVALIADO = x.RE_AVALIADO,
                    REGIONAL = x.REGIONAL,
                });

                return new JsonResult(new Response<IEnumerable<ListaAvaliacaoModel>>
                {
                    Data = listaavaliacoes,
                    Succeeded = true,
                    Message = "Tudo certo, O Formulário foi finalizado com sucesso!",
                    Errors = null,
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

        [HttpGet("GetQuestionsById_Prova")]
        [ProducesResponseType(typeof(Response<IEnumerable<AVALIACAO_RETORNO_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetQuestionsById_Prova(int id)
        {
            try
            {
                var avaliacao = CD.JORNADA_BD_AVALIACAO_RETORNOs.Where(x => x.ID_PROVA_RESPONDIDA == id)
                    .ProjectTo<AVALIACAO_RETORNO_DTO>(_mapper.ConfigurationProvider);

                return new JsonResult(new Response<IEnumerable<AVALIACAO_RETORNO_DTO>>
                {
                    Data = avaliacao,
                    Succeeded = true,
                    Message = "Tudo certo, O Formulário foi finalizado com sucesso!",
                    Errors = null,
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

        [HttpPost("GetPainelProvasRealizadas")]
        [ProducesResponseType(typeof(Response<PagedModelResponse<IEnumerable<PROVA_REALIZADA_DTO>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetPainelProvasRealizadas([FromBody] GenericPaginationModel<FILTROS_PROVA_REALIZADA_DTO> filter)
        {
            try
            {
                var DataProvas = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(x => x.ID_CRIADOR == filter.Value.Matricula_Criador
                    && x.REGIONAL == filter.Value.REGIONAL && x.ID_PROVA != 0);
                // Filtra por Matricula de quem está fazendo a requisição


                if (filter.Value.ELEGIVEL.HasValue)
                {
                    DataProvas = DataProvas.Where(x => x.ELEGIVEL == filter.Value.ELEGIVEL.Value);
                }

                if (filter.Value.FIXA.HasValue)
                {
                    DataProvas = DataProvas.Where(x => x.FIXA == filter.Value.FIXA.Value);
                }

                if (filter.Value.TP_FORMS.Any())
                {
                    DataProvas = DataProvas.Where(x => filter.Value.TP_FORMS.Contains(x.TP_FORMS));
                }

                if (filter.Value.PeriodoInicioAprovacao.Any())
                {
                    if (filter.Value.PeriodoInicioAprovacao.Count() == 2)
                    {
                        DataProvas = DataProvas.Where(x => x.DT_INICIO_AVALIACAO > filter.Value.PeriodoInicioAprovacao[0]
                        && x.DT_INICIO_AVALIACAO < filter.Value.PeriodoInicioAprovacao[1]);
                    }
                }

                if (filter.Value.PeriodoFinalizacao.Any())
                {
                    if (filter.Value.PeriodoFinalizacao.Count() == 2)
                    {
                        DataProvas = DataProvas.Where(x => x.DT_FINALIZACAO > filter.Value.PeriodoFinalizacao[0]
                        && x.DT_FINALIZACAO < filter.Value.PeriodoFinalizacao[1]);
                    }
                }

                if (filter.Value.Caderno != 0)
                {
                    DataProvas = DataProvas.Where(x => x.CADERNO == filter.Value.Caderno);
                }

                //var teste = DataProvas
                //    .GroupBy(x => x.ID_PROVA)
                //    .Select(x => x.FirstOrDefault())
                //    .ToList().Select(x=> _mapper.Map<PROVA_REALIZADA_DTO>(x));
                //.ProjectTo<PROVA_REALIZADA_DTO>(_mapper.ConfigurationProvider)

                var Provas = DataProvas
                    .GroupBy(x => x.ID_PROVA).AsEnumerable()
                    .Select(x =>
                    {
                        var saida = _mapper.Map<PROVA_REALIZADA_DTO>(x.First());
                        saida.Qtd_Perguntas = x.Count();
                        return saida;
                    });

                //Qtd_Respostas, CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(y => y.ID_PROVA == src.ID_PROVA).Count(),
                //Qtd_Perguntas, CD.JORNADA_BD_QUESTION_HISTORICOs.Where(y => y.ID_PROVA == src.ID_PROVA).Count(),
                //Sum_nota, CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(y => y.ID_PROVA == src.ID_PROVA).Select(x => x.NOTA).Sum(),

                var Data = Provas.OrderByDescending(x => x.ID_PROVA)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize).OrderBy(x => x.DT_CRIACAO);


                var totalRecords = Provas.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<PROVA_REALIZADA_DTO>>>
                {
                    Data = PagedResponse.CreatePagedReponse<PROVA_REALIZADA_DTO, FILTROS_PROVA_REALIZADA_DTO>(Data, filter, totalRecords),
                    Succeeded = true,
                    Message = "Tudo Certo!",
                    Errors = null,
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

        [HttpPost("FinalizarProvaByID")]
        [ProducesResponseType(typeof(Response<bool>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> FinalizarProvaByID(int id)
        {
            try
            {
                CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.ID_PROVA == id).ToList().ForEach(x =>
                {
                    x.DT_FINALIZACAO = DateTime.Now;
                });

                var resultado = await CD.SaveChangesAsync();

                return new JsonResult(new Response<bool>
                {
                    Data = resultado > 0 ? true : false,
                    Succeeded = true,
                    Message = "A Prova foi finalizada com sucesso!",
                    Errors = null,
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

        [HttpGet("ValidateProvaDisponivel")]
        [ProducesResponseType(typeof(Response<bool>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> ValidateProvaDisponivel(int ID_PROVA, int matricula)
        {
            try
            {
                var check = CD.JORNADA_BD_ANSWER_AVALIACAOs.Any(x => x.ID_PROVA == ID_PROVA && x.RE_AVALIADO == matricula);

                return new JsonResult(new Response<bool>
                {
                    Data = check,
                    Succeeded = true,
                    Message = "A Prova foi finalizada com sucesso!",
                    Errors = null,
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
                    }
                });
            }
        }

        [HttpGet("GetDetalhadoProvaByID")]
        [ProducesResponseType(typeof(Response<DETALHADO_PROVA_CRIADA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDetalhadoProvaByID(int id)
        {
            try
            {
                var Prova = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(x => x.ID_PROVA == id)
                    .ProjectTo<DETALHADO_PROVA_CRIADA_DTO>(_mapper.ConfigurationProvider)
                    .FirstOrDefault();

                return new JsonResult(new Response<DETALHADO_PROVA_CRIADA_DTO>
                {
                    Data = Prova,
                    Succeeded = true,
                    Message = "Tudo Certo!",
                    Errors = null,
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

        [HttpGet("GetAvaliadosProvaByID")]
        [ProducesResponseType(typeof(Response<AVALIADOS_PROVA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetAvaliadosProvaByID(int id)
        {
            try
            {
                var Prova = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(x => x.ID_PROVA == id)
                    .ProjectTo<AVALIADOS_PROVA_DTO>(_mapper.ConfigurationProvider)
                    .FirstOrDefault();

                return new JsonResult(new Response<AVALIADOS_PROVA_DTO>
                {
                    Data = Prova,
                    Succeeded = true,
                    Message = "Tudo Certo!",
                    Errors = null,
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

        [HttpPost("CriarFormularioDetalhado")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult CriarFormularioDetalhado(
            string regional,
            int matricula,
            string Tipo_prova,
            bool? Elegiveis,
            DateTime? Dt_inicio,
            DateTime? Dt_fim,
            Cargos Cargo,
            bool? Fixa,
            [FromBody] IEnumerable<JORNADA_QUESTION_DTO?> Questions
            )
        {
            try
            {
                bool FormularioExistente;
                int proximocaderno = 0;
                FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
                                        .Where(x => x.CARGO == (int)Cargo)
                                        .Where(x => x.TP_FORMS == Tipo_prova)
                                        .Where(x => x.REGIONAL == regional)
                                        .Where(x => x.FIXA == Fixa).Any();

                if (FormularioExistente)
                {
                    proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                        .Where(x => x.CARGO == (int)Cargo)
                        .Where(x => x.TP_FORMS == Tipo_prova)
                        .Where(x => x.REGIONAL == regional)
                        .Where(x => x.FIXA == Fixa).AsEnumerable()
                        .Select(y => y.CADERNO).Max() + 1);
                }
                else
                {
                    proximocaderno = 1;
                }

                var entityrelacao = CD.JORNADA_BD_RELACAO_HISTORICOs.Add(new JORNADA_BD_RELACAO_HISTORICO
                {
                    LOGIN_MOD = matricula,
                    DT_MOD = DateTime.Now
                }).Entity;

                CD.SaveChanges();

                if (!Dt_fim.HasValue)
                {
                    Dt_fim = null;
                }
                else
                {
                    Dt_fim = Dt_fim.Value.AddDays(1).AddSeconds(-1);
                }

                foreach (var item in Questions) // Adiciona as perguntas selecionadas a lista que será inserida no banco
                {
                    var canal = DePara.CanalCargoEnum(Cargo);
                    CD.JORNADA_BD_QUESTION_HISTORICOs.Add(new JORNADA_BD_QUESTION_HISTORICO
                    {
                        CANAL = (int)canal,
                        CARGO = (int)Cargo,
                        DT_CRIACAO = DateTime.Now,
                        ID_CRIADOR = matricula,
                        ID_QUESTION = item.ID_QUESTION,
                        ID_PROVA = entityrelacao.ID_PROVA,
                        CADERNO = proximocaderno,
                        TP_FORMS = Tipo_prova,
                        DT_INICIO_AVALIACAO = Dt_inicio.Value.Date,
                        DT_FINALIZACAO = Dt_fim,
                        FIXA = Fixa,
                        REGIONAL = regional,
                        ELEGIVEL = Elegiveis
                    });
                }

                CD.SaveChanges();

                return new JsonResult(new Response<string>
                {
                    Data = "O formulário foi criado corretamente!",
                    Succeeded = true,
                    Message = "O formulário foi criado corretamente",
                    Errors = null,
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

        private void InsertQuestionsIntoForm(
            string REGIONAL,
            string TIPO_PROVA,
            int CARGO,
            bool FIXA,
            int MATRICULA,
            string DT_INIT,
            string? DT_FINAL,
            List<JORNADA_BD_QUESTION> Formulario,
            int proximocaderno)
        {
            var entityrelacao = CD.JORNADA_BD_RELACAO_HISTORICOs.Add(new JORNADA_BD_RELACAO_HISTORICO
            {
                LOGIN_MOD = MATRICULA,
                DT_MOD = DateTime.Now
            }).Entity;
            CD.SaveChanges();
            DateTime? Dt_fim = DateTime.TryParse(DT_FINAL, out DateTime result) ? result : null;
            if (Dt_fim.HasValue)
                Dt_fim = Dt_fim.Value.AddDays(1).AddSeconds(-1);

            foreach (var item in Formulario) // Adiciona as perguntas selecionadas a lista que será inserida no banco
            {
                var canal = DePara.CanalCargoEnum((Cargos)CARGO);


                CD.JORNADA_BD_QUESTION_HISTORICOs.Add(new JORNADA_BD_QUESTION_HISTORICO
                {
                    CANAL = (int)canal,
                    CARGO = CARGO,
                    DT_CRIACAO = DateTime.Now,
                    ID_CRIADOR = MATRICULA,
                    ID_QUESTION = item.ID_QUESTION,
                    ID_PROVA = entityrelacao.ID_PROVA,
                    CADERNO = proximocaderno,
                    TP_FORMS = TIPO_PROVA,
                    DT_INICIO_AVALIACAO = Convert.ToDateTime(DT_INIT).Date,
                    DT_FINALIZACAO = Dt_fim,
                    FIXA = FIXA,
                    REGIONAL = REGIONAL,
                    ELEGIVEL = false
                });
            }
        }

        private void InsertQuestionsJornadaIntoForm(
            string REGIONAL,
            List<TEMAS_QTD>? TEMAS_QUANTIDADE,
            int CARGO,
            bool FIXA,
            bool QuestoesRepetidas,
            List<JORNADA_BD_QUESTION> Formulario,
            bool FormularioExistente,
            string rota,
            Random random,
            int i)
        {
            var tema = TEMAS_QUANTIDADE[i].Tema;
            var subtema = TEMAS_QUANTIDADE[i].Sub_tema;
            var qtdtema = TEMAS_QUANTIDADE[i].Qtd;

            List<JORNADA_BD_QUESTION> jornadaQuestion;

            Random rnd = new Random();

            if (FormularioExistente)
            {

                var questaorepetida = CD.JORNADA_BD_QUESTION_HISTORICOs // BUSCA OS ID'S DAS QUESTÕES REPETIDAS
                    .ToList()
                    .Where(x => x.CARGO == CARGO)
                    .Where(x => x.TP_FORMS == rota)
                    .Where(x => x.REGIONAL == REGIONAL)
                    .Where(x => x.FIXA == FIXA)
                    .Select(y => y.ID_QUESTION).ToList();

                jornadaQuestion = CD.JORNADA_BD_QUESTIONs
                    .ToList()
                    .Where(x => x.STATUS_QUESTION == true)
                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(k => k.ID_TEMAS == tema)
                    .Where(y => y.ID_SUB_TEMAS == subtema)
                    .OrderBy(item => random.Next())
                    .GroupBy(x => new { x.PERGUNTA }).Select(x => x.FirstOrDefault())
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Where(y => !questaorepetida.Contains(y.ID_QUESTION))
                    .Take(qtdtema.Value).ToList();

                if (jornadaQuestion.Count() < qtdtema)
                {
                    QuestoesRepetidas = true;

                    while (jornadaQuestion.Count() != qtdtema)
                    {
                        jornadaQuestion.Add(CD.JORNADA_BD_QUESTIONs.AsEnumerable().ToList()
                        .Where(x => x.STATUS_QUESTION == true)
                        .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                        .Where(k => k.ID_TEMAS == tema)
                        .Where(y => y.ID_SUB_TEMAS == subtema)
                        .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                        .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                        .OrderBy(item => random.Next())
                        .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault())
                        .FirstOrDefault());
                    }
                }
            }
            else
            {
                jornadaQuestion = CD.JORNADA_BD_QUESTIONs
                                         .ToList()
                    .Where(x => x.STATUS_QUESTION == true)
                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(k => k.ID_TEMAS == tema)
                    .Where(y => y.ID_SUB_TEMAS == subtema)
                    .OrderBy(item => random.Next())
                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Take(qtdtema.Value)
                    .ToList();
            }

            foreach (JORNADA_BD_QUESTION item in jornadaQuestion)
            {
                Formulario.Add(item);
            }
        }

        private void InsertQuestionsJornadaGestorIntoForm(
            string REGIONAL,
            List<TEMAS_QTD>? TEMAS_QUANTIDADE,
            int CARGO,
            bool FIXA,
            bool QuestoesRepetidas,
            List<JORNADA_BD_QUESTION> Formulario,
            bool FormularioExistente,
            string rota,
            Random random,
            int i)
        {
            var tema = TEMAS_QUANTIDADE[i].Tema;
            var subtema = TEMAS_QUANTIDADE[i].Sub_tema;
            var qtdtema = TEMAS_QUANTIDADE[i].Qtd;

            List<JORNADA_BD_QUESTION> jornadaQuestion;

            Random rnd = new Random();

            if (FormularioExistente)
            {

                var questaorepetida = CD.JORNADA_BD_QUESTION_HISTORICOs // BUSCA OS ID'S DAS QUESTÕES REPETIDAS
                    .Where(x => x.CARGO == CARGO)
                    .Where(x => x.TP_FORMS == rota)
                    .Where(x => x.REGIONAL == REGIONAL)
                    .Where(x => x.FIXA == FIXA)
                    .Select(y => y.ID_QUESTION);

                jornadaQuestion = CD.JORNADA_BD_QUESTIONs
                    .Where(x => x.STATUS_QUESTION == true && x.ID_TEMAS == tema && x.ID_SUB_TEMAS == subtema)
                    .AsEnumerable()
                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .OrderBy(item => random.Next())
                    .GroupBy(x => new { x.PERGUNTA }).Select(x => x.FirstOrDefault())
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Where(y => !questaorepetida.Contains(y.ID_QUESTION))
                    .Take(qtdtema.Value).ToList();

                if (jornadaQuestion.Count() < qtdtema)
                {
                    QuestoesRepetidas = true;

                    while (jornadaQuestion.Count() != qtdtema)
                    {
                        jornadaQuestion.Add(CD.JORNADA_BD_QUESTIONs.ToList()
                        .Where(x => x.STATUS_QUESTION == true)
                        .Where(k => k.ID_TEMAS == tema)
                        .Where(y => y.ID_SUB_TEMAS == subtema)
                        .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                        .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                        .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                        .OrderBy(item => random.Next())
                        .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault())
                        .FirstOrDefault());
                    }
                }
            }
            else
            {
                jornadaQuestion = CD.JORNADA_BD_QUESTIONs
                                         .ToList()
                    .Where(x => x.STATUS_QUESTION == true)
                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(k => k.ID_TEMAS == tema)
                    .Where(y => y.ID_SUB_TEMAS == subtema)
                    .OrderBy(item => random.Next())
                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Take(qtdtema.Value)
                    .ToList();
            }

            foreach (JORNADA_BD_QUESTION item in jornadaQuestion)
            {
                Formulario.Add(item);
            }
        }

        private void InsertQuestionsRotaCruzadaIntoForm(
            string REGIONAL,
            List<TEMAS_QTD>? TEMAS_QUANTIDADE,
            int CARGO,
            bool FIXA,
            bool QuestoesRepetidas,
            List<JORNADA_BD_QUESTION> Formulario,
            bool FormularioExistente,
            int matricula,
            Random random,
            int i)
        {
            var tema = TEMAS_QUANTIDADE[i].Tema;
            var subtema = TEMAS_QUANTIDADE[i].Sub_tema;
            var qtdtema = TEMAS_QUANTIDADE[i].Qtd;

            List<JORNADA_BD_QUESTION> jornadaQuestion;

            Random rnd = new Random();

            if (FormularioExistente) // Se for encontrado algum caderno do tipo escolhido
            {
                var questaorepetida = CD.JORNADA_BD_QUESTION_HISTORICOs //  pega todos as questões  que já passaram
                            .ToList()
                    .Where(x => x.CARGO == CARGO)
                    .Where(x => x.REGIONAL == REGIONAL)
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Where(x => x.TP_FORMS == "Rota Cruzada")
                    .Where(x => x.ID_CRIADOR == matricula)
                    .Select(y => y.ID_QUESTION)
                    .ToList();

                jornadaQuestion = CD.JORNADA_BD_QUESTIONs  //Gera um formulário novo em que não se repete nenhum das questões já passadas
                    .ToList()
                    .Where(x => x.STATUS_QUESTION == true)
                    .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(k => k.ID_TEMAS == tema)
                    .Where(k => k.ID_SUB_TEMAS == subtema)
                    .OrderBy(item => random.Next())
                    .GroupBy(x => x.PERGUNTA)
                    .Select(x => x.FirstOrDefault()).ToList()
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Where(k => !questaorepetida.Contains(k.ID_QUESTION))
                    .Take(qtdtema.Value)
                    .ToList();

                if (jornadaQuestion.Count() < qtdtema)
                {
                    QuestoesRepetidas = true;
                    while (jornadaQuestion.Count() != qtdtema)
                    {
                        jornadaQuestion.Add(CD.JORNADA_BD_QUESTIONs.AsEnumerable().ToList()
                            .Where(x => x.STATUS_QUESTION == true)
                            .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                            .Where(k => k.ID_TEMAS == tema)
                            .Where(k => k.ID_SUB_TEMAS == subtema)
                            .OrderBy(item => random.Next())
                            .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                            .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                            .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null)).FirstOrDefault());
                    }
                }

            }
            else
            {
                jornadaQuestion = CD.JORNADA_BD_QUESTIONs.AsEnumerable()
                            .ToList()
                    .Where(x => x.STATUS_QUESTION == true)
                    .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                    .Where(k => k.ID_TEMAS == tema)
                    .Where(k => k.ID_SUB_TEMAS == subtema)
                    .OrderBy(item => random.Next())
                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Take(qtdtema.Value)
                    .ToList();
            }
            foreach (JORNADA_BD_QUESTION item in jornadaQuestion)
            {
                Formulario.Add(item);
            }
        }

        private List<JORNADA_BD_QUESTION_HISTORICO> GetListaProvasRotaCruzadaDisponiveis(int MATRICULA)
        {
            var actual = DateTime.Now;
            var questions = CD.JORNADA_BD_QUESTION_HISTORICOs
                            .Where(x => x.ID_CRIADOR == MATRICULA)
                            .Where(y => y.TP_FORMS == "Rota Cruzada")
                            .OrderByDescending(x => x.ID_PROVA)
                            .ToList();

            // Este código filtrava as questões de rota cruzada para apenas questões que tem a data de init
            // abaixo do momento da solicitação e quanddo a data de finalização está nula

            questions = questions
                           .Where(x => Convert.ToDateTime(x.DT_INICIO_AVALIACAO) < actual) // Data inicial deve ser maior que hoje
                           .Where(x => !x.DT_FINALIZACAO.HasValue) // Data de finalização nula
                           .ToList();

            return questions;
        }

        private void GetListaProvasJornadaDisponiveis(
            string REGIONAL,
            int CARGO,
            int MATRICULA,
            bool FIXA,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornada,
            out bool resposta)
        {
            var actual = DateTime.Now;
            var maxcadernojornada = CD.JORNADA_BD_QUESTION_HISTORICOs // Buscar o caderno maximo baseado nos parametros
            .Where(y => y.TP_FORMS == "Jornada")
            .Where(y => y.CARGO == CARGO)
            .Where(y => y.FIXA == FIXA)
            .Where(y => y.REGIONAL == REGIONAL)
            .Max(y => y.CADERNO);

            questionsjornada = CD.JORNADA_BD_QUESTION_HISTORICOs
            .Where(y => y.TP_FORMS == "Jornada")
            .Where(y => y.CARGO == CARGO)
            .Where(y => y.FIXA == FIXA)
            .Where(y => y.REGIONAL == REGIONAL)
            .Where(y => y.CADERNO == maxcadernojornada)
            .ToList();

            questionsjornada = questionsjornada
                .Where(x => x.DT_INICIO_AVALIACAO.Value < actual) // Data inicial deve ser maior que hoje
                .Where(x => x.DT_FINALIZACAO.Value.AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                .ToList();

            resposta = CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                .Where(x => x.PUBLICO_CARGO == CARGO
                && x.CADERNO == maxcadernojornada
                && x.MATRICULA_APLICADOR == MATRICULA
                && x.REGIONAL == REGIONAL
                && x.TP_FORMS == "Jornada").Any();
        }

        private void GetListaProvasJornadaGestorDisponiveis(
            string REGIONAL,
            int CARGO,
            int MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            questionsjornadaGestor = new();
            var cargosGestor = new List<int> { 3, 6, 8 };
            IEnumerable<ACESSOS_MOBILE> Criador = CD.ACESSOS_MOBILEs.Where(y =>
                CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.TP_FORMS == "Jornada Gestor")
                    .Select(x => x.ID_CRIADOR)
                    .Distinct()
                    .ToList()
                    .Contains(y.MATRICULA) && cargosGestor.Contains(y.CARGO)
                ).Where(x => x.PDV == usuario.PDV).ToList();

            if (Criador.Any())
            {
                foreach (var Gestor in Criador)
                {
                    var actual = DateTime.Now;

                    var actualquestionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .Where(y => y.ID_CRIADOR == Gestor.MATRICULA)
                    .ToList();

                    actualquestionsjornadaGestor = actualquestionsjornadaGestor
                        .Where(x => x.DT_INICIO_AVALIACAO.Value < actual) // Data inicial deve ser maior que hoje
                        .Where(x => x.DT_FINALIZACAO.Value.AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                        .ToList();

                    var provasEncontradas = actualquestionsjornadaGestor.Select(x => x.ID_PROVA).Distinct().ToList();

                    var loopingquestions = actualquestionsjornadaGestor;

                    foreach (var item in provasEncontradas)
                    {
                        if (CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == MATRICULA)
                        .Any() == true)
                        {
                            loopingquestions = actualquestionsjornadaGestor.Where(x => x.ID_PROVA != item).ToList();
                        }
                    }

                    questionsjornadaGestor.AddRange(loopingquestions);
                }
            }
        }

        private void GetListaProvasJornadaGestorDivisaoDisponiveis(
            string REGIONAL,
            int CARGO,
            int MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            if ((Cargos)usuario.CARGO == Cargos.Gerente_Área)
            {
                JORNADA_BD_HIERARQUIum? PDVDivisão = CD.JORNADA_BD_HIERARQUIAs
                .Where(x => x.RE_GA != null)
                .Where(x => x.RE_GA == usuario.MATRICULA).FirstOrDefault();

                if (PDVDivisão is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.RE_DIVISAO.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .ToList();

                    questionsjornadaGestor = questionsjornadaGestor
                        .Where(x => x.DT_INICIO_AVALIACAO.Value < actual) // Data inicial deve ser maior que hoje
                        .Where(x => x.DT_FINALIZACAO.Value.AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                        .ToList();

                    var provasEncontradas = questionsjornadaGestor.Select(x => x.ID_PROVA).ToList();


                    foreach (var item in provasEncontradas)
                    {
                        if (CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == MATRICULA)
                        .Any() == true)
                        {
                            questionsjornadaGestor = questionsjornadaGestor.Where(x => x.ID_PROVA != item).ToList();
                        }
                    }
                }
                else
                {
                    questionsjornadaGestor = new();
                }
            }
            else if (((Cargos)usuario.CARGO) == Cargos.Gerente_Parceiros)
            {
                JORNADA_BD_HIERARQUIum? PDVDivisão = CD.JORNADA_BD_HIERARQUIAs
                .Where(x => x.RE_GP != null)
                .Where(x => x.RE_GP == usuario.MATRICULA).FirstOrDefault();

                if (PDVDivisão is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.RE_DIVISAO.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .ToList();

                    questionsjornadaGestor = questionsjornadaGestor
                        .Where(x => x.DT_INICIO_AVALIACAO.Value < actual) // Data inicial deve ser maior que hoje
                        .Where(x => x.DT_FINALIZACAO.Value.AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                        .ToList();

                    var provasEncontradas = questionsjornadaGestor.Select(x => x.ID_PROVA).Distinct().ToList();

                    foreach (var item in provasEncontradas)
                    {
                        if (CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == MATRICULA)
                        .Any() == true)
                        {
                            questionsjornadaGestor = questionsjornadaGestor.Where(x => x.ID_PROVA != item).ToList();
                        }
                    }
                }
                else
                {
                    questionsjornadaGestor = new();
                }
            }
            else if ((Cargos)usuario.CARGO == Cargos.Gerente_Vendas_B2C)
            {
                JORNADA_BD_HIERARQUIum? PDVDivisão = CD.JORNADA_BD_HIERARQUIAs
                .Where(x => x.RE_GV != null)
                .Where(x => x.RE_GV == usuario.MATRICULA).FirstOrDefault();

                if (PDVDivisão is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.RE_DIVISAO.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .ToList();

                    questionsjornadaGestor = questionsjornadaGestor
                        .Where(x => x.DT_INICIO_AVALIACAO.Value < actual) // Data inicial deve ser maior que hoje
                        .Where(x => x.DT_FINALIZACAO.Value.AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                        .ToList();

                    var provasEncontradas = questionsjornadaGestor.Select(x => x.ID_PROVA).ToList().Distinct();

                    foreach (var item in provasEncontradas)
                    {
                        if (CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == MATRICULA)
                        .Any() == true)
                        {
                            questionsjornadaGestor = questionsjornadaGestor.Where(x => x.ID_PROVA != item).ToList();
                        }
                    }
                }
                else
                {
                    questionsjornadaGestor = new();
                }
            }
            else
            {
                JORNADA_BD_HIERARQUIum PDVDivisão = CD.JORNADA_BD_HIERARQUIAs
                    .Where(x => x.ADABAS == usuario.PDV && x.RE_DIVISAO != null).FirstOrDefault();

                if (PDVDivisão is not null)
                {
                    var actual = DateTime.Now;
                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.RE_DIVISAO.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .ToList();

                    questionsjornadaGestor = questionsjornadaGestor
                        .Where(x => x.DT_INICIO_AVALIACAO.Value < actual) // Data inicial deve ser maior que hoje
                        .Where(x => x.DT_FINALIZACAO.Value.AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                        .ToList();

                    var provasEncontradas = questionsjornadaGestor.Select(x => x.ID_PROVA).Distinct().ToList();

                    foreach (var item in provasEncontradas)
                    {
                        if (CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == MATRICULA)
                        .Any() == true)
                        {
                            questionsjornadaGestor = questionsjornadaGestor.Where(x => x.ID_PROVA != item).ToList();
                        }
                    }
                }
                else
                {
                    questionsjornadaGestor = new();

                }
            }
        }

        private void GetListaProvasJornadaGestorGADisponiveis(
            string REGIONAL,
            int CARGO,
            int MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            JORNADA_BD_HIERARQUIum PDVDivisão = CD.JORNADA_BD_HIERARQUIAs
                .Where(x => x.ADABAS == usuario.PDV).FirstOrDefault();

            if (PDVDivisão is not null)
            {
                if (PDVDivisão.RE_GA is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.RE_GA.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .ToList();

                    questionsjornadaGestor = questionsjornadaGestor
                        .Where(x => x.DT_INICIO_AVALIACAO.Value < actual) // Data inicial deve ser maior que hoje
                        .Where(x => x.DT_FINALIZACAO.Value.AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                        .ToList();

                    var provasEncontradas = questionsjornadaGestor.Select(x => x.ID_PROVA).Distinct().ToList();

                    foreach (var item in provasEncontradas)
                    {
                        if (CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == MATRICULA)
                        .Any() == true)
                        {
                            questionsjornadaGestor = questionsjornadaGestor.Where(x => x.ID_PROVA != item).ToList();
                        }
                    }
                    //questionsjornadaGestor = questionsjornadaGestor.Where(y =>
                    //    CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                    //    .Where(x => provasEncontradas.Contains(x.ID_PROVA) && x.RE_AVALIADO == MATRICULA)
                    //    .Any() == true
                    //).ToList();
                }
                else
                {
                    questionsjornadaGestor = new();
                }
            }
            else
            {
                questionsjornadaGestor = new();
            }
        }

        private void GetListaProvasJornadaGestorGGPDisponiveis(
            string REGIONAL,
            int CARGO,
            int MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            JORNADA_BD_HIERARQUIum PDVDivisão = CD.JORNADA_BD_HIERARQUIAs
                .Where(x => x.ADABAS == usuario.PDV).FirstOrDefault();

            if (PDVDivisão is not null)
            {
                if (PDVDivisão.RE_GP is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.RE_GP.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .ToList();

                    questionsjornadaGestor = questionsjornadaGestor
                        .Where(x => x.DT_INICIO_AVALIACAO.Value < actual) // Data inicial deve ser maior que hoje
                        .Where(x => x.DT_FINALIZACAO.Value.AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                        .ToList();

                    var provasEncontradas = questionsjornadaGestor.Select(x => x.ID_PROVA).Distinct().ToList();

                    foreach (var item in provasEncontradas)
                    {
                        if (CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == MATRICULA)
                        .Any() == true)
                        {
                            questionsjornadaGestor = questionsjornadaGestor.Where(x => x.ID_PROVA != item).ToList();
                        }
                    }
                }
                else
                {
                    questionsjornadaGestor = new();
                }
            }
            else
            {
                questionsjornadaGestor = new();
            }
        }
        private void GetListaProvasJornadaGestorGVDisponiveis(
            string REGIONAL,
            int CARGO,
            int MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            JORNADA_BD_HIERARQUIum PDVDivisão = CD.JORNADA_BD_HIERARQUIAs
                .Where(x => x.ADABAS == usuario.PDV).FirstOrDefault();

            if (PDVDivisão is not null)
            {
                if (PDVDivisão.RE_GV is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.RE_GV.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .ToList();

                    questionsjornadaGestor = questionsjornadaGestor
                        .Where(x => Convert.ToDateTime(x.DT_INICIO_AVALIACAO) < actual) // Data inicial deve ser maior que hoje
                        .Where(x => Convert.ToDateTime(x.DT_FINALIZACAO).AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                        .ToList();

                    var provasEncontradas = questionsjornadaGestor.Select(x => x.ID_PROVA).Distinct().ToList();

                    foreach (var item in provasEncontradas)
                    {
                        if (CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == MATRICULA)
                        .Any() == true)
                        {
                            questionsjornadaGestor = questionsjornadaGestor.Where(x => x.ID_PROVA != item).ToList();
                        }
                    }
                }
                else
                {
                    questionsjornadaGestor = new();
                }
            }
            else
            {
                questionsjornadaGestor = new();
            }
        }
    }
}
