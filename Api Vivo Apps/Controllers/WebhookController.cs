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

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Webhook : ControllerBase
    {
        private readonly ILogger<Webhook> _logger;

        public Webhook(ILogger<Webhook> logger)
        {
            _logger = logger;
        }

        [HttpPost("simplewebhook")]
        public async Task<IActionResult> SimpleWebhook()
        {
            try
            {
                _logger.Log(LogLevel.Warning,"tudo certo");
                return Ok("Tudo Certo");
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message, title: "Algum erro ocorreu!");
            }
        }
    }
}
