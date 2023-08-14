using Api_Vivo_Apps.Data;

namespace Vivo_Apps_API.Models
{
    public class AcessoVivoMaisModel
    {
        public int idAcesso { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Regional { get; set; }
        public byte[] Senha { get; set; }
        public byte[] Imagem { get; set; }
        public string Status { get; set; }
        public bool? Primeiro_Acesso { get; set; }
        public ACESSO_PERMISSAO_MENU? ACESSO_PERMISSAO_MENU { get; set; }
    }
}
