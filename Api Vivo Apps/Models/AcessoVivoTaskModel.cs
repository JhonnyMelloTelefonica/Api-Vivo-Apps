using Vivo_Apps_API.Data;
using Vivo_Apps_API.Enums;

namespace Vivo_Apps_API.Models
{
    public class AcessoVivoTaskModel
    {
        public int ID { get; set; }
        public string EMAIL { get; set; }
        public string MATRICULA { get; set; }
        public string SENHA { get; set; }
        public string REGIONAL { get; set; }
        public Cargos CARGO { get; set; }
        public Canal CANAL { get; set; }
        public string PDV { get; set; }
        public string CPF { get; set; }
        public string NOME { get; set; }
        public string UF { get; set; }
        public bool? STATUS { get; set; }
        public bool? FIXA { get; set; }
        public string TP_AFASTAMENTO { get; set; }
        public string OBS { get; set; }
        public byte[] UserAvatar { get; set; }
        public string LOGIN_MOD { get; set; }
        public string DT_MOD { get; set; }
        public bool IsSuporte()
        {
            if (CARGO.HasFlag(Cargos.Coordenador_Suporte_Vendas) 
                || CARGO.HasFlag(Cargos.Diretora)
                )
            {
                return true;
            }

            return false;
        }
    }
}
