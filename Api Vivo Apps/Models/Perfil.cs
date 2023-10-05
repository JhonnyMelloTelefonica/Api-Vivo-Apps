using Shared_Class_Vivo_Mais.Data;

namespace Vivo_Apps_API.Models
{
    public class Perfil
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string PLATAFORMA { get; set; }
        public int? Cargo { get; set; }
        public required PERFIL_PLATAFORMAS_VIVO Perfil_Plataforma { get; set; }
        public string? Nome_Perfil { get; set; }
    }
}
