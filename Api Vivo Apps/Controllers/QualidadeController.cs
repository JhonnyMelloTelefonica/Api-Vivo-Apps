using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Vivo_Apps_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared_Static_Class.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Shared_Static_Class.Model_DTO;
using Microsoft.AspNetCore.SignalR;
using Vivo_Apps_API.Hubs;
using System.Numerics;
using TableDependency.SqlClient.Base.Messages;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Enums;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Linq;
using Microsoft.AspNetCore.StaticFiles;
using static Vivo_Apps_API.Models.Converters.Converters;
using Shared_Razor_Components.FundamentalModels;


namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QualidadeController : ControllerBase
    {
        private readonly Vivo_MaisContext _context;

        public QualidadeController(Vivo_MaisContext context)
        {
            _context = context;
        }

        [HttpGet("Qualidade")]
        public IActionResult GetAuditData()
        {
            try
            {
                var auditData = _context.QUALIDADE_BD_MANUAL_AUDITs.ToList();
                return Ok(auditData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }


        //[HttpPost("EnviarLinhaFidelizada/{idUser}")]
        //public IActionResult EnviarLinhaFidelizada(int idUser, [FromBody] LinhaFidelizadaDTO linhaFidelizada)
        //{
        //    try
        //    {

        //        //var linha = _context.QUALIDADE_BD_MANUAL_AUDITs.Find(idUser);

        //        var linha = _context.QUALIDADE_BD_MANUAL_AUDITs.FirstOrDefault(l => l.ID == idUser);

        //        if (linha == null)
        //        {
        //            return NotFound($"Linha com ID {idUser} não encontrada");
        //        }


        //        linha.LINHA_FIDELIZADA = linhaFidelizada.LinhaFidelizada;


        //        _context.SaveChanges();

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
        //    }
        //}


        [HttpPost("EnviarDadosFidelizacao")]
        public IActionResult EnviarDadosFidelizacao([FromBody] FidelizacaoDTO dadosFidelizacao)
        {
            try
            {

                var linha = _context.QUALIDADE_BD_MANUAL_AUDITs.FirstOrDefault(l => l.ID == dadosFidelizacao.IDUSER);

                if (linha == null)
                {
                    return NotFound($"Linha com ID {dadosFidelizacao.IDUSER} não encontrada");
                }


                linha.LINHA_FIDELIZADA = dadosFidelizacao.LINHAFIDELIZADA;

                linha.DT_FIDELIZACAO = dadosFidelizacao.DATAFIDELIZACAO;

                linha.TIPO_JUST_FIDELIZACAO = dadosFidelizacao.TIPOJUSTIFICATIVA;

                linha.MOTIVO_EXCECAO_FIDELIZACAO = dadosFidelizacao.MOTIVO;

                linha.MULTA_FAT_FID = dadosFidelizacao.MULTA_OK;

                linha.IMEI_NEXT = dadosFidelizacao.NEXT;

                linha.N_CHAMADO = dadosFidelizacao.N_CHAMADO;

                linha.DT_CHAMADO = dadosFidelizacao.DT_CHAMADO;

                linha.DT_ABERTURA_TICKET = dadosFidelizacao.DT_ABERTURA;

                linha.N_TICKET = dadosFidelizacao.N_TICKET;

                linha.ACAO_CORRETIVA = dadosFidelizacao.ACAO_CORRETIVA;

                linha.ACAO_PREVENTIVA = dadosFidelizacao.ACAO_PREVENTIVA;

                linha.N_VOUCHER = dadosFidelizacao.N_VOUCHER;

                linha.DT_EMISSAO = dadosFidelizacao.DT_VOUCHER;

                linha.VL_VOUCHER = dadosFidelizacao.VL_VOUCHER;

                linha.VALOR_NA_TABELA_DE_PREÇO = dadosFidelizacao.VL_TABELA;

                linha.N_PROTOCOLO_GED = dadosFidelizacao.N_PROTOCOLO_GED;



                _context.SaveChanges();


                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

    }
}


