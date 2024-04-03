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
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using Microsoft.EntityFrameworkCore.Internal;
using Blazorise;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.Extensions.Hosting;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System.Runtime.Intrinsics.X86;
using StackExchange.Redis;
using System.Data.Entity;

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
        private VICContext CD_VIC = new VICContext();

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

        [HttpGet("Update_Manual_Audit")]
        public async Task<IActionResult> Update_Manual_Audit()
        {
            try
            {
                var query = @"
            SELECT
                O.NM_FNTS AS LOJA,
                O.CENT,
                O.CD,
                O.ORDEM_VEND,
                O.TPOV,
                O.CPF_CNPJ,
                O.MATERIAL,
                O.DATA_NF,
                O.NR_SRAL AS N_DE_SERIE,
                O.VALOR_NF,
                O.DOC_FATURAMENTO AS NUMERO_PED,
                O.NO_LOGN_ATND_MVMT AS CRIADO_POR,
                O.DS_PLNO AS NM_PLANO,
                NULL AS APRL_DPAV,
                NULL AS STATUS_DA_FIDELIZAÇÃO,
                NULL AS NÚMERO_DA_LINHA_FIDELIZADA,
                NULL AS VIVO_RENOVA_NÚMERO_DO_VOUCHER_DO_VIVO_RENOVA,
                NULL AS DATA_DA_EMISSÃO_DO_VOUCHER_DO_VIVO_RENOVA,
                NULL AS VALOR_DO_VOUCHER_VIVO_RENOVA,
                NULL AS VIVO_VALORIZA_VALOR_DO_RESGATE_DA_PONTUAÇÃO_DO_VIVO_VALORIZA,
                NULL AS VALOR_DO_RESGATE_VIVO_VALORIZA,
                NULL AS DATA_DO_REGATE_DO_VIVO_VALORIZA,
                NULL AS VALOR_NA_TABELA_DE_PREÇO,
                NULL AS DELTA_DO_SUBSÍDIO_X_FATURAMENTO,
                NULL AS PROTOCOLO_DE_DIGITALIZAÇÃO,
                NULL AS OBSERVAÇÃO_DA_LOJA,
                NULL AS LOGIN_RESPONSÁVEL,
                NULL AS NÚMERO_DO_CHAMADO,
                NULL AS AVALIÇÃO_REGIONAL,
                NULL AS EMAIL_DO_RESPONSÁVEL_DA_REGIONAL,
                O.NU_ANO_MES_RFRN AS ANOMES,
                '' AS RETORNO_REGIONAL,
                'N' AS IsSaved, 
                'N' AS IsRESPONDIDO,
                O.NOME_COMERCIAL,
                O.DS_TIPO_MVMT_LNHA,
                '1' AS AUDITORIA
            FROM VPV_SDBX_PLNJ.VVIC_TRML_SUBSIDIO O
            WHERE
                o.nu_ano_mes_rfrn BETWEEN TO_CHAR(trunc(ADD_MONTHS (TO_DATE(TO_CHAR(trunc(sysdate),'YYYYMM'),'YYYYMM'),-2)),'YYYYMM')
                AND TO_CHAR(trunc(sysdate),'YYYYMM')
                AND SEGMENTO='B2C'
                AND DEPOSITO NOT IN ('FGAR','RDMA','RPAR','SNOV','SNTR','SUCT','USAD')
                AND CANAL_FATURAMENTO <>'Funcionários'
                AND CLASSIF_CATEGORIA IN ('APARELHOS','SMARTPHONES')
                AND O.SG_RGNL IN ('NE')
                AND O.CANAL_FATURAMENTO IN ('LOJAS PROPRIAS','CLIENTES ESPECIAIS')
                AND O.DEPOSITO = 'LVUT'
                AND FLAG_VNDA_MANUAL_APRL = 1";

                DataTable dataTable = new DataTable();
                using (OracleConnection connection = new OracleConnection(CD_VIC.Database.GetConnectionString()))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        connection.Close();
                    }
                }
                List<T_VIC_VNDA_MANUAL_AUDIT> resultList = new List<T_VIC_VNDA_MANUAL_AUDIT>();

                foreach (DataRow row in dataTable.Rows)
                {
                    T_VIC_VNDA_MANUAL_AUDIT item = new T_VIC_VNDA_MANUAL_AUDIT
                    {
                        LOJA = row["LOJA"].ToString(),
                        CENT = row["CENT"].ToString(),
                        CD = Convert.ToDecimal(row["CD"]),
                        ORDEM_VEND = Convert.ToDecimal(row["ORDEM_VEND"]),

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

    }
}
