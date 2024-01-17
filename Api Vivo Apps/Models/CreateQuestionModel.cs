using Shared_Class_Vivo_Apps.Data;

namespace Vivo_Apps_API.Models
{
    public class CreateQuestionModel
    {
        public int TEMA { get; set; }
        public int SUB_TEMA { get; set; }
        public IEnumerable<string> TP_FORMS { get; set; }
        public string TP_QUESTAO { get; set; }
        public string PERGUNTA { get; set; }
        public IEnumerable<int> CARGO { get; set; }
        public bool? FIXA { get; set; }
        public List<JORNADA_BD_ANSWER_ALTERNATIVA> ALTERNATIVAS { get; set; } = new();
        public int? matricula { get; set; }
        public required string regional { get; set; }
    }
}
