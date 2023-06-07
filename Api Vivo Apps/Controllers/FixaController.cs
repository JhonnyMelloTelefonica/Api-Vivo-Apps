using Newtonsoft.Json;
using DataTable = System.Data.DataTable;
using IHttpActionResult = System.Web.Http.IHttpActionResult;
using System.Data;
using Api_Vivo_Apps.Models;
using Api_Vivo_Apps.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using ApiController =  System.Web.Http.ApiController;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Api_Vivo_Apps.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FixaController
    {
        private Vivo_MAISContext CD = new Vivo_MAISContext();

        private readonly ILogger<FixaController> _logger;

        public FixaController(ILogger<FixaController> logger)
        {
            _logger = logger;
        }

        [HttpPost("GerarArquivoTexto_FIXA_ROTA")]
        public async Task<bool> GerarArquivoTexto_FIXA_ROTA(IList<string[]> listarray)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                string colunas = $"DDD,TERRITÓRIO,UF,CIDADE,BAIRRO,MICRORREGIÃO,CEP,TIPO,TITULO,LOGRADOURO,NÚMERO,DATA_ARMÁRIO,ARMÁRIO,CAIXA,CAPACIDADE,USADOS,DISPONÍVEL,OCUPAÇÃO,STATUS_LOTE,BADDEBT,FRAUDE,SEGMENTO,COD_CONDOMINIO,NOM_CONDOMINIO,ESTEIRA,DATA_ESTEIRA,PRIORIDADE,BLOCOS,QTD_APARTAMENTO,CLASSE_A,CLASSE_B,CLASSE_C,CLASSE_AB,TIPO_RESIDENCIA,CLIENTE_FTTC,VENDAS,MIGRAÇÃO,CEP_NUM,CLIENTE_FTTC_POR_DISPONIBILIDADE,AGING_ARMÁRIO";
                sb.AppendLine(colunas);
                foreach (string[] row in listarray)
                {
                    string line = string.Join(";", row);
                    sb.AppendLine(line);
                }

                string filePath = @"D:\VivoSimArquivos\Saida_Update_Painel_Fixa-" + DateTime.Now.ToShortTimeString() + ".txt";
                System.IO.File.WriteAllText(filePath, sb.ToString());

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        [HttpPost("UpdatePainelRota_SQL")]
        public async Task<JsonResult> UpdatePainelRota_SQL<T>()
        {
            IList<string[]> table = new List<string[]>();
            try
            {
                var dataTable = new DataTable();
                string sql = "select * from FIXA_VIEW_PAINEL_DE_ROTAS";
                dataTable = ExecutarCommandRetornaDataTable(sql);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow item in dataTable.Rows)
                    {
                        var linha = new string[]
                        {
                                item[0].ToString(),
                                item[1].ToString(),
                                item[2].ToString(),
                                item[3].ToString(),
                                item[4].ToString(),
                                item[5].ToString(),
                                item[6].ToString(),
                                item[7].ToString(),
                                item[8].ToString(),
                                item[9].ToString(),
                                item[10].ToString(),
                                item[11].ToString(),
                                item[12].ToString(),
                                item[13].ToString(),
                                item[14].ToString(),
                                item[15].ToString(),
                                item[16].ToString(),
                                item[17].ToString(),
                                item[18].ToString(),
                                item[19].ToString(),
                                item[20].ToString(),
                                item[21].ToString(),
                                item[22].ToString(),
                                item[23].ToString(),
                                item[24].ToString(),
                                item[25].ToString(),
                                item[26].ToString(),
                                item[27].ToString(),
                                item[28].ToString(),
                                item[29].ToString(),
                                item[30].ToString(),
                                item[31].ToString(),
                                item[32].ToString(),
                                item[33].ToString(),
                                item[34].ToString(),
                                item[35].ToString(),
                                item[36].ToString(),
                                item[37].ToString(),
                                item[38].ToString(),
                                item[39].ToString()
                        };
                        table.Add(linha);
                    }
                }

                var retorno = await GerarArquivoTexto_FIXA_ROTA(table);

                return new JsonResult(new Response<bool>
                {
                    Data = retorno,
                    Succeeded = retorno,
                    Message = "Tudo Ceto!"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<IEnumerable<string[]>>
                {
                    Data = table,
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace,
                        ex.HelpLink,
                        ex.HResult.ToString()
                    },
                    Message = "Algum erro nao identificado aconteceu ao executar esta acao"
                });
            }
        }

        [HttpGet("Get_Fixa_View")]
        public async Task<string> Get_Fixa_View()
        {
            try
            {
                return JsonConvert.SerializeObject(CD.FIXA_VIEW_PAINEL_DE_ROTAs.Select(x => new
                {
                    x.TERRITÓRIO,
                    x.UF,
                    x.DDD,
                    x.CIDADE,
                    x.MICRORREGIÃO,
                    x.CEP,
                    x.BAIRRO,
                    x.LOGRADOURO,
                    x.NÚMERO,
                    x.CAIXA,
                    x.TIPO_RESIDENCIA,
                    x.OCUPAÇÃO,
                }).AsEnumerable());
            }
            catch (Exception ex)
            {
                return $"500 --> {ex.Message} ------- {ex}";
            }
        }
        [HttpPost("GetDataFilters")]
        public async Task<JsonResult> GetDataFilters([FromBody] PainelRotaFilterModel data)
        {
            var lista = CD.FIXA_VIEW_PAINEL_DE_ROTAs.AsQueryable();
            if (data.Território.Count() > 0)
            {
                lista = lista.Where(x => data.Território.Contains(x.TERRITÓRIO));
            }
            if (data.UF.Count() > 0)
            {
                lista = lista.Where(x => data.UF.Contains(x.UF));
            }
            if (data.DDD.Count() > 0)
            {
                lista = lista.Where(x => data.DDD.Contains(x.DDD));
            }
            if (data.CIDADE.Count() > 0)
            {
                lista = lista.Where(x => data.CIDADE.Contains(x.CIDADE));
            }
            if (data.MICROREGIÃO.Count() > 0)
            {
                lista = lista.Where(x => data.MICROREGIÃO.Contains(x.MICRORREGIÃO));
            }
            if (data.CEP.Count() > 0)
            {
                lista = lista.Where(x => data.CEP.Contains(x.CEP));
            }
            if (data.BAIRRO.Count() > 0)
            {
                lista = lista.Where(x => data.BAIRRO.Contains(x.BAIRRO));
            }
            if (data.LOGRADOURO.Count() > 0)
            {
                lista = lista.Where(x => data.LOGRADOURO.Contains(x.LOGRADOURO));
            }
            if (data.NUMERO.Count() > 0)
            {
                lista = lista.Where(x => data.NUMERO.Contains(x.NÚMERO));
            }
            if (data.CAIXA.Count() > 0)
            {
                lista = lista.Where(x => data.CAIXA.Contains(x.CAIXA));
            }
            if (data.TIPO_RESIDENCIA.Count() > 0)
            {
                lista = lista.Where(x => data.TIPO_RESIDENCIA.Contains(x.TIPO_RESIDENCIA));
            }
            if (data.OCUPAÇÃO.Count() > 0)
            {
                lista = lista.Where(x => data.OCUPAÇÃO.Contains(x.OCUPAÇÃO));
            }

            var Território = lista.Select(x => x.TERRITÓRIO).Distinct().ToArray();
            var UF = lista.Select(x => x.UF).Distinct().ToArray();
            var DDD = lista.Select(x => x.DDD).Distinct().ToArray();
            var CIDADE = lista.Select(x => x.CIDADE).Distinct().ToArray();
            var MICROREGIÃO = lista.Select(x => x.MICRORREGIÃO).Distinct().ToArray();
            var CEP = lista.Select(x => x.CEP).Distinct().ToArray();
            var BAIRRO = lista.Select(x => x.BAIRRO).Distinct().ToArray();
            var LOGRADOURO = lista.Select(x => x.LOGRADOURO).Distinct().ToArray();
            var NUMERO = lista.Select(x => x.NÚMERO).Distinct().ToArray();
            var CAIXA = lista.Select(x => x.CAIXA).Distinct().ToArray();
            var TIPO_RESIDENCIA = lista.Select(x => x.TIPO_RESIDENCIA).Distinct().ToArray();
            var OCUPAÇÃO = lista.Select(x => x.OCUPAÇÃO).Distinct().ToArray();

            return new JsonResult(new
            {
                Território = Território,
                UF = UF,
                DDD = DDD,
                CIDADE = CIDADE,
                MICROREGIÃO = MICROREGIÃO,
                CEP = CEP,
                BAIRRO = BAIRRO,
                LOGRADOURO = LOGRADOURO,
                NUMERO = NUMERO,
                CAIXA = CAIXA,
                TIPO_RESIDENCIA = TIPO_RESIDENCIA,
                OCUPAÇÃO = OCUPAÇÃO
            });
        }

        [HttpPost("GetDataFiltersPruma")]
        public string GetDataFiltersPruma([FromBody] PainelRotaFilterModel data)
        {
            var lista = CD.FIXA_BASE_PRUMAs.AsQueryable();
            if (data.UF.Count() > 0)
            {
                lista = lista.Where(x => data.UF.Contains(x.UF));
            }
            if (data.CIDADE.Count() > 0)
            {
                lista = lista.Where(x => data.CIDADE.Contains(x.CIDADE));
            }
            if (data.CEP.Count() > 0)
            {
                lista = lista.Where(x => data.CEP.Contains(x.CEP.ToString()));
            }
            if (data.BAIRRO.Count() > 0)
            {
                lista = lista.Where(x => data.BAIRRO.Contains(x.BAIRRO));
            }
            if (data.LOGRADOURO.Count() > 0)
            {
                lista = lista.Where(x => data.LOGRADOURO.Contains(x.LOGRADOURO));
            }
            if (data.NUMERO.Count() > 0)
            {
                lista = lista.Where(x => data.NUMERO.Contains(x.NUMERO.ToString()));
            }
            if (data.CAIXA.Count() > 0)
            {
                lista = lista.Where(x => data.CAIXA.Contains(x.CAIXA));
            }

            var UF = lista.Select(x => x.UF).Distinct().ToArray();
            var CIDADE = lista.Select(x => x.CIDADE).Distinct().ToArray();
            var CEP = lista.Select(x => x.CEP).Distinct().ToArray();
            var BAIRRO = lista.Select(x => x.BAIRRO).Distinct().ToArray();
            var LOGRADOURO = lista.Select(x => x.LOGRADOURO).Distinct().ToArray();
            var NUMERO = lista.Select(x => x.NUMERO).Distinct().ToArray();
            var CAIXA = lista.Select(x => x.CAIXA).Distinct().ToArray();

            return JsonConvert.SerializeObject(new
            {
                UF = UF,
                CIDADE = CIDADE,
                CEP = CEP,
                BAIRRO = BAIRRO,
                LOGRADOURO = LOGRADOURO,
                NUMERO = NUMERO,
                CAIXA = CAIXA,
            });
        }

        [HttpPost("GetDataPruma")]
        public async Task<string> GetDataPruma([FromBody] PaginationPainelRotaModel filter)
        {
            var pagedData = CD.FIXA_BASE_PRUMAs.AsQueryable();

            if (filter.UF.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.UF.Contains(x.UF));
            }
            if (filter.CIDADE.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.CIDADE.Contains(x.CIDADE));
            }
            if (filter.CEP.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.CEP.Contains(x.CEP.ToString()));
            }
            if (filter.BAIRRO.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.BAIRRO.Contains(x.BAIRRO));
            }
            if (filter.LOGRADOURO.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.LOGRADOURO.Contains(x.LOGRADOURO));
            }
            if (filter.NUMERO.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.NUMERO.Contains(x.NUMERO.ToString()));
            }
            if (filter.CAIXA.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.CAIXA.Contains(x.CAIXA));
            }

            var Data = pagedData.OrderBy(x => x.ID)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToList();

            var totalRecords = pagedData.Count();
            var totalPages = ((double)totalRecords / (double)filter.PageSize);

            return JsonConvert.SerializeObject(
                PagedResponse.CreatePagedReponse<FIXA_BASE_PRUMA>(
                    Data, filter, totalRecords)
                );
        }

        [HttpPost("GetData")]
        public async Task<string> GetData([FromBody] PaginationPainelRotaModel filter)
        {
            var pagedData = CD.FIXA_VIEW_PAINEL_DE_ROTAs.AsQueryable();

            if (filter.Território.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Território.Contains(x.TERRITÓRIO));
            }
            if (filter.UF.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.UF.Contains(x.UF));
            }
            if (filter.DDD.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.DDD.Contains(x.DDD));
            }
            if (filter.CIDADE.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.CIDADE.Contains(x.CIDADE));
            }
            if (filter.MICROREGIÃO.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.MICROREGIÃO.Contains(x.MICRORREGIÃO));
            }
            if (filter.CEP.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.CEP.Contains(x.CEP));
            }
            if (filter.BAIRRO.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.BAIRRO.Contains(x.BAIRRO));
            }
            if (filter.LOGRADOURO.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.LOGRADOURO.Contains(x.LOGRADOURO));
            }
            if (filter.NUMERO.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.NUMERO.Contains(x.NÚMERO));
            }
            if (filter.CAIXA.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.CAIXA.Contains(x.CAIXA));
            }
            if (filter.TIPO_RESIDENCIA.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.TIPO_RESIDENCIA.Contains(x.TIPO_RESIDENCIA));
            }
            if (filter.OCUPAÇÃO.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.OCUPAÇÃO.Contains(x.OCUPAÇÃO));
            }

            double Pcr_ocp = 0;
            double Pcr_disp = 0;
            int qtd_casas = 0;
            int qtd_predio = 0;
            int media_fttc = 0;
            int total_BADDEBT = 0;
            int total_FRAUDE = 0;

            var capacidade = 0;
            var usados = 0;
            var disponivel = 0;

            if (filter.GetDash)
            {
                capacidade = await GetSomaAVGCOLUMN(filter, "CAPACIDADE");
                usados = await GetSomaAVGCOLUMN(filter, "USADOS");
                disponivel = await GetSomaAVGCOLUMN(filter, "DISPONÍVEL");

                Pcr_ocp = ((double)usados / (double)capacidade) * 100;
                Pcr_disp = ((double)disponivel / (double)capacidade) * 100;

                qtd_casas = pagedData.Where(y => y.TIPO_RESIDENCIA.Equals("CASA")).Select(x => x.CEP_NUM).Distinct().Count();
                qtd_predio = pagedData.Where(y => y.TIPO_RESIDENCIA.Equals("PRÉDIO")).Select(x => x.CEP_NUM).Distinct().Count();

                media_fttc = await GetMediaFTTC(filter);

                total_BADDEBT = pagedData.Where(y => !string.IsNullOrEmpty(y.BADDEBT)).Select(x => x.CEP_NUM).Distinct().Count();
                total_FRAUDE = pagedData.Where(y => !string.IsNullOrEmpty(y.FRAUDE)).Select(x => x.CEP_NUM).Distinct().Count();
            }

            var Data = pagedData.OrderBy(x => x.ID)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToList();

            var totalRecords = pagedData.Count();
            var totalPages = ((double)totalRecords / (double)filter.PageSize);

            return JsonConvert.SerializeObject(
                PagedResponse.CreatePagedReponse<FIXA_VIEW_PAINEL_DE_ROTA>(
                    Data, filter, totalRecords, Math.Round(Pcr_ocp, 2), Math.Round(Pcr_disp, 2),
                    qtd_casas, qtd_predio, media_fttc,
                    total_BADDEBT, total_FRAUDE)
                );
        }

        private DataTable ExecutarCommandRetornaDataTable(string comando)
        {
            DataTable dt = new DataTable();

            using (OracleConnection conn = new OracleConnection("Data Source=10.240.44.198:1521/VICPR;User Id=VPV_RGNL_NE;Password=NE_IC_2022"))
            {
                conn.Open();

                using (OracleDataAdapter adap = new OracleDataAdapter(comando, conn)
                {
                    SuppressGetDecimalInvalidCastException = true
                })
                {
                    adap.Fill(dt);
                }

                conn.Close();
            }
            return dt;
        }

        private async Task<int> GetSomaAVGCOLUMN(PaginationPainelRotaModel filter, string column)
        {
            try
            {
                int resultado = 0;

                string selectTopics = @"SELECT SUM(MEDIA_DISPONIVEL) AS SOMA_MEDIAS
                        FROM (
                            SELECT AVG(CAST(" + column + @" AS INT)) AS MEDIA_DISPONIVEL
                            FROM FIXA_VIEW_PAINEL_DE_ROTAS";

                if (filter.Território.Count() > 0 ||
                    filter.UF.Count() > 0 ||
                    filter.DDD.Count() > 0 ||
                    filter.CIDADE.Count() > 0 ||
                    filter.MICROREGIÃO.Count() > 0 ||
                    filter.CEP.Count() > 0 ||
                    filter.BAIRRO.Count() > 0 ||
                    filter.LOGRADOURO.Count() > 0 ||
                    filter.NUMERO.Count() > 0 ||
                    filter.CAIXA.Count() > 0 ||
                    filter.TIPO_RESIDENCIA.Count() > 0 ||
                    filter.OCUPAÇÃO.Count() > 0)
                {
                    selectTopics = string.Concat(selectTopics, " WHERE ");
                    if (filter.Território.Count() > 0)
                    {
                        selectTopics += $" AND Território IN (";
                        foreach (var item in filter.Território)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.UF.Count() > 0)
                    {
                        selectTopics += $" AND UF IN (";
                        foreach (var item in filter.UF)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.DDD.Count() > 0)
                    {
                        selectTopics += $" AND DDD IN (";
                        foreach (var item in filter.DDD)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.CIDADE.Count() > 0)
                    {
                        selectTopics += $" AND CIDADE IN (";
                        foreach (var item in filter.CIDADE)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.MICROREGIÃO.Count() > 0)
                    {
                        selectTopics += $" AND MICRORREGIÃO IN (";
                        foreach (var item in filter.MICROREGIÃO)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.CEP.Count() > 0)
                    {
                        selectTopics += $" AND CEP IN (";
                        foreach (var item in filter.CEP)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.BAIRRO.Count() > 0)
                    {
                        selectTopics += $" AND BAIRRO IN (";
                        foreach (var item in filter.BAIRRO)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.LOGRADOURO.Count() > 0)
                    {
                        selectTopics += $" AND LOGRADOURO IN (";
                        foreach (var item in filter.LOGRADOURO)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.NUMERO.Count() > 0)
                    {
                        selectTopics += $" AND NÚMERO IN (";
                        foreach (var item in filter.NUMERO)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.CAIXA.Count() > 0)
                    {
                        selectTopics += $" AND CAIXA IN (";
                        foreach (var item in filter.CAIXA)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.TIPO_RESIDENCIA.Count() > 0)
                    {
                        selectTopics += $" AND TIPO_RESIDENCIA IN (";
                        foreach (var item in filter.TIPO_RESIDENCIA)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }
                    if (filter.OCUPAÇÃO.Count() > 0)
                    {
                        selectTopics += $" AND OCUPAÇÃO IN (";
                        foreach (var item in filter.OCUPAÇÃO)
                        {
                            selectTopics += $"'{item}',";
                        }
                        selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                    }

                }

                selectTopics += @" GROUP BY CEP_NUM) AS medias_por_cep";

                string stringtoremove = " AND ";
                int index = selectTopics.IndexOf(stringtoremove);

                // If the string to remove is found, remove it from the original string
                if (index != -1)
                {
                    selectTopics = selectTopics.Remove(index, stringtoremove.Length);
                }
                else
                {
                    Console.WriteLine("String not found");
                }

                // Define the ADO.NET Objects
                using (SqlConnection con = new SqlConnection(CD.Database.GetConnectionString()))
                {
                    var dataTable = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = selectTopics;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow item in dataTable.Rows)
                        {
                            resultado = int.Parse(item[0].ToString());
                        }
                    }
                    con.Close();
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async Task<int> GetMediaFTTC(PaginationPainelRotaModel filter)
        {
            try
            {
                int resultado = 0;
                string selectTopics = @"SELECT SUM(MEDIA_DISPONIVEL) AS SOMA_MEDIAS
                        FROM(
                            SELECT AVG(CAST(CLIENTE_FTTC AS INT)) AS MEDIA_DISPONIVEL
                            FROM FIXA_VIEW_PAINEL_DE_ROTAS 
                            where CLIENTE_FTTC NOT IN(
                            'PRÉDIO',
                            'CASA',
                            '2019_VENDE-INSTALA (DISPONÍVEL)') ";
                if (filter.Território.Count() > 0)
                {
                    selectTopics += $" AND Território IN (";
                    foreach (var item in filter.Território)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.UF.Count() > 0)
                {
                    selectTopics += $" AND UF IN (";
                    foreach (var item in filter.UF)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.DDD.Count() > 0)
                {
                    selectTopics += $" AND DDD IN (";
                    foreach (var item in filter.DDD)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.CIDADE.Count() > 0)
                {
                    selectTopics += $" AND CIDADE IN (";
                    foreach (var item in filter.CIDADE)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.MICROREGIÃO.Count() > 0)
                {
                    selectTopics += $" AND MICRORREGIÃO IN (";
                    foreach (var item in filter.MICROREGIÃO)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.CEP.Count() > 0)
                {
                    selectTopics += $" AND CEP IN (";
                    foreach (var item in filter.CEP)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.BAIRRO.Count() > 0)
                {
                    selectTopics += $" AND BAIRRO IN (";
                    foreach (var item in filter.BAIRRO)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.LOGRADOURO.Count() > 0)
                {
                    selectTopics += $" AND LOGRADOURO IN (";
                    foreach (var item in filter.LOGRADOURO)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.NUMERO.Count() > 0)
                {
                    selectTopics += $" AND NÚMERO IN (";
                    foreach (var item in filter.NUMERO)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.CAIXA.Count() > 0)
                {
                    selectTopics += $" AND CAIXA IN (";
                    foreach (var item in filter.CAIXA)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.TIPO_RESIDENCIA.Count() > 0)
                {
                    selectTopics += $" AND TIPO_RESIDENCIA IN (";
                    foreach (var item in filter.TIPO_RESIDENCIA)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }
                if (filter.OCUPAÇÃO.Count() > 0)
                {
                    selectTopics += $" AND OCUPAÇÃO IN (";
                    foreach (var item in filter.OCUPAÇÃO)
                    {
                        selectTopics += $"'{item}',";
                    }
                    selectTopics = selectTopics.Remove(selectTopics.Length - 1) + ") ";
                }

                selectTopics += @" GROUP BY CEP_NUM) AS medias";

                // Define the ADO.NET Objects
                using (SqlConnection con = new SqlConnection(CD.Database.GetConnectionString()))
                {
                    var dataTable = new DataTable();
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = selectTopics;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow item in dataTable.Rows)
                        {
                            resultado = int.Parse(item[0].ToString());
                        }
                    }

                    con.Close();
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("Update_Fixa_View")]
        public async Task<string> Update_Fixa_View()
        {
            try
            {
                string sql = "select * FROM FIXA_BASE_PRUMA";
                var dataTable = new DataTable();
                // Define the ADO.NET Objects
                List<FIXA_BASE_PRUMA> lista = new List<FIXA_BASE_PRUMA>();
                dataTable = ExecutarCommandRetornaDataTable(sql);

                var ListaParaBorrar = CD.FIXA_BASE_PRUMAs.ToList();
                CD.FIXA_BASE_PRUMAs.RemoveRange(ListaParaBorrar);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow item in dataTable.Rows)
                    {
                        var COD_PREDIO = int.Parse(item[0].ToString());
                        var NOM_PREDIO = item[1].ToString();
                        var COD_CONDOMINIO = int.Parse(item[2].ToString());
                        var NOM_CONDOMINIO = item[3].ToString();
                        var DAT_INSERCAO = item[4].ToString();
                        var NOM_CONTVIST = item[5].ToString();
                        var NOM_CONTOBRAEXT = item[6].ToString();
                        var SEGMENTO = item[7].ToString();
                        var TIPO = item[8].ToString();
                        var LOGRADOURO = item[9].ToString();
                        var NUMERO = int.Parse(item[10].ToString());
                        var CIDADE = item[11].ToString();
                        var ESTEIRA = item[12].ToString();
                        var MOTIVO = item[13].ToString();
                        var DAT_LIB_COMERCIAL = item[14].ToString();
                        var CUSTO_OBRA_EXT = string.IsNullOrEmpty(item[15].ToString()) ? 0 : int.Parse(item[15].ToString());
                        var BLOCOS = string.IsNullOrEmpty(item[16].ToString()) ? 0 : int.Parse(item[16].ToString());
                        var QTD_APARTAMENTO = string.IsNullOrEmpty(item[17].ToString()) ? 0 : int.Parse(item[17].ToString());
                        var PROSPECTOR = item[18].ToString();
                        var CEP = string.IsNullOrEmpty(item[19].ToString()) ? 0 : int.Parse(item[19].ToString());
                        var DATA_ESTEIRA = item[20].ToString();
                        var OBRA_RUA_ESPECIAL = string.IsNullOrEmpty(item[21].ToString()) ? 0 : int.Parse(item[21].ToString());
                        var OBRA_PREDIO_ESPECIAL = string.IsNullOrEmpty(item[22].ToString()) ? 0 : int.Parse(item[22].ToString());
                        var VAL_QTDVISTAG = string.IsNullOrEmpty(item[23].ToString()) ? 0 : int.Parse(item[23].ToString());
                        var PRIORIDADE = item[24].ToString();
                        var REDE = item[25].ToString();
                        var ARMARIO = item[26].ToString();
                        var STATUS = item[27].ToString();
                        var CAIXA = item[28].ToString();
                        var UF = item[29].ToString();
                        var BAIRRO = item[30].ToString();
                        var REGIONAL = item[31].ToString();
                        var COMPLEMENTO = item[32].ToString();
                        var CASAS_CONSTRUIDAS = string.IsNullOrEmpty(item[33].ToString()) ? 0 : int.Parse(item[33].ToString());
                        var ARMARIO_COBRE = item[34].ToString();
                        var CONCORRENCIA = item[35].ToString();
                        var CLASSE = item[36].ToString();
                        var CEP_NUM = item[37].ToString();

                        lista.Add(new FIXA_BASE_PRUMA

                        {
                            COD_PREDIO = COD_PREDIO,
                            NOM_PREDIO = NOM_PREDIO,
                            COD_CONDOMINIO = COD_CONDOMINIO,
                            NOM_CONDOMINIO = NOM_CONDOMINIO,
                            DAT_INSERCAO = DAT_INSERCAO,
                            NOM_CONTVIST = NOM_CONTVIST,
                            NOM_CONTOBRAEXT = NOM_CONTOBRAEXT,
                            SEGMENTO = SEGMENTO,
                            TIPO = TIPO,
                            LOGRADOURO = LOGRADOURO,
                            NUMERO = NUMERO,
                            CIDADE = CIDADE,
                            ESTEIRA = ESTEIRA,
                            MOTIVO = MOTIVO,
                            DAT_LIB_COMERCIAL = DAT_LIB_COMERCIAL,
                            CUSTO_OBRA_EXT = CUSTO_OBRA_EXT,
                            BLOCOS = BLOCOS,
                            QTD_APARTAMENTO = QTD_APARTAMENTO,
                            PROSPECTOR = PROSPECTOR,
                            CEP = CEP,
                            DATA_ESTEIRA = DATA_ESTEIRA,
                            OBRA_RUA_ESPECIAL = OBRA_RUA_ESPECIAL,
                            OBRA_PREDIO_ESPECIAL = OBRA_PREDIO_ESPECIAL,
                            VAL_QTDVISTAG = VAL_QTDVISTAG,
                            PRIORIDADE = PRIORIDADE,
                            REDE = REDE,
                            ARMARIO = ARMARIO,
                            STATUS = STATUS,
                            CAIXA = CAIXA,
                            UF = UF,
                            BAIRRO = BAIRRO,
                            REGIONAL = REGIONAL,
                            COMPLEMENTO = COMPLEMENTO,
                            CASAS_CONSTRUIDAS = CASAS_CONSTRUIDAS,
                            ARMARIO_COBRE = ARMARIO_COBRE,
                            CONCORRENCIA = CONCORRENCIA,
                            CLASSE = CLASSE,
                            CEP_NUM = CEP_NUM,
                        });
                    }
                }

                CD.FIXA_BASE_PRUMAs.AddRange(lista);
                await CD.SaveChangesAsync();

                return "Tudo certo!";
            }
            catch (Exception ex)
            {
                return $"500 --> {ex.Message} ------- {ex}";
            }
        }
    }
}
