using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Office.Interop.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Pipelines.Sockets.Unofficial.Arenas;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Razor_Components.FundamentalModels;
using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Vivo_Apps_API.Hubs;
using static System.Runtime.InteropServices.JavaScript.JSType;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.JSInterop;
using Mono.TextTemplating;
using Path = System.IO.Path;
using File = System.IO.File;
using DataTable = System.Data.DataTable;
using System.Data;
using System.Linq;
using Range = Microsoft.Office.Interop.Excel.Range;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.AspNetCore.StaticFiles;
using AutoMapper;
using Microsoft.AspNetCore.OutputCaching;
using Shared_Razor_Components.Services;
using Shared_Static_Class.Model_DTO;
using AutoMapper.QueryableExtensions;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DesligamentosController : ControllerBase
    {
        private readonly ILogger<DesligamentosController> _logger;
        private readonly ISuporteDemandaHub _hubContext;
        private readonly IOutputCacheStore _cache;
        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext DB;
        private Vivo_MaisContext CD;
        private IMapper _mapper;
        private IPWService _service;

        public DesligamentosController(ILogger<DesligamentosController> logger,
            IDbContextFactory<DemandasContext> dbContextFactory, IOutputCacheStore cache,
            ISuporteDemandaHub hubContext, Vivo_MaisContext cD,IPWService service)
        {
            _service = service;
            _cache = cache;
            CD = cD;
            _logger = logger;
            _logger = logger;
            _hubContext = hubContext;
            DbFactory = dbContextFactory;
            DB = DbFactory.CreateDbContext();
            CD = cD;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] DEMANDA_DESLIGAMENTOS body, string MENSAGEM)
        {
            try
            {
                //body.Solicitante = DB.ACESSOS_MOBILE.First(x => x.MATRICULA == body.MATRICULA_SOLICITANTE);

                var demanda = new DEMANDA_RELACAO_CHAMADO
                {
                    Sequence = DB.DEMANDA_RELACAO_CHAMADO.Count() + 1,
                    Tabela = DEMANDA_RELACAO_CHAMADO.Tabela_Demanda.DesligamentoRelacao,
                    MATRICULA_SOLICITANTE = body.MATRICULA_SOLICITANTE,
                    DATA_ABERTURA = DateTime.Now,
                    PRIORIDADE = false,
                    PRIORIDADE_SEGMENTO = false,
                    DesligamentoRelacao = body,
                    LastStatus = STATUS_ACESSOS_PENDENTES.ABERTO.Value,
                    REGIONAL = body.REGIONAL,
                    ID_CHAMADO = body.ID
                };

                var demandaCompleta = DB.DEMANDA_RELACAO_CHAMADO.Add(demanda).Entity;
                await DB.SaveChangesAsync();

                demanda.ID_CHAMADO = demanda.DesligamentoRelacao.ID;

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

                var retorno = DB.ACESSOS_MOBILE
                    .Where(x => x.MATRICULA == demanda.AcessoRelacao.MATRICULA_RESPONSAVEL)
                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                    .First();
                var solicitante = DB.ACESSOS_MOBILE
                    .Where(x => x.MATRICULA == demanda.AcessoRelacao.MATRICULA_SOLICITANTE)
                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                    .First();

                SendEmailModel email = new SendEmailModel(new string[] { retorno.EMAIL, solicitante.EMAIL }, null, $"Nova solicitação de acesso N {demandaCompleta.Sequence}",
                    $"Nova solicitação de acesso do tipo {demanda.AcessoRelacao.Acao.GetDisplayName()} foi aberta por {solicitante.DISPLAY_NOME}",
                    $"Uma solicitação para o time de acessos do tipo {demanda.AcessoRelacao.Acao.GetDisplayName()} acaba de ser criada" +
                    $"com o responsável principal {retorno.DISPLAY_NOME}, por favor aguarde o retorno do time de acessos.", null,
                    new string[] { "ne_automacao.br@telefonica.com", "ne_acesso.br@telefonica.com" });

                Task.Run(() => _service.SendEmail(email));
                email.Footer = "<div></div>";
                Task.Run(() => _service.SendTeams(email));


                await _cache.EvictByTagAsync("AllDemandas", default);
                await _hubContext.SendTableDemandas();

                return Ok(new Response<string>
                {
                    Data = demanda.ID_RELACAO.ToString(),
                    Succeeded = true,
                    Message = $"Solicitação de desligamento criada, N° {demanda.Sequence}",
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
    }
}
