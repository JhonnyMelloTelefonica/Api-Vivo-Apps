using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vivo_Apps_API.Models
{
    public class AbrirDemanda
    {
        public int ID { get; set; }
        public int FILA { get; set; }
        public string MAT_SOLICITANTE { get; set; }
        public int TIPO_FILA { get; set; }
        public string REGIONAL { get; set; }
        public string PROBLEMA { get; set; }
        public string SEC_EMAIL { get; set; }
        public List<Campos> campos { get; set; }
    }
    public class Campos
    {
        public string CAMPO { get; set;}
        public string VALOR { get; set;}
    }
}