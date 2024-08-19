using Newtonsoft.Json;
using DataTable = System.Data.DataTable;
using System.Data;
using Vivo_Apps_API.Models;
using Shared_Static_Class.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiController = System.Web.Http.ApiController;
using Shared_Static_Class.Enums;
using Shared_Static_Class.Converters;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Web.Http.Results;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Runtime.ConstrainedExecution;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Vivo_Apps_API.Models.Converters.Converters;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Blazorise;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.Extensions.Hosting;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System.Runtime.Intrinsics.X86;
using StackExchange.Redis;
using CoreHtmlToImage;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RandomFunctions : ControllerBase
    {
        private Vivo_MaisContext CD = new Vivo_MaisContext();
        private Vivo_PBIContext CD_PBI = new Vivo_PBIContext();
        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext Demanda_BD;

        private readonly ILogger<RandomFunctions> _logger;

        public RandomFunctions(ILogger<RandomFunctions> logger, IDbContextFactory<DemandasContext> dbFactory)
        {
            _logger = logger;
            DbFactory = dbFactory;
            Demanda_BD = DbFactory.CreateDbContext();
        }

        public partial class PABody
        {
            [JsonPropertyName("$content-type")]
            public required string contenttype { get; set; }
            [JsonPropertyName("$content")]
            public required string content { get; set; }
        }

        /*
        [HttpGet("Update_Cliente_alto_Valor")]
        public async Task<IActionResult> Update_Cliente_alto_Valor(string telefone)
        {
            try
            {
                DataTable dataTable = new DataTable();
                string oracleConnectionString =
                    "Data Source=10.240.44.198:1521/VICPR;User Id=VPV_RGNL_NE;Password=NE_IC_2022";


                //string sqlServerConnectionString = "Data Source=10.124.100.153;Initial Catalog=Vivo_MAIS;TrustServerCertificate=True;User ID=RegionalNE;Password=RegionalNEvivo2019";
                string oraclequery = @$"SELECT DISTINCT 
                    ID_SGMN_CLNT
                    FROM TVIC_ODS_MVEL_PRQE 
                    WHERE NU_ANO_MES=202402
                    AND NU_TLFN = '81982675236'";
                //using (var sqlServerConnection = new SqlConnection(sqlServerConnectionString))
                //{ (DateTime.Now.Month < 10 ? string.Concat(DateTime.Now.Year, 0, DateTime.Now.Month) : string.Concat(DateTime.Now.Year, DateTime.Now.Month))}



                using (OracleConnection connection = new OracleConnection(oracleConnectionString))
                {
                    using (OracleCommand command = new OracleCommand(oraclequery, connection))
                    {
                        connection.Open();

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        connection.Close();
                    }
                }

                List<DEMANDA_PARQUE> resultList = new List<DEMANDA_PARQUE>();

                var data = DateTime.Now;

                foreach (DataRow row in dataTable.Rows)
                {
                    DEMANDA_PARQUE item = new DEMANDA_PARQUE
                    {
                        DS_SGMN_CLNT = row["DS_SGMN_CLNT"].ToString(),
                        NU_TLFN = row["NU_TLFN"].ToString(),
                        NU_ANO_MES = int.Parse(row["NU_ANO_MES"].ToString()),
                        DS_ORIG_PRDT = row["DS_ORIG_PRDT"].ToString(),
                        SG_UF = row["SG_UF"].ToString(),
                        NU_DDD = int.Parse(row["NU_DDD"].ToString() ?? "0"),
                        ID_PLNO = int.Parse(row["ID_PLNO"].ToString() ?? "0"),
                        DS_DCTO_PRNC = row["DS_DCTO_PRNC"].ToString(),
                        DATA = DateTime.Now
                    };

                    resultList.Add(item);
                }

                return Ok("Tudo certo!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
         */

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
                    Valor = decimal.TryParse(item.Field<string?>("Valor").Replace(".", ","), out decimal resultado)
                    ? Math.Round(resultado, 2)
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

        [HttpPost("StringHtmlToImage")]
        public async Task<IActionResult> StringHtmlToImage([FromBody] birthModel htmlpage)
        {
            try
            {
                var folderPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates", $"Birth{htmlpage.Usuário}.jpg");
                var usericon = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates", "usericon.png");
                var ballons = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates", "ballons.png");
                var converter = new HtmlConverter();
                var base64Encoded = System.IO.File.ReadAllText(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates", "birthtemplate.html"));

                base64Encoded = base64Encoded.Replace("@usericonpath", "data:image/png;base64," + Convert.ToBase64String(htmlpage.Image));
                base64Encoded = base64Encoded.Replace("@ballonspath", ballons);

                var bytes = converter.FromHtmlString(base64Encoded,360);
                System.IO.File.WriteAllBytes(folderPath, bytes);
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(folderPath, out var contentType))
                {
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                }
                var html = new
                {
                    content_type = "image/jpg",
                    content = System.IO.File.ReadAllBytes(folderPath)
                };

                return Ok(new { file = File(bytes, contentType, folderPath), html = html});
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        public class birthModel()
        {
            public string Nome { get; set; }
            public string DataNascimento { get; set; }
            public string Usuário { get; set; }
            public string E_mail { get; set; }
            public string Status { get; set; }
            public byte[] Image { get; set; }
        }
    }
}
