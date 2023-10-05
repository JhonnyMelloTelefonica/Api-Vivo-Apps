using Shared_Class_Vivo_Mais.Data;

namespace Vivo_Apps_API.Models
{
    public class RespostasAcessosPendentesModel
    {
        public int ID { get; set; }
        public int ID_ACESSOS_PENDENTE { get; set; }
        public ACESSOS_MOBILE? MATRICULA { get; set; }
        public string RESPOSTA { get; set; }
        public string STATUS { get; set; }
        public string DATA { get; set; }
    }
}
