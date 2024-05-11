using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Pipelines.Sockets.Unofficial.Arenas;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Models;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Vivo_Apps_API.Hubs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcessoTerceirosController : ControllerBase
    {
        private readonly ILogger<AcessoTerceirosController> _logger;
        private readonly IDistributedCache _cache;
        private readonly ISuporteDemandaHub _hubContext;
        public string? CachedTimeUTC { get; set; }
        public string? ASP_Environment { get; set; }

        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext DB;

        public AcessoTerceirosController(ILogger<AcessoTerceirosController> logger,
            IDistributedCache cache, IDbContextFactory<DemandasContext> dbContextFactory,
            ISuporteDemandaHub hubContext)
        {
            _cache = cache;
            _logger = logger;
            _hubContext = hubContext;
            DbFactory = dbContextFactory;
            DB = DbFactory.CreateDbContext();
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
                    AcessoRelacao = body,
                    ID_CHAMADO = body.ID
                };

                DB.DEMANDA_RELACAO_CHAMADO.Add(demanda);
                await DB.SaveChangesAsync();

                demanda.ID_CHAMADO = demanda.AcessoRelacao.ID;

                demanda.Respostas.Add(new DEMANDA_CHAMADO_RESPOSTA
                {
                    ID_RELACAO_CHAMADO = demanda.ID,
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

                return Ok(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = true,
                    Message = $"Solicitação de acessos criada, N° {body.ID}",
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
