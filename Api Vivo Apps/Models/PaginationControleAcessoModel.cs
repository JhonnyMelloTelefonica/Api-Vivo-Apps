using System.Collections.Generic;

namespace Vivo_Apps_API.Models
{
    public class PaginationControleAcessoModel
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public string? email { get; set; }
        public bool? IsSuporte { get; set; }
        public List<string>? Cargo { get; set; }
        public List<string>? Canal { get; set; }
        public List<string>? Regional { get; set; }
        public List<string>? Uf { get; set; }
        public List<bool>? Fixa { get; set; }

    }
}
