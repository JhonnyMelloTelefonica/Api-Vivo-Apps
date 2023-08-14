namespace Vivo_Apps_API.Models
{
    public class FilterEditQuestionModel
    {
        public int? Id_Question { get; set; }
        public string? Pergunta { get; set; }
        public bool? Fixa { get; set; }
        public List<string>? TP_Forms { get; set; }
        public List<string>? TP_questao { get; set; }
        public List<int>? Temas { get; set; }
        public List<int>? Sub_temas { get; set; }
        public List<int>? Cargos { get; set; }
        public List<int>? Canal { get; set; }
    }
}
