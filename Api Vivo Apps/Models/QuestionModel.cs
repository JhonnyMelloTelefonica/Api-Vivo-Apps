using Shared_Class_Vivo_Apps.Data;
using Shared_Class_Vivo_Apps.Enums;
using Vivo_Apps_API.ModelDTO;

namespace Vivo_Apps_API.Models
{
    public class QuestionModel
    {
        public int ID_QUESTION { get; set; }
        public string TEMA { get; set; }
        public string? TP_FORMS { get; set; }
        public string TP_QUESTAO { get; set; }
        public string PERGUNTA { get; set; }
        public string RESPOSTA_CORRETA { get; set; }
        public double? PESO { get; set; }
        public string EXPLICACAO { get; set; }
        public IEnumerable<Canal>? CANAIS { get; set; }
        public IEnumerable<Cargos>? CARGOS { get; set; }
        public bool? STATUS_QUESTION { get; set; }
        public bool? FIXA { get; set; }
        public string SUB_TEMA { get; set; }
        public DateTime? DT_MOD { get; set; }
        public ACESSOS_MOBILE? LOGIN_MOD { get; set; }
    }
}
