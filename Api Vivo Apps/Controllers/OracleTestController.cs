using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Vivo_Apps_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared_Class_Vivo_Mais.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Shared_Class_Vivo_Mais.Model_DTO;
using Shared_Class_Vivo_Mais.DataOracle;
using Shared_Class_Vivo_Mais.DB_Context_Vivo_MAIS;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OracleTestController
    {
        private readonly ILogger<OracleTestController> _logger;
        private readonly IMapper _mapper;

        public OracleTestController(ILogger<OracleTestController> logger)
        {
            _logger = logger;
        }

        private Vivo_MAISContext CD = new Vivo_MAISContext();
        private OracleContext CD_Oracle = new OracleContext();

        [HttpGet("Test")]
        [ProducesResponseType(typeof(Response<IEnumerable<T_VALID_MOVEL>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GerarBoleta()
        {
            try
            {
                var data = CD_Oracle.T_VALID_MOVELs.ToList();
                var data1 = CD_Oracle.TABLE_CARTEIRAs.ToList();
                
                return new JsonResult(new Response<IEnumerable<T_VALID_MOVEL>>
                {
                    Data = data,
                    Succeeded = true,
                    Message = $"Tudo Certo!",
                    Errors = null,
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
    }
}
