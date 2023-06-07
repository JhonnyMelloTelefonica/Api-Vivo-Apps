using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Vivo_Apps.Models
{
    public class RespostaFechamento
    {
        public string resposta { get; set; }
        public int IdChamado { get; set; }
        public string MATRICULA { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
    }
//    "resposta":"",
//"IdChamado":1,
//"MATRICULA":"",
//"Data":"",
//"Status":""

}