using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Vivo_Apps_API.Models;
using Vivo_Apps_API.Data;
using System.Drawing;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Vivo_Apps_API.Enums;
using NetTopologySuite.Algorithm;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControleQuestionsJornadaController
    {
        private Vivo_MAISContext CD = new Vivo_MAISContext();

        private readonly ILogger<ControleQuestionsJornadaController> _logger;

        public ControleQuestionsJornadaController(ILogger<ControleQuestionsJornadaController> logger)
        {
            _logger = logger;
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
                    TEMA = question.TEMA,
                    TP_QUESTAO = question.TP_QUESTAO,
                    SUB_TEMA = question.SUB_TEMA,
                    STATUS_QUESTION = true,
                    PERGUNTA = question.PERGUNTA,
                    PESO = 1,
                    RESPOSTA_CORRETA = null,
                    FIXA = question.FIXA,
                    EXPLICACAO = null,
                    CARGO = cargos,
                    CANAL = canais,
                    DT_MOD = DateTime.Now.ToString(),
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
                IEnumerable<Option<int>> cargos = CD.JORNADA_BD_CARGOS_CANALs.Select(x => new Option<int> { Value = Convert.ToInt32(x.ID), Text = x.CARGO, });
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
        [HttpGet("GetEditQuestion")]
        public async Task<JsonResult> GetEditQuestion([FromBody] GenericPaginationModel<FilterEditQuestionModel> filter)
        {
            try
            {
                var Data = CD.JORNADA_BD_QUESTIONs.Where(x => x.STATUS_QUESTION == true);

                var lista = Data.OrderBy(x => x.ID_QUESTION)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize);

                var totalRecords = Data.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<JORNADA_BD_QUESTION>>>
                {
                    Data = PagedResponse.CreatePagedReponse<JORNADA_BD_QUESTION, FilterEditQuestionModel>(Data, filter, totalRecords),
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
    }
}
