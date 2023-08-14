using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Vivo_Apps_API.Models;
using Api_Vivo_Apps.Data;
using System.Drawing;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Globalization;
using Vivo_Apps_API.Enums;
using Microsoft.AspNetCore.Components.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
using System.Collections.Generic;
using Vivo_Apps_API.ModelDTO;
using System.IO;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControleFormJornadaController
    {
        private Vivo_MAISContext CD = new Vivo_MAISContext();

        private readonly ILogger<ControleFormJornadaController> _logger;

        public ControleFormJornadaController(ILogger<ControleFormJornadaController> logger)
        {
            _logger = logger;
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

                var dadosDoBanco = CD.JORNADA_BD_QUESTIONs.ToList();

                int qtd = dadosDoBanco
                           .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                           .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(TIPO_PROVA))
                           .Where(k => (FIXA == false ? k.FIXA == FIXA : k.FIXA != null))
                           .Where(x => x.ID_TEMAS == TEMA.ToString())
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

                var dadosDoBanco = CD.JORNADA_BD_QUESTIONs.ToList();

                int qtd = dadosDoBanco
                           .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                           .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(TIPO_PROVA))
                           .Where(k => (FIXA == false ? k.FIXA == FIXA : k.FIXA != null))
                           .Where(x => x.ID_TEMAS == SUB_TEMA.ToString())
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
                            .Where(f => f.ID_TEMAS == x.ID_TEMAS.ToString())
                            .Count(),
                        QTD_SUB_TEMA = dadosDoBancoFiltrados
                            .Where(f => f.ID_SUB_TEMAS == x.ID_SUB_TEMAS.ToString())
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
               int QTD_TOTAL_SOLICITADA
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
                        .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                        .Where(x => x.ID_CRIADOR == matricula)
                        .Where(x => x.REGIONAL == REGIONAL)
                        .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        var maxcaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                            .ToList()
                            .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                            .Where(x => x.ID_CRIADOR == matricula)
                            .Where(x => x.REGIONAL == REGIONAL)
                            .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                            .Where(x => x.FIXA == FIXA)
                            .Select(y => y.CADERNO).Max());

                        //vai buscar a ultima prova com os parametros passados
                        var datafinal = CD.JORNADA_BD_QUESTION_HISTORICOs
                            .ToList()
                            .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                            .Where(x => x.ID_CRIADOR == matricula)
                            .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                            .Where(x => x.REGIONAL == REGIONAL)
                            .Where(x => x.FIXA == FIXA)
                            .Where(x => x.CADERNO == maxcaderno)
                            .Select(x => x.DT_FINALIZACAO).FirstOrDefault();

                        if (string.IsNullOrEmpty(datafinal))
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
                    FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
                        .ToList()
                        .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                        .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
                        .Where(x => x.REGIONAL == REGIONAL)
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                        .ToList()
                            .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                            .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
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
                        Message = "Você excedeu a quantidade total de questões disponiveis para formulários com estes parametros, foi necessário repetir questões mas o formulário foi criado corretamente",
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
                IQueryable<JORNADA_BD_ANSWER_AVALIACAO> resposta;

                List<JORNADA_BD_QUESTION_HISTORICO> questions = GetListaProvasRotaCruzadaDisponiveis(MATRICULA);
                GetListaProvasJornadaDisponiveis(REGIONAL, CARGO, MATRICULA, FIXA, out questionsjornada, out resposta);

                if (!resposta.Any())
                {
                    questions.AddRange(questionsjornada);
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
            , string CARGO
            , int CADERNO
            , string TP_FORMS
            , bool FIXA)
        {

            try
            {
                IEnumerable<JORNADA_BD_QUESTION_HISTORICO> questionatualizada = CD.JORNADA_BD_QUESTION_HISTORICOs
                    .Where(x => x.ID_CRIADOR == ID_CRIADOR)
                    .Where(x => x.FIXA == FIXA)
                    .Where(x => x.CARGO == CARGO)
                    .Where(x => x.TP_FORMS == TP_FORMS)
                    .Where(x => x.CADERNO == CADERNO).AsEnumerable();

                foreach (var item in questionatualizada)
                {
                    item.DT_FINALIZACAO = DateTime.Now.ToString();
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
                    TEMA = CD.JORNADA_BD_TEMAS_SUB_TEMAs.Where(y => y.ID_TEMAS.ToString() == x.ID_TEMAS).ToList(),
                    TP_FORMS = x.TP_FORMS,
                    TP_QUESTAO = x.TP_QUESTAO,
                    PERGUNTA = x.PERGUNTA,
                    PESO = x.PESO,
                    CANAL = x.CANAL,
                    CARGO = x.CARGO,
                    STATUS_QUESTION = x.STATUS_QUESTION,
                    FIXA = x.FIXA,
                    SUB_TEMA = x.ID_SUB_TEMAS,
                    DT_MOD = x.DT_MOD,
                    LOGIN_MOD = x.LOGIN_MOD,
                    ALTERNATIVAS = CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Where(y => y.ID_QUESTION == x.ID_QUESTION).AsEnumerable(),
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
                        ID_TEMAS = item.ID_TEMAS,
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
                var lista = CD.JORNADA_BD_ANSWER_AVALIACAOs.Where(x => x.MATRICULA_APLICADOR == matricula || x.RE_AVALIADO == matricula).AsEnumerable();
                var listaavaliacoes = lista.Select(x => new ListaAvaliacaoModel
                {
                    ID_PROVA_RESPONDIDA = x.ID_PROVA_RESPONDIDA,
                    ID_PROVA = x.ID_PROVA,
                    TEMA = x.ID_TEMAS,
                    TP_FORMS = x.TP_FORMS,
                    PUBLICO_CANAL = (Canal)int.Parse(x.PUBLICO_CANAL),
                    PUBLICO_CARGO = (Cargos)int.Parse(x.PUBLICO_CARGO),
                    DT_AVALIACAO = Convert.ToDateTime(x.DT_AVALIACAO),
                    MATRICULA_AVALIADOR = x.MATRICULA_APLICADOR,
                    NOME = x.NOME_APLICADOR,
                    CADERNO = x.CADERNO,
                    NOTA = Convert.ToDouble(x.NOTA),
                    REDE_AVALIADA = x.REDE_AVALIADA,
                    DDD_AVALIADO = x.DDD_AVALIADO,
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
        [ProducesResponseType(typeof(Response<IEnumerable<JORNADA_BD_AVALIACAO_RETORNO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetQuestionsById_Prova(int id)
        {
            try
            {
                var avaliacao = CD.JORNADA_BD_AVALIACAO_RETORNOs.Where(x => x.ID_PROVA_RESPONDIDA == id);

                return new JsonResult(new Response<IEnumerable<JORNADA_BD_AVALIACAO_RETORNO>>
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

        private void InsertQuestionsIntoForm(
            string REGIONAL,
            string TIPO_PROVA,
            int CARGO,
            bool FIXA,
            string MATRICULA,
            string DT_INIT,
            string? DT_FINAL,
            List<JORNADA_BD_QUESTION> Formulario,
            int proximocaderno)
        {
            var entityrelacao = CD.JORNADA_BD_RELACAO_HISTORICOs.Add(new JORNADA_BD_RELACAO_HISTORICO
            {
                LOGIN_MOD = MATRICULA,
                DT_MOD = DateTime.Now.ToString("dd/MM/yyyy")
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
                    CANAL = ((int)canal).ToString(),
                    CARGO = CARGO.ToString(),
                    DT_CRIACAO = DateTime.Now.ToString(),
                    ID_CRIADOR = MATRICULA,
                    ID_QUESTION = item.ID_QUESTION,
                    ID_PROVA = entityrelacao.ID_PROVA,
                    CADERNO = proximocaderno,
                    TP_FORMS = TIPO_PROVA,
                    DT_INICIO_AVALIACAO = DT_INIT.ToString(new CultureInfo("pt-BR")),
                    DT_FINALIZACAO = DT_FINAL,
                    FIXA = FIXA,
                    REGIONAL = REGIONAL
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
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
                    .Where(x => x.REGIONAL == REGIONAL)
                    .Where(x => x.FIXA == FIXA)
                    .Select(y => y.ID_QUESTION).ToList();

                jornadaQuestion = CD.JORNADA_BD_QUESTIONs
                    .ToList()
                    .Where(x => x.STATUS_QUESTION == true)
                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(k => k.ID_TEMAS == tema.ToString())
                    .Where(y => y.ID_SUB_TEMAS == subtema.ToString())
                    .OrderBy(item => random.Next())
                    .GroupBy(x => new { x.PERGUNTA }).Select(x => x.FirstOrDefault())
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Where(y => !questaorepetida.Contains(y.ID_QUESTION))
                    .Take(qtdtema).ToList();

                if (jornadaQuestion.Count() < qtdtema)
                {
                    QuestoesRepetidas = true;
 
                    while (jornadaQuestion.Count() != qtdtema)
                    {
                        jornadaQuestion.Add(CD.JORNADA_BD_QUESTIONs.AsEnumerable().ToList()
                        .Where(x => x.STATUS_QUESTION == true)
                        .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                        .Where(k => k.ID_TEMAS == tema.ToString())
                        .Where(y => y.ID_SUB_TEMAS == subtema.ToString())
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
                    .Where(k => k.ID_TEMAS == tema.ToString())
                    .Where(y => y.ID_SUB_TEMAS == subtema.ToString())
                    .OrderBy(item => random.Next())
                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Take(qtdtema)
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
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(x => x.REGIONAL == REGIONAL)
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                    .Where(x => x.ID_CRIADOR == matricula)
                    .Select(y => y.ID_QUESTION)
                    .ToList();

                jornadaQuestion = CD.JORNADA_BD_QUESTIONs  //Gera um formulário novo em que não se repete nenhum das questões já passadas
                    .ToList()
                    .Where(x => x.STATUS_QUESTION == true)
                    .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(k => k.ID_TEMAS == tema.ToString())
                    .Where(k => k.ID_SUB_TEMAS == subtema.ToString())
                    .OrderBy(item => random.Next())
                    .GroupBy(x => x.PERGUNTA)
                    .Select(x => x.FirstOrDefault()).ToList()
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Where(k => !questaorepetida.Contains(k.ID_QUESTION))
                    .Take(qtdtema)
                    .ToList();

                if (jornadaQuestion.Count() < qtdtema)
                {
                    QuestoesRepetidas = true;
                    while (jornadaQuestion.Count() != qtdtema)
                    {
                        jornadaQuestion.Add(CD.JORNADA_BD_QUESTIONs.AsEnumerable().ToList()
                            .Where(x => x.STATUS_QUESTION == true)
                            .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                            .Where(k => k.ID_TEMAS == tema.ToString())
                            .Where(k => k.ID_SUB_TEMAS == subtema.ToString())
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
                    .Where(k => k.ID_TEMAS == tema.ToString())
                    .Where(k => k.ID_SUB_TEMAS == subtema.ToString())
                    .OrderBy(item => random.Next())
                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                    .Take(qtdtema)
                    .ToList();
            }
            foreach (JORNADA_BD_QUESTION item in jornadaQuestion)
            {
                Formulario.Add(item);
            }
        }

        private List<JORNADA_BD_QUESTION_HISTORICO> GetListaProvasRotaCruzadaDisponiveis(string MATRICULA)
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
                           .Where(x => string.IsNullOrEmpty(x.DT_FINALIZACAO)) // Data de finalização nula
                           .ToList();

            return questions;

        }

        private void GetListaProvasJornadaDisponiveis(
            string REGIONAL,
            int CARGO,
            string MATRICULA,
            bool FIXA,
            out List<JORNADA_BD_QUESTION_HISTORICO> questionsjornada,
            out IQueryable<JORNADA_BD_ANSWER_AVALIACAO> resposta)
        {
            var actual = DateTime.Now;
            var maxcadernojornada = CD.JORNADA_BD_QUESTION_HISTORICOs // Buscar o caderno maximo baseado nos parametros
            .Where(y => y.TP_FORMS == "Jornada")
            .Where(y => y.CARGO == CARGO.ToString())
            .Where(y => y.FIXA == FIXA)
            .Where(y => y.REGIONAL == REGIONAL)
            .Max(y => y.CADERNO);

            questionsjornada = CD.JORNADA_BD_QUESTION_HISTORICOs
            .Where(y => y.TP_FORMS == "Jornada")
            .Where(y => y.CARGO == CARGO.ToString())
            .Where(y => y.FIXA == FIXA)
            .Where(y => y.REGIONAL == REGIONAL)
            .Where(y => y.CADERNO == maxcadernojornada)
            .ToList();

            questionsjornada = questionsjornada
                .Where(x => Convert.ToDateTime(x.DT_INICIO_AVALIACAO) < actual) // Data inicial deve ser maior que hoje
                .Where(x => Convert.ToDateTime(x.DT_FINALIZACAO) > actual) // Data final deve ser menor que hoje
                .ToList();

            resposta = CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                .Where(x => x.PUBLICO_CARGO == CARGO.ToString()
                && x.CADERNO == maxcadernojornada.ToString()
                && x.MATRICULA_APLICADOR == MATRICULA
                && x.REGIONAL == REGIONAL
                && x.MATRICULA_APLICADOR == MATRICULA
                && x.TP_FORMS == "Jornada");
        }
    }
}
