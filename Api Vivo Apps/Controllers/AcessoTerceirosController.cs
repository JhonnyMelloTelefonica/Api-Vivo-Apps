using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.Office.Interop.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Models;
using Vivo_Apps_API.Hubs;
using Path = System.IO.Path;
using System.Data;
using Range = Microsoft.Office.Interop.Excel.Range;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using Microsoft.AspNetCore.StaticFiles;
using Shared_Static_Class.Model_DTO;
using Newtonsoft.Json;
using Vivo_Apps_API.Models;
using Converters = Vivo_Apps_API.Models.Converters.Converters;
using Microsoft.AspNetCore.SignalR;
using AutoMapper.QueryableExtensions;
using static Shared_Static_Class.Data.DEMANDA_RELACAO_CHAMADO;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.OutputCaching;
using DataTable = System.Data.DataTable;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml;
using Shared_Static_Class.Model_Demanda_Context;
using DocumentFormat.OpenXml.Office2010.Excel;


namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcessoTerceirosController : ControllerBase
    {
        private readonly ILogger<AcessoTerceirosController> _logger;
        private readonly IOutputCacheStore _cache;
        private readonly ISuporteDemandaHub _hubContext;
        private readonly string _sharedFilesPath = @"..\Shared_Razor_Components\wwwroot\";
        private readonly IMapper _mapper;

        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext DB;
        private Vivo_MaisContext CD;

        public AcessoTerceirosController(ILogger<AcessoTerceirosController> logger,
            IOutputCacheStore cache, IDbContextFactory<DemandasContext> dbContextFactory,
            ISuporteDemandaHub hubContext, Vivo_MaisContext cD)
        {
            CD = cD;
            _logger = logger;
            _cache = cache;
            _logger = logger;
            _hubContext = hubContext;
            DbFactory = dbContextFactory;
            DB = DbFactory.CreateDbContext();
            CD = cD;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DEMANDA_RELACAO_CHAMADO, DEMANDA_DTO>();

                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_DTO>()
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => (Cargos)src.CARGO)
                    )
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => (Canal)src.CANAL)
                    )
                .ForMember(
                    dest => dest.DemandasResponsavel,
                    opt => opt.MapFrom(src => src.DemandasResponsavel.AsEnumerable())
                    );

                cfg.CreateMap<DEMANDA_CHAMADO_RESPOSTA, DEMANDA_CHAMADO_RESPOSTA_DTO>();
                cfg.CreateMap<DEMANDA_ARQUIVOS_RESPOSTA, DEMANDA_ARQUIVOS_RESPOSTA_DTO>();
                cfg.CreateMap<DEMANDA_STATUS_CHAMADO, DEMANDA_STATUS_CHAMADO_DTO>();
                cfg.CreateMap<DEMANDA_ACESSOS, ACESSO_TERCEIROS_DTO>()
                .ForMember(
                    dest => dest.Respostas,
                    opt => opt.MapFrom(src => src.Relacao.Respostas)
                    );

            });
            _mapper = config.CreateMapper();
        }

        [HttpPost("InformarMatricula")]
        public async Task<IActionResult> InformarMatricula(Guid id, int newmatricula, int matricula_resp, string mensagem)
        {
            try
            {
                //body.Solicitante = DB.ACESSOS_MOBILE.First(x => x.MATRICULA == body.MATRICULA_SOLICITANTE);
                await ExecuteChangeMatriculaTerceiro(id, newmatricula, matricula_resp, mensagem, out DEMANDA_ACESSOS? demanda);

                await _hubContext.SendTableDemandas(demanda.MATRICULA_RESPONSAVEL);

                await _cache.EvictByTagAsync("AllDemandas", default);
                var demanda_acesso = DB.DEMANDA_ACESSOS
                   .Include(x => x.Responsavel)
                   .Include(x => x.Solicitante)
                   .Include(x => x.Relacao)
                       .ThenInclude(x => x.Respostas)
                           .ThenInclude(x => x.Responsavel)
                               .ThenInclude(x => x.ResponsavelDemandasTotais)
                   .Include(x => x.Relacao)
                       .ThenInclude(x => x.Respostas)
                           .ThenInclude(x => x.Status)
                   .IgnoreAutoIncludes()
                   .ProjectTo<ACESSO_TERCEIROS_DTO>(_mapper.ConfigurationProvider)
                   .First(x => x.ID == demanda.ID);

                return new JsonResult(new Response<ACESSO_TERCEIROS_DTO>
                {
                    Data = demanda_acesso,
                    Succeeded = true,
                    Message = $"Matrícula do usuário alterada com sucesso, enviamos um e-mail informando o solicitante da alteração",
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Algum erro ocorreu ao tentar criar um novo elemento");
                return StatusCode(500, new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }

        [HttpPost("InformarMatriculaMassivo")]
        public async Task<IActionResult> InformarMatriculaMassivo(IEnumerable<Tuple<Guid, int>> id, int matricula_resp, string mensagem)
        {
            try
            {
                //body.Solicitante = DB.ACESSOS_MOBILE.First(x => x.MATRICULA == body.MATRICULA_SOLICITANTE);]
                foreach (Tuple<Guid, int> singleid in id)
                {
                    await ExecuteChangeMatriculaTerceiro(singleid.Item1, singleid.Item2, matricula_resp, mensagem, out DEMANDA_ACESSOS? demanda);
                }

                await _cache.EvictByTagAsync("AllDemandas", default);
                await _hubContext.SendTableDemandas();

                return new JsonResult(new Response<string>
                {
                    Data = "A matrícula foi atualizada para todas as demandas",
                    Succeeded = true,
                    Message = $"Matrícula de todos os usuários foi alterada com sucesso, enviamos um e-mail informando o solicitante da alteração para cada uma das demandas",
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Algum erro ocorreu ao tentar criar um novo elemento");
                return StatusCode(500, new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] DEMANDA_ACESSOS body, string MENSAGEM)
        {
            try
            {
                //body.Solicitante = DB.ACESSOS_MOBILE.First(x => x.MATRICULA == body.MATRICULA_SOLICITANTE);

                var demanda = new DEMANDA_RELACAO_CHAMADO
                {
                    Sequence = DB.DEMANDA_RELACAO_CHAMADO.Count() + 1,
                    Tabela = DEMANDA_RELACAO_CHAMADO.Tabela_Demanda.AcessoRelacao,
                    MATRICULA_SOLICITANTE = body.MATRICULA_SOLICITANTE,
                    DATA_ABERTURA = DateTime.Now,
                    PRIORIDADE = false,
                    PRIORIDADE_SEGMENTO = false,
                    AcessoRelacao = body,
                    ID_CHAMADO = body.ID
                };

                DB.DEMANDA_RELACAO_CHAMADO.Add(demanda);
                await DB.SaveChangesAsync();

                demanda.ID_CHAMADO = demanda.AcessoRelacao.ID;

                demanda.Respostas.Add(new DEMANDA_CHAMADO_RESPOSTA
                {
                    ID_RELACAO = demanda.ID_RELACAO,
                    ID_CHAMADO = demanda.ID_CHAMADO,
                    RESPOSTA = MENSAGEM,
                    MATRICULA_RESPONSAVEL = body.MATRICULA_SOLICITANTE,
                    DATA_RESPOSTA = DateTime.Now,
                    ARQUIVOS = null
                });
                await DB.SaveChangesAsync();

                demanda.Status.Add(new DEMANDA_STATUS_CHAMADO
                {
                    ID_CHAMADO = demanda.ID_CHAMADO,
                    STATUS = "ABERTO",
                    ID_RESPOSTA = demanda.Respostas.First().ID,
                    DATA = DateTime.Now
                });

                await DB.SaveChangesAsync();
                //await _hubContext.SendTableDemandas();
                await _cache.EvictByTagAsync("AllDemandas", default);

                await _hubContext.SendTableDemandas();

                return Ok(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = true,
                    Message = $"Solicitação de acessos criada, N° {demanda.Sequence}",
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Algum erro ocorreu ao tentar criar um novo elemento");
                return StatusCode(500, new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }

        [HttpPost("ExtractAcesso")]
        public async Task<IActionResult> ExtractAcesso([FromBody] Guid[] ids, int matricula, string regional)
        {
            var itens = DB.DEMANDA_ACESSOS.Where(x => ids.Contains(x.ID_RELACAO));

            string folderPath = "";
            string outputPath = "";
            try
            {
                foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
                {
                    process.Kill();
                }
                folderPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "FilesTemplates");

                if (System.IO.File.Exists(Path.Combine(folderPath, @"SolicitacaoAcessosExterno.xlsx")))
                {
                    System.IO.File.Delete(Path.Combine(folderPath, @"SolicitacaoAcessosExterno.xlsx"));
                }

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook livro = (Microsoft.Office.Interop.Excel.Workbook)(xlApp.Workbooks.Add(Path.Combine(folderPath, @"Layout-Externo-Novo.xlsx")));
                Worksheet xlWorkSheet = (Worksheet)livro.Worksheets.get_Item(2);
                Range r = xlWorkSheet.Cells;
                r.NumberFormat = "@";
                int i = 4;


                foreach (DEMANDA_ACESSOS item in itens)
                {
                    var carteira = CD.Carteira_NEs.Where(x => x.Vendedor == item.Adabas);
                    var extrator = CD.ACESSOS_MOBILEs.First(x => x.MATRICULA == matricula);

                    xlWorkSheet.Cells[i, 1] = item.Nome.ToUpper();     //1 Nome
                    xlWorkSheet.Cells[i, 4] = "T4 Dealers";                             //2 
                    xlWorkSheet.Cells[i, 8] = "-";                                      //3
                    xlWorkSheet.Cells[i, 11] = "0 Solt";                                //4
                    xlWorkSheet.Cells[i, 15] = "BR Brasileiro";                         //5
                    xlWorkSheet.Cells[i, 26] = "NÃO INFORMADO";                         //6
                    xlWorkSheet.Cells[i, 27] = "NÃO INFORMADO";                         //7
                    xlWorkSheet.Cells[i, 29] = "NÃO INFORMADO";                         //8
                    xlWorkSheet.Cells[i, 30] = "NÃO INFORMADO";                         //9
                    xlWorkSheet.Cells[i, 33] = "-";                                     //10
                    xlWorkSheet.Cells[i, 34] = "-";                                     //11
                    xlWorkSheet.Cells[i, 35] = "-";                                     //12
                    xlWorkSheet.Cells[i, 36] = "-";                                     //13
                    xlWorkSheet.Cells[i, 37] = "-";                                     //14
                    xlWorkSheet.Cells[i, 41] = "TOD";                                   //15
                    xlWorkSheet.Cells[i, 40] = "10000911";                              //16
                    if (regional.Equals("N"))
                    {
                        var cnpjDt = CD.APROVADORES_s.Where(x => x.CNPJ == item.Cnpj).Select(x => new { OP = x.Unidade_Gestor_Operacional, Cont = x.Unidade_Gestor_Contrato });
                        if (cnpjDt.Any())
                        {
                            foreach (var linha in cnpjDt)
                            {
                                xlWorkSheet.Cells[i, 25] = linha.OP;
                                xlWorkSheet.Cells[i, 26] = linha.Cont;
                            }
                        }
                    }
                    else
                    {
                        xlWorkSheet.Cells[i, 25] = "10017038";
                        xlWorkSheet.Cells[i, 26] = "10017038";
                    }
                    xlWorkSheet.Cells[i, 27] = matricula.ToString();

                    xlWorkSheet.Cells[i, 29] = item.DataContratoInicio;
                    xlWorkSheet.Cells[i, 30] = item.DataContratoFim;

                    xlWorkSheet.Cells[i, 31] = "A Ativo";
                    xlWorkSheet.Cells[i, 32] = "";
                    xlWorkSheet.Cells[i, 33] = "80000064    SERVIÇOS - VENDAS";
                    xlWorkSheet.Cells[i, 34] = "TBRA";
                    xlWorkSheet.Cells[i, 35] = item.Estado.Value.GetDisplayName(true, "T-");
                    xlWorkSheet.Cells[i, 36] = item.Cidade.ToUpper();
                    xlWorkSheet.Cells[i, 37] = item.Estado.Value.GetDisplayName();
                    xlWorkSheet.Cells[i, 38] = "";
                    //↓ COLUNA NÚMERO DE TELEFONE ↓
                    xlWorkSheet.Cells[i, 16] = item.Telefone;     // COLUNA   AM
                    xlWorkSheet.Cells[i, 49] = item.Celular.Replace("+", "");   // COLUNA AL
                                                                                //↑ COLUNA E-MAIL ↑
                    xlWorkSheet.Cells[i, 39] = "";      // COLUNA AL
                    xlWorkSheet.Cells[i, 40] = "";     // COLUNA   AM
                    xlWorkSheet.Cells[i, 41] = "1 Sim";
                    xlWorkSheet.Cells[i, 42] = "2 Não";
                    xlWorkSheet.Cells[i, 43] = "";    // COLUNA   AP
                    xlWorkSheet.Cells[i, 44] = "-";
                    xlWorkSheet.Cells[i, 45] = "3 Trabalha em Campo";
                    xlWorkSheet.Cells[i, 46] = "";
                    xlWorkSheet.Cells[i, 47] = "1 Sim";
                    xlWorkSheet.Cells[i, 48] = "2 Não";

                    if (item.Acao == Acao.INCLUSÃO)
                    {
                        xlWorkSheet.Cells[i, 2] = "1 Inclusão";
                        xlWorkSheet.Cells[i, 3] = "-";
                    }

                    if (item.Acao == Acao.ALTERAÇÃO || item.Acao == Acao.INATIVAÇÃO || item.Acao == Acao.REATIVAÇÃO)
                    {
                        xlWorkSheet.Cells[i, 2] = item.Acao.GetDisplayName();
                        if (regional.Equals("NE"))
                        {
                            xlWorkSheet.Cells[i, 3] = item.Matricula; // MATRICULA
                        }
                        else
                        {

                            xlWorkSheet.Cells[i, 3] = "T4 DEALERS";
                        }
                    }
                    else
                    {
                        xlWorkSheet.Cells[i, 2] = item.Acao.GetDisplayName();
                        xlWorkSheet.Cells[i, 3] = "T4 DEALERS";
                    }

                    xlWorkSheet.Cells[i, 5] = item.Nome;
                    xlWorkSheet.Cells[i, 6] = preencherValor(item.Sobrenome);
                    xlWorkSheet.Cells[i, 7] = item.Sexo.Value.GetDisplayName();

                    //string CPFFinal = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                    xlWorkSheet.Cells[i, 9] = item.Cpf;

                    // Ver se precisa da formatação do PIS aqui
                    xlWorkSheet.Cells[i, 10] = preencherValor(item.PIS);

                    xlWorkSheet.Cells[i, 12] = preencherValor(item.Rg);

                    //Orgao Emissor
                    xlWorkSheet.Cells[i, 13] = item.OrgaoEmissor.ToUpper();

                    xlWorkSheet.Cells[i, 14] = item.DataNascimento;

                    xlWorkSheet.Cells[i, 18] = "2 Ens Méd/Profissional";
                    xlWorkSheet.Cells[i, 19] = "1 Completo";
                    xlWorkSheet.Cells[i, 20] = "-";
                    xlWorkSheet.Cells[i, 21] = "-";
                    xlWorkSheet.Cells[i, 22] = "-";


                    xlWorkSheet.Cells[i, 23] = preencherValor(item.Cnpj);


                    if (regional == "NE")
                    {
                        if (item.SubGrupo == "ALTERNATIVOS PF")
                        {
                            xlWorkSheet.Cells[i, 24] = "4 Governo";
                        }
                        else
                        {
                            xlWorkSheet.Cells[i, 24] = preencherValor(item.SubGrupo.ToUpper());
                        }
                    }
                    else
                    {
                        xlWorkSheet.Cells[i, 24] = preencherValor(item.SubGrupo.ToUpper());
                    }

                    if (regional.Equals("N"))
                    {
                        xlWorkSheet.Cells[i, 39] = "";
                        xlWorkSheet.Cells[i, 40] = "";
                        xlWorkSheet.Cells[i, 43] = "";
                    }
                    i++;
                }
                object misValue = System.Reflection.Missing.Value;
                outputPath = @$"SolicitacaoAcessosExterno_{itens.Count()}_{DateTime.Now.ToShortDateString().Replace('/', '-')}.xlsx";
                livro.SaveAs(Path.Combine(folderPath, outputPath), XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                livro.Close(true, misValue, misValue);
                xlApp.Quit();
                itens.ExecuteUpdate(x => x.SetProperty(y => y.DataExtracao, y => DateTime.Now));
                await DB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            var provider = new FileExtensionContentTypeProvider();

            if (!provider.TryGetContentType(Path.Combine(folderPath, outputPath), out var contentType))
            {
                contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            }
            var bytes = await System.IO.File.ReadAllBytesAsync(Path.Combine(folderPath, outputPath));

            System.IO.File.Delete(Path.Combine(folderPath, outputPath));

            return new JsonResult(new Response<FileContentResult>
            {
                Data = File(bytes, contentType, Path.Combine(folderPath, outputPath)),
                Succeeded = true,
                Message = "Extração concluída, aguarde o download."
            });
        }

        [HttpPost("ExtractInclusaoAcessos")]
        public async Task<IActionResult> GetUsuariosExcel([FromBody] IEnumerable<Guid> ids)
        {
            try
            {
                var acessos = DB.DEMANDA_RELACAO_CHAMADO
                    .Include(x => x.AcessoRelacao)
                    .Where(x => ids.Contains(x.ID_RELACAO));

                string folderPath = string.Empty;
                string outputPath = string.Empty;

                foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
                {
                    process.Kill();
                }

                folderPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "FilesTemplates");

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook livro = (Microsoft.Office.Interop.Excel.Workbook)(xlApp.Workbooks.Add(Path.Combine(folderPath, @"Extract_Matricula_Model.xlsx")));
                Worksheet xlWorkSheet = (Worksheet)livro.Worksheets.get_Item(1);
                Range r = xlWorkSheet.Cells;
                r.NumberFormat = "@";
                int i = 2; //Row
                foreach (DEMANDA_RELACAO_CHAMADO item in acessos)
                {
                    var carteira = CD.Carteira_NEs.Where(x => x.Vendedor == item.AcessoRelacao.Adabas);
                    //var extrator = CD.ACESSOS_MOBILEs.First(x => x.MATRICULA == item.AcessoRelacao.Matricula);
                    //(item.AcessoRelacao?.Acao == Acao.INCLUSÃO ? "@0V@" : "@0W@")
                    Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[i, 1];
                    float Left = (float)((double)oRange.Left);
                    float Top = (float)((double)oRange.Top);
                    xlWorkSheet.Shapes.AddPicture(Path.Combine(folderPath, item.AcessoRelacao?.Acao == Acao.INCLUSÃO ? "Imagem1.gif" : "Imagem2.gif"), Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 8, 8);

                    xlWorkSheet.Cells[i, 2] = $"Foi criado o Terceiro : {item.AcessoRelacao?.Matricula}";
                    xlWorkSheet.Cells[i, 3] = (int)Acao.INCLUSÃO;
                    xlWorkSheet.Cells[i, 4] = string.IsNullOrEmpty(item.AcessoRelacao?.Matricula) ? item.AcessoRelacao?.Matricula : string.Empty;
                    xlWorkSheet.Cells[i, 5] = "T4";
                    xlWorkSheet.Cells[i, 6] = item.AcessoRelacao.Nome.Split()[0];
                    xlWorkSheet.Cells[i, 7] = item.AcessoRelacao.Nome.Split().Count() > 1 ? item.AcessoRelacao.Nome.Split().Skip(1) : string.Empty;
                    xlWorkSheet.Cells[i, 8] = (int)item.AcessoRelacao.Sexo;
                    xlWorkSheet.Cells[i, 9] = string.Empty;
                    xlWorkSheet.Cells[i, 10] = item.AcessoRelacao.Cpf;
                    xlWorkSheet.Cells[i, 11] = item.AcessoRelacao.Cnpj;
                    xlWorkSheet.Cells[i, 12] = 0;
                    xlWorkSheet.Cells[i, 13] = item.AcessoRelacao.Rg;
                    xlWorkSheet.Cells[i, 14] = item.AcessoRelacao.OrgaoEmissor;
                    xlWorkSheet.Cells[i, 15] = item.AcessoRelacao.DataNascimento.Value.ToShortDateString();
                    xlWorkSheet.Cells[i, 16] = "BR";
                    xlWorkSheet.Cells[i, 17] = item.AcessoRelacao.Telefone;
                    xlWorkSheet.Cells[i, 18] = item.AcessoRelacao.Email;
                    xlWorkSheet.Cells[i, 19] = 2;
                    xlWorkSheet.Cells[i, 20] = 1;
                    xlWorkSheet.Cells[i, 21] = string.Empty;
                    xlWorkSheet.Cells[i, 22] = 0;
                    xlWorkSheet.Cells[i, 23] = string.Empty;
                    xlWorkSheet.Cells[i, 24] = item.AcessoRelacao.Cnpj;
                    xlWorkSheet.Cells[i, 25] = item.AcessoRelacao.SubGrupo;
                    xlWorkSheet.Cells[i, 26] = "10017038";
                    xlWorkSheet.Cells[i, 27] = "10017038";
                    xlWorkSheet.Cells[i, 28] = "163794";
                    xlWorkSheet.Cells[i, 29] = 0;
                    xlWorkSheet.Cells[i, 30] = 0;
                    xlWorkSheet.Cells[i, 31] = item.AcessoRelacao.DataContratoInicio != null ? item.AcessoRelacao.DataContratoInicio.Value.ToShortDateString() : string.Empty;
                    //xlWorkSheet.Cells[$"AE{i}"] = item.AcessoRelacao.DataContratoFim != null ? item.AcessoRelacao.DataContratoFim.Value.ToShortDateString() : string.Empty;
                    xlWorkSheet.Cells[i, 32] = "A";
                    xlWorkSheet.Cells[i, 33] = "-";
                    xlWorkSheet.Cells[i, 34] = "-";
                    xlWorkSheet.Cells[i, 35] = "TBRA";
                    xlWorkSheet.Cells[i, 36] = item.AcessoRelacao.Estado.Value.GetDisplayName(true, "T-");
                    xlWorkSheet.Cells[i, 37] = item.AcessoRelacao.SubGrupo;
                    xlWorkSheet.Cells[i, 38] = item.AcessoRelacao.Cidade;
                    xlWorkSheet.Cells[i, 39] = item.AcessoRelacao.Estado.Value.GetDisplayName();
                    xlWorkSheet.Cells[i, 40] = 0;
                    xlWorkSheet.Cells[i, 41] = string.Empty;
                    xlWorkSheet.Cells[i, 42] = 1;
                    xlWorkSheet.Cells[i, 43] = 2;
                    xlWorkSheet.Cells[i, 44] = string.Empty;
                    xlWorkSheet.Cells[i, 45] = string.Empty;
                    xlWorkSheet.Cells[i, 46] = 3;
                    xlWorkSheet.Cells[i, 47] = string.Empty;
                    xlWorkSheet.Cells[i, 48] = 1;
                    xlWorkSheet.Cells[i, 49] = 2;
                    i++;
                }

                object misValue = System.Reflection.Missing.Value;
                outputPath = @$"SolicitacaoAcessosExterno_{acessos.Count()}_{DateTime.Now.ToShortDateString().Replace('/', '-')}.xlsx";
                livro.SaveAs(Path.Combine(folderPath, outputPath), XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                livro.Close(true, misValue, misValue);
                xlApp.Quit();

                var provider = new FileExtensionContentTypeProvider();

                if (!provider.TryGetContentType(Path.Combine(folderPath, outputPath), out var contentType))
                {
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                }
                var bytes = await System.IO.File.ReadAllBytesAsync(Path.Combine(folderPath, outputPath));

                System.IO.File.Delete(Path.Combine(folderPath, outputPath));

                return new JsonResult(new Response<FileContentResult>
                {
                    Data = File(bytes, contentType, Path.Combine(folderPath, outputPath)),
                    Succeeded = true,
                    Message = "O excel foi gerado corretamente baseando-se nos filtros atuais, aguarde o download."
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }

        [HttpPost("UploadTreinamento")]
        public IActionResult UploadTreinamento([FromBody] DEMANDA_RELACAO_TREINAMENTO_FINALIZADO NovoTreinamento, string mensagem, int matricula)
        {
            try
            {
                AddNewTreinamentoHistory(NovoTreinamento,mensagem,matricula, out bool valid);
                if (!valid)
                {
                    return new JsonResult(new Response<bool>
                    {
                        Data = valid,
                        Succeeded = true,
                        Message = "O excel foi gerado corretamente baseando-se nos filtros atuais, aguarde o download."
                    });
                }

                return new JsonResult(new Response<string>
                {
                    Data = string.Empty,
                    Succeeded = true,
                    Message = "O excel foi gerado corretamente baseando-se nos filtros atuais, aguarde o download."
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }
        [HttpPost("UploadMassivoTreinamento")]
        public IActionResult UploadMassivoTreinamento([FromBody] IEnumerable<DEMANDA_RELACAO_TREINAMENTO_FINALIZADO> NovosTreinamentos, string mensagem, int matricula)
        {
            try
            {
                foreach (var item in NovosTreinamentos)
                {
                    AddNewTreinamentoHistory(item, mensagem, matricula, out bool valid);
                    if (!valid)
                    {
                        return new JsonResult(new Response<bool>
                        {
                            Data = valid,
                            Succeeded = true,
                            Message = $"o colaborador de matrícula {item.MATRICULA} ainda não foi desligado."
                        });
                    }
                }

                return new JsonResult(new Response<bool>
                {
                    Data = true,
                    Succeeded = true,
                    Message = "Foram atualizadas um total x de demandas que estavam aguardando a etapa de treinamento"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }

        private void AddNewTreinamentoHistory(DEMANDA_RELACAO_TREINAMENTO_FINALIZADO item,string mensagem,  int matricularesp, out bool valid)
        {
            valid = true;
            var acessoaberto = DB.DEMANDA_ACESSOS.FirstOrDefault(x => x.Matricula == item.MATRICULA.ToString());
            var matricularepetida = DB.DEMANDA_RELACAO_TREINAMENTO_FINALIZADO.FirstOrDefault(x => x.MATRICULA == item.MATRICULA);

            if (acessoaberto != null)
            {
                if (matricularepetida != null)
                {
                    if(matricularepetida.STATUS_MATRICULA == "ATIVO")
                    {
                        valid = false;
                    }
                }
                item.ID_RELACAO = acessoaberto.ID;
                DB.DEMANDA_RELACAO_TREINAMENTO_FINALIZADO.Add(item);

                var demanda_relacao = DB.DEMANDA_RELACAO_CHAMADO.Find(acessoaberto.ID_RELACAO);

                var resposta = new DEMANDA_CHAMADO_RESPOSTA
                {
                    ID_RELACAO = acessoaberto.ID_RELACAO,
                    ID_CHAMADO = acessoaberto.ID,
                    RESPOSTA = mensagem,
                    MATRICULA_RESPONSAVEL = matricularesp,
                    DATA_RESPOSTA = DateTime.Now,
                    ARQUIVOS = null
                };

                demanda_relacao.Respostas.Add(resposta);
                DB.SaveChanges();

                demanda_relacao.Status.Add(new DEMANDA_STATUS_CHAMADO
                {
                    ID_CHAMADO = acessoaberto.ID,
                    STATUS = STATUS_ACESSOS_PENDENTES.APROVADO.Value,
                    ID_RESPOSTA = resposta.ID,
                    DATA = DateTime.Now
                });

                DB.SaveChanges();
            }
        }

        private dynamic preencherValor(string xx)
        {
            if (string.IsNullOrEmpty(xx))
            {
                return "-";
            }
            return xx;
        }
        private Task ExecuteChangeMatriculaTerceiro(Guid id, int newmatricula,
            int matricula_resp, string mensagem, out DEMANDA_ACESSOS? demanda)
        {
            var demanda_relacao = DB.DEMANDA_RELACAO_CHAMADO.Find(id);
            demanda = DB.DEMANDA_ACESSOS.First(x => x.ID_RELACAO == id);
            demanda.Matricula = newmatricula.ToString();

            var resposta = new DEMANDA_CHAMADO_RESPOSTA
            {
                ID_RELACAO = id,
                ID_CHAMADO = demanda.ID,
                RESPOSTA = mensagem,
                MATRICULA_RESPONSAVEL = matricula_resp,
                DATA_RESPOSTA = DateTime.Now,
                ARQUIVOS = null
            };

            demanda_relacao.Respostas.Add(resposta);
            DB.SaveChanges();

            demanda_relacao.Status.Add(new DEMANDA_STATUS_CHAMADO
            {
                ID_CHAMADO = demanda.ID,
                STATUS = STATUS_ACESSOS_PENDENTES.AGUARDANDO_TREINAMENTO.Value,
                ID_RESPOSTA = resposta.ID,
                DATA = DateTime.Now
            });

            DB.SaveChanges();
            return Task.CompletedTask;
        }

    }
}
