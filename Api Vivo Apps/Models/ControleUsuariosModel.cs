using Api_Vivo_Apps.Data;

namespace Vivo_Apps_API.Models
{
    public class ControleUsuariosModel
    {
        public int ID { get; set; }
        public string EMAIL { get; set; }
        public string MATRICULA { get; set; }
        public string SENHA { get; set; }
        public string REGIONAL { get; set; }
        public string CARGO { get; set; }
        public string? CANAL { get; set; }
        public string PDV { get; set; }
        public string CPF { get; set; }
        public string NOME { get; set; }
        public string UF { get; set; }
        public bool? STATUS { get; set; }
        public bool? FIXA { get; set; }
        public string? TP_AFASTAMENTO { get; set; }
        public string? OBS { get; set; }
        public byte[]? UserAvatar { get; set; }
        public string? LOGIN_MOD { get; set; }
        public string? DT_MOD { get; set; }
        public int? ID_Perfil_Usuario { get; set; }
        public List<int?>? Perfil { get; set; }
    }
}
