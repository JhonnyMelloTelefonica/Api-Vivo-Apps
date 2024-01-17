using Newtonsoft.Json;
using DataTable = System.Data.DataTable;
using System.Data;
using Vivo_Apps_API.Models;
using Shared_Class_Vivo_Apps.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiController = System.Web.Http.ApiController;
using Shared_Class_Vivo_Apps.Enums;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Web.Http.Results;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Runtime.ConstrainedExecution;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Vivo_Apps_API.Converters.Converters;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RandomFunctions : ControllerBase
    {
        private Vivo_MaisContext CD = new Vivo_MaisContext();
        private Vivo_PBIContext CD_PBI = new Vivo_PBIContext();

        private readonly ILogger<RandomFunctions> _logger;

        public RandomFunctions(ILogger<RandomFunctions> logger)
        {
            _logger = logger;
        }

        public partial class PABody
        {
            [JsonPropertyName("$content-type")]
            public required string contenttype { get; set; }
            [JsonPropertyName("$content")]
            public required string content { get; set; }
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

        [HttpPost("Att_Trought_OneDrive")]
        public async Task<JsonResult> Att_Trought_OneDrive([FromBody] PABody ExcelContent)
        {
            try
            {
                byte[] binaryContent = Convert.FromBase64String(ExcelContent.content);
                // Read Excel file into DataTable
                DataTable dataTable = ReadExcelToDataTable(binaryContent);
                List<fGOESTOQUE> Table = new List<fGOESTOQUE>();

                Table = dataTable.AsEnumerable().Select(item => new fGOESTOQUE
                {
                    Data = Convert.ToDateTime(item.Field<string?>("Data") ?? DateTime.Now.ToString()),
                    Revenda = item.Field<string>("Revenda"),
                    Filial_Estoque = item.Field<string>("Filial Estoque"),
                    Data_Compra = Convert.ToDateTime(item.Field<string?>("Data Compra") ?? DateTime.Now.ToString()),
                    Fornecedor_Compra = item.Field<string>("Fornecedor Compra"),
                    Marca = item.Field<string>("Marca"),
                    Modelo_Comercial = item.Field<string>("Modelo Comercial"),
                    Modelo_DPGC = item.Field<string>("Modelo DPGC"),
                    SKU = item.Field<string>("SKU"),
                    Cor = item.Field<string>("Cor"),
                    Serial = item.Field<string>("Serial"),
                    Dias_em_Estoque = item.Field<string>("Dias em Estoque"),
                    Valor = decimal.TryParse(item.Field<string?>("Valor").Replace(".",","), out decimal resultado)
                    ? Math.Round(resultado,2)
                    : 0,
                    //decimal.TryParse(, out decimal resultado) == true ? Math.Round(resultado, 2) : 0
                    Quantidade = Convert.ToDouble(item.Field<string?>("Quantidade") ?? "0.0"),
                    Gama = item.Field<string>("Gama")
                }).ToList();

                await CD_PBI.fGOESTOQUEs.AddRangeAsync(Table);
                CD_PBI.SaveChanges();

                return new JsonResult(Table);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }

    }
}
