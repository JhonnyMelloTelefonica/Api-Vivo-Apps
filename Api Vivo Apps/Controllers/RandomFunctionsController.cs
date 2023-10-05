using Newtonsoft.Json;
using DataTable = System.Data.DataTable;
using System.Data;
using Vivo_Apps_API.Models;
using Shared_Class_Vivo_Mais.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using ApiController = System.Web.Http.ApiController;
using Shared_Class_Vivo_Mais.Enums;
using Shared_Class_Vivo_Mais.DB_Context_Vivo_MAIS;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RandomFunctions
    {
        private Vivo_MAISContext CD = new Vivo_MAISContext();

        private readonly ILogger<RandomFunctions> _logger;

        public RandomFunctions(ILogger<RandomFunctions> logger)
        {
            _logger = logger;
        }

        [HttpGet("Att_Visao_Cargos_VivoTask")]
        public async Task<string> Att_Visao_Cargos_VivoTask()
        {
            try
            {
                var acessos = CD.ACESSOS_MOBILEs.AsEnumerable();

                foreach (var acesso in acessos)
                {
                    if (((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Operações
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Parceiros
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Geral
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Supervisor_PAP
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Revenda
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Área
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Operações
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Vendas_B2C
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Senior_Territorial
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Coordenador_Suporte_Vendas
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Suporte_Vendas
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Diretora
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Consultor_Gestão_Vendas
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Gerente_Senior_Gestão_Vendas)
                    {

                    }
                    if (((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Consultor_Negócios
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Vendedor_PAP
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Vendedor_Revenda
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Consultor_Tecnológico
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Analista_Suporte_Vendas_Junior
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Analista_Suporte_Vendas_Pleno
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Analista_Suporte_Vendas_Senior
                        || ((Cargos)int.Parse(acesso.CARGO.ToString())) == Cargos.Estagiário
                        )
                    {

                    }
                }

                return "Tudo certo!";
            }
            catch (Exception ex)
            {
                return $"ERRO --> {ex.Message} ------- {ex}";
            }
        }
    }
}
