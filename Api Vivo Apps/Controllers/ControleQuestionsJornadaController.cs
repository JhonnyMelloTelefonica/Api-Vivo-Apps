using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Vivo_Apps_API.Models;
using Shared_Class_Vivo_Apps.Data;
using System.Drawing;
using Newtonsoft.Json;
using Shared_Class_Vivo_Apps.Enums;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using static Shared_Class_Vivo_Apps.Model_DTO.JORNADA_DTO;
using static Vivo_Apps_API.Converters.Converters;
using Shared_Class_Vivo_Apps.Models;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControleQuestionsJornadaController : ControllerBase
    {
        private Vivo_MaisContext CD = new Vivo_MaisContext();

        private readonly ILogger<ControleQuestionsJornadaController> _logger;

        public ControleQuestionsJornadaController(ILogger<ControleQuestionsJornadaController> logger)
        {
            _logger = logger;
        }

        [HttpPost("CreateQuestionMassivo")]
        public async Task<JsonResult> CreateQuestionMassivo([FromBody] List<JORNADA_QUESTION_DTO> data, int matricula)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == matricula).FirstOrDefault();
                foreach (var question in data)
                {
                    var oldId = question.ID_QUESTION;

                    var question_criada = CD.JORNADA_BD_QUESTIONs.Add(new JORNADA_BD_QUESTION
                    {
                        TP_FORMS = string.Join(';', question.TP_FORMS),
                        ID_TEMAS = question.ID_TEMAS,
                        TP_QUESTAO = question.TP_QUESTAO,
                        ID_SUB_TEMAS = question.ID_SUB_TEMAS,
                        STATUS_QUESTION = question.STATUS_QUESTION,
                        PERGUNTA = question.PERGUNTA,
                        PESO = 1,
                        REGIONAL = question.REGIONAL,
                        FIXA = question.FIXA,
                        EXPLICACAO = null,
                        CARGO = string.Join(';', question.CARGO.Distinct().Select(x => (int)x)),
                        CANAL = string.Join(';', question.CANAL.Distinct().Select(x => (int)x)),
                        DT_MOD = DateTime.Now,
                        LOGIN_MOD = user.MATRICULA
                    }).Entity;

                    await CD.SaveChangesAsync();

                    foreach (var item in question.Alternativas.Where(x => x.ID_QUESTION == oldId))
                    {
                        CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Add(new JORNADA_BD_ANSWER_ALTERNATIVA
                        {
                            ID_QUESTION = question_criada.ID_QUESTION,
                            ALTERNATIVA = item.ALTERNATIVA,
                            PESO = 1,
                            RESPOSTA_CORRETA = item.RESPOSTA_CORRETA,
                            STATUS_ALTERNATIVA = item.STATUS_ALTERNATIVA
                        });
                    }
                }

                await CD.SaveChangesAsync();

                return new JsonResult(new Response<string>
                {
                    Data = $"Total de {data.Count} novas perguntas criadas e pronta para uso!!",
                    Succeeded = true,
                    Message = $"Total de {data.Count} novas perguntas criadas e pronta para uso!!",
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

        [HttpPost("CreateQuestion")]
        public async Task<JsonResult> CreateQuestion([FromBody] CreateQuestionModel question)
        {
            try
            {
                string cargos = string.Join(";", question.CARGO);
                List<string> canaislista = new();

                foreach (var item in question.CARGO)
                {
                    canaislista.Add(((int)DePara.CanalCargoEnum((Cargos)item)).ToString());
                }

                string canais = string.Join(";", canaislista.Distinct());
                string TP_FORMS = string.Join(";", question.TP_FORMS);

                var question_criada = CD.JORNADA_BD_QUESTIONs.Add(new JORNADA_BD_QUESTION
                {
                    TP_FORMS = TP_FORMS,
                    ID_TEMAS = question.TEMA,
                    TP_QUESTAO = question.TP_QUESTAO,
                    ID_SUB_TEMAS = question.SUB_TEMA,
                    STATUS_QUESTION = true,
                    PERGUNTA = question.PERGUNTA,
                    PESO = 1,
                    REGIONAL = question.regional,
                    FIXA = question.FIXA,
                    EXPLICACAO = null,
                    CARGO = cargos,
                    CANAL = canais,
                    DT_MOD = DateTime.Now,
                    LOGIN_MOD = question.matricula
                }).Entity;

                await CD.SaveChangesAsync();

                foreach (var item in question.ALTERNATIVAS)
                {
                    CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Add(new JORNADA_BD_ANSWER_ALTERNATIVA
                    {
                        ID_QUESTION = question_criada.ID_QUESTION,
                        ALTERNATIVA = item.ALTERNATIVA,
                        PESO = 1,
                        RESPOSTA_CORRETA = item.RESPOSTA_CORRETA,
                        STATUS_ALTERNATIVA = true
                    });
                }

                await CD.SaveChangesAsync();

                return new JsonResult(new Response<object>
                {
                    Data = null,
                    Succeeded = true,
                    Message = "Pergunta criada com sucesso!!",
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

        [HttpGet("GetDataCriarQuestion")]
        public async Task<JsonResult> GetDataCriarQuestion()
        {
            try
            {
                var list = new List<Cargos>() {
                    Cargos.ADM,
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

                IEnumerable<Option<int>> cargos = Enum.GetValues(typeof(Cargos))
                    .Cast<Cargos>().ToList().Where(x => !list.Contains(x))
                    .Select(x => new Option<int> { Value = Convert.ToInt32(x), Text = x.GetDisplayName(), });

                var tema_subtema = CD.JORNADA_BD_TEMAS_SUB_TEMAs;

                return new JsonResult(new Response<object>
                {
                    Data = new
                    {
                        tema_subtema,
                        cargos
                    },
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

        [HttpPost("GetEditQuestion")]
        public async Task<JsonResult> GetEditQuestion([FromBody] GenericPaginationModel<FilterEditQuestionModel> filter)
        {
            try
            {

                var Data = CD.JORNADA_BD_QUESTIONs.AsQueryable();

                if (filter.Value.Status is not null)
                {
                    Data = Data.Where(x => x.STATUS_QUESTION == filter.Value.Status);
                }

                if (filter.Value.Pergunta is not null)
                {
                    if (string.IsNullOrEmpty(filter.Value.Pergunta))
                    {
                        Data = Data.Where(x => x.PERGUNTA.Contains(filter.Value.Pergunta));
                    }
                }

                if (filter.Value.Id_Question is not null)
                {
                    if (filter.Value.Id_Question != 0)
                    {
                        Data = Data.Where(x => x.ID_QUESTION == filter.Value.Id_Question);
                    }
                }

                if (filter.Value.Temas is not null)
                {
                    if (filter.Value.Temas.Any())
                    {
                        Data = Data.Where(x => filter.Value.Temas.Contains(x.ID_TEMAS.Value));

                        if (filter.Value.Sub_temas is not null)
                        {
                            if (filter.Value.Sub_temas.Any())
                            {
                                Data = Data.Where(x => filter.Value.Sub_temas.Contains(x.ID_SUB_TEMAS.Value));
                            }
                        }
                    }
                }

                if (filter.Value.Cargos is not null)
                {
                    if (filter.Value.Cargos.Any())
                    {
                        Data = Data.AsEnumerable().Where(x => x.CARGO.Split(new[] { ';' }).Any(cargo => filter.Value.Cargos.Select(x => x.ToString()).Contains(cargo))).AsQueryable();
                    }
                }

                if (filter.Value.TP_Forms is not null)
                {
                    if (filter.Value.TP_Forms.Any())
                    {
                        Data = Data.AsEnumerable().Where(x => x.TP_FORMS.Split(new[] { ';' }).Any(cargo => filter.Value.TP_Forms.Contains(cargo))).AsQueryable();
                    }
                }

                if (filter.Value.TP_questao is not null)
                {
                    if (filter.Value.TP_questao.Any())
                    {
                        Data = Data.Where(x => filter.Value.TP_questao.Contains(x.TP_QUESTAO));
                    }
                }


                if (filter.Value.Fixa is not null)
                {
                    Data = Data.Where(x => x.FIXA == filter.Value.Fixa);
                }

                var lista = Data.OrderBy(x => x.ID_QUESTION)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize);

                var totalRecords = Data.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                IEnumerable<QuestionModel> listaModel = lista.Select(x => new QuestionModel
                {
                    ID_QUESTION = x.ID_QUESTION,
                    TEMA = CD.JORNADA_BD_TEMAS_SUB_TEMAs.Where(k => k.ID_TEMAS == x.ID_TEMAS).FirstOrDefault().TEMAS,
                    TP_FORMS = x.TP_FORMS,
                    TP_QUESTAO = x.TP_QUESTAO,
                    PERGUNTA = x.PERGUNTA,
                    REGIONAL = x.REGIONAL,
                    PESO = x.PESO,
                    EXPLICACAO = x.EXPLICACAO,
                    CANAIS = GetCanaisFromCargos(x.CARGO),
                    CARGOS = GetCargosFromStringList(x.CARGO),
                    STATUS_QUESTION = x.STATUS_QUESTION,
                    FIXA = x.FIXA,
                    SUB_TEMA = CD.JORNADA_BD_TEMAS_SUB_TEMAs.Where(k => k.ID_SUB_TEMAS == x.ID_SUB_TEMAS).FirstOrDefault().SUB_TEMAS,
                    DT_MOD = Convert.ToDateTime(x.DT_MOD),
                    LOGIN_MOD = CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == x.LOGIN_MOD).FirstOrDefault()
                }).ToList();


                return new JsonResult(new Response<PagedModelResponse<IEnumerable<QuestionModel>>>
                {
                    Data = PagedResponse.CreatePagedReponse<QuestionModel, FilterEditQuestionModel>(listaModel, filter, totalRecords),
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

        [HttpDelete("DeleteQuestion")]
        public async Task<JsonResult> DeleteQuestion(int ID_QUESTION)
        {
            try
            {
                var question = CD.JORNADA_BD_QUESTIONs.Find(ID_QUESTION);
                question.STATUS_QUESTION = false;
                await CD.SaveChangesAsync();
                return new JsonResult(new Response<string>
                {
                    Data = $"A Questão de ID: {ID_QUESTION} foi inativada com sucesso!",
                    Succeeded = true,
                    Message = $"A Questão de ID: {ID_QUESTION} foi inativada com sucesso!",
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

        [HttpGet("GetSingleQuestion")]
        public async Task<JsonResult> GetSingleQuestion(int ID_QUESTION)
        {
            try
            {
                var getquestion = CD.JORNADA_BD_QUESTIONs.Find(ID_QUESTION);

                CreateQuestionModel question = new CreateQuestionModel
                {
                    regional = getquestion.REGIONAL,
                    TEMA = getquestion.ID_TEMAS.Value,
                    SUB_TEMA = getquestion.ID_SUB_TEMAS.Value,
                    TP_FORMS = getquestion.TP_FORMS.Split(new[] { ';' }).ToList(),
                    TP_QUESTAO = getquestion.TP_QUESTAO,
                    PERGUNTA = getquestion.PERGUNTA,
                    CARGO = GetCargosFromStringList(getquestion.CARGO).Cast<int>().ToList(),
                    FIXA = getquestion.FIXA,
                    ALTERNATIVAS = CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Where(x => x.ID_QUESTION == ID_QUESTION).ToList()
                };

                return new JsonResult(new Response<CreateQuestionModel>
                {
                    Data = question,
                    Succeeded = true,
                    Message = $"Tudo Certo!",
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

        [HttpPost("UpdateQuestion")]
        public async Task<JsonResult> UpdateQuestion([FromBody] CreateQuestionModel question, int ID_QUESTION)
        {
            try
            {
                string cargos = string.Join(";", question.CARGO);
                List<string> canaislista = new();

                foreach (var item in question.CARGO)
                {
                    canaislista.Add(((int)DePara.CanalCargoEnum((Cargos)item)).ToString());
                }

                string canais = string.Join(";", canaislista.Distinct());
                string TP_FORMS = string.Join(";", question.TP_FORMS);

                var question_criada = CD.JORNADA_BD_QUESTIONs.Find(ID_QUESTION);
                question_criada.TP_FORMS = TP_FORMS;
                question_criada.ID_TEMAS = question.TEMA;
                question_criada.TP_QUESTAO = question.TP_QUESTAO;
                question_criada.ID_SUB_TEMAS = question.SUB_TEMA;
                question_criada.STATUS_QUESTION = true;
                question_criada.PERGUNTA = question.PERGUNTA;
                question_criada.PESO = 1;
                question_criada.REGIONAL = question.regional;
                question_criada.FIXA = question.FIXA;
                question_criada.EXPLICACAO = null;
                question_criada.CARGO = cargos;
                question_criada.CANAL = canais;
                question_criada.DT_MOD = DateTime.Now;
                question_criada.LOGIN_MOD = question.matricula;
                await CD.SaveChangesAsync();

                CD.JORNADA_BD_ANSWER_ALTERNATIVAs.RemoveRange(CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Where(x => x.ID_QUESTION == ID_QUESTION));
                await CD.SaveChangesAsync();

                foreach (var item in question.ALTERNATIVAS)
                {
                    //var alternativa_criada = CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Find(item.ID_ALTERNATIVA);
                    CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Add(new JORNADA_BD_ANSWER_ALTERNATIVA
                    {
                        ID_QUESTION = ID_QUESTION,
                        ALTERNATIVA = item.ALTERNATIVA,
                        PESO = 1,
                        RESPOSTA_CORRETA = item.RESPOSTA_CORRETA,
                        STATUS_ALTERNATIVA = true,
                    });

                    await CD.SaveChangesAsync();
                }

                await CD.SaveChangesAsync();

                return new JsonResult(new Response<object>
                {
                    Data = null,
                    Succeeded = true,
                    Message = "Pergunta atualizada com sucesso!!",
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

    }
}
