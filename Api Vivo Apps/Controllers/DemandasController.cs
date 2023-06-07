using Newtonsoft.Json;
using Api_Vivo_Apps.Models;
using Microsoft.AspNetCore.Mvc;
using Api_Vivo_Apps.Data;

namespace Api_Vivo_Apps.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemandasController
    {
        private readonly ILogger<DemandasController> _logger;

        public DemandasController(ILogger<DemandasController> logger)
        {
            _logger = logger;
        }

        private Vivo_MAISContext CD = new Vivo_MAISContext();
        private string[] listaAdm = new string[] { "Gerente Geral", "GA", "Adm_Consumer", "GO", "Vendas_Adm" };

        [HttpGet("GetTimeSuporte")]
        public string GetTimeSuporte() => JsonConvert.SerializeObject(CD.TAB_PESSOAS_SUPORTEs.ToList());

        [HttpGet("GetSubFila")]
        public string GetSubFila() => JsonConvert.SerializeObject(CD.SUB_FILAs.ToList());
        [HttpGet("GetTipoFila")]
        public string GetTipoFila() => JsonConvert.SerializeObject(CD.TIPO_FILAs.ToList());
        [HttpGet("GetCamposFila")]
        public string GetCamposFila() => JsonConvert.SerializeObject(CD.CAMPOS_FILAs.ToList());
        [HttpGet("GetValoresCamposSuspensos")]
        public string GetValoresCamposSuspensos() => JsonConvert.SerializeObject(CD.VALORES_CAMPOS_SUSPENSOs.ToList());

        [HttpPost("InsertRespostaFechamento")]
        public string InsertRespostaFechamento([FromBody] RespostaFechamento data)
        {
            try
            {
                var retorno = CD.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs.Add(new CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTum
                {
                    RESPOSTA = data.resposta,
                    ID_CHAMADO = data.IdChamado,
                    MATRICULA_RESPONSAVEL = data.MATRICULA,
                    DATA_RESPOSTA = data.Data
                });

                var chamado = CD.CONTROLE_DE_DEMANDAS_CHAMADOs.Where(x => x.ID == data.IdChamado).FirstOrDefault();

                CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Add(new CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO
                {
                    ID_STATUS_CHAMADO = (int)chamado.ID_STATUS_CHAMADO,
                    STATUS = data.Status,
                    DATA = data.Data,
                    ID_RESPOSTA = chamado.ID.ToString(),
                });

                CD.SaveChanges();

                return JsonConvert.SerializeObject(retorno);
            }
            catch (Exception ex)
            {
                return $"500 -> {ex.Message} ---------------------- {ex.ToString()}";
            }
        }
        [HttpPost("InsertRespostaIntoDemandaChangeStatus")]
        public string InsertRespostaIntoDemandaChangeStatus([FromBody] RespostaFechamento data)
        {
            try
            {
                var retorno = CD.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs.Add(new CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTum
                {
                    RESPOSTA = data.resposta,
                    ID_CHAMADO = data.IdChamado,
                    MATRICULA_RESPONSAVEL = data.MATRICULA,
                    DATA_RESPOSTA = DateTime.Now
                }).Entity;

                CD.SaveChanges();
                var chamado = CD.CONTROLE_DE_DEMANDAS_CHAMADOs.Find(data.IdChamado);
                CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Add(new CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO
                {
                    ID_STATUS_CHAMADO = (int)chamado.ID_STATUS_CHAMADO,
                    STATUS = data.Status,
                    DATA = DateTime.Now,
                    ID_RESPOSTA = retorno.ID.ToString()
                });
                CD.SaveChanges();
                if (data.Status == "FECHADO")
                {
                    chamado.DATA_FECHAMENTO = DateTime.Now;
                }
                else if (data.Status == "CHAMADO REABERTO")
                {
                    chamado.DATA_FECHAMENTO = null;
                }
                CD.SaveChanges();

                return JsonConvert.SerializeObject(retorno);
            }
            catch (Exception ex)
            {
                return $"500 -> {ex.Message} ---------------------- {ex.ToString()}";
            }
        }

        [HttpPost("InsertRespostaIntoDemanda")]
        public string InsertRespostaIntoDemanda([FromBody] RespostaFechamento data)
        {
            try
            {
                var retorno = CD.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs.Add(new CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTum
                {
                    RESPOSTA = data.resposta,
                    ID_CHAMADO = data.IdChamado,
                    MATRICULA_RESPONSAVEL = data.MATRICULA,
                    DATA_RESPOSTA = DateTime.Now
                });
                CD.SaveChanges();
                return JsonConvert.SerializeObject(retorno);
            }
            catch (Exception ex)
            {
                return $"500 -> {ex.Message} ---------------------- {ex.ToString()}";
            }
        }
        [HttpPost("AbrirDemanda")]
        public string AbrirDemanda(AbrirDemanda data)
        {
            try
            {
                var demanda = CD.CONTROLE_DE_DEMANDAS_CHAMADOs.Add(new CONTROLE_DE_DEMANDAS_CHAMADO
                {
                    ID_FILA_CHAMADO = data.ID,
                    MATRICULA_SOLICITANTE = data.MAT_SOLICITANTE,
                    REGIONAL = data.REGIONAL,
                    EMAIL_SECUNDARIO = data.SEC_EMAIL,
                    DATA_ABERTURA = DateTime.Now,
                    PRIORIDADE = "BAIXA"
                }).Entity;

                CD.SaveChanges();

                var relacao_campos = CD.CONTROLE_DE_DEMANDAS_CAMPOS_CHAMADOs.Add(new CONTROLE_DE_DEMANDAS_CAMPOS_CHAMADO
                {
                    ID_CHAMADO = demanda.ID
                }).Entity;
                CD.SaveChanges();


                demanda.ID_CAMPOS_CHAMADO = relacao_campos.ID;

                foreach (var campo in data.campos)
                {
                    CD.CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADOs.Add(new CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADO
                    {
                        ID_CAMPOS_CHAMADO = relacao_campos.ID,
                        VALOR = campo.VALOR,
                        CAMPO = campo.CAMPO
                    });
                }
                CD.SaveChanges();

                var relacao_status = CD.CONTROLE_DE_DEMANDAS_STATUS_CHAMADOs.Add(new CONTROLE_DE_DEMANDAS_STATUS_CHAMADO { ID_CHAMADO = demanda.ID }).Entity;
                CD.SaveChanges();

                demanda.ID_STATUS_CHAMADO = relacao_status.ID;

                CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Add(new CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO
                {
                    ID_STATUS_CHAMADO = relacao_status.ID,
                    STATUS = "EM ABERTO",
                    DATA = DateTime.Now,
                });

                CD.SaveChanges();
                return $"{demanda.ID}";
            }
            catch (Exception ex)
            {
                return $"500 -> {ex.Message} ---------------------- {ex.ToString()}";
            }
        }

        [HttpPost("GetDemandaById")]
        public string GetDemandaById(int IdDemanda)
        {
            try
            {
                var demanda = CD.CONTROLE_DE_DEMANDAS_CHAMADOs.Where(x => x.ID == IdDemanda).FirstOrDefault();
                var campos = CD.CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADOs.Where(x => x.ID_CAMPOS_CHAMADO == demanda.ID_CAMPOS_CHAMADO).ToList();
                var status = CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Where(x => x.ID_STATUS_CHAMADO == demanda.ID_STATUS_CHAMADO).ToList();
                var respostas = CD.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs.Where(x => x.ID_CHAMADO == IdDemanda).ToList();

                var retorno = JsonConvert.SerializeObject(new
                {
                    ID = demanda.ID,
                    ID_FILA_CHAMADO = demanda.ID_FILA_CHAMADO,
                    MATRICULA_RESPONSAVEL = demanda.MATRICULA_RESPONSAVEL,
                    DATA_FECHAMENTO = demanda.DATA_FECHAMENTO,
                    MOTIVO_FECHAMENTO_SUPORTE = demanda.MOTIVO_FECHAMENTO_SUPORTE,
                    REGIONAL = demanda.REGIONAL,
                    EMAIL_SECUNDARIO = demanda.EMAIL_SECUNDARIO,
                    RESPONSAVEL_OUTRA_AREA = demanda.RESPONSAVEL_OUTRA_AREA,
                    CAMPOS = campos.Select(x => new { CAMPO = x.CAMPO, VALOR = x.VALOR }),
                    STATUS = status.Select(x => new
                    {
                        ID_STATUS_CHAMADO = x.ID_STATUS_CHAMADO,
                        STATUS = x.STATUS,
                        DATA = x.DATA,
                        MAT_QUEM_REDIRECIONOU = x.MAT_QUEM_REDIRECIONOU,
                        ID = x.ID,
                        ID_RESPOSTA = x.ID_RESPOSTA
                    }),
                    RESPOSTAS = respostas.Select(x => new
                    {
                        ID = x.ID,
                        RESPOSTA = x.RESPOSTA,
                        ID_CHAMADO = x.ID_CHAMADO,
                        MATRICULA_RESPONSAVEL = x.MATRICULA_RESPONSAVEL,
                        DATA_RESPOSTA = x.DATA_RESPOSTA
                    }),
                });
                return retorno;
            }
            catch (Exception ex)
            {
                return $"500 -> {ex.Message} ---------------------- {ex.ToString()}";
            }
        }
        [HttpPost("GetDemandasByMatricula")]
        public string GetDemandasByMatricula([FromBody] PaginationListaDemandasModel filter)
        {
            try
            {
                var demandas = CD.CONTROLE_DE_DEMANDAS_CHAMADOs.Where(x => x.MATRICULA_SOLICITANTE == filter.matricula).ToList();

                List<RetornoDemandas> lista = new List<RetornoDemandas>();

                foreach (var item in demandas)
                {
                    if (item.ID_STATUS_CHAMADO != null)
                    {
                        var retorno = CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Where(x => x.ID_STATUS_CHAMADO == item.ID_STATUS_CHAMADO).OrderByDescending(x => x.DATA).FirstOrDefault();
                        lista.Add(new RetornoDemandas
                        {
                            ID = item.ID,
                            ID_CAMPOS_CHAMADO = item.ID_CAMPOS_CHAMADO,
                            ID_STATUS_CHAMADO = item.ID_STATUS_CHAMADO,
                            ID_FILA_CHAMADO = item.ID_FILA_CHAMADO,
                            MATRICULA_RESPONSAVEL = item.MATRICULA_RESPONSAVEL,
                            MATRICULA_SOLICITANTE = item.MATRICULA_SOLICITANTE,
                            DATA_ABERTURA = item.DATA_ABERTURA,
                            DATA_FECHAMENTO = item.DATA_FECHAMENTO,
                            PRIORIDADE = item.PRIORIDADE,
                            REGIONAL = item.REGIONAL,
                            EMAIL_SECUNDARIO = retorno.MAT_QUEM_REDIRECIONOU,
                            ULTIMO_STATUS = retorno.STATUS,
                            DATA_STATUS = retorno.DATA.ToString()
                        });
                    }
                    else
                    {
                        lista.Add(new RetornoDemandas
                        {
                            ID = item.ID,
                            ID_CAMPOS_CHAMADO = item.ID_CAMPOS_CHAMADO,
                            ID_STATUS_CHAMADO = item.ID_STATUS_CHAMADO,
                            ID_FILA_CHAMADO = item.ID_FILA_CHAMADO,
                            MATRICULA_RESPONSAVEL = item.MATRICULA_RESPONSAVEL,
                            MATRICULA_SOLICITANTE = item.MATRICULA_SOLICITANTE,
                            DATA_ABERTURA = item.DATA_ABERTURA,
                            DATA_FECHAMENTO = item.DATA_FECHAMENTO,
                            PRIORIDADE = item.PRIORIDADE,
                            REGIONAL = item.REGIONAL
                        });
                    }
                }

                var Data = lista.OrderBy(x => x.ID)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToList();

                var totalRecords = lista.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                return JsonConvert.SerializeObject(
                PagedResponse.CreateListaDemandasPagedReponse<RetornoDemandas>(Data, filter, totalRecords));

                //return JsonConvert.SerializeObject(lista);
            }
            catch (Exception ex)
            {
                return $"500 -> {ex.Message} ---------------------- {ex.ToString()}";
            }
        }

    }
}
