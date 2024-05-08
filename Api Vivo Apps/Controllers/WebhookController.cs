using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Shared_Static_Class.Data;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Models;
using System;
using System.Data.Entity;
using System.Text;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcessoTerceirosController : ControllerBase
    {
        private readonly ILogger<AcessoTerceirosController> _logger;
        private readonly IDistributedCache _cache;
        public string? CachedTimeUTC { get; set; }
        public string? ASP_Environment { get; set; }

        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext DB;

        public AcessoTerceirosController(ILogger<AcessoTerceirosController> logger,
            IDistributedCache cache, IDbContextFactory<DemandasContext> dbContextFactory)
        {
            _cache = cache;
            _logger = logger;
            DbFactory = dbContextFactory;
            DB = DbFactory.CreateDbContext();
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] DEMANDA_ACESSOS body)
        {
            try
            {
                DB.DEMANDA_ACESSOS.Add(body);
                await DB.SaveChangesAsync();

                return Ok(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = true,
                    Message = $"Solicitação de acessos criada, N° {body.ID_RELACAO}",
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Algum erro ocorreu ao tentar criar um novo elemente");
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
