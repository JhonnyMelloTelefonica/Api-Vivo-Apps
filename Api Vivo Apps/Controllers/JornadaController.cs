using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Vivo_Apps_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared_Class_Vivo_Apps.Data;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using Shared_Class_Vivo_Apps.ModelDTO;
using static Shared_Class_Vivo_Apps.Model_DTO.JORNADA_DTO;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using Shared_Class_Vivo_Apps.Model_DTO.FilterModels;
using System.Linq;
using DocumentFormat.OpenXml.Drawing;
using System.Drawing;
using Shared_Class_Vivo_Apps.Model_DTO;
using Shared_Class_Vivo_Apps.Enums;
using DocumentFormat.OpenXml.Drawing.Charts;
using DataTable = System.Data.DataTable;
using Microsoft.AspNetCore.StaticFiles;
using DocumentFormat.OpenXml.Office2010.Excel;
using OfficeOpenXml;
using HtmlAgilityPack;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JornadaController : ControllerBase
    {
        private readonly ILogger<JornadaController> _logger;
        private readonly IMapper _mapper;

        public JornadaController(ILogger<JornadaController> logger)
        {
            _logger = logger;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_DTO>()
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => (Cargos)src.CARGO)
                    )
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => (Canal)src.CANAL)
                    );

                cfg.CreateMap<JORNADA_BD_HIERARQUIum, JORNADA_HIERARQUIA_DTO>()
                .ForMember(
                    dest => dest.DT_MOD,
                    opt => opt.MapFrom(src => Convert.ToDateTime(src.DT_MOD))
                    )
                .ForMember(
                    dest => dest.LOGIN_MOD,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs
                    .Where(x => x.MATRICULA == src.LOGIN_MOD.ToString()).FirstOrDefault()))
                .ForMember(
                    dest => dest.RE_DIVISAO,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs
                    .Where(x => x.MATRICULA == (src.RE_DIVISAO != null ? src.RE_DIVISAO.Value.ToString() : "")).FirstOrDefault()))
                .ForMember(
                    dest => dest.RE_GA,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs
                    .Where(x => x.MATRICULA == src.RE_GA).FirstOrDefault()))
                .ForMember(
                    dest => dest.RE_GP,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs
                    .Where(x => x.MATRICULA == src.RE_GP).FirstOrDefault()))
                .ForMember(
                    dest => dest.RE_GV,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs
                    .Where(x => x.MATRICULA == src.RE_GV).FirstOrDefault()));

            });
            _mapper = config.CreateMapper();
        }

        private Vivo_MaisContext CD = new Vivo_MaisContext();
        private string[] listaAdm = new string[] { "Gerente Geral", "GA", "Adm_Consumer", "GO", "Vendas_Adm" };

        [HttpGet("GetQuestions")]
        public string GetQuestions() => JsonConvert.SerializeObject(CD.Carteira_NEs.AsEnumerable());
        [HttpPost("GetAvatarImage")]
        public string GetAvatarImage(string matricula) => JsonConvert.SerializeObject(CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == matricula).FirstOrDefault().UserAvatar);

        [HttpGet("GetCNS_BASE_TERCEIROS")]
        public async Task<string> GetCNS_BASE_TERCEIROS()
        {
            try
            {
                string selectTopics = "select * FROM CNS_BASE_TERCEIROS_SAP_GT";
                var dataTable = new DataTable();
                List<BASE_SAP_GT> list = new List<BASE_SAP_GT>();

                using (SqlConnection con = new SqlConnection(CD.Database.GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand();


                    cmd.CommandText = selectTopics;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow item in dataTable.Rows)
                        {
                            list.Add(new BASE_SAP_GT
                            {
                                CPF = item[0].ToString(),
                                PIS = item[1].ToString(),
                                MATRICULA = item[2].ToString(),
                                Nome = item[3].ToString(),
                                CARGO = item[4].ToString(),
                                ANOMES = item[5].ToString(),
                            });
                        }
                    }

                    con.Close();
                }
                return JsonConvert.SerializeObject(list);
            }
            catch (Exception ex)
            {
                return $"500 --> {ex.Message} ------- {ex}";
            }
        }

        [HttpGet("GetAllJornadas")]
        public string GetAllJornadas() => JsonConvert.SerializeObject(CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.TP_FORMS == "Jornada"));

        [HttpPost("UpdateAvatarImage")]
        public bool UpdateAvatarImage([FromBody] AvatarImageModel data)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == data.matricula).FirstOrDefault();
                user.UserAvatar = data.bytes;
                CD.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetDataToCreateForm")]
        public string GetDataToCreateForm() => JsonConvert.SerializeObject(CD.Carteira_NEs
            .Select(x => new { x.Vendedor, x.Uf, x.REDE, x.DDD_LOCALIDADE_PDV, x.ANOMES })
            .Where(x => x.ANOMES == CD.Carteira_NEs.Max(y => y.ANOMES))
            .AsEnumerable());

        [HttpPost("GetProvaById")]
        public string GetProvaById(int id) => JsonConvert.SerializeObject(CD.JORNADA_BD_AVALIACAO_RETORNOs.Where(x => x.ID == id).FirstOrDefault());
        [HttpPost("GetLoginSenha")]
        public JsonResult GetLoginSenha(string matricula) => new JsonResult(CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == matricula).FirstOrDefault());
        //[HttpGet("GetListaRoles")]
        //public string GetListaRoles() => JsonConvert.SerializeObject(CD.PERFIL_Vivo_Xs.AsEnumerable());

        [HttpPost("InsertRespostasProva")]
        public string InsertRespostasProva(Respostas data)
        {
            try
            {
                foreach (var item in data.RESPOSTAS.Distinct())
                {
                    CD.JORNADA_BD_AVALIACAO_RETORNOs.Add(new JORNADA_BD_AVALIACAO_RETORNO
                    {
                        ID_QUESTION = item.ID_QUESTION,
                        ID_TEMAS = item.TEMA,
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
                        STATUS_RESPOSTA = item.STATUS_RESPOSTA
                    });
                }
                CD.SaveChanges();
                return $"200 -> {data}";
            }
            catch (Exception ex)
            {
                return $"500 -> {ex.Message} ----------------- {ex.ToString()}";
            }
        }
        [HttpPost("InsertResultadoProva")]
        public string InsertResultadoProva(Prova data)
        {
            try
            {
                CD.JORNADA_BD_ANSWER_AVALIACAOs.Add(new JORNADA_BD_ANSWER_AVALIACAO
                {
                    ID_TEMAS = data.TEMA,
                    TP_FORMS = data.TP_FORMS,
                    PUBLICO_CANAL = data.PUBLICO_CANAL,
                    PUBLICO_CARGO = data.PUBLICO_CARGO,
                    DT_AVALIACAO = data.DT_AVALIACAO,
                    MATRICULA_APLICADOR = data.MATRICULA_APLICADOR,
                    NOME_APLICADOR = data.NOME_APLICADOR,
                    CADERNO = data.CADERNO,
                    NOTA = decimal.Parse(data.NOTA),
                    REDE_AVALIADA = data.REDE_AVALIADA,
                    DDD_AVALIADO = data.DDD_AVALIADO,
                    PDV_AVALIADO = data.PDV_AVALIADO,
                    RE_AVALIADO = data.RE_AVALIADO
                });

                CD.SaveChanges();
                return $"{data.ID}";
            }
            catch (Exception ex)
            {
                return $"500 -> {ex.Message} --------------- {ex.ToString()}";
            }
        }

        //[HttpPost("FinalizarForm")]
        //public string FinalizarForm(FinalizarForm data)
        //{
        //    try
        //    {
        //        IEnumerable<int> Ids = CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.ID_CRIADOR == data.ID_CRIADOR
        //        && x.FIXA == data.FIXA
        //        && x.CARGO == data.CARGO
        //        && x.TP_FORMS == data.TP_FORMS
        //        && x.CADERNO == data.CADERNO).Select(x => x.ID_PROVA).AsEnumerable();
        //        foreach (var item in CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => Ids.Contains(x.ID_PROVA)))
        //        {
        //            item.DT_FINALIZACAO = DateTime.Now.ToString();
        //        }
        //        CD.SaveChanges();

        //        return $"Tudo Certo -> {Ids}";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"Algum erro ocorreu log: {ex.Message} -------- {ex.ToString()}";
        //    }
        //}

        [HttpGet("GetDataQuestions")]
        public string GetDataQuestions()
        {
            return JsonConvert.SerializeObject(CD.JORNADA_BD_QUESTIONs.GroupBy(x => new
            {
                x.FIXA,
                x.ID_TEMAS,
                x.CARGO,
                x.TP_FORMS
            }).Select(y => new
            {
                y.Key.ID_TEMAS,
                y.Key.CARGO,
                y.Key.FIXA,
                y.Key.TP_FORMS,
                QTDE = y.Count()
            }).AsEnumerable());
        }

        [HttpPost("GetFormRota")]
        public string GetFormRota([FromBody] FormDisponivel data)
        {
            var questions = CD.JORNADA_BD_QUESTION_HISTORICOs
            .Where(x => x.TP_FORMS == "Rota Cruzada" && x.ID_CRIADOR == data.MATRICULA).OrderByDescending(x => x.CADERNO).ToList();


            questions = questions.Where(x =>
            string.IsNullOrEmpty(x.DT_FINALIZACAO) &&
            Convert.ToDateTime(x.DT_INICIO_AVALIACAO) <= DateTime.Now).ToList();

            questions.ConvertAll(x => x.DT_FINALIZACAO = null);

            return JsonConvert.SerializeObject(questions);
        }

        [HttpPost("Get_List_Resultado_Prova")]
        public string Get_List_Resultado_Prova(string matricula, string cargo)
        {
            return listaAdm.Contains(cargo) ?
                JsonConvert.SerializeObject(CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(x => x.MATRICULA_APLICADOR == matricula || x.RE_AVALIADO == matricula).AsEnumerable()) :
                JsonConvert.SerializeObject(CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(x => x.RE_AVALIADO == matricula).AsEnumerable());
        }

        [HttpPost("GetQuestionsById_Prova")]
        public string GetQuestionsById_Prova(int id)
        {
            return JsonConvert.SerializeObject(CD.JORNADA_BD_AVALIACAO_RETORNOs.Where(x => x.ID_PROVA_RESPONDIDA == id).ToList());
        }


        //[HttpPost("GetFormJornada")]
        //public string GetFormJornada([FromBody] FormDisponivelJornada data)
        //{
        //    try
        //    {
        //        var actual = DateTime.Now;
        //        var maxcaderno = CD.JORNADA_BD_QUESTION_HISTORICOs // Buscar o caderno maximo baseado nos parametros
        //        .Where(y => y.TP_FORMS == "Jornada"
        //        && y.CARGO == data.CARGO
        //        && y.FIXA == data.FIXA)
        //        .Max(y => y.CADERNO);

        //        var questions = CD.JORNADA_BD_QUESTION_HISTORICOs
        //        .Where(x => x.TP_FORMS == "Jornada"
        //        && x.CARGO == data.CARGO
        //        && x.FIXA == data.FIXA
        //        && x.CADERNO == maxcaderno).ToList();

        //        questions = questions.Where(x => Convert.ToDateTime(x.DT_FINALIZACAO) > actual && Convert.ToDateTime(x.DT_INICIO_AVALIACAO) < DateTime.Now).ToList();

        //        var resposta = CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
        //            .Where(x => x.PUBLICO_CARGO == data.CARGO
        //            && x.CADERNO == maxcaderno.ToString()
        //            && x.MATRICULA_APLICADOR == data.MATRICULA
        //            && x.TP_FORMS == "Jornada");

        //        if (resposta.Count() > 0)
        //        {
        //            return "[]";
        //        }
        //        else
        //        {
        //            return JsonConvert.SerializeObject(questions);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        return $"500 -> {ex.Message} ----------------- {ex.ToString()}";
        //    }
        //}

        [HttpGet("GetAllRotaByMAT")]
        public string GetAllRotaByMAT(string matricula) =>
            JsonConvert.SerializeObject(CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.TP_FORMS == "Rota Cruzada" && x.ID_CRIADOR == matricula && x.DT_FINALIZACAO == null));

        [HttpPost("GetFormulario")]
        public string GetFormulario([FromBody] IEnumerable<int> Questions)
        {

            var questions = CD.JORNADA_BD_QUESTIONs.Where(x => Questions.Contains(x.ID_QUESTION)).Select(x => new
            {
                ID_QUESTION = x.ID_QUESTION,
                TEMA = x.ID_TEMAS,
                TP_FORMS = x.TP_FORMS,
                TP_QUESTAO = x.TP_QUESTAO,
                PERGUNTA = x.PERGUNTA,
                REGIONAL = x.REGIONAL,
                PESO = x.PESO,
                EXPLICACAO = x.EXPLICACAO,
                CANAL = x.CANAL,
                CARGO = x.CARGO,
                STATUS_QUESTION = x.STATUS_QUESTION,
                ALTERNATIVAS = CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Where(y => y.ID_QUESTION == x.ID_QUESTION).AsEnumerable(),
            }).ToList();
            return JsonConvert.SerializeObject(questions);
        }

        /* Comandos Carteira Hierarquia Jornada */

        [HttpPost("GetHierarquiaJornada")]
        [ProducesResponseType(typeof(Response<PagedModelResponse<IEnumerable<JORNADA_HIERARQUIA_DTO>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetHierarquiaJornada([FromBody] GenericPaginationModel<PaginationFilterHierarquiaJornada> filter)
        {
            try
            {
                var dataBeforeFilter = CD.JORNADA_BD_HIERARQUIAs.AsQueryable();

                if (!string.IsNullOrEmpty(filter.Value.AnyColumnMatch))
                {
                    dataBeforeFilter = dataBeforeFilter.Where(x =>
                        filter.Value.AnyColumnMatch.Contains(x.ADABAS)
                    );
                }

                if (filter.Value.REGIONAL.Any())
                {
                    dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.REGIONAL.Contains(x.REGIONAL));
                }

                if (filter.Value.DDD.Any())
                {
                    dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.DDD.Contains(x.DDD.Value));
                }

                if (filter.Value.NOMEFANTASIA.Any())
                {
                    dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.NOMEFANTASIA.Contains(x.NOME_FANTASIA));
                }

                var dataAfterFilter = dataBeforeFilter.OrderByDescending(x => x.ID)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize);


                var demandas = dataAfterFilter.AsNoTracking()
                        .ProjectTo<JORNADA_HIERARQUIA_DTO>(_mapper.ConfigurationProvider).AsEnumerable();

                var totalRecords = dataBeforeFilter.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<JORNADA_HIERARQUIA_DTO>>>
                {
                    Data = PagedResponse.CreatePagedReponse<JORNADA_HIERARQUIA_DTO, PaginationFilterHierarquiaJornada>(demandas, filter, totalRecords),
                    Succeeded = true,
                    Message = $"Tudo certo!",
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

        [HttpPost("GetUsersByCargo")]
        [ProducesResponseType(typeof(Response<IEnumerable<ACESSOS_MOBILE_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetUsersByCargo([FromBody] List<Cargos> cargos)
        {
            try
            {
                var saida = CD.ACESSOS_MOBILEs.ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                    .Where(x => cargos.Contains(x.CARGO)).AsEnumerable();

                return new JsonResult(new Response<IEnumerable<ACESSOS_MOBILE_DTO>>
                {
                    Data = saida,
                    Succeeded = true,
                    Message = $"Tudo certo!",
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

        [HttpPost("AddPdvHierarquiaMassivo")]
        [ProducesResponseType(typeof(Response<JORNADA_HIERARQUIA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult AddPdvHierarquiaMassivo([FromBody] List<JORNADA_BD_HIERARQUIum> pdvs, string matricula)
        {
            foreach (var newpdv in pdvs)
            {
                var saida = CD.JORNADA_BD_HIERARQUIAs.Add(new JORNADA_BD_HIERARQUIum
                {
                    ADABAS = newpdv.ADABAS,
                    NOME_FANTASIA = newpdv.NOME_FANTASIA,
                    REDE = newpdv.REDE,
                    UF = newpdv.UF,
                    DDD = newpdv.DDD,
                    REGIONAL = newpdv.REGIONAL,
                    RE_DIVISAO = newpdv.RE_DIVISAO != null ? newpdv.RE_DIVISAO : null,
                    RE_GA = newpdv.RE_GA != null ? newpdv.RE_GA : null,
                    RE_GP = newpdv.RE_GP != null ? newpdv.RE_GP : null,
                    RE_GV = newpdv.RE_GV != null ? newpdv.RE_GV : null,
                    STATUS = true,
                    CANAL = newpdv.CANAL,
                    LOGIN_MOD = int.Parse(matricula),
                    DT_MOD = DateTime.Now,
                }).Entity;
            }

            var alterados = CD.SaveChanges();
            
            try
            {
                return new JsonResult(new Response<string>
                {
                    Data = $"{alterados} novos foram adicionados com sucesso!",
                    Succeeded = true,
                    Message = $"{alterados} novos foram adicionados com sucesso!",
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

        [HttpPost("AddPdvHierarquia")]
        [ProducesResponseType(typeof(Response<JORNADA_HIERARQUIA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult AddPdvHierarquia([FromBody] JORNADA_HIERARQUIA_DTO newpdv, string matricula)
        {
            var saida = CD.JORNADA_BD_HIERARQUIAs.Add(new JORNADA_BD_HIERARQUIum
            {
                ADABAS = newpdv.ADABAS,
                NOME_FANTASIA = newpdv.NOME_FANTASIA,
                REDE = newpdv.REDE,
                UF = newpdv.UF,
                DDD = newpdv.DDD,
                REGIONAL = newpdv.REGIONAL,
                RE_DIVISAO = newpdv.RE_DIVISAO != null ? double.Parse(newpdv.RE_DIVISAO.MATRICULA) : null,
                RE_GA = newpdv.RE_GA != null ? newpdv.RE_GA.MATRICULA : null,
                RE_GP = newpdv.RE_GP != null ? newpdv.RE_GP.MATRICULA : null,
                RE_GV = newpdv.RE_GV != null ? newpdv.RE_GV.MATRICULA : null,
                STATUS = true,
                CANAL = newpdv.CANAL,
                LOGIN_MOD = int.Parse(matricula),
                DT_MOD = DateTime.Now,
            }).Entity;

            CD.SaveChanges();
            var saidamapped = _mapper.Map<JORNADA_HIERARQUIA_DTO>(saida);
            try
            {

                return new JsonResult(new Response<JORNADA_HIERARQUIA_DTO>
                {
                    Data = saidamapped,
                    Succeeded = true,
                    Message = $"O Pdv foi criado com sucesso!",
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

        [HttpPost("EditPdvHierarquia")]
        [ProducesResponseType(typeof(Response<JORNADA_HIERARQUIA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult EditPdvHierarquia([FromBody] JORNADA_HIERARQUIA_DTO pdv, string matricula)
        {
            var saida = CD.JORNADA_BD_HIERARQUIAs.Find(pdv.ID);
            if (saida is not null)
            {
                saida.ADABAS = pdv.ADABAS;
                saida.NOME_FANTASIA = pdv.NOME_FANTASIA;
                saida.REDE = pdv.REDE;
                saida.UF = pdv.UF;
                saida.DDD = pdv.DDD;
                saida.CANAL = pdv.CANAL;
                saida.REGIONAL = pdv.REGIONAL;
                saida.STATUS = pdv.STATUS;
                saida.RE_DIVISAO = pdv.RE_DIVISAO != null ? double.Parse(pdv.RE_DIVISAO.MATRICULA) : null;
                saida.RE_GA = pdv.RE_GA != null ? pdv.RE_GA.MATRICULA : null;
                saida.RE_GP = pdv.RE_GP != null ? pdv.RE_GP.MATRICULA : null;
                saida.RE_GV = pdv.RE_GV != null ? pdv.RE_GV.MATRICULA : null;
                saida.LOGIN_MOD = int.Parse(matricula);
                saida.DT_MOD = DateTime.Now;
            }
            CD.SaveChanges();
            var saidamapped = _mapper.Map<JORNADA_HIERARQUIA_DTO>(saida);

            try
            {
                return new JsonResult(new Response<JORNADA_HIERARQUIA_DTO>
                {
                    Data = saidamapped,
                    Succeeded = true,
                    Message = $"O PDV {saida.ADABAS} foi alterado com sucesso!",
                    Errors = new string[] { },
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

        [HttpPost("EditPdvHierarquiaMassivo")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult EditPdvHierarquiaMassivo([FromBody] List<JORNADA_BD_HIERARQUIum> listapdv, string matricula)
        {
            foreach (var pdv in listapdv)
            {
                var saida = CD.JORNADA_BD_HIERARQUIAs.Find(pdv.ID);
                if (saida is not null)
                {
                    saida.ADABAS = pdv.ADABAS;
                    saida.NOME_FANTASIA = pdv.NOME_FANTASIA;
                    saida.REDE = pdv.REDE;
                    saida.UF = pdv.UF;
                    saida.DDD = pdv.DDD;
                    saida.CANAL = pdv.CANAL;
                    saida.REGIONAL = pdv.REGIONAL;
                    saida.STATUS = true;
                    saida.RE_DIVISAO = pdv.RE_DIVISAO != null ? pdv.RE_DIVISAO : null;
                    saida.RE_GA = pdv.RE_GA != null ? pdv.RE_GA : null;
                    saida.RE_GP = pdv.RE_GP != null ? pdv.RE_GP : null;
                    saida.RE_GV = pdv.RE_GV != null ? pdv.RE_GV : null;
                    saida.LOGIN_MOD = int.Parse(matricula);
                    saida.DT_MOD = DateTime.Now;
                }
            }
            var alterados = CD.SaveChanges();

            try
            {
                return new JsonResult(new Response<string>
                {
                    Data = $"{alterados} foram alterados com sucesso!",
                    Succeeded = true,
                    Message = $"{alterados} foram alterados com sucesso!",
                    Errors = new string[] { },
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

        [HttpPost("ChangeStatusPdvHierarquia")]
        [ProducesResponseType(typeof(Response<JORNADA_HIERARQUIA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult ChangeStatusPdvHierarquia([FromBody] JORNADA_HIERARQUIA_DTO pdv, string matricula)
        {
            var saida = CD.JORNADA_BD_HIERARQUIAs.Find(pdv.ID);
            if (saida is not null)
            {
                saida.STATUS = !pdv.STATUS;
                saida.LOGIN_MOD = int.Parse(matricula);
                saida.DT_MOD = DateTime.Now;
            }

            CD.SaveChanges();

            var saidamapped = _mapper.Map<JORNADA_HIERARQUIA_DTO>(saida);

            try
            {
                return new JsonResult(new Response<JORNADA_HIERARQUIA_DTO>
                {
                    Data = saidamapped,
                    Succeeded = true,
                    Message = $"O status do PDV {saida.ADABAS} foi alterado com sucesso!",
                    Errors = new string[] { },
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

        [HttpPost("GetHierarquiaJornadaToExcel")]
        [ProducesResponseType(typeof(Response<PagedModelResponse<IEnumerable<JORNADA_HIERARQUIA_DTO>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetHierarquiaJornadaToExcel([FromBody] GenericPaginationModel<PaginationFilterHierarquiaJornada> filter)
        {
            try
            {
                var dataBeforeFilter = CD.JORNADA_BD_HIERARQUIAs.AsQueryable();

                if (!string.IsNullOrEmpty(filter.Value.AnyColumnMatch))
                {
                    dataBeforeFilter = dataBeforeFilter.Where(x =>
                        filter.Value.AnyColumnMatch.Contains(x.ADABAS)
                    );
                }

                if (filter.Value.REGIONAL.Any())
                {
                    dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.REGIONAL.Contains(x.REGIONAL));
                }

                if (filter.Value.DDD.Any())
                {
                    dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.DDD.Contains(x.DDD.Value));
                }

                if (filter.Value.NOMEFANTASIA.Any())
                {
                    dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.NOMEFANTASIA.Contains(x.NOME_FANTASIA));
                }

                var dataAfterEntity = dataBeforeFilter.AsNoTracking()
                        .ProjectTo<JORNADA_HIERARQUIA_DTO>(_mapper.ConfigurationProvider).AsEnumerable();

                string templatepath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates//Jornada_bd_hierarquia_Model.html");
                string htmldata = System.IO.File.ReadAllText(templatepath);

                var excelstring = new System.Text.StringBuilder();

                foreach (var blocao in dataAfterEntity)
                {
                    excelstring.Append("<tr>");
                    excelstring.Append($"<td>{blocao.ID} </td>");
                    excelstring.Append($"<td>{blocao.ADABAS}</td>");
                    excelstring.Append($"<td>{blocao.NOME_FANTASIA}</td>");
                    excelstring.Append($"<td>{blocao.REDE}</td>");
                    excelstring.Append($"<td>{blocao.UF}</td>");
                    excelstring.Append($"<td>{blocao.DDD}</td>");
                    excelstring.Append($"<td>{blocao.REGIONAL}</td>");
                    excelstring.Append($"<td>{blocao.RE_DIVISAO?.MATRICULA}</td>");
                    excelstring.Append($"<td>{blocao.RE_GA?.MATRICULA}</td>");
                    excelstring.Append($"<td>{blocao.RE_GP?.MATRICULA}</td>");
                    excelstring.Append($"<td>{blocao.RE_GV?.MATRICULA}</td>");
                    excelstring.Append($"<td>{blocao.CANAL}</td>");
                    excelstring.Append("</tr>");
                }
                htmldata = htmldata.Replace("@@ActualData", excelstring.ToString());

                // Convertendo HTML para DataTable
                DataTable dataTable = ConvertHtmlTableToDataTable(htmldata);

                // Convertendo DataTable para XLSX
                string StoredFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates", "Excel_Saida.xlsx");

                if (System.IO.File.Exists(StoredFilePath))
                {
                    System.IO.File.Delete(StoredFilePath);
                }

                ExportToExcel(dataTable, StoredFilePath);

                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(StoredFilePath, out var contentType))
                {
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                }

                var bytes = await System.IO.File.ReadAllBytesAsync(StoredFilePath);

                return new JsonResult(new Response<FileContentResult>
                {
                    Data = File(bytes, contentType, System.IO.Path.Combine(StoredFilePath)),
                    Succeeded = true,
                    Message = "O excel foi gerado corretamente baseando-se nos filtros atuais, aguarde o download."
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

        static DataTable ConvertHtmlTableToDataTable(string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            DataTable table = new DataTable();

            // Obtendo a primeira linha para criar colunas
            HtmlNodeCollection headerRows = doc.DocumentNode.SelectNodes("//table/tr");
            if (headerRows != null)
            {
                foreach (HtmlNode headerRow in headerRows.Take(1))
                {
                    foreach (HtmlNode cell in headerRow.SelectNodes("th|td"))
                    {
                        table.Columns.Add(cell.InnerText.Trim());
                    }
                }
            }

            // Adicionando linhas de dados
            HtmlNodeCollection dataRows = doc.DocumentNode.SelectNodes("//table/tr[position()>1]");
            if (dataRows != null)
            {
                foreach (HtmlNode dataRow in dataRows)
                {
                    DataRow row = table.NewRow();
                    int columnIndex = 0;

                    foreach (HtmlNode cell in dataRow.SelectNodes("th|td"))
                    {
                        row[columnIndex] = cell.InnerText.Trim();
                        columnIndex++;
                    }

                    table.Rows.Add(row);
                }
            }

            return table;
        }

        static void ExportToExcel(DataTable dataTable, string outputPath)
        {
            FileInfo newFile = new FileInfo(outputPath);

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Adicionando cabeçalho
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                }

                // Adicionando dados
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j];
                    }
                }

                // Salvar o arquivo XLSX
                package.Save();
            }
        }

    }
}
