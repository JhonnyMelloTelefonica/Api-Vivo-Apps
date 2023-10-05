using Shared_Class_Vivo_Mais.Data;

namespace Vivo_Apps_API.Models
{
    public class StatusDemanda
    {
        public int ID_STATUS_CHAMADO { get; set; }
        public string STATUS { get; set; }
        public DateTime DATA { get; set; }
        public ACESSO? QUEM_REDIRECIONOU { get; set; }
        public int ID { get; set; }
        public string ID_RESPOSTA { get; set; }
    }
}
