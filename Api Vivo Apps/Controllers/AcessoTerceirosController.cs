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
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using System.Globalization;
using DocumentFormat.OpenXml.ExtendedProperties;
using System.Drawing;


namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcessoTerceirosController : ControllerBase
    {
        private readonly ILogger<AcessoTerceirosController> _logger;
        private readonly IOutputCacheStore _cache;
        private readonly ISuporteDemandaHub _hubContext;
        private readonly string _sharedFilesPath = @"_content\Shared_Razor_Components\wwwroot\";
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
                var mat_Desligada = DB.DEMANDA_RELACAO_TREINAMENTO_FINALIZADO.FirstOrDefault(x => x.MATRICULA == newmatricula);

                if (mat_Desligada != null && mat_Desligada.STATUS_MATRICULA == "ATIVO")
                {
                    return Ok(new Response<string>
                    {
                        Data = $"A solicitação não foi concluída pois você está solicitando acesso para uma matrícula que ainda possui um acesso ativo",
                        Succeeded = false,
                        Message = $"A solicitação não foi concluída pois você está solicitando acesso para uma matrícula que ainda possui um acesso ativo",
                    });
                }

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
                    var mat_Desligada = DB.DEMANDA_RELACAO_TREINAMENTO_FINALIZADO.FirstOrDefault(x => x.MATRICULA == singleid.Item2);

                    if (mat_Desligada != null && mat_Desligada.STATUS_MATRICULA == "ATIVO")
                    {
                        return Ok(new Response<string>
                        {
                            Data = $"A solicitação não foi concluída pois você está solicitando acesso para uma matrícula que ainda possui um acesso ativo",
                            Succeeded = false,
                            Message = $"A solicitação não foi concluída pois você está solicitando acesso para uma matrícula que ainda possui um acesso ativo",
                        });
                    }

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
                var demanda = new DEMANDA_RELACAO_CHAMADO
                {
                    Sequence = DB.DEMANDA_RELACAO_CHAMADO.Count() + 1,
                    Tabela = DEMANDA_RELACAO_CHAMADO.Tabela_Demanda.AcessoRelacao,
                    MATRICULA_SOLICITANTE = body.MATRICULA_SOLICITANTE,
                    DATA_ABERTURA = DateTime.Now,
                    PRIORIDADE = false,
                    PRIORIDADE_SEGMENTO = false,
                    LastStatus = STATUS_ACESSOS_PENDENTES.ABERTO.Value,
                    REGIONAL = body.REGIONAL,
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
                    Data = demanda.ID_RELACAO.ToString(),
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
                    item.DataContratoInicio = DateTime.Now;

                    xlWorkSheet.Cells[i, 1] = extrator.NOME.ToUpper();     //1 Nome
                    xlWorkSheet.Cells[i, 2] = item.Acao.GetDisplayName();

                    if (item.Acao == Acao.INCLUSÃO)
                    {
                        xlWorkSheet.Cells[i, 3] = "-";
                    }
                    else
                    {
                        xlWorkSheet.Cells[i, 3] = item.Matricula;
                    }
                    xlWorkSheet.Cells[i, 4] = "T4 Dealers";                             //2 
                    xlWorkSheet.Cells[i, 5] = item.Nome;
                    xlWorkSheet.Cells[i, 6] = preencherValor(item.Sobrenome);
                    xlWorkSheet.Cells[i, 7] = item.Sexo.Value.GetDisplayName();
                    xlWorkSheet.Cells[i, 8] = "-";
                    //string CPFFinal = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                    xlWorkSheet.Cells[i, 9] = item.Cpf;
                    // Ver se precisa da formatação do PIS aqui
                    xlWorkSheet.Cells[i, 10] = preencherValor(item.PIS);
                    xlWorkSheet.Cells[i, 11] = "0 Solt";                                //4
                    xlWorkSheet.Cells[i, 12] = preencherValor(item.Rg);
                    //Orgao Emissor
                    string filteredString = new string(item.OrgaoEmissor.Where(Char.IsLetter).ToArray());
                    string modifiedString = string.Join("/", new string(filteredString.Take(3).ToArray()), new string(filteredString.Skip(3).ToArray()));

                    xlWorkSheet.Cells[i, 13] = modifiedString.ToUpper();
                    xlWorkSheet.Cells[i, 14] = item.DataNascimento;                     //3
                    xlWorkSheet.Cells[i, 15] = "BR Brasileiro";                         //5
                    xlWorkSheet.Cells[i, 16] = item.Telefone;     // COLUNA   AM
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
                    xlWorkSheet.Cells[i, 29] = item.DataContratoInicio.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                    xlWorkSheet.Cells[i, 30] = item.DataContratoInicio.Value.AddYears(2).ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                    xlWorkSheet.Cells[i, 31] = "A Ativo";
                    xlWorkSheet.Cells[i, 32] = "";
                    xlWorkSheet.Cells[i, 33] = "80000064    SERVIÇOS - VENDAS";
                    xlWorkSheet.Cells[i, 34] = "TBRA";
                    xlWorkSheet.Cells[i, 35] = "T-" + item.Estado?.GetDisplayName();
                    xlWorkSheet.Cells[i, 36] = item.Estado.Value.GetDisplayName();
                    xlWorkSheet.Cells[i, 37] = item.Cidade.ToUpper();
                    xlWorkSheet.Cells[i, 38] = "";
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
        public async Task<IActionResult> ExtractMatriculaAcessos([FromBody] IEnumerable<Guid> ids)
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

                    xlWorkSheet.Cells[i, 1] = item.ID_CHAMADO;
                    xlWorkSheet.Cells[i, 2] = item.ID_RELACAO.ToString();

                    Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[i, 3];
                    float Left = (float)((double)oRange.Left);
                    float Top = (float)((double)oRange.Top);
                    xlWorkSheet.Shapes.AddPicture(Path.Combine(folderPath, item.AcessoRelacao?.Acao == Acao.INCLUSÃO ? "Imagem1.gif" : "Imagem2.gif"), Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 8, 8);

                    xlWorkSheet.Cells[i, 4] = $"Foi criado o Terceiro : {item.AcessoRelacao?.Matricula}";
                    xlWorkSheet.Cells[i, 5] = (int)Acao.INCLUSÃO;
                    xlWorkSheet.Cells[i, 6] = string.IsNullOrEmpty(item.AcessoRelacao?.Matricula) ? item.AcessoRelacao?.Matricula : string.Empty;
                    xlWorkSheet.Cells[i, 7] = "T4";
                    xlWorkSheet.Cells[i, 8] = item.AcessoRelacao.Nome.Split()[0];
                    xlWorkSheet.Cells[i, 9] = item.AcessoRelacao.Nome.Split().Count() > 1 ? item.AcessoRelacao.Nome.Split().Skip(1) : string.Empty;
                    xlWorkSheet.Cells[i, 10] = (int)item.AcessoRelacao.Sexo;
                    xlWorkSheet.Cells[i, 11] = string.Empty;
                    xlWorkSheet.Cells[i, 12] = item.AcessoRelacao.Cpf;
                    xlWorkSheet.Cells[i, 13] = item.AcessoRelacao.Cnpj;
                    xlWorkSheet.Cells[i, 14] = 0;
                    xlWorkSheet.Cells[i, 15] = item.AcessoRelacao.Rg;
                    xlWorkSheet.Cells[i, 16] = item.AcessoRelacao.OrgaoEmissor;
                    xlWorkSheet.Cells[i, 17] = item.AcessoRelacao.DataNascimento.Value.ToShortDateString();
                    xlWorkSheet.Cells[i, 18] = "BR";
                    xlWorkSheet.Cells[i, 19] = item.AcessoRelacao.Telefone;
                    xlWorkSheet.Cells[i, 20] = item.AcessoRelacao.Email;
                    xlWorkSheet.Cells[i, 21] = 2;
                    xlWorkSheet.Cells[i, 22] = 1;
                    xlWorkSheet.Cells[i, 23] = string.Empty;
                    xlWorkSheet.Cells[i, 24] = 0;
                    xlWorkSheet.Cells[i, 25] = string.Empty;
                    xlWorkSheet.Cells[i, 26] = item.AcessoRelacao.Cnpj;
                    xlWorkSheet.Cells[i, 27] = item.AcessoRelacao.SubGrupo;
                    xlWorkSheet.Cells[i, 28] = "10017038";
                    xlWorkSheet.Cells[i, 29] = "10017038";
                    xlWorkSheet.Cells[i, 30] = "163794";
                    xlWorkSheet.Cells[i, 31] = 0;
                    xlWorkSheet.Cells[i, 32] = 0;
                    xlWorkSheet.Cells[i, 33] = item.AcessoRelacao.DataContratoInicio != null ? item.AcessoRelacao.DataContratoInicio.Value.ToShortDateString() : string.Empty;
                    //xlWorkSheet.Cells[$"AE{i}"] = item.AcessoRelacao.DataContratoFim != null ? item.AcessoRelacao.DataContratoFim.Value.ToShortDateString() : string.Empty;
                    xlWorkSheet.Cells[i, 34] = "A";
                    xlWorkSheet.Cells[i, 35] = "-";
                    xlWorkSheet.Cells[i, 36] = "-";
                    xlWorkSheet.Cells[i, 37] = "TBRA";
                    xlWorkSheet.Cells[i, 38] = item.AcessoRelacao.Estado.Value.GetDisplayName(true, "T-");
                    xlWorkSheet.Cells[i, 39] = item.AcessoRelacao.SubGrupo;
                    xlWorkSheet.Cells[i, 40] = item.AcessoRelacao.Cidade;
                    xlWorkSheet.Cells[i, 41] = item.AcessoRelacao.Estado.Value.GetDisplayName();
                    xlWorkSheet.Cells[i, 42] = 0;
                    xlWorkSheet.Cells[i, 43] = string.Empty;
                    xlWorkSheet.Cells[i, 44] = 1;
                    xlWorkSheet.Cells[i, 45] = 2;
                    xlWorkSheet.Cells[i, 46] = string.Empty;
                    xlWorkSheet.Cells[i, 47] = string.Empty;
                    xlWorkSheet.Cells[i, 48] = 3;
                    xlWorkSheet.Cells[i, 49] = string.Empty;
                    xlWorkSheet.Cells[i, 50] = 1;
                    xlWorkSheet.Cells[i, 51] = 2;
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

        [HttpPost("UploadTreinamento/{id}/{mensagem}/{matricula}")]
        public async Task<IActionResult> UploadTreinamento([FromBody] TREINAMENTO_MODEL TREINAMENTO, Guid id, string mensagem, int matricula)
        {
            try
            {
                var NovoTreinamento = new DEMANDA_RELACAO_TREINAMENTO_FINALIZADO(TREINAMENTO.MATRICULA, TREINAMENTO.Nome, TREINAMENTO.Data_Admissão.Value, TREINAMENTO.Cargo, TREINAMENTO.Empresa, TREINAMENTO.CNPJ, TREINAMENTO.Canal, TREINAMENTO.Uf, TREINAMENTO.Cidade, TREINAMENTO.Data_Conclusao.Value, matricula, Formato_inclusao.DETALHADO);

                await AddNewTreinamentoHistory(NovoTreinamento, mensagem, matricula, out bool valid, id);

                if (!valid)
                {
                    return new JsonResult(new Response<bool>
                    {
                        Data = valid,
                        Succeeded = true,
                        Message = "O excel foi gerado corretamente baseando-se nos filtros atuais, aguarde o download."
                    });
                }

                await _hubContext.SendTableDemandas(matricula);

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
                   .First(x => x.ID_RELACAO == NovoTreinamento.ID_RELACAO);

                return new JsonResult(new Response<ACESSO_TERCEIROS_DTO>
                {
                    Data = demanda_acesso,
                    Succeeded = true,
                    Message = "Adicionamos o resgistro de treinamento para este de usuário, falta apenas a criação de acesso para finalizar este chamado."
                }, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
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

        [HttpPost("UploadMassivoTreinamento/{mensagem}/{matricula}")]
        public async Task<IActionResult> UploadMassivoTreinamento([FromBody] IEnumerable<TREINAMENTO_MODEL> NovosTreinamentos, string mensagem, int matricula)
        {
            try
            {
                _ = Task.Run(() => UploadTreinamentoAsync(NovosTreinamentos, mensagem, matricula));

                return new JsonResult(new Response<bool>
                {
                    Data = true,
                    Succeeded = true,
                    Message = "Aguarde enquanto atualizamos as demandas com base nas informações do arquivo"
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

        private async Task UploadTreinamentoAsync(IEnumerable<TREINAMENTO_MODEL> NovosTreinamentos, string mensagem, int matricula)
        {
            int i = 0;

            foreach (var TREINAMENTO in NovosTreinamentos)
            {
                if (i == NovosTreinamentos.Count() - 1)
                {
                    await _hubContext.ProgressMassivoTreinamento(matricula, 100, $"Upload de base de treinamento finalizado ✔");
                }
                if (i == (int)(NovosTreinamentos.Count() / 2.0))
                {
                    await _hubContext.ProgressMassivoTreinamento(matricula, 50, $"Upload de base de treinamento em 50%...");
                }
                if (i == (int)(NovosTreinamentos.Count() / 3.0))
                {
                    await _hubContext.ProgressMassivoTreinamento(matricula, 33, $"Upload de base de treinamento em 33%...");
                }
                if (i == (int)(NovosTreinamentos.Count() / 4.0))
                {
                    await _hubContext.ProgressMassivoTreinamento(matricula, 25, $"Upload de base de treinamento em 25%...");
                }
                if (i == (int)(NovosTreinamentos.Count() / 5.0))
                {
                    await _hubContext.ProgressMassivoTreinamento(matricula, 20, $"Upload de base de treinamento em 20%...");
                }

                var newitem = new DEMANDA_RELACAO_TREINAMENTO_FINALIZADO(TREINAMENTO.MATRICULA, TREINAMENTO.Nome, TREINAMENTO.Data_Admissão.Value, TREINAMENTO.Cargo, TREINAMENTO.Empresa, TREINAMENTO.CNPJ, TREINAMENTO.Canal, TREINAMENTO.Uf, TREINAMENTO.Cidade, TREINAMENTO.Data_Conclusao.Value, matricula, Formato_inclusao.MASSIVO);

                await AddNewTreinamentoHistory(newitem, mensagem, matricula, out bool valid);

                if (!valid)
                {
                    await _hubContext.ProgressMassivoTreinamento(matricula, 100, $"Não foi possível finalizar pois já existe um usuário ativo com a matrícula {TREINAMENTO.MATRICULA}, todas as matrículas anteriores a essa no arquivo foram validadas.");
                }
                i++;
            }
        }

        private Task AddNewTreinamentoHistory(DEMANDA_RELACAO_TREINAMENTO_FINALIZADO item, string mensagem, int matricularesp, out bool valid, Guid? id = null)
        {
            valid = true;
            DEMANDA_ACESSOS? acessoaberto;

            /** Caso o Id seja informado, procura por ID, caso não busca por matricula **/
            /** Caso encontre algum acesso continua com a requisição **/

            var matricularepetida = DB.DEMANDA_RELACAO_TREINAMENTO_FINALIZADO.FirstOrDefault(x => x.MATRICULA == item.MATRICULA);

            /** Caso encontre algum item na tabela de treinamento
             * com a mesma matrícula retorna impossibilitando a continuidade
             * e não adiciona um novo elemento na tabela **/

            if (matricularepetida != null)
            {
                if (matricularepetida.STATUS_MATRICULA == "ATIVO")
                {
                    valid = false;
                    return Task.CompletedTask;
                }

            }


            if (id.HasValue)
                acessoaberto = DB.DEMANDA_ACESSOS.First(x => x.ID_RELACAO == id);
            else
                acessoaberto = DB.DEMANDA_ACESSOS.FirstOrDefault(x => x.Matricula == item.MATRICULA.ToString());

            if (acessoaberto != null)
            {

                item.ID_RELACAO = acessoaberto.ID_RELACAO;
                DB.DEMANDA_RELACAO_TREINAMENTO_FINALIZADO.Add(item);

                DB.SaveChanges();

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
                    STATUS = STATUS_ACESSOS_PENDENTES.AGUARDANDO_CRIAÇÃO_DE_ACESSO.Value,
                    ID_RESPOSTA = resposta.ID,
                    DATA = DateTime.Now
                });
                demanda_relacao.LastStatus = STATUS_ACESSOS_PENDENTES.AGUARDANDO_CRIAÇÃO_DE_ACESSO.Value;
                DB.SaveChanges();
            }

            return Task.CompletedTask;

        }

        private Task ExecuteChangeMatriculaTerceiro(Guid id, int newmatricula, int matricula_resp, string mensagem, out DEMANDA_ACESSOS? demanda)
        {
            var demanda_relacao = DB.DEMANDA_RELACAO_CHAMADO.Find(id);
            demanda = DB.DEMANDA_ACESSOS.First(x => x.ID_RELACAO == id);

            if (demanda.Acao == Acao.INCLUSÃO
            && string.IsNullOrEmpty(demanda.Matricula)
            && demanda_relacao.LastStatus == STATUS_ACESSOS_PENDENTES.ABERTO.Value)
            // Se for uma inclusão em que a matrícula ainda está vazia incluimos a demanda
            {
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

                demanda_relacao.LastStatus = STATUS_ACESSOS_PENDENTES.AGUARDANDO_TREINAMENTO.Value;

                DB.SaveChanges();
            }

            return Task.CompletedTask;
        }
        private dynamic preencherValor(string xx)
        {
            if (string.IsNullOrEmpty(xx))
            {
                return "-";
            }
            return xx;
        }

    }
}
