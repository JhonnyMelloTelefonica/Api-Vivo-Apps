using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Vivo_Apps_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared_Class_Vivo_Mais.Data;
using Shared_Class_Vivo_Mais.DB_Context_Vivo_MAIS;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JornadaController
    {
        private readonly ILogger<JornadaController> _logger;

        public JornadaController(ILogger<JornadaController> logger)
        {
            _logger = logger;
        }

        private Vivo_MAISContext CD = new Vivo_MAISContext();
        private string[] listaAdm = new string[] { "Gerente Geral", "GA", "Adm_Consumer", "GO", "Vendas_Adm" };

        [HttpGet("GetQuestions")]
        public string GetQuestions() => JsonConvert.SerializeObject(CD.Carteira_NEs.AsEnumerable());
        [HttpPost("GetAvatarImage")]
        public string GetAvatarImage(string matricula) => JsonConvert.SerializeObject(CD.ACESSOS_MOBILEs.Where(x=>x.MATRICULA == matricula).FirstOrDefault().UserAvatar);

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
                RESPOSTA_CORRETA = x.RESPOSTA_CORRETA,
                PESO = x.PESO,
                EXPLICACAO = x.EXPLICACAO,
                CANAL = x.CANAL,
                CARGO = x.CARGO,
                STATUS_QUESTION = x.STATUS_QUESTION,
                ALTERNATIVAS = CD.JORNADA_BD_ANSWER_ALTERNATIVAs.Where(y => y.ID_QUESTION == x.ID_QUESTION).AsEnumerable(),
            }).ToList();
            return JsonConvert.SerializeObject(questions);
        }
    }


}
