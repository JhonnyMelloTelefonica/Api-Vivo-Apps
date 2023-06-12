using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Vivo_Apps_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vivo_Apps_API.Data;
using Vivo_Apps_API.Models;

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
                // Define the ADO.NET Objects
                using (SqlConnection con = new SqlConnection(CD.Database.GetConnectionString()))
                {
                    //    SqlCommand topiccmd = new SqlCommand(selectTopics, con);
                    //    con.Open();
                    //    var numros = topiccmd.ExecuteReader();
                    //    con.Close();
                    //}
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
        public string GetLoginSenha(string Email, string Senha) => JsonConvert.SerializeObject(CD.ACESSOS_MOBILEs.Where(x => x.EMAIL == Email).FirstOrDefault());
        [HttpGet("GetListaAdm")]
        public string GetListaAdm() => JsonConvert.SerializeObject(CD.ACESSOS_MOBILE_PERFILs.AsEnumerable());
        [HttpGet("GetListaRoles")]
        public string GetListaRoles() => JsonConvert.SerializeObject(CD.PERFIL_VIVO_TASKs.AsEnumerable());

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
                        TEMA = item.TEMA,
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
                    TEMA = data.TEMA,
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

        [HttpPost("FinalizarForm")]
        public string FinalizarForm(FinalizarForm data)
        {
            try
            {
                IEnumerable<int> Ids = CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.ID_CRIADOR == data.ID_CRIADOR
                && x.FIXA == data.FIXA
                && x.CARGO == data.CARGO
                && x.TP_FORMS == data.TP_FORMS
                && x.CADERNO == data.CADERNO).Select(x => x.ID_PROVA).AsEnumerable();
                foreach (var item in CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => Ids.Contains(x.ID_PROVA)))
                {
                    item.DT_FINALIZACAO = DateTime.Now.ToString();
                }
                CD.SaveChanges();

                return $"Tudo Certo -> {Ids}";
            }
            catch (Exception ex)
            {
                return $"Algum erro ocorreu log: {ex.Message} -------- {ex.ToString()}";
            }
        }

        [HttpGet("GetDataQuestions")]
        public string GetDataQuestions()
        {
            return JsonConvert.SerializeObject(CD.JORNADA_BD_QUESTIONs.GroupBy(x => new
            {
                x.FIXA,
                x.TEMA,
                x.CARGO,
                x.TP_FORMS
            }).Select(y => new
            {
                y.Key.TEMA,
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
            return JsonConvert.SerializeObject(CD.JORNADA_BD_AVALIACAO_RETORNOs.Where(x => x.ID_PROVA == id).ToList());
        }


        [HttpPost("GetFormJornada")]
        public string GetFormJornada([FromBody] FormDisponivelJornada data)
        {
            try
            {
                var actual = DateTime.Now;
                var maxcaderno = CD.JORNADA_BD_QUESTION_HISTORICOs // Buscar o caderno maximo baseado nos parametros
                .Where(y => y.TP_FORMS == "Jornada"
                && y.CARGO == data.CARGO
                && y.FIXA == data.FIXA)
                .Max(y => y.CADERNO);

                var questions = CD.JORNADA_BD_QUESTION_HISTORICOs
                .Where(x => x.TP_FORMS == "Jornada"
                && x.CARGO == data.CARGO
                && x.FIXA == data.FIXA
                && x.CADERNO == maxcaderno).ToList();

                questions = questions.Where(x => Convert.ToDateTime(x.DT_FINALIZACAO) > actual && Convert.ToDateTime(x.DT_INICIO_AVALIACAO) < DateTime.Now).ToList();

                var resposta = CD.JORNADA_BD_ANSWER_AVALIACAOs // Busca respostas para o formulario encontrado
                    .Where(x => x.PUBLICO_CARGO == data.CARGO
                    && x.CADERNO == maxcaderno.ToString()
                    && x.MATRICULA_APLICADOR == data.MATRICULA
                    && x.TP_FORMS == "Jornada");

                if (resposta.Count() > 0)
                {
                    return "[]";
                }
                else
                {
                    return JsonConvert.SerializeObject(questions);
                }
            }
            catch (Exception ex)
            {

                return $"500 -> {ex.Message} ----------------- {ex.ToString()}";
            }
        }

        [HttpGet("GetAllRotaByMAT")]
        public string GetAllRotaByMAT(string matricula) => JsonConvert.SerializeObject(CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.TP_FORMS == "Rota Cruzada" && x.ID_CRIADOR == matricula && x.DT_FINALIZACAO == null));
        [HttpPost("GetFormulario")]
        public string GetFormulario([FromBody] IEnumerable<int> Questions)
        {

            var questions = CD.JORNADA_BD_QUESTIONs.Where(x => Questions.Contains(x.ID_QUESTION)).Select(x => new
            {
                ID_QUESTION = x.ID_QUESTION,
                TEMA = x.TEMA,
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
        private string DeParaDeCanalCargo(string cargo)
        {
            switch (cargo)
            {
                case "Guru":

                    return "Loja Própria";

                case "GGP":

                    return "MultCanal";

                case "Gerente Geral":

                    return "Loja Própria";

                case "GA":

                    return "MultCanal";

                case "GO":

                    return "Loja Própria";

                case "Supervisor PAP":

                    return "PAP";

                case "Vendedor PAP":

                    return "PAP";

                case "Gerente de Revenda":

                    return "Revenda";

                case "Vendedor Revenda":

                    return "Revenda";

                case "CN":

                    return "Loja Própria";

                case "Vendas_Adm":

                    return "Adm_Consumer";

                case "Adm_Consumer":

                    return "Adm_Consumer";

                default:
                    return "";
            }
        }
        [HttpPost("GerarNovoFormulario")]
        public string GerarNovoFormulario([FromBody] Form data)
        {
            try
            {
                List<JORNADA_BD_QUESTION> Formulario = new List<JORNADA_BD_QUESTION>();
                int proximocaderno = 0;
                JORNADA_BD_QUESTION_HISTORICO check = new JORNADA_BD_QUESTION_HISTORICO();
                var rand = new Random();
                var matricula = data.MATRICULA;
                string rota = data.TIPO_ROTA;

                if (rota.Equals("Rota Cruzada"))
                {
                    check = CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.CARGO == data.CARGO &&
                    x.ID_CRIADOR == matricula &&
                    x.TP_FORMS == data.TIPO_ROTA && x.FIXA == data.FIXA).FirstOrDefault();

                    if (check != null)
                    {
                        var maxcaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.CARGO == data.CARGO && x.ID_CRIADOR == matricula && x.TP_FORMS == "Rota Cruzada" && x.FIXA == data.FIXA)
                            .Select(y => y.CADERNO)
                        .Max());

                        var datafinal = CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.CARGO == data.CARGO &&
                            x.ID_CRIADOR == matricula 
                            && x.TP_FORMS == "Rota Cruzada"
                            && x.FIXA == data.FIXA
                            && x.CADERNO == maxcaderno).Select(x => x.DT_FINALIZACAO).FirstOrDefault(); //vai buscar a ultima prova com os parametros passados

                        if (string.IsNullOrEmpty(datafinal))
                        {
                            //DateTime.Now > Convert.ToDateTime(datafinal)
                            //significa que o formulário está finalizado
                            return "403";
                        }

                        proximocaderno = maxcaderno + 1;
                    }
                    else
                    {
                        proximocaderno = 1;
                    }


                    for (int i = 0; i < data.Temas.Count; i++)
                    {
                        var tema = data.Temas[i].Tema;
                        var qtdtema = data.Temas[i].Qtd_Pergunta;
                        List<JORNADA_BD_QUESTION> jornadaQuestion;
                        Random rnd = new Random();
                        if (check != null) // Sele for encontrado algum caderno do tipo escolhido
                        {
                            var questaorepetida = CD.JORNADA_BD_QUESTION_HISTORICOs //  pega todos as questões  que já passaram
                                .Where(x => x.CARGO == data.CARGO)
                                .Where(x => (data.FIXA == "NAO" ? x.FIXA == data.FIXA : x.FIXA != null))
                                .Where(x => x.TP_FORMS == "Rota Cruzada")
                                .Where(x => x.ID_CRIADOR == matricula)
                                .Select(y => y.ID_QUESTION)
                                .ToList();

                            jornadaQuestion = CD.JORNADA_BD_QUESTIONs  //Gera um formulário novo em que não se repete nenhum as questões já passadas
                                .Where(y => y.TP_FORMS == "Rota Cruzada")
                                .Where(x => x.CARGO == data.CARGO)
                                .Where(k => k.TEMA == tema)
                                .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                .Where(x => (data.FIXA == "NAO" ? x.FIXA == data.FIXA : x.FIXA != null))
                            .Where(k => !questaorepetida.Contains(k.ID_QUESTION))
                                .Take(qtdtema)
                                .ToList();

                            if (jornadaQuestion.Count() < qtdtema) // se não houver questões no banco suficiente para o que foi requisitado
                            {
                                jornadaQuestion = CD.JORNADA_BD_QUESTIONs.Where(y => y.TP_FORMS == "Rota Cruzada")
                                    .Where(k => k.TEMA == tema)
                                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                    .Where(k => k.CARGO == data.CARGO)
                                    .Where(k => (data.FIXA == "NAO" ? k.FIXA == data.FIXA : k.FIXA != null))
                                    .Where(y => !jornadaQuestion.Select(p => p.ID_QUESTION).Contains(y.ID_QUESTION))
                                    .Take(qtdtema)
                                    .ToList();

                                if (jornadaQuestion.Count() < qtdtema)
                                {
                                    var diferenca = qtdtema - jornadaQuestion.Count();

                                    jornadaQuestion.AddRange(jornadaQuestion = CD.JORNADA_BD_QUESTIONs.AsEnumerable()
                                .Where(k => k.TP_FORMS == "Rota Cruzada")
                                .Where(y => y.CARGO == data.CARGO)
                                .Where(t => t.TEMA == tema)
                                .Where(g => (data.FIXA == "NAO" ? g.FIXA == data.FIXA : g.FIXA != null))
                                .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                .Take(diferenca)
                                .ToList());
                                }
                            }
                        }
                        else
                        {
                            jornadaQuestion = CD.JORNADA_BD_QUESTIONs.AsEnumerable()
                                .Where(k => k.TP_FORMS == "Rota Cruzada")
                                .Where(y => y.CARGO == data.CARGO)
                                .Where(t => t.TEMA == tema)
                                .Where(g => (data.FIXA == "NAO" ? g.FIXA == data.FIXA : g.FIXA != null))
                                .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
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
                    check = CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.CARGO == data.CARGO && x.FIXA == data.FIXA && x.TP_FORMS == "Jornada").FirstOrDefault();
                    if (check != null)
                    {
                        proximocaderno = (int)(CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.CARGO == data.CARGO && x.FIXA == data.FIXA && x.TP_FORMS == "Jornada").Select(y => y.CADERNO).Max() + 1);
                    }
                    else
                    {
                        proximocaderno = 1;
                    }

                    for (int i = 0; i < data.Temas.Count; i++)
                    {
                        var tema = data.Temas[i].Tema;
                        var qtdtema = data.Temas[i].Qtd_Pergunta;
                        List<JORNADA_BD_QUESTION> jornadaQuestion;
                        if (check != null)
                        {

                            var questaorepetida = CD.JORNADA_BD_QUESTION_HISTORICOs.Where(x => x.CARGO == data.CARGO && x.FIXA == data.FIXA && x.TP_FORMS == "Jornada").Select(y => y.ID_QUESTION).ToList();

                            jornadaQuestion = CD.JORNADA_BD_QUESTIONs.Where(x => x.TP_FORMS == "Jornada" && x.CARGO == data.CARGO).GroupBy(x => new { x.PERGUNTA }).Select(x => x.FirstOrDefault())
                                .Where(y => data.FIXA == "NAO" ? y.FIXA == data.FIXA : y.FIXA != null)
                                .Where(y => y.TEMA == tema)
                                .Where(y => !questaorepetida.Contains(y.ID_QUESTION))
                                .Take(qtdtema).ToList();

                            if (jornadaQuestion.Count() < qtdtema) // Se a quantidade máxima de perguntas para os formulários do responsavel chegou o limite
                            {
                                jornadaQuestion =
                                    CD.JORNADA_BD_QUESTIONs
                                    .Where(x => x.TP_FORMS == "Jornada")
                                    .Where(x => x.CARGO == data.CARGO)
                                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                .Where(k => (data.FIXA == "NAO" ? k.FIXA == data.FIXA : k.FIXA != null))
                                .Where(k => k.TEMA == tema)
                                .Where(y => !jornadaQuestion.Select(p => p.ID_QUESTION).Contains(y.ID_QUESTION))
                                .Take(qtdtema)
                                .ToList();

                                if (jornadaQuestion.Count() < qtdtema)
                                {
                                    var diferenca = qtdtema - jornadaQuestion.Count();

                                    jornadaQuestion.AddRange(jornadaQuestion = CD.JORNADA_BD_QUESTIONs.AsEnumerable()
                                    .Where(k => k.TP_FORMS == "Jornada")
                                    .Where(y => y.CARGO == data.CARGO)
                                    .Where(t => t.TEMA == tema)
                                    .Where(g => (data.FIXA == "NAO" ? g.FIXA == data.FIXA : g.FIXA != null))
                                    .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                    .Take(diferenca)
                                    .ToList());
                                }
                            }
                        }
                        else
                        {
                            jornadaQuestion = CD.JORNADA_BD_QUESTIONs.Where(y => y.TP_FORMS == "Jornada" && y.CARGO == data.CARGO)
                                .GroupBy(x => x.PERGUNTA).Select(x => x.FirstOrDefault()).ToList()
                                .Where(k => (data.FIXA == "NAO") ? k.FIXA == data.FIXA : k.FIXA != null && k.TEMA == tema)
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
                    return "505 -> Não foi encontrado nenhuma pergunta com estes parametros";
                }

                foreach (var item in Formulario) // Adiciona as perguntas selecionadas a lista que será inserida no banco
                {
                    var canal = DeParaDeCanalCargo(data.CARGO);

                    CD.JORNADA_BD_QUESTION_HISTORICOs.Add(new JORNADA_BD_QUESTION_HISTORICO
                    {
                        CANAL = canal,
                        CARGO = data.CARGO,
                        DT_CRIACAO = DateTime.Now.ToString(),
                        ID_CRIADOR = data.MATRICULA,
                        ID_QUESTION = item.ID_QUESTION,
                        CADERNO = proximocaderno,
                        TP_FORMS = item.TP_FORMS,
                        DT_INICIO_AVALIACAO = data.Data_Aval.ToString(new CultureInfo("pt-BR")),
                        DT_FINALIZACAO = item.TP_FORMS == "Rota Cruzada" ? null : data.DT_FINALIZACAO.ToString(new CultureInfo("pt-BR")),
                        FIXA = data.FIXA
                    });

                }
                CD.SaveChanges();
                return $"200 -> {JsonConvert.SerializeObject(Formulario)}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return $"505 -> {ex.Message}\n\n{ex.InnerException}\n\n{ex}";
            }
        }
    }


}
