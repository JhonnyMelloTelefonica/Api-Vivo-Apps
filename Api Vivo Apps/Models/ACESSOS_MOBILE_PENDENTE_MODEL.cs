﻿using Vivo_Apps_API.Data;

namespace Vivo_Apps_API.Models
{
    public class ACESSOS_MOBILE_PENDENTE_MODEL
    {
        public int ID { get; set; }
        public string EMAIL { get; set; }
        public string MATRICULA { get; set; }
        public string SENHA { get; set; }
        public string REGIONAL { get; set; }
        public string CARGO { get; set; }
        public string CANAL { get; set; }
        public string NOME { get; set; }
        public string UF { get; set; }
        public string CPF { get; set; }
        public string PDV { get; set; }
        public bool? APROVACAO { get; set; }
        public bool? FIXA { get; set; }
        public string TIPO { get; set; }
        public ACESSO? SOLICITANTE { get; set; }
        public string DT_SOLICITACAO { get; set; }
        public string LOGIN_RESPONSAVEL { get; set; }
        public string DT_RETORNO { get; set; }
        public string DT_PRIMEIRO_RETORNO { get; set; }
    }
}