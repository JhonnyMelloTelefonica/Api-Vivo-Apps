using System.ComponentModel.DataAnnotations;

namespace Vivo_Apps_API.Models
{
    public class GenericPaginationModel<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        [Required]
        public T Value { get; set; }
    }
}
