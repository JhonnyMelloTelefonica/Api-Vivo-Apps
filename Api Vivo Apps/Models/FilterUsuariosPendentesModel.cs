namespace Vivo_Apps_API.Models
{
    public class FilterUsuariosPendentesModel
    {
        public bool? IsSuporte { get; set; }
        public required string LOGIN { get; set; }
        public bool? APROVACAO { get; set; }
        public required string REGIONAL { get; set; }
        public string? UF { get; set; }
        public string? DT_SOLICITACAO { get; set; }

    }
}
