using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using Newtonsoft.Json;
using System.Web;

namespace Vivo_Apps_API.Models
{
    
    public class PaginationPainelRotaModel
    {
        public bool GetDash { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public List<string>? Território { get; set; }
        public List<string>? UF { get; set; }
        public List<string>? DDD { get; set; }
        public List<string>? CIDADE { get; set; }
        public List<string>? MICROREGIÃO { get; set; }
        public List<string>? CEP { get; set; }
        public List<string>? BAIRRO { get; set; }
        public List<string>? LOGRADOURO { get; set; }
        public List<string>? NUMERO { get; set; }
        public List<string>? CAIXA { get; set; }
        public List<string>? TIPO_RESIDENCIA { get; set; }
        public List<string>? OCUPAÇÃO { get; set; }

    }

    public class PagedResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public bool isFirstpage { get; set; } = false;
        public bool isLastpage { get; set; } = false;
        public double Pcr_ocupação { get; set; } //Porcentagem de ocupação
        public double Pcr_disponível { get; set; }
        public int qtd_total_casas { get; set; }
        public int qtd_total_prédios { get; set; }
        public int qtd_clientes_FTTC { get; set; }
        public int total_cliente_BADDEBT { get; set; }
        public int total_clientes_FRAUDE { get; set; }
        [JsonConstructor]
        public PagedResponse(T data, int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Data = data;
            this.Message = null;
            this.Succeeded = true;
            this.Errors = null;
        }
    }

    public class Response<T>
    {
        public Response()
        {
        }

        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public string[] Errors { get; set; }
        public string Message { get; set; }
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