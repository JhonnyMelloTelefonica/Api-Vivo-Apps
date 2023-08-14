using Api_Vivo_Apps.Data;

namespace Vivo_Apps_API.Models
{
    public class RespostaDemanda
    {
        public int ID { get; set; }
        public string RESPOSTA { get; set; }
        public int ID_CHAMADO { get; set; }
        public ACESSO? RESPONSAVEL { get; set; }
        public DateTime? DATA_RESPOSTA { get; set; }
        public IEnumerable<CONTROLE_DE_DEMANDAS_ARQUIVOS_RESPOSTum>? ANEXOS { get; set; }
    }
}
