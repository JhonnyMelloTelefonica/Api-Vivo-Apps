namespace Vivo_Apps_API.Models
{
    public class PaginationDemandasModel
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string matricula { get; set; }
        public IEnumerable<DateTime> datas { get; set; }
        public IEnumerable<string> regional { get; set; }
        public IEnumerable<int> id_demandas { get; set; }
        public IEnumerable<string> responsável { get; set; }
        public IEnumerable<string> status { get; set; }
        public IEnumerable<string> fila { get; set; }
        public IEnumerable<string> tipo_fila { get; set; }
        //public int PageSize { get; set; }
    }
}
