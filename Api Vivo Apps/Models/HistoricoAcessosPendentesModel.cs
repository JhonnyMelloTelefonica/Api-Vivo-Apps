using Vivo_Apps_API.Data;
using Vivo_Apps_API.Enums;

namespace Vivo_Apps_API.Models
{
    public class HistoricoAcessosPendentesModel
    {
        public int ID { get; set; }
        public ACESSOS_MOBILE? ID_ACESSOS_MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string MATRICULA { get; set; }
        public string SENHA { get; set; }
        public string REGIONAL { get; set; }
        public Cargos CARGO { get; set; }
        public Canal CANAL { get; set; }
        public string NOME { get; set; }
        public string UF { get; set; }
        public string CPF { get; set; }
        public string PDV { get; set; }
        public bool? APROVACAO { get; set; }
        public bool? FIXA { get; set; }
        public string TIPO { get; set; }
        public bool? STATUS_USUARIO { get; set; }
        public ACESSO? LOGIN_SOLICITANTE { get; set; }
        public ACESSO? LOGIN_RESPONSAVEL { get; set; }
        public string DT_SOLICITACAO { get; set; }
        public string? DT_RETORNO { get; set; }

        public string STATUS { get; set; }
        public IEnumerable<RespostasAcessosPendentesModel> RESPOSTAS { get; set; }
    }
}
