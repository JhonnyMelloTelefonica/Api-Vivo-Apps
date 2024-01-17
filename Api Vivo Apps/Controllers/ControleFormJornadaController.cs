using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Vivo_Apps_API.Models;
using Shared_Class_Vivo_Apps.Data;
using System.Drawing;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Shared_Class_Vivo_Apps.Enums;
using Microsoft.AspNetCore.Components.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using AutoMapper;
using static Shared_Class_Vivo_Apps.Model_DTO.JORNADA_DTO;
using AutoMapper.QueryableExtensions;
using Shared_Class_Vivo_Apps.Model_DTO;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using static Vivo_Apps_API.Converters.Converters;
using Shared_Class_Vivo_Apps.Models;
using Shared_Class_Vivo_Apps.ModelDTO;

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
                    dest => dest.ID_QUESTION,
                    opt => opt.MapFrom(src => CD.JORNADA_BD_QUESTIONs.Where(x => x.ID_QUESTION == src.ID_QUESTION.Value).FirstOrDefault()))
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => ((Canal)src.CANAL)))
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => ((Cargos)src.CARGO)))
                .ForMember(
                    dest => dest.ID_CRIADOR,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == src.ID_CRIADOR.ToString()).FirstOrDefault()));

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
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == src.ID_CRIADOR.ToString()).FirstOrDefault()));

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
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => ConvertStringToEnumList<Canal>(src.CANAL)))
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => ConvertStringToEnumList<Cargos>(src.CARGO)))
                .ForMember(
                    dest => dest.DT_MOD,
                    opt => opt.MapFrom(src => Convert.ToDateTime(src.DT_MOD)))
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
                                .Select(y => y.RE_AVALIADO.ToString())
                                .Contains(k.MATRICULA)).Select(x => new ACESSOS_MOBILE_AVALIACAO
                                {
                                    ID = x.ID,
                                    EMAIL = x.EMAIL,
                                    MATRICULA = x.MATRICULA,
                                    PDV = x.PDV,
                                    NOME = x.NOME,
                                    UserAvatar = x.UserAvatar,
                                    PROVA_REALIZADA = CD.JORNADA_BD_ANSWER_AVALIACAOs
                                        .Where(y => y.RE_AVALIADO.ToString() == x.MATRICULA && y.ID_PROVA == src.ID_PROVA)
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
                };

                IEnumerable<Option<int>>
                    cargos = CD.JORNADA_BD_CARGOS_CANALs
                    .Where(x => !list.Contains(((Cargos)x.ID)))
                    .Select(x => new Option<int> { Value = Convert.ToInt32(x.ID), Text = x.CARGO, });

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
                int CARGO,
                bool FIXA)
        {
            try
            {
                if (TIPO_PROVA == "Jornada Gestor")
                {
                    TIPO_PROVA = "Jornada";
                }

                var dadosDoBanco = CD.JORNADA_BD_QUESTIONs.ToList();

                // Parte 1: Consulta executada no banco de dados
                var dadosDoBancoFiltrados = dadosDoBanco
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(y => y.TP_FORMS.Split(new[] { ';' }).Contains(TIPO_PROVA))
                    .Where(k => (FIXA == false ? k.FIXA == FIXA : k.FIXA != null))
                    .ToList(); // Aqui trazemos os dados do banco para a memória

                List<int> temas_id = dadosDoBancoFiltrados
                            .Select(x => Convert.ToInt32(x.ID_TEMAS))
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

        //[HttpPost("CreateFormulario")]
        //[ProducesResponseType(typeof(Response<string>), 200)]
        //[ProducesResponseType(typeof(Response<string>), 500)]
        //public async Task<JsonResult> CreateFormulario(
        //       [FromBody] List<TEMAS_QTD>? TEMAS_QUANTIDADE,
        //       string TIPO_PROVA,
        //       int CARGO,
        //       bool FIXA,
        //       string REGIONAL,
        //       string MATRICULA,
        //       string DT_INIT,
        //       string? DT_FINAL,
        //       int QTD_TOTAL_SOLICITADA
        //   )
        //{
        //    try
        //    {
        //        List<JORNADA_BD_QUESTION> Formulario = new List<JORNADA_BD_QUESTION>(); // LISTA ONDE SERÁ INSERIDA AS PERGUNTAS
        //        bool FormularioExistente;
        //        int proximocaderno = 0;
        //        var matricula = MATRICULA;
        //        string rota = TIPO_PROVA;
        //        Random random = new Random();

        //        if (rota.Equals("Rota Cruzada"))
        //        {
        //            FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
        //                .ToList()
        //                .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
        //                .Where(x => x.ID_CRIADOR == matricula)
        //                .Where(x => x.REGIONAL == REGIONAL)
        //                .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
        //                .Where(x => x.FIXA == FIXA).Any();

        //            if (FormularioExistente)
        //            {
        //                var maxcaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
        //                    .ToList()
        //                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
        //                    .Where(x => x.ID_CRIADOR == matricula)
        //                    .Where(x => x.REGIONAL == REGIONAL)
        //                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
        //                    .Where(x => x.FIXA == FIXA)
        //                    .Select(y => y.CADERNO).Max());

        //                //vai buscar a ultima prova com os parametros passados
        //                var datafinal = CD.JORNADA_BD_QUESTION_HISTORICOs
        //                .ToList()
        //                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
        //                    .Where(x => x.ID_CRIADOR == matricula)
        //                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
        //                    .Where(x => x.REGIONAL == REGIONAL)
        //                    .Where(x => x.FIXA == FIXA)
        //                    .Where(x => x.CADERNO == maxcaderno)
        //                    .Select(x => x.DT_FINALIZACAO).FirstOrDefault();

        //                if (string.IsNullOrEmpty(datafinal))
        //                {
        //                    //DateTime.Now > Convert.ToDateTime(datafinal)
        //                    //significa que o formulário está finalizado
        //                    return new JsonResult(new Response<string>
        //                    {
        //                        Data = "Tentativa de criação de formulário repetido",
        //                        Succeeded = false,
        //                        Message = "Desculpe já existe uma prova com os mesmos filtros associados ao seu usuário onde ainda não foi finalizada, por favor finalize a prova e tente novamente",
        //                        Errors = null,
        //                    });
        //                }

        //                proximocaderno = maxcaderno + 1;
        //            }
        //            else
        //            {
        //                proximocaderno = 1;
        //            }


        //            for (int i = 0; i < TEMAS_QUANTIDADE.Count(); i++)
        //            {
        //                InsertQuestionsRotaCruzadaIntoForm(REGIONAL, TEMAS_QUANTIDADE, CARGO, FIXA, Formulario, FormularioExistente, matricula, random, i);
        //            }
        //        }
        //        else // Caso seja Jornada
        //        { // Este looping faz o mesmo mas sem o parametro de matricula
        //            FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
        //                .ToList()
        //                .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
        //                .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
        //                .Where(x => x.REGIONAL == REGIONAL)
        //                .Where(x => x.FIXA == FIXA).Any();

        //            if (FormularioExistente)
        //            {
        //                proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
        //                .ToList()
        //                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
        //                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
        //                    .Where(x => x.REGIONAL == REGIONAL)
        //                    .Where(x => x.FIXA == FIXA)
        //                    .Select(y => y.CADERNO).Max() + 1);
        //            }
        //            else
        //            {
        //                proximocaderno = 1;
        //            }

        //            for (int i = 0; i < TEMAS_QUANTIDADE.Count(); i++)
        //            {
        //                InsertQuestionsJornadaIntoForm(REGIONAL, TEMAS_QUANTIDADE, CARGO, FIXA, Formulario, FormularioExistente, rota, random, i);
        //            }
        //        }

        //        if (Formulario.Count() <= 0 || Formulario is null)
        //        {
        //            return new JsonResult(new Response<string>
        //            {
        //                Data = "Algum erro ocorreu",
        //                Succeeded = false,
        //                Message = "Não foi encontrado nenhuma pergunta com esses filtros para o formulário",
        //                Errors = new string[]
        //                {
        //                    "Lista de perguntas retornou vazia"
        //                },
        //            });
        //        }
        //        if (Formulario.Count() < QTD_TOTAL_SOLICITADA)
        //        {
        //            return new JsonResult(new Response<string>
        //            {
        //                Data = "Algum erro ocorreu",
        //                Succeeded = false,
        //                Message = "A quantidade total de perguntadas encontradas não foi suficiente para o preenchimento do formulário",
        //                Errors = new string[]
        //                {
        //                    "Lista de perguntas retornou vazia"
        //                },
        //            });
        //        }

        //        InsertQuestionsIntoForm(REGIONAL, TIPO_PROVA, CARGO, FIXA, MATRICULA, DT_INIT, DT_FINAL, Formulario, proximocaderno);

        //        await CD.SaveChangesAsync();

        //        return new JsonResult(new Response<string>
        //        {
        //            Data = "Tudo certo!",
        //            Succeeded = true,
        //            Message = "O formulário foi criado corretamente",
        //            Errors = null,
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return new JsonResult(new Response<string>
        //        {
        //            Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
        //            Succeeded = false,
        //            Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
        //            Errors = new string[]
        //            {
        //                ex.Message,
        //                ex.StackTrace
        //            },
        //        });
        //    }
        //}

        [HttpPost("CreateFormulario")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> CreateFormulario(
               [FromBody] List<TEMAS_QTD>? TEMAS_QUANTIDADE,
               string TIPO_PROVA,
               int CARGO,
               bool FIXA,
               string REGIONAL,
               string MATRICULA,
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
                        .ToList()
                        .Where(x => x.CARGO == CARGO)
                        .Where(x => x.ID_CRIADOR == int.Parse(matricula))
                        .Where(x => x.REGIONAL == REGIONAL)
                        .Where(x => x.TP_FORMS == rota)
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        var maxcaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                            .ToList()
                            .Where(x => x.CARGO == CARGO)
                            .Where(x => x.ID_CRIADOR == int.Parse(matricula))
                            .Where(x => x.REGIONAL == REGIONAL)
                            .Where(x => x.TP_FORMS == "Rota Cruzada")
                            .Where(x => x.FIXA == FIXA)
                            .Select(y => y.CADERNO).Max());

                        //vai buscar a ultima prova com os parametros passados
                        var datafinal = CD.JORNADA_BD_QUESTION_HISTORICOs
                            .ToList()
                            .Where(x => x.CARGO == CARGO)
                            .Where(x => x.ID_CRIADOR == int.Parse(matricula))
                            .Where(x => x.TP_FORMS == "Rota Cruzada")
                            .Where(x => x.REGIONAL == REGIONAL)
                            .Where(x => x.FIXA == FIXA)
                            .Where(x => x.CADERNO == maxcaderno)
                            .Select(x => x.DT_FINALIZACAO).FirstOrDefault();

                        if (datafinal.HasValue)
                        {
                            //DateTime.Now > Convert.ToDateTime(datafinal)
                            //significa que o formulário está finalizado
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
                        .ToList()
                        .Where(x => x.CARGO == CARGO)
                        .Where(x => x.TP_FORMS == rota)
                        .Where(x => x.REGIONAL == REGIONAL)
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                        .ToList()
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
                        .ToList()
                        .Where(x => x.CARGO == CARGO)
                        .Where(x => x.TP_FORMS == rota)
                        .Where(x => x.REGIONAL == REGIONAL)
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                        .ToList()
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

                InsertQuestionsIntoForm(REGIONAL, TIPO_PROVA, CARGO, FIXA, MATRICULA, DT_INIT, DT_FINAL, Formulario, ELEGIVEL, proximocaderno);

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
        public JsonResult GetFormsRotaByUser(int CARGO, string MATRICULA, bool FIXA, string REGIONAL)
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
                    Cargos.Gerente_Revenda
                };

                IEnumerable<Cargos> CargosProvaGGP = new List<Cargos> // Cargos que iram ver prova de GA
                {
                    Cargos.Vendedor_PAP,
                    Cargos.Supervisor_PAP,
                    Cargos.Vendedor_Revenda,
                    Cargos.Gerente_Revenda,
                    Cargos.Gerente_Área
                };

                IEnumerable<Cargos> CargosProvaGV = new List<Cargos> // Cargos que iram ver prova de GA
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
                };

                IEnumerable<Cargos> CargosProvaJornadaGestorDireto = new List<Cargos> // Cargos que iram ver prova de Divisão
                {
                    Cargos.Vendedor_PAP,
                    Cargos.Supervisor_PAP,
                    Cargos.Vendedor_Revenda,
                    Cargos.Gerente_Revenda,
                    Cargos.Gerente_Operações,
                    Cargos.Consultor_Negócios,
                    Cargos.Consultor_Tecnológico
                };

                // Busca Provas de Rota
                List<JORNADA_BD_QUESTION_HISTORICO> questions = GetListaProvasRotaCruzadaDisponiveis(MATRICULA, userGet.ELEGIVEL.Value);

                // Busca Provas de Jornada Regional
                GetListaProvasJornadaDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet.ELEGIVEL.Value, out questionsjornada, out resposta);

                if (CargosProvaJornadaGestorDireto.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada 1-1 em PDV
                    GetListaProvasJornadaGestorDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, out questionsjornadaGestor, userGet.ELEGIVEL.Value);
                }
                else
                {
                    questionsjornadaGestor = new();
                }

                if (CargosProvaDivisao.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada por Divisão
                    GetListaProvasJornadaGestorDivisaoDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, userGet.ELEGIVEL.Value, out questionsjornadaGestorDivisao);
                }
                else
                {
                    questionsjornadaGestorDivisao = new();
                }

                if (CargosProvaGa.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada por GA
                    GetListaProvasJornadaGestorGADisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, userGet.ELEGIVEL.Value, out questionsjornadaGA);
                }
                else
                {
                    questionsjornadaGA = new();
                }
                if (CargosProvaGGP.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada por GGP
                    GetListaProvasJornadaGestorGGPDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, userGet.ELEGIVEL.Value, out questionsjornadaGGP);
                }
                else
                {
                    questionsjornadaGGP = new();
                }
                if (CargosProvaGV.Contains((Cargos)userGet.CARGO))
                {
                    // Busca Provas de Jornada por GV
                    GetListaProvasJornadaGestorGVDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, userGet, userGet.ELEGIVEL.Value, out questionsjornadaGV);
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
                    MATRICULA_AVALIADOR = x.MATRICULA_APLICADOR.ToString(),
                    NOME = x.NOME_APLICADOR,
                    CADERNO = x.CADERNO.ToString(),
                    NOTA = Convert.ToDouble(x.NOTA),
                    REDE_AVALIADA = x.REDE_AVALIADA,
                    DDD_AVALIADO = x.DDD_AVALIADO.ToString(),
                    PDV_AVALIADO = x.PDV_AVALIADO,
                    RE_AVALIADO = x.RE_AVALIADO.ToString(),
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
                    .Where(x => x.ID_CRIADOR == int.Parse(filter.Value.Matricula_Criador)
                    && x.REGIONAL == filter.Value.REGIONAL && x.ID_PROVA != null);
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

                //if (filter.Value.PeriodoCriacao is not null)
                //{
                //    if (filter.Value.PeriodoCriacao.Any())
                //    {
                //        if (filter.Value.PeriodoCriacao.Count() == 2)
                //        {
                //            DataProvas = DataProvas.Where(x => Convert.ToDateTime(x.DT_CRIACAO) > filter.Value.PeriodoCriacao[0]
                //            && Convert.ToDateTime(x.DT_CRIACAO) < filter.Value.PeriodoCriacao[1]);
                //        }
                //    }
                //}

                //if (filter.Value.PeriodoInicio is not null)
                //{
                //    if (filter.Value.PeriodoInicio.Any())
                //    {
                //        if (filter.Value.PeriodoInicio.Count() == 2)
                //        {
                //            DataProvas = DataProvas.Where(x => Convert.ToDateTime(x.DT_INICIO_AVALIACAO) > filter.Value.PeriodoInicio[0]
                //            && Convert.ToDateTime(x.DT_INICIO_AVALIACAO) < filter.Value.PeriodoInicio[1]);
                //        }
                //    }
                //}

                //if (filter.Value.PeriodoFinalizacao is not null)
                //{
                //    if (filter.Value.PeriodoFinalizacao.Any())
                //    {
                //        if (filter.Value.PeriodoFinalizacao.Count() == 2)
                //        {
                //            DataProvas = DataProvas.Where(x => Convert.ToDateTime(x.DT_FINALIZACAO) > filter.Value.PeriodoFinalizacao[0]
                //            && Convert.ToDateTime(x.DT_FINALIZACAO) < filter.Value.PeriodoFinalizacao[1]);
                //        }
                //    }
                //}

                var Provas = DataProvas
                    .ProjectTo<PROVA_REALIZADA_DTO>(_mapper.ConfigurationProvider)
                    .GroupBy(x => x.ID_PROVA)
                    .Select(x => new PROVA_REALIZADA_DTO()
                    {
                        ID_PROVA = x.Select(y => y.ID_PROVA).FirstOrDefault(),
                        ID_CRIADOR = x.Select(y => y.ID_CRIADOR).FirstOrDefault(),
                        TP_FORMS = x.Select(y => y.TP_FORMS).FirstOrDefault(),
                        CARGO = x.Select(y => y.CARGO).FirstOrDefault(),
                        ELEGIVEL = x.Select(y => y.ELEGIVEL).FirstOrDefault(),
                        CANAL = x.Select(y => y.CANAL).FirstOrDefault(),
                        FIXA = x.Select(y => y.FIXA).FirstOrDefault(),
                        CADERNO = x.Select(y => y.CADERNO).FirstOrDefault(),
                        DT_CRIACAO = x.Select(y => y.DT_CRIACAO).FirstOrDefault(),
                        DT_INICIO_AVALIACAO = x.Select(y => y.DT_INICIO_AVALIACAO).FirstOrDefault(),
                        DT_FINALIZACAO = x.Select(y => y.DT_FINALIZACAO).FirstOrDefault(),
                        Temas = new(),
                        SubTemas = new(),
                        Qtd_Respostas = CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(y => y.ID_PROVA == x.Select(k => k.ID_PROVA).FirstOrDefault()).Count(),
                        Qtd_Perguntas = x.Count(),
                        Sum_nota = CD.JORNADA_BD_ANSWER_AVALIACAOs
                                    .Where(y => y.ID_PROVA == x.Select(k => k.ID_PROVA).FirstOrDefault())
                                    .Select(x => x.NOTA).Sum()
                    }).AsQueryable();


                var Data = Provas.OrderByDescending(x => x.ID_PROVA)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize).ToList();


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

        private void InsertQuestionsIntoForm(
            string REGIONAL,
            string TIPO_PROVA,
            int CARGO,
            bool FIXA,
            string MATRICULA,
            string DT_INIT,
            string? DT_FINAL,
            List<JORNADA_BD_QUESTION> Formulario,
            bool ELEGIVEL,
            int proximocaderno)
        {
            var entityrelacao = CD.JORNADA_BD_RELACAO_HISTORICOs.Add(new JORNADA_BD_RELACAO_HISTORICO
            {
                LOGIN_MOD = MATRICULA,
                DT_MOD = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            }).Entity;
            CD.SaveChanges();

            foreach (var item in Formulario) // Adiciona as perguntas selecionadas a lista que será inserida no banco
            {
                var canal = DePara.CanalCargoEnum((Cargos)CARGO);

                if (Convert.ToDateTime(DT_FINAL) == DateTime.MinValue)
                {
                    DT_FINAL = null;
                }

                CD.JORNADA_BD_QUESTION_HISTORICOs.Add(new JORNADA_BD_QUESTION_HISTORICO
                {
                    CANAL = (int)canal,
                    CARGO = CARGO,
                    DT_CRIACAO = DateTime.Now,
                    ID_CRIADOR = int.Parse(MATRICULA),
                    ID_QUESTION = item.ID_QUESTION,
                    ID_PROVA = entityrelacao.ID_PROVA,
                    CADERNO = proximocaderno,
                    TP_FORMS = TIPO_PROVA,
                    DT_INICIO_AVALIACAO = Convert.ToDateTime(DT_INIT),
                    DT_FINALIZACAO = Convert.ToDateTime(DT_FINAL),
                    FIXA = FIXA,
                    REGIONAL = REGIONAL,
                    ELEGIVEL = ELEGIVEL
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

        private void InsertQuestionsRotaCruzadaIntoForm(
            string REGIONAL,
            List<TEMAS_QTD>? TEMAS_QUANTIDADE,
            int CARGO,
            bool FIXA,
            bool QuestoesRepetidas,
            List<JORNADA_BD_QUESTION> Formulario,
            bool FormularioExistente,
            string matricula,
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
                    .Where(x => x.ID_CRIADOR == int.Parse(matricula))
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

        private List<JORNADA_BD_QUESTION_HISTORICO> GetListaProvasRotaCruzadaDisponiveis(string MATRICULA, bool ELEGIVEL)
        {
            var actual = DateTime.Now;
            var questions = CD.JORNADA_BD_QUESTION_HISTORICOs
                            .Where(x => x.ID_CRIADOR == int.Parse(MATRICULA))
                            .Where(y => y.TP_FORMS == "Rota Cruzada")
                            .OrderByDescending(x => x.ID_PROVA)
                            .ToList();

            // Este código filtrava as questões de rota cruzada para apenas questões que tem a data de init
            // abaixo do momento da solicitação e quanddo a data de finalização está nula

            questions = questions
                           .Where(x => Convert.ToDateTime(x.DT_INICIO_AVALIACAO) < actual) // Data inicial deve ser maior que hoje
                           .Where(x => x.DT_FINALIZACAO.HasValue) // Data de finalização nula
                           .ToList();

            return questions;
        }

        private void GetListaProvasJornadaDisponiveis(
            string REGIONAL,
            int CARGO,
            string MATRICULA,
            bool FIXA,
            bool ELEGIVEL,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornada,
            out bool resposta)
        {
            var actual = DateTime.Now;
            var maxcadernojornada = CD.JORNADA_BD_QUESTION_HISTORICOs // Buscar o caderno maximo baseado nos parametros
            .Where(y => y.TP_FORMS == "Jornada")
            .Where(y => y.CARGO == CARGO)
            .Where(y => y.FIXA == FIXA)
            .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
            .Where(y => y.REGIONAL == REGIONAL)
            .Max(y => y.CADERNO);

            questionsjornada = CD.JORNADA_BD_QUESTION_HISTORICOs
            .Where(y => y.TP_FORMS == "Jornada")
            .Where(y => y.CARGO == CARGO)
            .Where(y => y.FIXA == FIXA)
            .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
            .Where(y => y.REGIONAL == REGIONAL)
            .Where(y => y.CADERNO == maxcadernojornada)
            .ToList();

            questionsjornada = questionsjornada
                .Where(x => Convert.ToDateTime(x.DT_INICIO_AVALIACAO) < actual) // Data inicial deve ser maior que hoje
                .Where(x => Convert.ToDateTime(x.DT_FINALIZACAO).AddHours(23).AddMinutes(59) > actual) // Data final deve ser menor que hoje
                .ToList();

            resposta = CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                .Where(x => x.PUBLICO_CARGO == CARGO
                && x.CADERNO == maxcadernojornada
                && x.MATRICULA_APLICADOR == int.Parse(MATRICULA)
                && x.REGIONAL == REGIONAL
                && x.TP_FORMS == "Jornada").Any();
        }

        private void GetListaProvasJornadaGestorDisponiveis(
            string REGIONAL,
            int CARGO,
            string MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor,
            bool ELEGIVEL)
        {
            questionsjornadaGestor = new();
            var cargosGestor = new List<int> { 3, 6, 8 };
            IEnumerable<ACESSOS_MOBILE> Criador = CD.ACESSOS_MOBILEs.Where(y =>
                CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.TP_FORMS == "Jornada Gestor")
                    .Select(x => x.ID_CRIADOR.Value.ToString())
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
                    .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => y.FIXA == FIXA)
                    .Where(y => y.REGIONAL == REGIONAL)
                    .Where(y => y.ID_CRIADOR.ToString() == Gestor.MATRICULA)
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
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == int.Parse(MATRICULA))
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
            string MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            bool ELEGIVEL,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            if ((Cargos)usuario.CARGO == Cargos.Gerente_Área)
            {
                JORNADA_BD_CARTEIRA_DIVISAO? PDVDivisão = CD.JORNADA_BD_CARTEIRA_DIVISAOs
                .Where(x => x.RE_GA != null)
                .Where(x => x.RE_GA == usuario.MATRICULA).FirstOrDefault();

                if (PDVDivisão is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.DIVISAO.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
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
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == int.Parse(MATRICULA))
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
                JORNADA_BD_CARTEIRA_DIVISAO? PDVDivisão = CD.JORNADA_BD_CARTEIRA_DIVISAOs
                .Where(x => x.RE_GGP != null)
                .Where(x => x.RE_GGP == usuario.MATRICULA).FirstOrDefault();

                if (PDVDivisão is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.DIVISAO.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
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
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == int.Parse(MATRICULA))
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
                JORNADA_BD_CARTEIRA_DIVISAO? PDVDivisão = CD.JORNADA_BD_CARTEIRA_DIVISAOs
                .Where(x => x.RE_GV != null)
                .Where(x => x.RE_GV == usuario.MATRICULA).FirstOrDefault();

                if (PDVDivisão is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.DIVISAO.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
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
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == int.Parse(MATRICULA))
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
                JORNADA_BD_CARTEIRA_DIVISAO PDVDivisão = CD.JORNADA_BD_CARTEIRA_DIVISAOs
                    .Where(x => x.Vendedor == usuario.PDV).FirstOrDefault();

                if (PDVDivisão is not null)
                {
                    var actual = DateTime.Now;
                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == PDVDivisão.DIVISAO.Value)
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
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
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == int.Parse(MATRICULA))
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
            string MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            bool ELEGIVEL,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            JORNADA_BD_CARTEIRA_DIVISAO PDVDivisão = CD.JORNADA_BD_CARTEIRA_DIVISAOs
                .Where(x => x.Vendedor == usuario.PDV).FirstOrDefault();

            if (PDVDivisão is not null)
            {
                if (PDVDivisão.RE_GA is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == int.Parse(PDVDivisão.RE_GA))
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
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
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == int.Parse(MATRICULA))
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
            string MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            bool ELEGIVEL,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            JORNADA_BD_CARTEIRA_DIVISAO PDVDivisão = CD.JORNADA_BD_CARTEIRA_DIVISAOs
                .Where(x => x.Vendedor == usuario.PDV).FirstOrDefault();

            if (PDVDivisão is not null)
            {
                if (PDVDivisão.RE_GGP is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == int.Parse(PDVDivisão.RE_GGP))
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
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
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == int.Parse(MATRICULA))
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
            string MATRICULA,
            bool FIXA,
            ACESSOS_MOBILE usuario,
            bool ELEGIVEL,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornadaGestor)
        {
            JORNADA_BD_CARTEIRA_DIVISAO PDVDivisão = CD.JORNADA_BD_CARTEIRA_DIVISAOs
                .Where(x => x.Vendedor == usuario.PDV).FirstOrDefault();

            if (PDVDivisão is not null)
            {
                if (PDVDivisão.RE_GV is not null)
                {
                    var actual = DateTime.Now;

                    questionsjornadaGestor = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(y => y.TP_FORMS == "Jornada Gestor")
                    .Where(y => y.ID_CRIADOR == int.Parse(PDVDivisão.RE_GV))
                    .Where(y => y.CARGO == CARGO)
                    .Where(y => (ELEGIVEL == true ? y.FIXA == FIXA : y.ELEGIVEL != null))
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
                        .Where(x => item == x.ID_PROVA && x.RE_AVALIADO == int.Parse(MATRICULA))
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
