namespace Vivo_Apps_API.Models
{
    public class FilterEditQuestionModel
    {
        public int? Id_Question { get; set; }
        public string? Pergunta { get; set; }
        public IEnumerable<bool>? Fixa { get; set; }
        public IEnumerable<string>? TP_questao { get; set; }
        public IEnumerable<int>? Temas { get; set; }
        public IEnumerable<int>? Sub_temas { get; set; }
        public IEnumerable<int>? Cargos { get; set; }
        public IEnumerable<int>? Canal { get; set; }
    }
}
