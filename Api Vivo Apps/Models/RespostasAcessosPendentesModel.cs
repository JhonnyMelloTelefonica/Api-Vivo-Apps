using Api_Vivo_Apps.Data;

namespace Vivo_Apps_API.Models
{
    public class RespostasAcessosPendentesModel
    {
        public int ID { get; set; }
        public int ID_ACESSOS_PENDENTE { get; set; }
        public ACESSO? MATRICULA { get; set; }
        public string RESPOSTA { get; set; }
        public string STATUS { get; set; }
        public string DATA { get; set; }
    }
}
