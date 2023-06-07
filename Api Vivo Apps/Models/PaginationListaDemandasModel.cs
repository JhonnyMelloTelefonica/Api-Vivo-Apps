using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;

namespace Api_Vivo_Apps.Models
{
    public class PaginationListaDemandasModel
    {
        public string matricula { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class PagedModelResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public bool isFirstpage { get; set; } = false;
        public bool isLastpage { get; set; } = false;
        public PagedModelResponse(T data, int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Data = data;
            this.Message = null;
            this.Succeeded = true;
            this.Errors = null;
        }
    }
}
//{
//    "GetDash":"",
//"PageNumber":12,
//"PageSize":43,
//"Território":[],
//"UF":[],
//"DDD":[],
//"CIDADE":[],
//"MICRORREGIÃO":[],
//"CEP":[],
//"BAIRRO":[],
//"LOGRADOURO":[],
//"NÚMERO":[],
//"CAIXA":[],
//"TIPO_RESIDENCIA":[],
//"OCUPAÇÃO":[],
//}