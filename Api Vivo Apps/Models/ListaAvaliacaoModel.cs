using Shared_Class_Vivo_Apps.Enums;

namespace Vivo_Apps_API.ModelDTO
{
    public class ListaAvaliacaoModel
    {
        public int ID_PROVA_RESPONDIDA { get; set; }
        public int? ID_PROVA { get; set; }
        public string TEMA { get; set; }
        public string TP_FORMS { get; set; }
        public Canal PUBLICO_CANAL { get; set; }
        public Cargos PUBLICO_CARGO { get; set; }
        public DateTime DT_AVALIACAO { get; set; }
        public string MATRICULA_AVALIADOR { get; set; }
        public string NOME { get; set; }
        public string CADERNO { get; set; }
        public double NOTA { get; set; }
        public string REDE_AVALIADA { get; set; }
        public string DDD_AVALIADO { get; set; }
        public string PDV_AVALIADO { get; set; }
        public string RE_AVALIADO { get; set; }
        public string REGIONAL { get; set; }
    }
}
