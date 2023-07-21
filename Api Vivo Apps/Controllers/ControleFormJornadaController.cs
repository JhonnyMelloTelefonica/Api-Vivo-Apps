using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Vivo_Apps_API.Models;
using Vivo_Apps_API.Data;
using System.Drawing;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Globalization;
using Vivo_Apps_API.Enums;

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
        public async Task<JsonResult> GetDataCriarFormulario()
        {
            try
            {
                IEnumerable<Option<int>>
                    cargos = CD.JORNADA_BD_CARGOS_CANALs.Select(x => new Option<int> { Value = Convert.ToInt32(x.ID), Text = x.CARGO, });

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
                           .Where(k => k.FIXA == FIXA)
                           .Where(x => x.TEMA == TEMA.ToString())
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
                           .Where(k => k.FIXA == FIXA)
                           .Where(x => x.TEMA == SUB_TEMA.ToString())
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
                    .Where(k => k.FIXA == FIXA)
                    .ToList(); // Aqui trazemos os dados do banco para a memória

                List<int> temas_id = dadosDoBancoFiltrados
                            .Select(x => Convert.ToInt32(x.TEMA))
                            .ToList();

                // Parte 2: Consulta executada no lado do cliente (em memória)
                IEnumerable<TEMA_SUB_TEMA_QTD> temas = CD.JORNADA_BD_TEMAS_SUB_TEMAs
                    .Where(x => ((Canal)x.ID_SUB_TEMAS) != Canal.Consumer)
                    .Where(x => temas_id.Contains(x.ID_TEMAS.Value)).ToList()
                    .Select(x => new TEMA_SUB_TEMA_QTD
                    {
                        ID_SUB_TEMAS = x.ID_SUB_TEMAS,
                        SUB_TEMAS = x.SUB_TEMAS,
                        ID_TEMAS = x.ID_TEMAS,
                        TEMAS = x.TEMAS,
                        QTD_TEMA = dadosDoBancoFiltrados
                            .Where(f => f.TEMA == x.ID_TEMAS.ToString())
                            .Count(),
                        QTD_SUB_TEMA = dadosDoBancoFiltrados
                            .Where(f => f.SUB_TEMA == x.ID_SUB_TEMAS.ToString())
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

        [HttpPost("CreateFormulario")]
        public async Task<JsonResult> CreateFormulario(
                [FromBody] List<TEMAS_QTD>? TEMAS_QUANTIDADE,
                string TIPO_PROVA,
                int CARGO,
                bool FIXA,
                int QTD_TEMA,
                int QTD_PERGUNTA,
                string MATRICULA,
                string DT_INIT,
                string? DT_FINAL
            )
        {
            try
            {

                List<JORNADA_BD_QUESTION> Formulario = new List<JORNADA_BD_QUESTION>(); // LISTA ONDE SERÁ INSERIDA AS PERGUNTAS
                bool FormularioExistente;
                int proximocaderno = 0;
                var matricula = MATRICULA;
                string rota = TIPO_PROVA;
                Random random = new Random();

                if (rota.Equals("Rota Cruzada"))
                {
                    FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
                        .ToList()
                        .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                        .Where(x => x.ID_CRIADOR == matricula)
                        .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        var maxcaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                            .ToList()
                            .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                            .Where(x => x.ID_CRIADOR == matricula)
                            .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                            .Where(x => x.FIXA == FIXA)
                            .Select(y => y.CADERNO).Max());

                        //vai buscar a ultima prova com os parametros passados
                        var datafinal = CD.JORNADA_BD_QUESTION_HISTORICOs
                        .ToList()
                            .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                            .Where(x => x.ID_CRIADOR == matricula)
                            .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                            .Where(x => x.FIXA == FIXA)
                            .Where(x => x.CADERNO == maxcaderno)
                            .Select(x => x.DT_FINALIZACAO).FirstOrDefault();

                        if (string.IsNullOrEmpty(datafinal))
                        {
                            //DateTime.Now > Convert.ToDateTime(datafinal)
                            //significa que o formulário está finalizado
                            return new JsonResult(new Response<string>
                            {
                                Data = "Tudo certo",
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


                    for (int i = 0; i < TEMAS_QUANTIDADE.Count(); i++)
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
                                .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                                .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                                .Where(x => x.ID_CRIADOR == matricula)
                                .Select(y => y.ID_QUESTION)
                                .ToList();

                            jornadaQuestion = CD.JORNADA_BD_QUESTIONs  //Gera um formulário novo em que não se repete nenhum as questões já passadas
                        .ToList()
                                .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                                .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                                .Where(k => k.TEMA == tema.ToString())
                                .OrderBy(item => random.Next())
                                .GroupBy(x => x.PERGUNTA)
                                .Select(x => x.FirstOrDefault()).ToList()
                                .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                                .Where(k => !questaorepetida.Contains(k.ID_QUESTION))
                                .Take(qtdtema)
                                .ToList();

                            if (jornadaQuestion.Count() < qtdtema) // se não houver questões no banco suficiente para o que foi requisitado
                            {
                                jornadaQuestion = CD.JORNADA_BD_QUESTIONs
                        .ToList()
                                    .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                                    .Where(k => k.TEMA == tema.ToString())
                                    .OrderBy(item => random.Next())
                                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                                    .Where(y => !jornadaQuestion.Select(p => p.ID_QUESTION).Contains(y.ID_QUESTION))
                                    .Take(qtdtema)
                                    .ToList();

                                if (jornadaQuestion.Count() < qtdtema)
                                {
                                    var diferenca = qtdtema - jornadaQuestion.Count();

                                    jornadaQuestion.AddRange(jornadaQuestion = CD.JORNADA_BD_QUESTIONs.AsEnumerable()
                        .ToList()
                                        .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                                        .Where(k => k.TEMA == tema.ToString())
                                        .OrderBy(item => random.Next())
                                        .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                        .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                                        .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                                        .Take(diferenca)
                                        .ToList());
                                }
                            }
                        }
                        else
                        {
                            jornadaQuestion = CD.JORNADA_BD_QUESTIONs.AsEnumerable()
                        .ToList()
                                .Where(y => y.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Rota Cruzada"))
                                .Where(k => k.TEMA == tema.ToString())
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
                }
                else // Caso seja Jornada
                { // Este looping faz o mesmo mas sem o parametro de matricula
                    FormularioExistente = CD.JORNADA_BD_QUESTION_HISTORICOs
                        .ToList()
                        .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                        .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
                        .Where(x => x.FIXA == FIXA).Any();

                    if (FormularioExistente)
                    {
                        proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs
                        .ToList()
                            .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                            .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
                            .Where(x => x.FIXA == FIXA)
                            .Select(y => y.CADERNO).Max() + 1);
                    }
                    else
                    {
                        proximocaderno = 1;
                    }

                    for (int i = 0; i < TEMAS_QUANTIDADE.Count(); i++)
                    {
                        var tema = TEMAS_QUANTIDADE[i].Tema;
                        var subtema = TEMAS_QUANTIDADE[i].Sub_tema;
                        var qtdtema = TEMAS_QUANTIDADE[i].Qtd;

                        List<JORNADA_BD_QUESTION> jornadaQuestion;

                        Random rnd = new Random();

                        if (FormularioExistente)
                        {

                            var questaorepetida = CD.JORNADA_BD_QUESTION_HISTORICOs
                                                    .ToList()
                                .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                                .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains(rota))
                                .Where(x => x.FIXA == FIXA)
                                .Select(y => y.ID_QUESTION).ToList();

                            jornadaQuestion = CD.JORNADA_BD_QUESTIONs
                                .ToList()
                                .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                                .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                                .OrderBy(item => random.Next())
                                .GroupBy(x => new { x.PERGUNTA }).Select(x => x.FirstOrDefault())
                                .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                                .Where(y => y.TEMA == tema.ToString())
                                .Where(y => !questaorepetida.Contains(y.ID_QUESTION))
                                .Take(qtdtema).ToList();

                            if (jornadaQuestion.Count() < qtdtema) // Se a quantidade máxima de perguntas para os formulários do responsavel chegou o limite
                            {
                                jornadaQuestion =
                                    CD.JORNADA_BD_QUESTIONs
                                                      .ToList()
                                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                                .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                                .OrderBy(item => random.Next())
                                .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                                .Where(y => y.TEMA == tema.ToString())
                                .Where(y => !jornadaQuestion.Select(p => p.ID_QUESTION).Contains(y.ID_QUESTION))
                                .Take(qtdtema)
                                .ToList();

                                if (jornadaQuestion.Count() < qtdtema)
                                {
                                    var diferenca = qtdtema - jornadaQuestion.Count();

                                    jornadaQuestion.AddRange(jornadaQuestion = CD.JORNADA_BD_QUESTIONs.AsEnumerable()
                                                         .ToList()
                                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                                    .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                                    .Where(y => y.TEMA == tema.ToString())
                                    .OrderBy(item => random.Next())
                                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                    .Take(diferenca)
                                    .ToList());
                                }
                            }
                        }
                        else
                        {
                            jornadaQuestion = CD.JORNADA_BD_QUESTIONs
                                                     .ToList()
                                    .Where(x => x.TP_FORMS.Split(new[] { ';' }).Select(c => c).Contains("Jornada"))
                                .Where(x => x.CARGO.Split(new[] { ';' }).Select(c => int.Parse(c)).Contains(CARGO))
                                .OrderBy(item => random.Next())
                                .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                .Where(x => (FIXA == false ? x.FIXA == FIXA : x.FIXA != null))
                                .Where(y => y.TEMA == tema.ToString())
                                .Take(qtdtema)
                                .ToList();
                        }
                        foreach (JORNADA_BD_QUESTION item in jornadaQuestion)
                        {
                            Formulario.Add(item);
                        }
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

                foreach (var item in Formulario) // Adiciona as perguntas selecionadas a lista que será inserida no banco
                {
                    var canal = DePara.CanalCargoEnum((Cargos)CARGO);

                    CD.JORNADA_BD_QUESTION_HISTORICOs.Add(new JORNADA_BD_QUESTION_HISTORICO
                    {
                        CANAL = ((int)canal).ToString(),
                        CARGO = CARGO.ToString(),
                        DT_CRIACAO = DateTime.Now.ToString(),
                        ID_CRIADOR = MATRICULA,
                        ID_QUESTION = item.ID_QUESTION,
                        CADERNO = proximocaderno,
                        TP_FORMS = TIPO_PROVA,
                        DT_INICIO_AVALIACAO = DT_INIT.ToString(new CultureInfo("pt-BR")),
                        DT_FINALIZACAO = (item.TP_FORMS == "Rota Cruzada" ? null : DT_FINAL),
                        FIXA = FIXA
                    });
                }
                await CD.SaveChangesAsync();

                return new JsonResult(new Response<string>
                {
                    Data = "Tudo certo!",
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

    }
}
