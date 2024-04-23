using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Static_Class.Data;
using Vivo_Apps_API.Models;

namespace Vivo_Apps_API.ModelDTO
{
    public partial class Formulario
    {
        public List<QUESTIONS> QUESTIONS { get; set; }
        public string REDE_AVALIADA { get; set; }
        public string DDD_AVALIADO { get; set; }
        public string PDV_AVALIADO { get; set; }
        public string RE_AVALIADO { get; set; }

    }
    public class QUESTIONS
    {
        public int ID_QUESTION { get; set; }
        public IEnumerable<JORNADA_BD_TEMAS_SUB_TEMA> TEMA { get; set; }
        public string TP_FORMS { get; set; }
        public string TP_QUESTAO { get; set; }
        public string PERGUNTA { get; set; }
        public double? PESO { get; set; } = 1;
        public string CANAL { get; set; }
        public string CARGO { get; set; }
        public bool? STATUS_QUESTION { get; set; }
        public bool? FIXA { get; set; }
        public int SUB_TEMA { get; set; }
        public DateTime DT_MOD { get; set; }
        public int LOGIN_MOD { get; set; }
        public IEnumerable<JORNADA_BD_ANSWER_ALTERNATIVA> ALTERNATIVAS { get; set; }
    }

    public partial class ALTERNATIVAS
    {
        public int ID_ALTERNATIVA { get; set; }
        public string ALTERNATIVA { get; set; }
        public int? ID_QUESTION { get; set; }
        public bool? STATUS_ALTERNATIVA { get; set; }
        public double? PESO { get; set; }
        public bool? RESPOSTA_CORRETA { get; set; }

    }
}
