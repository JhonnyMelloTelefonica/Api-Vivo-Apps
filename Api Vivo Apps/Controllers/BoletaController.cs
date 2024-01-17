using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Vivo_Apps_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared_Class_Vivo_Apps.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Shared_Class_Vivo_Apps.Model_DTO;
using Microsoft.AspNetCore.SignalR;
using Vivo_Apps_API.Hubs;
using System.Numerics;
using TableDependency.SqlClient.Base.Messages;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using Shared_Class_Vivo_Apps.Enums;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Linq;
using Microsoft.AspNetCore.StaticFiles;


namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoletaController : ControllerBase
    {
        private readonly ILogger<BoletaController> _logger;
        private readonly IMapper _mapper;
        private readonly IHubContext<VivoXHub> _hubContext;

        public BoletaController(ILogger<BoletaController> logger, IHubContext<VivoXHub> hubContext)
        {
            _logger = logger;
            _hubContext = hubContext;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BOLETA_BD_PALITAGEM, BOLETA_PALITAGEM_DTO>()
                .ForMember(
                    dest => dest.DATA_INICIO,
                    opt => opt.MapFrom(src => StringToDateTime(src.DATA_INICIO))
                    )
                .ForMember(
                    dest => dest.DT_PRIMEIRO_RETORNO,
                    opt => opt.MapFrom(src => StringToDateTime(src.DT_PRIMEIRO_RETORNO))
                    )
                .ForMember(
                    dest => dest.DT_RETORNO,
                    opt => opt.MapFrom(src => StringToDateTime(src.DT_RETORNO))
                ).ForMember(
                    dest => dest.MAT_CONSULTOR,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.FirstOrDefault(x => x.MATRICULA == src.MAT_CONSULTOR))
                ).ForMember(
                    dest => dest.BOLETA_BD_CLIENTEs,
                    opt => opt.MapFrom(src => src.BOLETA_BD_CLIENTEs.FirstOrDefault())
                );

                cfg.CreateMap<HISTORICO_BOLETA_BD_PALITAGEM, HISTORICO_BOLETA_BD_PALITAGEM_DTO>()
                .ForMember(
                    dest => dest.MATRICULA,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.FirstOrDefault(x => x.MATRICULA == src.MATRICULA))
                );

                cfg.CreateMap<BOLETA_BD_CLIENTE, BOLETA_CLIENTE_DTO>();

                cfg.CreateMap<BOLETA_BD_BLOCAO, BOLETA_BLOCAO_DTO>();

                cfg.CreateMap<BOLETA_BD_DADO, BOLETA_DADO_DTO>()
                .ForMember(
                    dest => dest.BOLETA_BD_LINHAs,
                    opt => opt.MapFrom(src => src.BOLETA_BD_LINHAs.FirstOrDefault())
                )
                .ForMember(
                    dest => dest.BOLETA_BD_EQUIPAMENTOs,
                    opt => opt.MapFrom(src => src.BOLETA_BD_EQUIPAMENTOs.FirstOrDefault())
                )
                .ForMember(
                    dest => dest.BOLETA_BD_SVAs,
                    opt => opt.MapFrom(src => src.BOLETA_BD_SVAs.FirstOrDefault())
                ).ForMember(
                    dest => dest.PLATAFORMA,
                    opt => opt.MapFrom(src => ((Plataforma)int.Parse(src.PLATAFORMA)))
                ).ForMember(
                    dest => dest.CATEGORIA,
                    opt => opt.MapFrom(src => ((Categoria)int.Parse(src.CATEGORIA)))
                ).ForMember(
                    dest => dest.MOVIMENTO,
                    opt => opt.MapFrom(src => ((Movimento)int.Parse(src.MOVIMENTO)))
                ).ForMember(
                    dest => dest.PLANO,
                    opt => opt.MapFrom(src => ((Planos)int.Parse(src.PLANO)))
                );

                cfg.CreateMap<BOLETA_BD_EQUIPAMENTO, BOLETA_EQUIPAMENTO_DTO>();

                cfg.CreateMap<BOLETA_BD_LINHA, BOLETA_LINHA_DTO>();

                cfg.CreateMap<BOLETA_BD_SVA, BOLETA_SVA_DTO>()
                .ForMember(
                    dest => dest.NOME,
                    opt => opt.MapFrom(src => ((SVA)int.Parse(src.NOME)))
                );

                cfg.CreateMap<BOLETA_BD_MOVIMENTO, BOLETA_MOVIMENTO_DTO>()
                .ForMember(
                    dest => dest.ID_MOVIMENTO,
                    opt => opt.MapFrom(src => ((Movimento)src.ID_MOVIMENTO))
                )
                .ForMember(
                    dest => dest.ID_CATEGORIA,
                    opt => opt.MapFrom(src => ConvertStringToEnumList<Categoria>(src.ID_CATEGORIA))
                    )
                .ForMember(
                    dest => dest.ID_PLATAFORMA,
                    opt => opt.MapFrom(src => ConvertStringToEnumList<Plataforma>(src.ID_PLATAFORMA))
                    )
                .ForMember(
                    dest => dest.DESCRICAO,
                    opt => opt.MapFrom(src => Convert.ToBoolean(src.DESCRICAO))
                )
                .ForMember(
                    dest => dest.PLANO,
                    opt => opt.MapFrom(src => Convert.ToBoolean(src.PLANO))
                )
                .ForMember(
                    dest => dest.PORTABLIDADE,
                    opt => opt.MapFrom(src => Convert.ToBoolean(src.PORTABLIDADE))
                )
                .ForMember(
                    dest => dest.FIDELIZACAO,
                    opt => opt.MapFrom(src => Convert.ToBoolean(src.FIDELIZACAO))
                )
                .ForMember(
                    dest => dest.VIVO_TOTAL,
                    opt => opt.MapFrom(src => Convert.ToBoolean(src.VIVO_TOTAL))
                )
                .ForMember(
                    dest => dest.COD,
                    opt => opt.MapFrom(src => Convert.ToBoolean(src.COD))
                )
                .ForMember(
                    dest => dest.DAUTO,
                    opt => opt.MapFrom(src => Convert.ToBoolean(src.DAUTO))
                );

                //////////////////////////////////////////////////////

                cfg.CreateMap<BOLETA_BD_CATEGORIum, BOLETA_CATEGORIA_DTO>()
                .ForMember(
                    dest => dest.ID_CATEGORIA,
                    opt => opt.MapFrom(src => ((Categoria)src.ID_CATEGORIA))
                )
                .ForMember(
                    dest => dest.ID_PLATAFORMA,
                    opt => opt.MapFrom(src => ConvertStringToEnumList<Plataforma>(src.ID_PLATAFORMA))
                    )
                .ForMember(
                    dest => dest.MOVIMENTO,
                    opt => opt.MapFrom(src => Convert.ToBoolean(src.MOVIMENTO))
                );

                cfg.CreateMap<BOLETA_BD_PLANO, BOLETA_PLANO_DTO>()
                .ForMember(
                    dest => dest.Origem,
                    opt => opt.MapFrom(src => ((Plataforma)int.Parse(src.Origem)))
                )
                .ForMember(
                    dest => dest.ID_PLATAFORMA,
                    opt => opt.MapFrom(src => ConvertStringToEnumList<Plataforma>(src.ID_PLATAFORMA))
                    )
                .ForMember(
                    dest => dest.ID_PLANO,
                    opt => opt.MapFrom(src => ((Planos)src.ID_PLANO))
                );

                //cfg.CreateMap<object, Categoria>().ConvertUsing(value => (Categoria)value);
                //cfg.CreateMap<object, Plataforma>().ConvertUsing(value => (Plataforma)value);
                //cfg.CreateMap<object, Movimento>().ConvertUsing(value => (Movimento)value);
                // Add more mappings as needed for other entities   
            });

            _mapper = config.CreateMapper();
        }
        private static DateTime? StringToDateTime(string date) => (date is not null ? Convert.ToDateTime(date) : null);
        private static string RemoveNonNumericCharacters(string input) => new string(input.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
        private static List<TEnum> ConvertStringToEnumList<TEnum>(string input) where TEnum : struct
        {
            var enumList = new List<TEnum>();

            if (!string.IsNullOrEmpty(input))
            {
                if (input.Contains(";"))
                {
                    // Multiple values separated by semicolon
                    var enumValues = input.Split(';').Select(x => x.Trim());

                    foreach (var value in enumValues)
                    {
                        if (Enum.TryParse(typeof(TEnum), value, out var categoriaValue) && categoriaValue is TEnum)
                        {
                            enumList.Add((TEnum)categoriaValue);
                        }
                        else
                        {
                            // Handle the case where parsing fails or provide a default value
                        }
                    }
                }
                else
                {
                    // Single value without semicolon
                    if (Enum.TryParse(typeof(TEnum), input.Trim(), out var categoriaValue) && categoriaValue is TEnum)
                    {
                        enumList.Add((TEnum)categoriaValue);
                    }
                    else
                    {
                        // Handle the case where parsing fails or provide a default value
                    }
                }
            }

            return enumList;
        }

        private Vivo_MaisContext CD = new Vivo_MaisContext();

        [HttpPost("GerarBoleta")]
        [ProducesResponseType(typeof(Response<int>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GerarBoleta([FromBody] BoletaModelUnvalidated data, string matricula)
        {
            if (data.Dados_Solicitacao.Any(x =>
                x.Portabilidade is null ||
                x.Fidelizacao is null ||
                x.Descricao is null ||
                x.Categoria is null ||
                x.Movimento is null)
                )
            {
                return new JsonResult(new Response<string>
                {
                    Data = "ALGUM DADO NÃO FOI INFORMADO CORRETAMENTE!!!",
                    Succeeded = false,
                    Message = $"Alguma informação necessária para criação da boleta não foi informada, por favor informar dados faltantes e tentar novamente",
                    Errors = new string[]
                    {
                        $"Alguma informação necessária para criação da boleta não foi informada, por favor informar dados faltantes e tentar novamente",
                        "ALGUM DADO NÃO FOI INFORMADO CORRETAMENTE!!!"
                    },
                });
            }
            else if (data.Dados_Solicitacao.Any(x => x.Movimento.Value == Movimento.ALTA && (x.HasLinha == false || x.Linha is null)))
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Não é possivel criar uma boleta com movimento de ALTA sem linha",
                    Succeeded = false,
                    Message = $"Não é possivel criar uma boleta com movimento de ALTA sem linha, por favor adicione uma linha.",
                    Errors = new string[]
                    {
                        $"Não é possivel criar uma boleta com movimento de ALTA sem linha, por favor adicione uma linha.",
                        "Não é possivel criar uma boleta com movimento de ALTA sem linha"
                    },
                });
            }

            try
            {
                var Pdv_Criador = CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == matricula).FirstOrDefault()?.PDV;
                var lastBoleta = CD.BOLETA_BD_PALITAGEMs.Where(x => x.PDV == Pdv_Criador).OrderBy(x => x.ID_BOLETA).LastOrDefault();
                var PrincipalData = CD.BOLETA_BD_PALITAGEMs.Add(new BOLETA_BD_PALITAGEM
                {
                    DATA_INICIO = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    MET_PAGAMENTO = (int)data.Met_Pagamento,
                    MAT_CONSULTOR = matricula,
                    TOTAL_PAGAMENTO = data.Total_Pagamento,
                    PDV = Pdv_Criador,
                    ID_BOLETA_PDV = lastBoleta is null ? 0 : lastBoleta.ID_BOLETA_PDV + 1,
                    STATUS = "BOLETA GERADA",

                }).Entity;

                CD.SaveChanges();

                CD.HISTORICO_BOLETA_BD_PALITAGEMs.Add(new HISTORICO_BOLETA_BD_PALITAGEM
                {
                    ID_BOLETA = PrincipalData.ID_BOLETA,
                    DATA = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    STATUS = "BOLETA GERADA",
                    MATRICULA = matricula,
                    RESPOSTA = "BOLETA ABERTA"
                });

                CD.BOLETA_BD_CLIENTEs.Add(new BOLETA_BD_CLIENTE
                {
                    CPF_CNPJ = data.Cliente.CPF_CNPJ,
                    ID_BOLETA = PrincipalData.ID_BOLETA,
                    NOME = data.Cliente.NOME,
                    TELEFONE = data.Cliente.TELEFONE,
                    SENHA_GSS = data.Cliente.SENHA_GSS
                });

                foreach (var item in data.Dados_Solicitacao)
                {
                    var DadosBlocao = CD.BOLETA_BD_BLOCAOs.Add(new BOLETA_BD_BLOCAO { ID_BOLETA = PrincipalData.ID_BOLETA }).Entity;
                    CD.SaveChanges();

                    if (item.SVA.Value)
                    {
                        if (item.Servicos_Atrelados is not null)
                        {
                            if (item.Servicos_Atrelados.Any())
                            {
                                foreach (var sva in item.Servicos_Atrelados)
                                {
                                    var DadosInfo = CD.BOLETA_BD_DADOs.Add(new BOLETA_BD_DADO
                                    {
                                        ID_BLOCAO_BOLETA = DadosBlocao.ID_BLOCAO_BOLETA,
                                        ID_BOLETA = PrincipalData.ID_BOLETA,
                                        CATEGORIA = item.Categoria is null ? "0" : ((int)item.Categoria).ToString(),
                                        MOVIMENTO = item.Movimento is null ? "0" : ((int)item.Movimento).ToString(),
                                        PORTABILIDADE = item.Portabilidade,
                                        FIDELIZACAO = item.Fidelizacao,
                                        PLANO = item.Plano is null ? "0" : ((int)item.Plano).ToString(),
                                        SVA = item.SVA,
                                        DESCRICAO = item.Descricao,
                                        PLATAFORMA = ((int)item.Plataforma).ToString()
                                    }).Entity;

                                    CD.SaveChanges();

                                    CD.BOLETA_BD_SVAs.Add(new BOLETA_BD_SVA
                                    {
                                        ID_DADOS_BOLETA = DadosInfo.ID_DADOS_BOLETA,
                                        NOME = ((int)sva.Nome).ToString(),
                                        VALOR = sva.Valor,
                                    });
                                }
                            }
                        }
                    }

                    if (item.HasEquipamento.Value)
                    {
                        if (item.boletaEquipamentos is not null)
                        {
                            if (item.boletaEquipamentos.Any())
                            {
                                foreach (var equip in item.boletaEquipamentos)
                                {
                                    var DadosInfo = CD.BOLETA_BD_DADOs.Add(new BOLETA_BD_DADO
                                    {
                                        ID_BLOCAO_BOLETA = DadosBlocao.ID_BLOCAO_BOLETA,
                                        ID_BOLETA = PrincipalData.ID_BOLETA,
                                        CATEGORIA = item.Categoria is null ? "0" : ((int)item.Categoria).ToString(),
                                        MOVIMENTO = item.Movimento is null ? "0" : ((int)item.Movimento).ToString(),
                                        PORTABILIDADE = item.Portabilidade,
                                        FIDELIZACAO = item.Fidelizacao,
                                        PLANO = item.Plano is null ? "0" : ((int)item.Plano).ToString(),
                                        SVA = item.SVA,
                                        DESCRICAO = item.Descricao,
                                        PLATAFORMA = ((int)item.Plataforma).ToString()
                                    }).Entity;

                                    CD.SaveChanges();

                                    CD.BOLETA_BD_EQUIPAMENTOs.Add(new BOLETA_BD_EQUIPAMENTO
                                    {
                                        ID_DADOS_BOLETA = DadosInfo.ID_DADOS_BOLETA,
                                        MODELO = equip.Modelo
                                    });
                                }
                            }
                        }
                    }

                    if (item.HasLinha.Value)
                    {
                        if (item.Linha is not null)
                        {
                            var DadosInfo = CD.BOLETA_BD_DADOs.Add(new BOLETA_BD_DADO
                            {
                                ID_BLOCAO_BOLETA = DadosBlocao.ID_BLOCAO_BOLETA,
                                ID_BOLETA = PrincipalData.ID_BOLETA,
                                CATEGORIA = item.Categoria is null ? "0" : ((int)item.Categoria).ToString(),
                                MOVIMENTO = item.Movimento is null ? "0" : ((int)item.Movimento).ToString(),
                                PORTABILIDADE = item.Portabilidade,
                                FIDELIZACAO = item.Fidelizacao,
                                PLANO = item.Plano is null ? "0" : ((int)item.Plano).ToString(),
                                SVA = item.SVA,
                                DESCRICAO = item.Descricao,
                                PLATAFORMA = ((int)item.Plataforma).ToString()
                            }).Entity;

                            CD.SaveChanges();

                            CD.BOLETA_BD_LINHAs.Add(new BOLETA_BD_LINHA
                            {
                                ID_DADOS_BOLETA = DadosInfo.ID_DADOS_BOLETA,
                                FATURAMENTO = item.Linha.Faturamento,
                                ICCID = item.Linha.ICCID,
                                MATERIAL = item.Linha.Material,
                                NOTA_FISCAL = item.Linha.NF,
                                NUMERO_LINHA = item.Linha.Numero_Linha,
                                NUMERO_PROVISORIO = item.Linha.Numero_Provisorio,
                                VALOR = item.Linha.Valor,
                                DATA_VENC_FAT = item.Linha.Data_Venc_Fat,
                                OPERA_DOA = item.Linha.Opera_doa
                            });
                        }
                    }
                }
                CD.SaveChanges();
                var newboleta = CD.BOLETA_BD_PALITAGEMs
                        .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                        .Include(x => x.BOLETA_BD_CLIENTEs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_LINHAs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_SVAs)
                        .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider) // Map to DTO
                        .FirstOrDefault(x => x.ID_BOLETA == PrincipalData.ID_BOLETA);

                _hubContext.Clients.Group(newboleta.MAT_CONSULTOR.PDV).SendAsync("NewNotification", newboleta.MAT_CONSULTOR.NOME, $"Boleta {PrincipalData.ID_BOLETA_PDV} Gerada",
                    $"Uma nova boleta acabou de ser gerada por {newboleta.MAT_CONSULTOR.NOME}, com o número {PrincipalData.ID_BOLETA_PDV}", $"/BoletaByID/{PrincipalData.ID_BOLETA}");

                _hubContext.Clients.Group(newboleta.MAT_CONSULTOR.PDV).SendAsync("SendNewBoletaToPdv", newboleta);
                //_hubContext.Clients.Group(id).SendAsync("SendNewBoletaToPdv", );

                return new JsonResult(new Response<int>
                {
                    Data = PrincipalData.ID_BOLETA,
                    Succeeded = true,
                    Message = $"a boleta foi criada com sucesso, N° {PrincipalData.ID_BOLETA_PDV}",
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

        [HttpPost("AprovarBoleta")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult AprovarBoleta([FromBody] BOLETA_PALITAGEM_DTO_Unvalidated data, string matricula, string message)
        {
            try
            {
                var boleta = CD.BOLETA_BD_PALITAGEMs.Find(data.ID_BOLETA);

                if (boleta.DT_PRIMEIRO_RETORNO is null)
                {
                    boleta.DT_PRIMEIRO_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.DT_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.MAT_ANALISTA = matricula;
                }
                else
                {
                    boleta.DT_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.MAT_ANALISTA = matricula;
                }

                boleta.MET_PAGAMENTO = (int)data.MET_PAGAMENTO;
                boleta.TOTAL_PAGAMENTO = data.TOTAL_PAGAMENTO;
                boleta.STATUS = "APROVADO";


                CD.HISTORICO_BOLETA_BD_PALITAGEMs.Add(new HISTORICO_BOLETA_BD_PALITAGEM
                {
                    ID_BOLETA = boleta.ID_BOLETA,
                    DATA = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    STATUS = "APROVADO",
                    MATRICULA = matricula,
                    RESPOSTA = message
                });

                var cliente = CD.BOLETA_BD_CLIENTEs.Find(data.BOLETA_BD_CLIENTEs.ID_CLIENTE_BOLETA);

                cliente.CPF_CNPJ = data.BOLETA_BD_CLIENTEs.CPF_CNPJ;
                cliente.ID_BOLETA = data.BOLETA_BD_CLIENTEs.ID_BOLETA;
                cliente.NOME = data.BOLETA_BD_CLIENTEs.NOME;
                cliente.TELEFONE = data.BOLETA_BD_CLIENTEs.TELEFONE;
                cliente.SENHA_GSS = data.BOLETA_BD_CLIENTEs.SENHA_GSS;

                foreach (var bloco in data.BOLETA_BD_BLOCAOs)
                {
                    foreach (var item in bloco.BOLETA_BD_DADOs)
                    {
                        var DadosInfo = CD.BOLETA_BD_DADOs.Find(item.ID_DADOS_BOLETA);

                        DadosInfo.ID_DADOS_BOLETA = data.ID_BOLETA;
                        DadosInfo.CATEGORIA = ((int)item.CATEGORIA).ToString();
                        DadosInfo.MOVIMENTO = ((int)item.MOVIMENTO).ToString();
                        DadosInfo.PORTABILIDADE = item.PORTABILIDADE;
                        DadosInfo.FIDELIZACAO = item.FIDELIZACAO;
                        DadosInfo.PLANO = ((int)item.PLANO).ToString();
                        DadosInfo.SVA = item.SVA;
                        DadosInfo.DESCRICAO = item.DESCRICAO;
                        DadosInfo.PLATAFORMA = ((int)item.PLATAFORMA).ToString();

                        CD.SaveChanges();
                        if (item.SVA.Value)
                        {
                            if (item.BOLETA_BD_SVAs is not null)
                            {
                                var svaAtual = CD.BOLETA_BD_SVAs.Find(item.BOLETA_BD_SVAs.ID_SVA_BOLETA);
                                svaAtual.NOME = ((int)item.BOLETA_BD_SVAs.NOME).ToString();
                                svaAtual.VALOR = item.BOLETA_BD_SVAs.VALOR;
                            }
                        }

                        if (item.BOLETA_BD_EQUIPAMENTOs is not null)
                        {
                            var equipAtual = CD.BOLETA_BD_EQUIPAMENTOs.Find(item.BOLETA_BD_EQUIPAMENTOs.ID_EQUIPAMENTO_BOLETA);
                            equipAtual.ID_DADOS_BOLETA = DadosInfo.ID_DADOS_BOLETA;
                            equipAtual.MATERIAL = item.BOLETA_BD_EQUIPAMENTOs.MATERIAL;
                            equipAtual.IMEI = item.BOLETA_BD_EQUIPAMENTOs.IMEI;
                            equipAtual.FATURAMENTO = item.BOLETA_BD_EQUIPAMENTOs.FATURAMENTO;
                            equipAtual.NOTA_FISCAL = item.BOLETA_BD_EQUIPAMENTOs.NOTA_FISCAL;
                            equipAtual.MODELO = item.BOLETA_BD_EQUIPAMENTOs.MODELO;
                            equipAtual.VALOR = item.BOLETA_BD_EQUIPAMENTOs.VALOR;
                        }

                        if (item.BOLETA_BD_LINHAs is not null)
                        {
                            var linhaAtual = CD.BOLETA_BD_LINHAs.Find(item.BOLETA_BD_LINHAs.ID_LINHA_BOLETA);

                            linhaAtual.ID_DADOS_BOLETA = DadosInfo.ID_DADOS_BOLETA;
                            linhaAtual.FATURAMENTO = item.BOLETA_BD_LINHAs.FATURAMENTO;
                            linhaAtual.ICCID = item.BOLETA_BD_LINHAs.ICCID;
                            linhaAtual.MATERIAL = item.BOLETA_BD_LINHAs.MATERIAL;
                            linhaAtual.NOTA_FISCAL = item.BOLETA_BD_LINHAs.NOTA_FISCAL;
                            linhaAtual.NUMERO_LINHA = item.BOLETA_BD_LINHAs.NUMERO_LINHA;
                            linhaAtual.NUMERO_PROVISORIO = item.BOLETA_BD_LINHAs.NUMERO_PROVISORIO;
                            linhaAtual.VALOR = item.BOLETA_BD_LINHAs.VALOR;
                        }
                    }
                }
                CD.SaveChanges();

                var newboleta = CD.BOLETA_BD_PALITAGEMs
                .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                .Include(x => x.BOLETA_BD_CLIENTEs)
                .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                        .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                        .ThenInclude(d => d.BOLETA_BD_LINHAs)
                .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                        .ThenInclude(d => d.BOLETA_BD_SVAs)
                .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider) // Map to DTO
                .FirstOrDefault(x => x.ID_BOLETA == data.ID_BOLETA);

                _hubContext.Clients.Group($"{newboleta.MAT_CONSULTOR.PDV}/{data.ID_BOLETA}").SendAsync("UpdateStatusBoleta", newboleta);

                return new JsonResult(new Response<string>
                {
                    Data = $"N° {data.ID_BOLETA}, a boleta foi atualizada com sucesso aguarde o retorno do analista!",
                    Succeeded = true,
                    Message = $"N° {data.ID_BOLETA}, a boleta foi atualizada com sucesso aguarde o retorno do analista!"
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

        [HttpPost("DevolverBoletaAnalista")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult DevolverBoletaAnalista([FromBody] BOLETA_PALITAGEM_DTO_Unvalidated data, string matricula, string message)
        {
            try
            {
                var boleta = CD.BOLETA_BD_PALITAGEMs.Find(data.ID_BOLETA);

                boleta.DT_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                boleta.MET_PAGAMENTO = (int)data.MET_PAGAMENTO;
                boleta.TOTAL_PAGAMENTO = data.TOTAL_PAGAMENTO;
                boleta.STATUS = "BOLETA FINALIZADA";


                CD.HISTORICO_BOLETA_BD_PALITAGEMs.Add(new HISTORICO_BOLETA_BD_PALITAGEM
                {
                    ID_BOLETA = boleta.ID_BOLETA,
                    DATA = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    STATUS = "BOLETA FINALIZADA",
                    MATRICULA = matricula,
                    RESPOSTA = message
                });

                var cliente = CD.BOLETA_BD_CLIENTEs.Find(data.BOLETA_BD_CLIENTEs.ID_CLIENTE_BOLETA);

                cliente.CPF_CNPJ = data.BOLETA_BD_CLIENTEs.CPF_CNPJ;
                cliente.ID_BOLETA = data.BOLETA_BD_CLIENTEs.ID_BOLETA;
                cliente.NOME = data.BOLETA_BD_CLIENTEs.NOME;
                cliente.TELEFONE = data.BOLETA_BD_CLIENTEs.TELEFONE;
                cliente.SENHA_GSS = data.BOLETA_BD_CLIENTEs.SENHA_GSS;

                foreach (var bloco in data.BOLETA_BD_BLOCAOs)
                {
                    foreach (var item in bloco.BOLETA_BD_DADOs)
                    {
                        var DadosInfo = CD.BOLETA_BD_DADOs.Find(item.ID_DADOS_BOLETA);

                        DadosInfo.ID_BOLETA = data.ID_BOLETA;
                        DadosInfo.CATEGORIA = ((int)item.CATEGORIA).ToString();
                        DadosInfo.MOVIMENTO = ((int)item.MOVIMENTO).ToString();
                        DadosInfo.PORTABILIDADE = item.PORTABILIDADE;
                        DadosInfo.FIDELIZACAO = item.FIDELIZACAO;
                        DadosInfo.PLANO = ((int)item.PLANO).ToString();
                        DadosInfo.SVA = item.SVA;
                        DadosInfo.DESCRICAO = item.DESCRICAO;
                        DadosInfo.PLATAFORMA = ((int)item.PLATAFORMA).ToString();

                        CD.SaveChanges();
                        if (item.SVA.Value)
                        {
                            if (item.BOLETA_BD_SVAs is not null)
                            {
                                if (item.BOLETA_BD_SVAs.ID_SVA_BOLETA > 0)
                                {
                                    var svaAtual = CD.BOLETA_BD_SVAs.Find(item.BOLETA_BD_SVAs.ID_SVA_BOLETA);
                                    svaAtual.NOME = ((int)item.BOLETA_BD_SVAs.NOME).ToString();
                                    svaAtual.VALOR = item.BOLETA_BD_SVAs.VALOR;
                                }
                                else
                                {
                                    CD.BOLETA_BD_SVAs.Add(new BOLETA_BD_SVA
                                    {
                                        ID_DADOS_BOLETA = DadosInfo.ID_DADOS_BOLETA,
                                        NOME = ((int)item.BOLETA_BD_SVAs.NOME).ToString(),
                                        VALOR = item.BOLETA_BD_SVAs.VALOR,
                                    });
                                }
                            }
                        }

                        if (item.BOLETA_BD_EQUIPAMENTOs is not null)
                        {
                            var equipAtual = CD.BOLETA_BD_EQUIPAMENTOs.Find(item.BOLETA_BD_EQUIPAMENTOs.ID_EQUIPAMENTO_BOLETA);
                            equipAtual.ID_DADOS_BOLETA = DadosInfo.ID_DADOS_BOLETA;
                            equipAtual.MATERIAL = item.BOLETA_BD_EQUIPAMENTOs.MATERIAL;
                            equipAtual.IMEI = item.BOLETA_BD_EQUIPAMENTOs.IMEI;
                            equipAtual.FATURAMENTO = item.BOLETA_BD_EQUIPAMENTOs.FATURAMENTO;
                            equipAtual.NOTA_FISCAL = item.BOLETA_BD_EQUIPAMENTOs.NOTA_FISCAL;
                            equipAtual.MODELO = item.BOLETA_BD_EQUIPAMENTOs.MODELO;
                            equipAtual.VALOR = item.BOLETA_BD_EQUIPAMENTOs.VALOR;
                        }

                        if (item.BOLETA_BD_LINHAs is not null)
                        {
                            var linhaAtual = CD.BOLETA_BD_LINHAs.Find(item.BOLETA_BD_LINHAs.ID_LINHA_BOLETA);

                            linhaAtual.ID_DADOS_BOLETA = DadosInfo.ID_DADOS_BOLETA;
                            linhaAtual.FATURAMENTO = item.BOLETA_BD_LINHAs.FATURAMENTO;
                            linhaAtual.ICCID = item.BOLETA_BD_LINHAs.ICCID;
                            linhaAtual.MATERIAL = item.BOLETA_BD_LINHAs.MATERIAL;
                            linhaAtual.NOTA_FISCAL = item.BOLETA_BD_LINHAs.NOTA_FISCAL;
                            linhaAtual.NUMERO_LINHA = item.BOLETA_BD_LINHAs.NUMERO_LINHA;
                            linhaAtual.NUMERO_PROVISORIO = item.BOLETA_BD_LINHAs.NUMERO_PROVISORIO;
                            linhaAtual.VALOR = item.BOLETA_BD_LINHAs.VALOR;
                            linhaAtual.DATA_VENC_FAT = item.BOLETA_BD_LINHAs.DATA_VENC_FAT;
                            linhaAtual.OPERA_DOA = item.BOLETA_BD_LINHAs.OPERA_DOA;

                        }
                    }
                }

                CD.SaveChanges();
                var newboleta = CD.BOLETA_BD_PALITAGEMs
                    .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                    .Include(x => x.BOLETA_BD_CLIENTEs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_LINHAs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_SVAs)
                    .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider) // Map to DTO
                    .FirstOrDefault(x => x.ID_BOLETA == data.ID_BOLETA);

                _hubContext.Clients.Group($"{newboleta.MAT_CONSULTOR.PDV}/{data.ID_BOLETA}").SendAsync("UpdateStatusBoleta", newboleta);

                return new JsonResult(new Response<string>
                {
                    Data = $"N° {data.ID_BOLETA}, a boleta foi finalizada com sucesso!",
                    Succeeded = true,
                    Message = $"N° {data.ID_BOLETA}, a boleta foi finalizada com sucesso!"
                });
                //return GetDadosBoletaByID(data.ID_BOLETA,
                //    $"N° {data.ID_BOLETA}, a boleta foi atualizada com sucesso aguarde o retorno do analista!");

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

        [HttpPost("DevolverBoletaConsultor")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult DevolverBoletaConsultor([FromBody] BOLETA_PALITAGEM_DTO_Unvalidated data, string message, string matricula, int idboleta)
        {
            try
            {
                var boleta = CD.BOLETA_BD_PALITAGEMs.Find(idboleta);

                boleta.STATUS = "DEVOLVIDO PARA O CONSULTOR";

                if (boleta.DT_PRIMEIRO_RETORNO is null)
                {
                    boleta.DT_PRIMEIRO_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.DT_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.MAT_ANALISTA = matricula;
                }
                else
                {
                    boleta.DT_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.MAT_ANALISTA = matricula;
                }

                CD.HISTORICO_BOLETA_BD_PALITAGEMs.Add(new HISTORICO_BOLETA_BD_PALITAGEM
                {
                    ID_BOLETA = idboleta,
                    DATA = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    STATUS = "DEVOLVIDO PARA O CONSULTOR",
                    MATRICULA = matricula,
                    RESPOSTA = message
                });

                foreach (var bloco in data.BOLETA_BD_BLOCAOs)
                {
                    foreach (var item in bloco.BOLETA_BD_DADOs)
                    {
                        var DadosInfo = CD.BOLETA_BD_DADOs.Find(item.ID_DADOS_BOLETA);

                        if (item.BOLETA_BD_EQUIPAMENTOs is not null)
                        {
                            var equipAtual = CD.BOLETA_BD_EQUIPAMENTOs.Find(item.BOLETA_BD_EQUIPAMENTOs.ID_EQUIPAMENTO_BOLETA);

                            equipAtual.MATERIAL = item.BOLETA_BD_EQUIPAMENTOs.MATERIAL;
                            equipAtual.IMEI = item.BOLETA_BD_EQUIPAMENTOs.IMEI;
                        }

                        if (item.BOLETA_BD_LINHAs is not null)
                        {
                            var linhaAtual = CD.BOLETA_BD_LINHAs.Find(item.BOLETA_BD_LINHAs.ID_LINHA_BOLETA);

                            linhaAtual.ICCID = item.BOLETA_BD_LINHAs.ICCID;
                            linhaAtual.MATERIAL = item.BOLETA_BD_LINHAs.MATERIAL;
                        }
                    }
                }

                CD.SaveChanges();

                var newboleta = CD.BOLETA_BD_PALITAGEMs
                    .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                    .Include(x => x.BOLETA_BD_CLIENTEs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_LINHAs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_SVAs)
                    .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider) // Map to DTO
                    .FirstOrDefault(x => x.ID_BOLETA == data.ID_BOLETA);

                _hubContext.Clients.Group($"{newboleta.MAT_CONSULTOR.PDV}/{data.ID_BOLETA}").SendAsync("UpdateStatusBoleta", newboleta);


                return new JsonResult(new Response<string>
                {
                    Data = $"N° {data.ID_BOLETA}, a boleta foi atualizada com sucesso aguarde o retorno do analista!",
                    Succeeded = true,
                    Message = $"N° {data.ID_BOLETA}, a boleta foi atualizada com sucesso aguarde o retorno do analista!"
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

        [HttpPost("ReprovarBoleta")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult ReprovarBoleta(string message, string matricula, int idboleta)
        {
            try
            {
                var boleta = CD.BOLETA_BD_PALITAGEMs.Find(idboleta);

                boleta.STATUS = "REPROVADO";

                if (boleta.DT_PRIMEIRO_RETORNO is null)
                {
                    boleta.DT_PRIMEIRO_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.DT_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.MAT_ANALISTA = matricula;
                }
                else
                {
                    boleta.DT_RETORNO = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    boleta.MAT_ANALISTA = matricula;
                }

                CD.HISTORICO_BOLETA_BD_PALITAGEMs.Add(new HISTORICO_BOLETA_BD_PALITAGEM
                {
                    ID_BOLETA = idboleta,
                    DATA = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    STATUS = "REPROVADO",
                    MATRICULA = matricula,
                    RESPOSTA = message
                });

                CD.SaveChanges();

                var newboleta = CD.BOLETA_BD_PALITAGEMs
                    .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                    .Include(x => x.BOLETA_BD_CLIENTEs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_LINHAs)
                    .Include(x => x.BOLETA_BD_BLOCAOs)
                    .ThenInclude(y => y.BOLETA_BD_DADOs)
                    .ThenInclude(d => d.BOLETA_BD_SVAs)
                    .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider) // Map to DTO
                    .FirstOrDefault(x => x.ID_BOLETA == idboleta);

                _hubContext.Clients.Group($"{newboleta.MAT_CONSULTOR.PDV}/{idboleta}").SendAsync("UpdateStatusBoleta", newboleta);


                return new JsonResult(new Response<string>
                {
                    Data = $"N° {idboleta}, a boleta foi atualizada com sucesso aguarde o retorno do analista!",
                    Succeeded = true,
                    Message = $"N° {idboleta}, a boleta foi atualizada com sucesso aguarde o retorno do analista!"
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

        [HttpPost("GetDadosBoleta")]
        [ProducesResponseType(typeof(Response<PagedModelResponse<IEnumerable<BOLETA_PALITAGEM_DTO>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDadosBoleta([FromBody] GenericPaginationModel<FilterBoletaModel> filter)
        {
            try
            {
                var boletas = CD.BOLETA_BD_PALITAGEMs
                        .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                        .Include(x => x.BOLETA_BD_CLIENTEs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_LINHAs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_SVAs)
                        .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider)
                        .AsEnumerable(); // Map to DTO

                if (filter.Value.IsAnalista)
                {
                    boletas = boletas.Where(x => x.PDV == filter.Value.PDV);
                }
                else
                {
                    boletas = boletas.Where(x => x.MAT_CONSULTOR.MATRICULA == filter.Value.matricula);
                }

                if (filter.Value.Status.Any())
                {
                    boletas = boletas.Where(x => filter.Value.Status.Contains(x.STATUS));
                }

                var Data = boletas.OrderBy(x => x.ID_BOLETA)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize);


                var totalRecords = boletas.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<BOLETA_PALITAGEM_DTO>>>
                {

                    Data = PagedResponse.CreatePagedReponse<BOLETA_PALITAGEM_DTO, FilterBoletaModel>(Data, filter, totalRecords),
                    Succeeded = true,
                    Message = $"Tudo certo!",
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

        [HttpPost("GetDadosDetalhadoBoleta")]
        [ProducesResponseType(typeof(Response<PagedModelResponse<IEnumerable<BOLETA_PALITAGEM_DTO>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDadosDetalhadoBoleta([FromBody] GenericPaginationModel<FilterDetalhadoBoletaModel> filter)
        {
            try
            {
                var Planos = CD.BOLETA_BD_PLANOs.ToList();
                var boletas = CD.BOLETA_BD_PALITAGEMs.AsNoTracking()
                        .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                        .Include(x => x.BOLETA_BD_CLIENTEs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_LINHAs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_SVAs)
                        .Where(x => x.PDV == filter.Value.PDV)
                        .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider)
                        .AsEnumerable(); // Map to DTO

                if (filter.Value.mes is not null)
                {
                    boletas = boletas.AsEnumerable().Where(x => filter.Value.mes == x.DATA_INICIO.Month);

                    if (filter.Value.dia is not null)
                    {
                        boletas = boletas.AsEnumerable().Where(x => filter.Value.dia == x.DATA_INICIO.Day);
                    }
                }

                if (filter.Value.ano is not null)
                {
                    boletas = boletas.AsEnumerable().Where(x => filter.Value.ano == x.DATA_INICIO.Year);
                }

                if (filter.Value.ID_BOLETA.Any())// ✅
                {
                    boletas = boletas.Where(x => filter.Value.ID_BOLETA.Select(x => int.Parse(x)).Contains(x.ID_BOLETA_PDV));
                }

                if (filter.Value.MAT_CONSULTOR.Any())// ✅
                {
                    boletas = boletas.Where(x => filter.Value.MAT_CONSULTOR.Contains(x.MAT_CONSULTOR.MATRICULA));
                }
                if (filter.Value.STATUS.Any())// ✅
                {
                    boletas = boletas.Where(x => filter.Value.STATUS.Contains(x.STATUS));
                }
                if (filter.Value.MAT_ANALISTA.Any())// ✅
                {
                    boletas = boletas.Where(x => filter.Value.MAT_ANALISTA.Contains(x.MAT_ANALISTA));
                }

                if (filter.Value.PLATAFORMA.Any())// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado => filter.Value.PLATAFORMA.Contains(dado.PLATAFORMA))
                            )
                    );
                }

                if (filter.Value.MOVIMENTO.Any())// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado => filter.Value.MOVIMENTO.Contains(dado.MOVIMENTO))
                            )
                    );
                }

                if (filter.Value.CATEGORIA.Any())// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado => filter.Value.CATEGORIA.Contains(dado.CATEGORIA))
                            )
                    );
                }

                if (filter.Value.FATURAMENTO != string.Empty)
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs
                            .Any(dado => dado.BOLETA_BD_EQUIPAMENTOs != null
                                && dado.BOLETA_BD_EQUIPAMENTOs.FATURAMENTO != null
                                && dado.BOLETA_BD_EQUIPAMENTOs.FATURAMENTO.ToLower() == filter.Value.FATURAMENTO.ToLower())));
                }
                if (filter.Value.NOTA_FISCAL != string.Empty)
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs
                            .Any(dado => dado.BOLETA_BD_EQUIPAMENTOs != null
                                && dado.BOLETA_BD_EQUIPAMENTOs.NOTA_FISCAL != null
                                && dado.BOLETA_BD_EQUIPAMENTOs.NOTA_FISCAL.ToLower() == filter.Value.NOTA_FISCAL.ToLower())));
                }

                if (filter.Value.MATERIAL != string.Empty)
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                        b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                        blocao.BOLETA_BD_DADOs
                        .Any(dado => dado.BOLETA_BD_EQUIPAMENTOs != null
                        && dado.BOLETA_BD_EQUIPAMENTOs.MATERIAL != null
                        && dado.BOLETA_BD_EQUIPAMENTOs.MATERIAL.ToLower() == filter.Value.MATERIAL.ToLower())));
                }

                if (filter.Value.IMEI.Any())
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado =>
                            dado.BOLETA_BD_EQUIPAMENTOs != null
                            && dado.BOLETA_BD_EQUIPAMENTOs.IMEI != null
                            && filter.Value.IMEI.Select(x => x.ToString().ToLower())
                            .Contains(dado.BOLETA_BD_EQUIPAMENTOs.IMEI.ToLower()))
                            )
                            );
                }

                if (filter.Value.NOME_CLIENTE.Any())// ✅
                {
                    boletas = boletas.Where(b => filter.Value.NOME_CLIENTE.Select(x => x.ToLower()).Contains(b.BOLETA_BD_CLIENTEs.NOME.ToLower()));
                }
                if (filter.Value.CPF_CLIENTE.Any())// ✅
                {
                    boletas = boletas.Where(b => filter.Value.CPF_CLIENTE.Select(x => RemoveNonNumericCharacters(x)).Contains(RemoveNonNumericCharacters(b.BOLETA_BD_CLIENTEs.CPF_CNPJ)));
                }
                if (filter.Value.TELEFONE_CLIENTE.Any())// ✅
                {
                    boletas = boletas.Where(b => filter.Value.TELEFONE_CLIENTE.Select(x => RemoveNonNumericCharacters(x)).Contains(RemoveNonNumericCharacters(b.BOLETA_BD_CLIENTEs.TELEFONE)));
                }
                if (filter.Value.TIPO_CLIENTE != string.Empty) // ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                             blocao.BOLETA_BD_DADOs.Any(dado =>
                                    Planos
                                    .Where(x => x.ID_PLANO == (int)dado.PLATAFORMA)
                                    .Any(x => x.TP_Cliente == filter.Value.TIPO_CLIENTE)
                            ))
                    );
                }
                if (filter.Value.PLANO.Any())
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado =>
                                    filter.Value.PLANO.Contains(dado.PLANO)
                            ))
                    );
                }

                if (filter.Value.ORIGEM != string.Empty) // ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado =>
                                    Planos
                                    .Where(x => x.ID_PLANO == (int)dado.PLATAFORMA)
                                    .Any(x => x.Origem == filter.Value.ORIGEM)
                            ))
                    );
                }

                if (filter.Value.PORTABILIDADE)// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Select(dado => dado.PORTABILIDADE).Contains(filter.Value.PORTABILIDADE)));
                }
                if (filter.Value.FIDELIZACAO)// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Select(dado => dado.FIDELIZACAO).Contains(filter.Value.FIDELIZACAO)));
                }

                if (filter.Value.DATA_INICIO.Any()) // ✅
                {
                    if (filter.Value.DATA_INICIO.Count == 2)
                    {
                        boletas = boletas.AsEnumerable().Where(x => filter.Value.DATA_INICIO[0] < x.DATA_INICIO && filter.Value.DATA_INICIO[1] > x.DATA_INICIO);
                    }
                }
                if (filter.Value.DATA_PRIMEIRA_ABERTURA.Any()) // ✅
                {
                    if (filter.Value.DATA_PRIMEIRA_ABERTURA.Count == 2)
                    {
                        boletas = boletas.AsEnumerable().Where(x => filter.Value.DATA_PRIMEIRA_ABERTURA[0] < x.DT_PRIMEIRO_RETORNO && filter.Value.DATA_PRIMEIRA_ABERTURA[1] > x.DT_PRIMEIRO_RETORNO);
                    }
                }
                if (filter.Value.DATA_RETORNO.Any()) // ✅
                {
                    if (filter.Value.DATA_RETORNO.Count == 2)
                    {
                        boletas = boletas.AsEnumerable().Where(x => filter.Value.DATA_RETORNO[0] < x.DT_RETORNO && filter.Value.DATA_RETORNO[1] > x.DT_RETORNO);
                    }
                }

                filter.PageSize = boletas.Count();

                var Data = boletas.OrderBy(x => x.ID_BOLETA)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize);


                var totalRecords = boletas.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<BOLETA_PALITAGEM_DTO>>>
                {
                    Data = PagedResponse.CreatePagedReponse<BOLETA_PALITAGEM_DTO, FilterDetalhadoBoletaModel>(Data, filter, totalRecords),
                    Succeeded = true,
                    Message = $"Tudo certo!",
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

        [HttpPost("GetExcelDadosDetalhadoBoleta")]
        [ProducesResponseType(typeof(Response<FileContentResult>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<IActionResult> GetExcelDadosDetalhadoBoleta([FromBody] GenericPaginationModel<FilterDetalhadoBoletaModel> filter)
        {
            try
            {
                var Planos = CD.BOLETA_BD_PLANOs.ToList();
                var boletas = CD.BOLETA_BD_PALITAGEMs.AsNoTracking()
                        .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                        .Include(x => x.BOLETA_BD_CLIENTEs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_LINHAs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_SVAs)
                        .Where(x => x.PDV == filter.Value.PDV)
                        .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider)
                        .AsEnumerable(); // Map to DTO

                if (filter.Value.mes is not null)
                {
                    boletas = boletas.AsEnumerable().Where(x => filter.Value.mes == x.DATA_INICIO.Month);

                    if (filter.Value.dia is not null)
                    {
                        boletas = boletas.AsEnumerable().Where(x => filter.Value.dia == x.DATA_INICIO.Day);
                    }
                }

                if (filter.Value.ano is not null)
                {
                    boletas = boletas.AsEnumerable().Where(x => filter.Value.ano == x.DATA_INICIO.Year);
                }

                if (filter.Value.ID_BOLETA.Any())// ✅
                {
                    boletas = boletas.Where(x => filter.Value.ID_BOLETA.Select(x => int.Parse(x)).Contains(x.ID_BOLETA_PDV));
                }

                if (filter.Value.MAT_CONSULTOR.Any())// ✅
                {
                    boletas = boletas.Where(x => filter.Value.MAT_CONSULTOR.Contains(x.MAT_CONSULTOR.MATRICULA));
                }
                if (filter.Value.STATUS.Any())// ✅
                {
                    boletas = boletas.Where(x => filter.Value.STATUS.Contains(x.STATUS));
                }
                if (filter.Value.MAT_ANALISTA.Any())// ✅
                {
                    boletas = boletas.Where(x => filter.Value.MAT_ANALISTA.Contains(x.MAT_ANALISTA));
                }

                if (filter.Value.PLATAFORMA.Any())// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado => filter.Value.PLATAFORMA.Contains(dado.PLATAFORMA))
                            )
                    );
                }

                if (filter.Value.MOVIMENTO.Any())// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado => filter.Value.MOVIMENTO.Contains(dado.MOVIMENTO))
                            )
                    );
                }

                if (filter.Value.CATEGORIA.Any())// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado => filter.Value.CATEGORIA.Contains(dado.CATEGORIA))
                            )
                    );
                }

                if (filter.Value.FATURAMENTO != string.Empty)
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs
                            .Any(dado => dado.BOLETA_BD_EQUIPAMENTOs != null
                                && dado.BOLETA_BD_EQUIPAMENTOs.FATURAMENTO != null
                                && dado.BOLETA_BD_EQUIPAMENTOs.FATURAMENTO.ToLower() == filter.Value.FATURAMENTO.ToLower())));
                }
                if (filter.Value.NOTA_FISCAL != string.Empty)
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs
                            .Any(dado => dado.BOLETA_BD_EQUIPAMENTOs != null
                                && dado.BOLETA_BD_EQUIPAMENTOs.NOTA_FISCAL != null
                                && dado.BOLETA_BD_EQUIPAMENTOs.NOTA_FISCAL.ToLower() == filter.Value.NOTA_FISCAL.ToLower())));
                }

                if (filter.Value.MATERIAL != string.Empty)
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                        b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                        blocao.BOLETA_BD_DADOs
                        .Any(dado => dado.BOLETA_BD_EQUIPAMENTOs != null
                        && dado.BOLETA_BD_EQUIPAMENTOs.MATERIAL != null
                        && dado.BOLETA_BD_EQUIPAMENTOs.MATERIAL.ToLower() == filter.Value.MATERIAL.ToLower())));
                }

                if (filter.Value.IMEI.Any())
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado =>
                            dado.BOLETA_BD_EQUIPAMENTOs != null
                            && dado.BOLETA_BD_EQUIPAMENTOs.IMEI != null
                            && filter.Value.IMEI.Select(x => x.ToString().ToLower())
                            .Contains(dado.BOLETA_BD_EQUIPAMENTOs.IMEI.ToLower()))
                            )
                            );
                }

                if (filter.Value.NOME_CLIENTE.Any())// ✅
                {
                    boletas = boletas.Where(b => filter.Value.NOME_CLIENTE.Select(x => x.ToLower()).Contains(b.BOLETA_BD_CLIENTEs.NOME.ToLower()));
                }
                if (filter.Value.CPF_CLIENTE.Any())// ✅
                {
                    boletas = boletas.Where(b => filter.Value.CPF_CLIENTE.Select(x => RemoveNonNumericCharacters(x)).Contains(RemoveNonNumericCharacters(b.BOLETA_BD_CLIENTEs.CPF_CNPJ)));
                }
                if (filter.Value.TELEFONE_CLIENTE.Any())// ✅
                {
                    boletas = boletas.Where(b => filter.Value.TELEFONE_CLIENTE.Select(x => RemoveNonNumericCharacters(x)).Contains(RemoveNonNumericCharacters(b.BOLETA_BD_CLIENTEs.TELEFONE)));
                }
                if (filter.Value.TIPO_CLIENTE != string.Empty) // ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                             blocao.BOLETA_BD_DADOs.Any(dado =>
                                    Planos
                                    .Where(x => x.ID_PLANO == (int)dado.PLATAFORMA)
                                    .Any(x => x.TP_Cliente == filter.Value.TIPO_CLIENTE)
                            ))
                    );
                }
                if (filter.Value.PLANO.Any())
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado =>
                                    filter.Value.PLANO.Contains(dado.PLANO)
                            ))
                    );
                }

                if (filter.Value.ORIGEM != string.Empty) // ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Any(dado =>
                                    Planos
                                    .Where(x => x.ID_PLANO == (int)dado.PLATAFORMA)
                                    .Any(x => x.Origem == filter.Value.ORIGEM)
                            ))
                    );
                }

                if (filter.Value.PORTABILIDADE)// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Select(dado => dado.PORTABILIDADE).Contains(filter.Value.PORTABILIDADE)));
                }
                if (filter.Value.FIDELIZACAO)// ✅
                {
                    boletas = boletas.Where(b => b.BOLETA_BD_BLOCAOs != null &&
                            b.BOLETA_BD_BLOCAOs.Any(blocao => blocao.BOLETA_BD_DADOs != null &&
                            blocao.BOLETA_BD_DADOs.Select(dado => dado.FIDELIZACAO).Contains(filter.Value.FIDELIZACAO)));
                }

                if (filter.Value.DATA_INICIO.Any()) // ✅
                {
                    if (filter.Value.DATA_INICIO.Count == 2)
                    {
                        boletas = boletas.AsEnumerable().Where(x => filter.Value.DATA_INICIO[0] < x.DATA_INICIO && filter.Value.DATA_INICIO[1] > x.DATA_INICIO);
                    }
                }
                if (filter.Value.DATA_PRIMEIRA_ABERTURA.Any()) // ✅
                {
                    if (filter.Value.DATA_PRIMEIRA_ABERTURA.Count == 2)
                    {
                        boletas = boletas.AsEnumerable().Where(x => filter.Value.DATA_PRIMEIRA_ABERTURA[0] < x.DT_PRIMEIRO_RETORNO && filter.Value.DATA_PRIMEIRA_ABERTURA[1] > x.DT_PRIMEIRO_RETORNO);
                    }
                }
                if (filter.Value.DATA_RETORNO.Any()) // ✅
                {
                    if (filter.Value.DATA_RETORNO.Count == 2)
                    {
                        boletas = boletas.AsEnumerable().Where(x => filter.Value.DATA_RETORNO[0] < x.DT_RETORNO && filter.Value.DATA_RETORNO[1] > x.DT_RETORNO);
                    }
                }

                string templatepath = Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates//ExcelBoletaModel.html");
                string htmldata = System.IO.File.ReadAllText(templatepath);

                var excelstring = new System.Text.StringBuilder();

                foreach (BOLETA_PALITAGEM_DTO blocao in boletas)
                {
                    foreach (var venda in blocao.BOLETA_BD_BLOCAOs)
                    {
                        foreach (var boleta in venda.BOLETA_BD_DADOs)
                        {
                            excelstring.Append("<tr>");
                            excelstring.Append($"<td>{blocao.DATA_INICIO} </td>");
                            excelstring.Append($"<td>{blocao.BOLETA_BD_CLIENTEs?.NOME}</td>");
                            excelstring.Append($"<td>{blocao.BOLETA_BD_CLIENTEs?.CPF_CNPJ}</td>");
                            excelstring.Append($"<td>{blocao.BOLETA_BD_CLIENTEs?.TELEFONE}</td>");
                            excelstring.Append($"<td>{blocao.BOLETA_BD_BLOCAOs.Count}</td>");
                            excelstring.Append($"<td>{blocao.STATUS}</td> ");
                            excelstring.Append($"<td>{blocao.MAT_CONSULTOR?.MATRICULA}</td>");
                            excelstring.Append($"<td>{blocao.MAT_ANALISTA ?? "-"}</td>");
                            excelstring.Append($"<td>{boleta.MOVIMENTO.GetDisplayName()}</td>");
                            excelstring.Append($"<td>{boleta.PLANO.GetDisplayName()}</td>");
                            excelstring.Append($"<td>{boleta.BOLETA_BD_LINHAs?.NUMERO_LINHA}</td>");
                            excelstring.Append($"<td>{boleta.BOLETA_BD_LINHAs?.ICCID}</td>");
                            excelstring.Append($"<td>{boleta.BOLETA_BD_LINHAs?.VALOR}</td>");
                            excelstring.Append($"<td>{boleta.BOLETA_BD_EQUIPAMENTOs?.IMEI}</td>");
                            excelstring.Append($"<td>{blocao.TOTAL_PAGAMENTO}</td>");
                            excelstring.Append("</tr>");
                        }
                    }
                }
                htmldata = htmldata.Replace("@@ActualData", excelstring.ToString());
                string StoredFilePath = Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates", "BoletaDowloaded.xls");
                if (System.IO.File.Exists(StoredFilePath))
                {
                    System.IO.File.Delete(StoredFilePath);
                }
                System.IO.File.AppendAllText(StoredFilePath, htmldata);

                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(StoredFilePath, out var contentType))
                {
                    contentType = "application/octet-stream";
                }

                var bytes = await System.IO.File.ReadAllBytesAsync(StoredFilePath);

                return new JsonResult(new Response<FileContentResult>
                {
                    Data = File(bytes, contentType, Path.Combine(StoredFilePath)),
                    Succeeded = true,
                    Message = "Tudo certo, o Excel foi gerado corretamente"
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

        [HttpGet("GetDadosBoletaByID")]
        [ProducesResponseType(typeof(Response<BOLETA_PALITAGEM_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDadosBoletaByID(int ID_BOLETA, string? message = $"Tudo certo!")
        {
            try
            {
                var boleta = CD.BOLETA_BD_PALITAGEMs
                        .Include(x => x.HISTORICO_BOLETA_BD_PALITAGEMs)
                        .Include(x => x.BOLETA_BD_CLIENTEs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_EQUIPAMENTOs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_LINHAs)
                        .Include(x => x.BOLETA_BD_BLOCAOs)
                            .ThenInclude(y => y.BOLETA_BD_DADOs)
                                .ThenInclude(d => d.BOLETA_BD_SVAs)
                        .ProjectTo<BOLETA_PALITAGEM_DTO>(_mapper.ConfigurationProvider) // Map to DTO
                        .FirstOrDefault(x => x.ID_BOLETA == ID_BOLETA);

                return new JsonResult(new Response<BOLETA_PALITAGEM_DTO>
                {
                    Data = boleta,
                    Succeeded = true,
                    Message = message,
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

        [HttpGet("GetBoletaCategorias")]
        [ProducesResponseType(typeof(Response<IEnumerable<BOLETA_CATEGORIA_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetBoletaCategorias()
        {
            try
            {
                var boleta = CD.BOLETA_BD_CATEGORIAs
                    .ProjectTo<BOLETA_CATEGORIA_DTO>(_mapper.ConfigurationProvider)
                    .AsQueryable();

                return new JsonResult(new Response<IEnumerable<BOLETA_CATEGORIA_DTO>>
                {
                    Data = boleta,
                    Succeeded = true,
                    Message = "Tudo Certo!",
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

        [HttpGet("GetBoletaMovimento")]
        [ProducesResponseType(typeof(Response<IEnumerable<BOLETA_MOVIMENTO_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetBoletaMovimento()
        {
            try
            {
                var boleta = CD.BOLETA_BD_MOVIMENTOs
                    .ProjectTo<BOLETA_MOVIMENTO_DTO>(_mapper.ConfigurationProvider)
                    .AsQueryable();

                return new JsonResult(new Response<IEnumerable<BOLETA_MOVIMENTO_DTO>>
                {
                    Data = boleta,
                    Succeeded = true,
                    Message = "Tudo Certo!",
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

        [HttpGet("GetBoletaPlano")]
        [ProducesResponseType(typeof(Response<IEnumerable<BOLETA_PLANO_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetBoletaPlano()
        {
            try
            {
                var boleta = CD.BOLETA_BD_PLANOs
                    .ProjectTo<BOLETA_PLANO_DTO>(_mapper.ConfigurationProvider)
                    .AsQueryable();

                return new JsonResult(new Response<IEnumerable<BOLETA_PLANO_DTO>>
                {
                    Data = boleta,
                    Succeeded = true,
                    Message = "Tudo Certo!",
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
