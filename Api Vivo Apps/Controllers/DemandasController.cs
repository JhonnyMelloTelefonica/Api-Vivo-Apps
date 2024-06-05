using Newtonsoft.Json;
using Vivo_Apps_API.Models;
using Vivo_Apps_API.Hubs;
using Microsoft.AspNetCore.Mvc;
using Shared_Static_Class.Data;
using Shared_Static_Class.Model_DTO;
using Shared_Static_Class.Converters;
using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using AutoMapper.QueryableExtensions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using Shared_Static_Class.Enums;
using System.Data;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.IO.Compression;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.InkML;
using System.Net;
using DocumentFormat.OpenXml.Drawing;
using System.Net.Http;
using System.Text;
using Blazorise;
using static Shared_Static_Class.Data.DEMANDA_RELACAO_CHAMADO;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.Build.Framework;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemandasController : ControllerBase
    {
        private readonly ILogger<DemandasController> _logger;
        private readonly IMapper _mapper;
        private readonly ISuporteDemandaHub _hubContext;
        private readonly IOutputCacheStore _cache;
        private static Vivo_MaisContext CD;
        private static HttpClient _httpclient;
        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext Demanda_BD;
        public DemandasController(
            ILogger<DemandasController> logger
            , ISuporteDemandaHub hubContext
            , Vivo_MaisContext bd_context
            , IDbContextFactory<DemandasContext> dbContextFactory
            , HttpClient httpclient
            , IOutputCacheStore cache)
        {
            _cache = cache;
            _httpclient = httpclient;
            DbFactory = dbContextFactory;
            Demanda_BD = DbFactory.CreateDbContext();
            CD = bd_context;
            _hubContext = hubContext;
            _logger = logger;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DEMANDA_RELACAO_CHAMADO, DEMANDA_DTO>();
                cfg.CreateMap<DEMANDA_TIPO_FILA, DEMANDA_TIPO_FILA_DTO>();
                cfg.CreateMap<DEMANDA_SUB_FILA, PAINEL_DEMANDA_SUB_FILA_DTO>();
                cfg.CreateMap<DEMANDA_SUB_FILA, DEMANDA_SUB_FILA_DTO>()
                .ForMember(
                    dest => dest.Responsaveis,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE.Where(y =>
                        Demanda_BD.DEMANDA_RESPONSAVEL_FILA
                                .Where(x => x.ID_SUB_FILA == src.ID_SUB_FILA)
                                .Select(x => x.MATRICULA_RESPONSAVEL)
                                .Distinct()
                                .Contains(y.MATRICULA)))
                    );
                cfg.CreateMap<DEMANDA_CAMPOS_FILA, DEMANDA_CAMPOS_FILA_DTO>();

                cfg.CreateMap<DEMANDA_VALORES_CAMPOS_SUSPENSO, DEMANDA_VALORES_CAMPOS_SUSPENSO_DTO>();

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


                cfg.CreateMap<DEMANDA_BD_OPERADORE, DEMANDA_BD_OPERADORES_DTO>()
                .ForMember(
                    dest => dest.MATRICULA,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs
                                .Where(x => x.MATRICULA == src.MATRICULA)
                                .FirstOrDefault()))
                .ForMember(
                    dest => dest.MATRICULA_MOD,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs
                                .Where(x => x.MATRICULA == src.MATRICULA_MOD)
                                .FirstOrDefault())
                    );

                cfg.CreateMap<DEMANDA_CHAMADO, PAINEL_DEMANDAS_CHAMADO_DTO>()
                .ForMember(
                    dest => dest.Respostas,
                    opt => opt.MapFrom(src => src.Relacao.Respostas)
                    );

                cfg.CreateMap<DEMANDA_CHAMADO, DEMANDAS_CHAMADO_DTO>()
                .ForMember(
                    dest => dest.Respostas,
                    opt => opt.MapFrom(src => src.Relacao.Respostas)
                    );

                cfg.CreateMap<DEMANDA_ACESSOS, ACESSO_TERCEIROS_DTO>()
                .ForMember(
                    dest => dest.Respostas,
                    opt => opt.MapFrom(src => src.Relacao.Respostas)
                    );

                cfg.CreateMap<DEMANDA_DESLIGAMENTOS, DESLIGAMENTO_DTO>()
                .ForMember(
                    dest => dest.Respostas,
                    opt => opt.MapFrom(src => src.Relacao.Respostas)
                    )
                .ForMember(
                    dest => dest.Solicitante,
                    opt => opt.MapFrom(src => src.Relacao.Solicitante)
                    );

                cfg.CreateMap<DEMANDA_CHAMADO_RESPOSTA, DEMANDA_CHAMADO_RESPOSTA_DTO>();
                cfg.CreateMap<DEMANDA_ARQUIVOS_RESPOSTA, DEMANDA_ARQUIVOS_RESPOSTA_DTO>()
                .ForMember(
                    dest => dest.ARQUIVO,
                    opt => opt.MapFrom(src => ConvertFile(src.ARQUIVO))
                    );

                cfg.CreateMap<DEMANDA_STATUS_CHAMADO, DEMANDA_STATUS_CHAMADO_DTO>()
                .ForMember(
                    dest => dest.Quem_redirecionou,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE.First(x => x.MATRICULA == src.MAT_QUEM_REDIRECIONOU))
                    )
                .ForMember(
                    dest => dest.Para_Quem_redirecionou,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE.First(x => x.MATRICULA == src.MAT_DESTINATARIO))
                    );

            });
            _mapper = config.CreateMapper();
        }


        [HttpGet("GetFilesMenssageChamado/{IdResposta}")]
        [ProducesResponseType(typeof(Response<IEnumerable<DEMANDA_ARQUIVOS_RESPOSTA>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetFilesMenssageChamado(int IdResposta)
        {
            try
            {
                var Arquivos = Demanda_BD.DEMANDA_ARQUIVOS_RESPOSTA.Where(x=> x.ID_RESPOSTA == IdResposta);

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(Arquivos, options);

            }
            catch (Exception ex)
            {
                return new JsonResult(new DEMANDA_ARQUIVOS_RESPOSTA[0]);
            }
        }

        [HttpGet("GetAnalistasByRegional")]
        [ProducesResponseType(typeof(Response<IEnumerable<ACESSOS_MOBILE_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetAnalistasByRegional(string regional)
        {
            try
            {
                var AnalistaSuporte = CD.ACESSOS_MOBILEs.Where(x =>
                    CD.DEMANDA_BD_OPERADOREs.Where(y => y.REGIONAL == regional)
                    .Select(x => x.MATRICULA)
                    .Distinct().Contains(x.MATRICULA)
                ).IgnoreAutoIncludes()
                .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider).ToList();

                return new JsonResult(new Response<IEnumerable<ACESSOS_MOBILE_DTO>>
                {
                    Data = AnalistaSuporte,
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpPost("AddNewFila")]
        [ProducesResponseType(typeof(Response<int>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult AddNewFila([FromBody] DEMANDA_TIPO_FILA_DTO data, int matricula, string regional)
        {
            try
            {
                var NewFila = CD.DEMANDA_TIPO_FILAs.Add(new DEMANDA_TIPO_FILA
                {
                    DT_CRIACAO = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    MAT_CRIADOR = matricula,
                    NOME_TIPO_FILA = data.NOME_TIPO_FILA,
                    REGIONAL = regional,
                    STATUS_TIPO_FILA = true,
                    DESCRICAO = data.DESCRICAO
                }).Entity;

                CD.SaveChanges();
                if (data.DEMANDA_SUB_FILAs.Any())
                {
                    foreach (var sub_fila in data.DEMANDA_SUB_FILAs)
                    {
                        var NewSubFila = CD.DEMANDA_SUB_FILAs.Add(new DEMANDA_SUB_FILA
                        {
                            CAMPOS_AUTO = sub_fila.CAMPOS_AUTO,
                            CAMPOS_IDENT_USER = sub_fila.CAMPOS_IDENT_USER,
                            DATA_CRIACAO = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                            ID_ANTIGO = null,
                            ID_TIPO_FILA = NewFila.ID_TIPO_FILA,
                            MAT_CRIADOR = matricula,
                            NOME_SUB_FILA = sub_fila.NOME_SUB_FILA,
                            DESCRICAO = sub_fila.DESCRICAO,
                            REGIONAL = regional,
                            STATUS_SUB_FILA = true,
                            SLA = sub_fila.SLA
                        }).Entity;

                        CD.SaveChanges();

                        if (sub_fila.DEMANDA_CAMPOS_FILAs.Any())
                        {
                            foreach (var campo in sub_fila.DEMANDA_CAMPOS_FILAs)
                            {
                                var NewCampo = CD.DEMANDA_CAMPOS_FILAs.Add(new DEMANDA_CAMPOS_FILA
                                {
                                    CAMPO = campo.CAMPO,
                                    CAMPO_SUSPENSO = campo.CAMPO_SUSPENSO,
                                    DT_CRIACAO = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                                    ID_SUB_FILA = NewSubFila.ID_SUB_FILA,
                                    MASCARA = campo.CAMPO_SUSPENSO == true ? "" : campo.MASCARA,
                                    MAT_CRIADOR = matricula,
                                    REGIONAL = regional,
                                    STATUS_CAMPOS_FILA = true,
                                }).Entity;

                                CD.SaveChanges();

                                if (campo.CAMPO_SUSPENSO)
                                {
                                    if (campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Any())
                                    {
                                        foreach (var valorescampo in campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs)
                                        {
                                            CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Add(new DEMANDA_VALORES_CAMPOS_SUSPENSO
                                            {
                                                ID_CAMPOS = NewCampo.ID_CAMPOS,
                                                VALOR = valorescampo.VALOR
                                            });
                                        }
                                    }
                                    CD.SaveChanges();

                                }
                            }
                        }
                        if (sub_fila.Responsaveis is not null)
                        {
                            if (sub_fila.Responsaveis.Any())
                            {
                                foreach (var resp in sub_fila.Responsaveis)
                                {
                                    CD.DEMANDA_RESPONSAVEL_FILAs.Add(new DEMANDA_RESPONSAVEL_FILA
                                    {
                                        ID_SUB_FILA = NewSubFila.ID_SUB_FILA,
                                        MATRICULA_RESPONSAVEL = resp.MATRICULA
                                    });
                                }
                            }
                            CD.SaveChanges();
                        }
                    }
                }

                return new JsonResult(new Response<int>
                {
                    Data = NewFila.ID_TIPO_FILA,
                    Succeeded = true,
                    Message = "Nova fila criada com sucesso, o sistema já irá disponibiliza-la para o público correspondente",
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

        [HttpPost("AddNewSubFila")]
        [ProducesResponseType(typeof(Response<int>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult AddNewSubFila([FromBody] DEMANDA_TIPO_FILA_DTO data, int matricula, string regional)
        {
            try
            {
                var NewFila = CD.DEMANDA_TIPO_FILAs.Find(data.ID_TIPO_FILA);

                CD.SaveChanges();
                if (data.DEMANDA_SUB_FILAs.Any())
                {
                    foreach (var sub_fila in data.DEMANDA_SUB_FILAs)
                    {
                        var NewSubFila = CD.DEMANDA_SUB_FILAs.Add(new DEMANDA_SUB_FILA
                        {
                            CAMPOS_AUTO = sub_fila.CAMPOS_AUTO,
                            CAMPOS_IDENT_USER = sub_fila.CAMPOS_IDENT_USER,
                            DATA_CRIACAO = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                            ID_ANTIGO = null,
                            ID_TIPO_FILA = NewFila.ID_TIPO_FILA,
                            MAT_CRIADOR = matricula,
                            NOME_SUB_FILA = sub_fila.NOME_SUB_FILA,
                            REGIONAL = regional,
                            DESCRICAO = sub_fila.DESCRICAO,
                            STATUS_SUB_FILA = true,
                            SLA = sub_fila.SLA
                        }).Entity;

                        CD.SaveChanges();

                        if (sub_fila.DEMANDA_CAMPOS_FILAs.Any())
                        {
                            foreach (var campo in sub_fila.DEMANDA_CAMPOS_FILAs)
                            {
                                var NewCampo = CD.DEMANDA_CAMPOS_FILAs.Add(new DEMANDA_CAMPOS_FILA
                                {
                                    CAMPO = campo.CAMPO,
                                    CAMPO_SUSPENSO = campo.CAMPO_SUSPENSO,
                                    DT_CRIACAO = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                                    ID_SUB_FILA = NewSubFila.ID_SUB_FILA,
                                    MASCARA = campo.CAMPO_SUSPENSO == true ? "" : campo.MASCARA,
                                    MAT_CRIADOR = matricula,
                                    REGIONAL = regional,
                                    STATUS_CAMPOS_FILA = true,
                                }).Entity;

                                CD.SaveChanges();

                                if (campo.CAMPO_SUSPENSO)
                                {
                                    if (campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Any())
                                    {
                                        foreach (var valorescampo in campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs)
                                        {
                                            CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Add(new DEMANDA_VALORES_CAMPOS_SUSPENSO
                                            {
                                                ID_CAMPOS = NewCampo.ID_CAMPOS,
                                                VALOR = valorescampo.VALOR
                                            });
                                        }
                                    }

                                    CD.SaveChanges();

                                }
                            }
                        }

                        if (sub_fila.Responsaveis is not null)
                        {
                            if (sub_fila.Responsaveis.Any())
                            {
                                foreach (var resp in sub_fila.Responsaveis)
                                {
                                    CD.DEMANDA_RESPONSAVEL_FILAs.Add(new DEMANDA_RESPONSAVEL_FILA
                                    {
                                        ID_SUB_FILA = NewSubFila.ID_SUB_FILA,
                                        MATRICULA_RESPONSAVEL = resp.MATRICULA
                                    });
                                }
                            }

                            CD.SaveChanges();

                        }
                    }
                }

                return new JsonResult(new Response<int>
                {
                    Data = NewFila.ID_TIPO_FILA,
                    Succeeded = true,
                    Message = "Nova(s) sub-fila(s) criada com sucesso, o sistema já irá disponibiliza-la para o público correspondente",
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

        [HttpPost("EditSubFila")]
        [ProducesResponseType(typeof(Response<int>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult EditSubFila([FromBody] DEMANDA_SUB_FILA_DTO data, int matricula, string regional)
        {
            try
            {
                var NewSubFila = CD.DEMANDA_SUB_FILAs.Find(data.ID_SUB_FILA);

                NewSubFila.CAMPOS_AUTO = data.CAMPOS_AUTO;
                NewSubFila.CAMPOS_IDENT_USER = data.CAMPOS_IDENT_USER;
                NewSubFila.NOME_SUB_FILA = data.NOME_SUB_FILA;
                NewSubFila.DESCRICAO = data.DESCRICAO;
                NewSubFila.SLA = data.SLA;
                //NewSubFila.STATUS_SUB_FILA = true;

                CD.SaveChanges();

                if (data.DEMANDA_CAMPOS_FILAs.Any())
                {
                    List<string> camposAntigos = CD.DEMANDA_CAMPOS_FILAs.Where(x => x.ID_SUB_FILA == data.ID_SUB_FILA).Select(x => x.CAMPO).ToList();

                    if (data.DEMANDA_CAMPOS_FILAs.Count > camposAntigos.Count)
                    {
                        foreach (var campo in data.DEMANDA_CAMPOS_FILAs)
                        {
                            if (!camposAntigos.Any(x => x == campo.CAMPO))
                            {
                                var NewCampo = CD.DEMANDA_CAMPOS_FILAs.Add(new DEMANDA_CAMPOS_FILA
                                {
                                    CAMPO = campo.CAMPO,
                                    CAMPO_SUSPENSO = campo.CAMPO_SUSPENSO,
                                    DT_CRIACAO = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                                    ID_SUB_FILA = NewSubFila.ID_SUB_FILA,
                                    MASCARA = campo.CAMPO_SUSPENSO == true ? "" : campo.MASCARA,
                                    MAT_CRIADOR = matricula,
                                    REGIONAL = regional,
                                    STATUS_CAMPOS_FILA = true,
                                }).Entity;

                                if (campo.CAMPO_SUSPENSO)
                                {
                                    if (campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Any())
                                    {
                                        foreach (var valorescampo in campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs)
                                        {
                                            CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Add(new DEMANDA_VALORES_CAMPOS_SUSPENSO
                                            {
                                                ID_CAMPOS = NewCampo.ID_CAMPOS,
                                                VALOR = valorescampo.VALOR
                                            });
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (data.DEMANDA_CAMPOS_FILAs.Count < camposAntigos.Count)
                    {
                        foreach (var valorescampo in camposAntigos)
                        {
                            if (!data.DEMANDA_CAMPOS_FILAs.Any(x => x.CAMPO == valorescampo))
                            {
                                var campo = CD.DEMANDA_CAMPOS_FILAs.Where(x =>
                                    x.ID_SUB_FILA == data.ID_SUB_FILA && x.CAMPO == valorescampo).First();

                                campo.STATUS_CAMPOS_FILA = false;

                                if (campo.CAMPO_SUSPENSO)
                                {
                                    var camposus = CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Where(x =>
                                        x.ID_CAMPOS == campo.ID_CAMPOS);

                                    camposus.ExecuteUpdate(x => x.SetProperty(y => y.STATUS, y => false));

                                    //CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.RemoveRange(camposus);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var campo in data.DEMANDA_CAMPOS_FILAs)
                        {
                            var campofrombanco = CD.DEMANDA_CAMPOS_FILAs
                                .Find(campo.ID_CAMPOS);

                            campofrombanco.CAMPO = campo.CAMPO;
                            campofrombanco.MASCARA = campo.GetMascara();
                            campofrombanco.CAMPO_SUSPENSO = campo.CAMPO_SUSPENSO;
                            campofrombanco.STATUS_CAMPOS_FILA = campo.STATUS_CAMPOS_FILA;

                            if (campo.CAMPO_SUSPENSO)
                            {
                                var NewCampo = CD.DEMANDA_CAMPOS_FILAs.Find(campo.ID_CAMPOS);
                                if (NewCampo is not null)
                                {
                                    if (campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Any())
                                    {
                                        List<string> camposSusAntigos = CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Where(x => x.ID_CAMPOS == campo.ID_CAMPOS).Select(x => x.VALOR).ToList();

                                        if (campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Count > camposSusAntigos.Count)
                                        {
                                            foreach (var valorescampo in campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs)
                                            {
                                                if (!camposSusAntigos.Any(x => x == valorescampo.VALOR))
                                                {
                                                    CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Add(new DEMANDA_VALORES_CAMPOS_SUSPENSO
                                                    {
                                                        ID_CAMPOS = NewCampo.ID_CAMPOS,
                                                        VALOR = valorescampo.VALOR
                                                    });
                                                }
                                            }
                                        }
                                        else if (campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Count < camposSusAntigos.Count)
                                        {
                                            foreach (var valorescampo in camposSusAntigos)
                                            {
                                                if (!campo.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Any(x => x.VALOR == valorescampo))
                                                {
                                                    var camposus = CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Where(x =>
                                                        x.ID_CAMPOS == NewCampo.ID_CAMPOS && x.VALOR == valorescampo).First();
                                                    camposus.STATUS = false;
                                                    //CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Remove(camposus);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    CD.SaveChanges();
                }

                if (data.Responsaveis is not null)
                {
                    if (data.Responsaveis.Any())
                    {
                        List<int> listaOperadores = CD.DEMANDA_RESPONSAVEL_FILAs.Where(x =>
                            x.ID_SUB_FILA == data.ID_SUB_FILA).Select(x => x.MATRICULA_RESPONSAVEL.Value).ToList();
                        // Buscando todas os responsaveis que já existe dentro da fila
                        if (data.Responsaveis.Count() > listaOperadores.Count) // Usuário adicionado
                        {
                            foreach (var resp in data.Responsaveis)
                            {
                                if (!listaOperadores.Any(x => x == resp.MATRICULA))
                                {
                                    CD.DEMANDA_RESPONSAVEL_FILAs.Add(new DEMANDA_RESPONSAVEL_FILA
                                    {
                                        ID_SUB_FILA = data.ID_SUB_FILA,
                                        MATRICULA_RESPONSAVEL = resp.MATRICULA
                                    });
                                }
                            }
                        }
                        else if (data.Responsaveis.Count() < listaOperadores.Count) // Usuário Excluido
                        {
                            foreach (var resp in listaOperadores)
                            {
                                if (!data.Responsaveis.Any(x => x.MATRICULA == resp))
                                {
                                    var usuario = CD.DEMANDA_RESPONSAVEL_FILAs.Where(x =>
                                        x.ID_SUB_FILA == data.ID_SUB_FILA
                                        && x.MATRICULA_RESPONSAVEL == resp).First();

                                    CD.DEMANDA_RESPONSAVEL_FILAs.Remove(usuario);
                                }
                            }
                        }

                    }
                    CD.SaveChanges();
                }

                return new JsonResult(new Response<int>
                {
                    Data = data.ID_TIPO_FILA,
                    Succeeded = true,
                    Message = "A sub-fila foi alterada com sucesso, o sistema já irá disponibiliza-la para o público correspondente",
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

        [HttpGet("AtivarFilaById")]
        [ProducesResponseType(typeof(Response<DEMANDA_SUB_FILA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult AtivarFilaById(int id)
        {
            try
            {
                var fila = CD.DEMANDA_SUB_FILAs.Find(id);
                if (fila is not null)
                {
                    fila.STATUS_SUB_FILA = true;
                    var resultado = CD.SaveChanges();
                    return new JsonResult(new Response<bool>
                    {
                        Data = resultado > 0 ? true : false,
                        Succeeded = true,
                        Message = $"A fila {fila.NOME_SUB_FILA} foi ativada com sucesso!"
                    });
                }
                else
                {
                    return new JsonResult(new Response<bool>
                    {
                        Data = false,
                        Succeeded = true,
                        Message = "Houve algum erro, não foi possivél encontrar esta fila",
                        Errors = new string[]
                        {
                            "Houve algum erro, não foi possivél encontrar esta fila"
                        }
                    });
                }
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

        [HttpGet("InativarFilaById")]
        [ProducesResponseType(typeof(Response<DEMANDA_SUB_FILA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult InativarFilaById(int id)
        {
            try
            {
                var fila = CD.DEMANDA_SUB_FILAs.Find(id);
                if (fila is not null)
                {
                    fila.STATUS_SUB_FILA = false;
                    var resultado = CD.SaveChanges();
                    return new JsonResult(new Response<bool>
                    {
                        Data = resultado > 0 ? true : false,
                        Succeeded = true,
                        Message = $"A fila {fila.NOME_SUB_FILA} foi inativada com sucesso!"
                    });
                }
                else
                {
                    return new JsonResult(new Response<bool>
                    {
                        Data = false,
                        Succeeded = true,
                        Message = "Houve algum erro, não foi possivél encontrar esta fila",
                        Errors = new string[]
                        {
                            "Houve algum erro, não foi possivél encontrar esta fila"
                        }
                    });
                }
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

        [HttpGet("GetSubFilaById")]
        [ProducesResponseType(typeof(Response<DEMANDA_SUB_FILA_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetSubFilaById(int id)
        {
            try
            {
                var fila = Demanda_BD.DEMANDA_SUB_FILA.Where(x => x.ID_SUB_FILA == id)
                        .ProjectTo<DEMANDA_SUB_FILA_DTO>(_mapper.ConfigurationProvider).FirstOrDefault();

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(new Response<DEMANDA_SUB_FILA_DTO>
                {
                    Data = fila,
                    Succeeded = true,
                    Message = "",
                    Errors = null,
                }, options);
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

        [HttpPost("GetFilaDemandasList")]
        [ProducesResponseType(typeof(Response<PagedModelResponse<IEnumerable<DEMANDA_SUB_FILA>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetFilaDemandasList([FromBody] GenericPaginationModel<PaginationFilaDemandasModel> filter)
        {
            try
            {
                var dataBeforeFilter = CD.DEMANDA_SUB_FILAs.AsQueryable();
                //if (!string.IsNullOrEmpty(filter.Value.matricula))
                //{
                //    dataBeforeFilter = dataBeforeFilter.Where(x => x.MATRICULA_SOLICITANTE == filter.Value.matricula);
                //}

                if (filter.Value.regional is not null)
                {
                    if (filter.Value.regional.Any())
                    {
                        dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.regional.Contains(x.REGIONAL));
                    }
                }

                if (filter.Value.tipo_fila is not null)
                {
                    if (filter.Value.tipo_fila.Any())
                    {
                        List<int> tipo_fila = filter.Value.tipo_fila.Select(x => x.ID_TIPO_FILA).ToList();

                        dataBeforeFilter = dataBeforeFilter.Where(k =>
                            tipo_fila.Contains(k.ID_TIPO_FILA));

                        if (filter.Value.fila is not null)
                        {
                            if (filter.Value.fila.Any())
                            {
                                List<int> sub_fila = filter.Value.fila.Select(x => x.ID_SUB_FILA).ToList();

                                dataBeforeFilter = dataBeforeFilter.Where(k => sub_fila.Contains(k.ID_SUB_FILA));
                            }
                        }
                    }
                }

                if (filter.Value.responsável is not null)
                {
                    if (filter.Value.responsável.Any())
                    {
                        dataBeforeFilter = dataBeforeFilter.Where(k =>
                            CD.DEMANDA_RESPONSAVEL_FILAs
                                .Where(postAndMeta => filter.Value.responsável
                                        .Select(x => x.MATRICULA)
                                        .Contains(postAndMeta.MATRICULA_RESPONSAVEL.Value))
                                .Select(l => l.ID_SUB_FILA).Contains(k.ID_SUB_FILA)
                        );
                    }
                }

                var dataAfterFilter = dataBeforeFilter.OrderByDescending(x => x.ID_SUB_FILA)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize);

                var demandas = dataAfterFilter.AsNoTracking().ToList();

                var totalRecords = dataBeforeFilter.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<DEMANDA_SUB_FILA>>>
                {
                    Data = PagedResponse.CreatePagedReponse<DEMANDA_SUB_FILA, PaginationFilaDemandasModel>(demandas, filter, totalRecords),
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

        [HttpGet("GetFiltersFilas")]
        [ProducesResponseType(typeof(Response<FilterFilaDemandasModel>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetFiltersFilas(string regional)
        {
            try
            {
                var datafilters = new FilterFilaDemandasModel();

                datafilters.filas = Demanda_BD.DEMANDA_TIPO_FILA
                    .Where(x => x.REGIONAL == regional)
                    .ProjectTo<DEMANDA_TIPO_FILA_DTO>(_mapper.ConfigurationProvider);

                datafilters.AnalistaSuporte = Demanda_BD.ACESSOS_MOBILE.Where(x =>
                    Demanda_BD.DEMANDA_RESPONSAVEL_FILA
                            .Select(x => x.MATRICULA_RESPONSAVEL)
                            .Distinct().Contains(x.MATRICULA)
                ).ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider);

                return new JsonResult(new Response<FilterFilaDemandasModel>
                {
                    Data = datafilters,
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpGet("GetFiltersDemandas")]
        public JsonResult GetFiltersDemandas(string regional)
        {
            try
            {
                var fila = Demanda_BD.DEMANDA_TIPO_FILA.Where(x => x.REGIONAL == regional).IgnoreAutoIncludes()
                    .ProjectTo<DEMANDA_TIPO_FILA_DTO>(_mapper.ConfigurationProvider).AsEnumerable();

                var analistassuporte = Demanda_BD.ACESSOS_MOBILE.Where(k => k.REGIONAL == regional).Where(k =>
                            Demanda_BD.DEMANDA_RESPONSAVEL_FILA.Select(x => x.MATRICULA_RESPONSAVEL).Distinct().Contains(k.MATRICULA)
                        ).IgnoreAutoIncludes().ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider).AsEnumerable();

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(new Response<FilterFilaDemandasModel>
                {
                    Data = new FilterFilaDemandasModel
                    {
                        filas = fila,
                        AnalistaSuporte = analistassuporte
                    },
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                }, options);
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpGet("GetFilas")]
        [ProducesResponseType(typeof(Response<IEnumerable<DEMANDA_TIPO_FILA_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetFilas()
        {
            try
            {
                var Dados_Fila = Demanda_BD.DEMANDA_TIPO_FILA
                    .ProjectTo<DEMANDA_TIPO_FILA_DTO>(_mapper.ConfigurationProvider)
                    .AsEnumerable();

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(new Response<IEnumerable<DEMANDA_TIPO_FILA_DTO>>
                {
                    Data = Dados_Fila,
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                }, options);
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpGet("GetDadosFilaByID")]
        [ProducesResponseType(typeof(Response<DATA_CRIAR_DEMANDA>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDadosFilaByID()
        {
            try
            {
                var Carteira = CD.Carteira_NEs.Where(x => x.ANOMES == CD.Carteira_NEs.Max(y => y.ANOMES));
                var Sap = CD.CNS_BASE_TERCEIROS_SAP_GTs.AsQueryable();

                return new JsonResult(new Response<DATA_CRIAR_DEMANDA>
                {
                    Data = new DATA_CRIAR_DEMANDA
                    {
                        Carteira = Carteira,
                        Sap = Sap
                    },
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpPost("InsertRespostaChangeStatus")]
        [ProducesResponseType(typeof(Response<object>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> InsertRespostaChangeStatus([FromBody] RespostaDemandaModel data, Tabela_Demanda tabela)
        {
            try
            {
                var retorno = Demanda_BD.DEMANDA_CHAMADO_RESPOSTA.Add(new DEMANDA_CHAMADO_RESPOSTA
                {
                    RESPOSTA = data.resposta,
                    ID_CHAMADO = data.IdChamado,
                    ID_RELACAO = data.ID_RELACAO,
                    MATRICULA_RESPONSAVEL = data.MATRICULA,
                    DATA_RESPOSTA = data.Data,
                    Status = new DEMANDA_STATUS_CHAMADO
                    {
                        ID_CHAMADO = data.IdChamado,
                        ID_RELACAO = data.ID_RELACAO,
                        STATUS = data.Status,
                        DATA = data.Data,
                        MAT_QUEM_REDIRECIONOU = data.MATRICULA,
                        MAT_DESTINATARIO = data.MATRICULA_REDIRECIONADO
                    },
                    ARQUIVOS = data.Arquivos.Any() ? data.Arquivos.Select(x => new DEMANDA_ARQUIVOS_RESPOSTA
                    {
                        NOME_CAMPO = x.FileName.Split('.')[0],
                        ARQUIVO = x.Bytes,
                        EXT_ARQUIVO = x.Extensao,
                    }).ToList() : null
                });

                //Demanda_BD.SaveChanges();
                Demanda_BD.SaveChanges();

                //Demanda_BD.DEMANDA_STATUS_CHAMADO.Add(new DEMANDA_STATUS_CHAMADO
                //{
                //    ID_CHAMADO = data.IdChamado,
                //    STATUS = data.Status,
                //    DATA = data.Data,
                //    MAT_QUEM_REDIRECIONOU = data.MATRICULA,
                //    MAT_DESTINATARIO = data.MATRICULA_REDIRECIONADO,
                //    ID_RESPOSTA = retorno.ID
                //});

                var chamado_relacao = Demanda_BD.DEMANDA_RELACAO_CHAMADO.Find(data.ID_RELACAO);
                object demanda = null;

                switch (tabela)
                {
                    case Tabela_Demanda.ChamadoRelacao:
                        var chamado = Demanda_BD.DEMANDA_CHAMADO.Find(data.IdChamado);

                        if (data.MATRICULA_REDIRECIONADO.HasValue)
                        {
                            chamado.MATRICULA_RESPONSAVEL = data.MATRICULA_REDIRECIONADO;
                            chamado_relacao.MATRICULA_RESPONSAVEL = data.MATRICULA_REDIRECIONADO;
                        }

                        if (data.Status == STATUS_ACESSOS_PENDENTES.APROVADO.Value)
                        {
                            chamado.DATA_FECHAMENTO = DateTime.Now;
                        }
                        else if (data.Status == STATUS_ACESSOS_PENDENTES.REABRIR.Value)
                        {
                            chamado.DATA_FECHAMENTO = null;
                        }
                        demanda = GetDemandaByID(data.IdChamado);
                        Task.Run(() => _hubContext.UpdateDemanda(demanda as DEMANDAS_CHAMADO_DTO));
                        break;
                    case Tabela_Demanda.AcessoRelacao:
                        demanda = GetAcessoByID(data.IdChamado);
                        break;
                    case Tabela_Demanda.DesligamentoRelacao:
                        demanda = GetDesligamentoByID(data.IdChamado);
                        break;
                    default:
                        demanda = null;
                        break;
                }

                await _cache.EvictByTagAsync("AllDemandas", default);
                await _hubContext.SendTableDemandas();

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(new Response<object>
                {
                    Data = demanda,
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                }, options);
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao Executar ação",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao Executar ação"
                });
            }
        }

        [HttpPost("InsertResposta")]
        [ProducesResponseType(typeof(Response<object>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> InsertResposta([FromBody] RespostaDemandaModel data, Tabela_Demanda tabela)
        {
            try
            {
                var retorno = Demanda_BD.DEMANDA_CHAMADO_RESPOSTA.Add(new DEMANDA_CHAMADO_RESPOSTA
                {
                    RESPOSTA = data.resposta,
                    ID_CHAMADO = data.IdChamado,
                    MATRICULA_RESPONSAVEL = data.MATRICULA,
                    ID_RELACAO = data.ID_RELACAO,
                    DATA_RESPOSTA = data.Data,
                    Status = null,
                    ARQUIVOS = data.Arquivos.Any() ? data.Arquivos.Select(x => new DEMANDA_ARQUIVOS_RESPOSTA
                    {
                        NOME_CAMPO = x.FileName.Split('.')[0],
                        ARQUIVO = x.Bytes,
                        EXT_ARQUIVO = x.Extensao,
                    }).ToList() : null
                });

                Demanda_BD.SaveChanges();
                await _cache.EvictByTagAsync("AllDemandas", default);
                await _hubContext.SendTableDemandas();
                object demanda;
                switch (tabela)
                {
                    case Tabela_Demanda.ChamadoRelacao:
                        demanda = GetDemandaByID(data.IdChamado);
                        Task.Run(() => _hubContext.UpdateDemanda(demanda as DEMANDAS_CHAMADO_DTO));
                        break;
                    case Tabela_Demanda.AcessoRelacao:
                        demanda = GetAcessoByID(data.IdChamado);
                        break;
                    case Tabela_Demanda.DesligamentoRelacao:
                        demanda = GetDesligamentoByID(data.IdChamado);
                        break;
                    default:
                        demanda = null;
                        break;
                }

                return new JsonResult(new Response<object>
                {
                    Data = demanda,
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                }
                , new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao Executar ação",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
    },
                    Message = "Erro ao Executar ação"
                });
            }
        }

        [HttpPost("AbrirDemanda")]
        [ProducesResponseType(typeof(Response<ACESSOS_MOBILE_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> AbrirDemanda([FromBody] DEMANDAS_FILA data)
        {
            try
            {
                var fila = Demanda_BD.DEMANDA_SUB_FILA.Include(x => x.DEMANDA_RESPONSAVEL_FILAs).First(x => x.ID_SUB_FILA == data.FILA_DTO.ID_SUB_FILA);
                int responsavel;

                if (fila.DEMANDA_RESPONSAVEL_FILAs.Count > 1)
                {
                    List<(int, int)> saida = new();

                    foreach (var item in fila.DEMANDA_RESPONSAVEL_FILAs)
                    {
                        saida.Add((Demanda_BD.DEMANDA_CHAMADO.Count(x => x.MATRICULA_RESPONSAVEL == item.MATRICULA_RESPONSAVEL.Value), item.MATRICULA_RESPONSAVEL.Value));
                    }

                    responsavel = saida.MinBy(x => x.Item1).Item2;
                }
                else
                {
                    responsavel = fila.DEMANDA_RESPONSAVEL_FILAs.First().MATRICULA_RESPONSAVEL.Value;
                }
                var demanda = new DEMANDA_RELACAO_CHAMADO
                {
                    Sequence = Demanda_BD.DEMANDA_RELACAO_CHAMADO.Count() + 1,
                    Tabela = DEMANDA_RELACAO_CHAMADO.Tabela_Demanda.ChamadoRelacao,
                    DATA_ABERTURA = DateTime.Now,
                    PRIORIDADE = false,
                    PRIORIDADE_SEGMENTO = false,
                    MATRICULA_SOLICITANTE = int.Parse(data.MAT_SOLICITANTE),
                    MATRICULA_RESPONSAVEL = responsavel,
                    ChamadoRelacao = new DEMANDA_CHAMADO
                    {
                        ID_FILA_CHAMADO = data.FILA_DTO.ID_SUB_FILA,
                        MATRICULA_RESPONSAVEL = responsavel,
                        MATRICULA_SOLICITANTE = int.Parse(data.MAT_SOLICITANTE),
                        DATA_ABERTURA = DateTime.Now,
                        DATA_FECHAMENTO = null,
                        REGIONAL = data.REGIONAL,
                        CLIENTE_ALTO_VALOR = null,
                        Campos = data.CAMPOS.Select(campo => new DEMANDA_CAMPOS_CHAMADO
                        {
                            VALOR = campo.RESPOSTA,
                            CAMPO = campo.CAMPO
                        }).ToList(),
                    }
                };

                /*var demanda = new DEMANDA_CHAMADO
                {
                    ID_FILA_CHAMADO = data.FILA_DTO.ID_SUB_FILA,
                    MATRICULA_RESPONSAVEL = responsavel,
                    MATRICULA_SOLICITANTE = int.Parse(data.MAT_SOLICITANTE),
                    DATA_ABERTURA = DateTime.Now,
                    DATA_FECHAMENTO = null,
                    PRIORIDADE = "BAIXA",
                    REGIONAL = data.REGIONAL,
                    CLIENTE_ALTO_VALOR = null,
                    Respostas = new List<DEMANDA_CHAMADO_RESPOSTA>
                    {
                        new DEMANDA_CHAMADO_RESPOSTA
                        {
                            RESPOSTA = data.PROBLEMA,
                            MATRICULA_RESPONSAVEL = int.Parse(data.MAT_SOLICITANTE),
                            DATA_RESPOSTA = DateTime.Now,
                            ARQUIVOS = data.Arquivos.Select(x => new DEMANDA_ARQUIVOS_RESPOSTA
                            {
                                NOME_CAMPO = x.FileName.Split('.')[0],
                                ARQUIVO = x.Bytes,
                                EXT_ARQUIVO = x.FileName.Split('.')[1]
                            }).ToList()
                        }
                    },
                    Campos = data.CAMPOS.Select(campo => new DEMANDA_CAMPOS_CHAMADO
                    {
                        VALOR = campo.RESPOSTA,
                        CAMPO = campo.CAMPO
                    }).ToList(),
                };*/

                Demanda_BD.DEMANDA_RELACAO_CHAMADO.Add(demanda);

                await Demanda_BD.SaveChangesAsync();
                demanda.ID_CHAMADO = demanda.ChamadoRelacao.ID;
                demanda.Respostas.Add(new DEMANDA_CHAMADO_RESPOSTA
                {
                    ID_RELACAO = demanda.ID_RELACAO,
                    ID_CHAMADO = demanda.ChamadoRelacao.ID,
                    RESPOSTA = data.PROBLEMA,
                    MATRICULA_RESPONSAVEL = int.Parse(data.MAT_SOLICITANTE),
                    DATA_RESPOSTA = DateTime.Now,
                    ARQUIVOS = data.Arquivos.Select(x => new DEMANDA_ARQUIVOS_RESPOSTA
                    {
                        NOME_CAMPO = x.FileName.Split('.')[0],
                        ARQUIVO = x.Bytes,
                        EXT_ARQUIVO = x.FileName.Split('.')[1]
                    }).ToList()
                }
                    );
                await Demanda_BD.SaveChangesAsync();

                demanda.Status.Add(new DEMANDA_STATUS_CHAMADO
                {
                    ID_CHAMADO = demanda.ChamadoRelacao.ID,
                    STATUS = "ABERTO",
                    ID_RESPOSTA = demanda.Respostas.First().ID,
                    DATA = DateTime.Now
                });

                await Demanda_BD.SaveChangesAsync();

                var retorno = Demanda_BD.ACESSOS_MOBILE
                    .Where(x => x.MATRICULA == demanda.ChamadoRelacao.MATRICULA_RESPONSAVEL)
                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                    .First();

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                await _cache.EvictByTagAsync("AllDemandas", default);
                await _hubContext.SendTableDemandas();
                await _hubContext.NewNotificationByUser(responsavel, demanda.ChamadoRelacao);
                await _hubContext.NewNotificationByUser(int.Parse(data.MAT_SOLICITANTE), demanda.ChamadoRelacao);

                var demandaCompleta = GetDemandaByID(demanda.ChamadoRelacao.ID);

                /*string jsonContent = JsonConvert.SerializeObject(new
                {
                    matricula = demandaCompleta.Solicitante.MATRICULA,
                    link = $"/consultar/consultardemandasbyid/{demandaCompleta.ID}",
                    descricaolink = "link para demanda",
                    matriculaanalista = retorno.MATRICULA,
                    matriculasolicitante = demandaCompleta.Solicitante.MATRICULA,
                    emailanalista = retorno.EMAIL,
                    emailsolicitante = demandaCompleta.Solicitante.EMAIL,
                    detalhes = "Apenas uma solicitação de avaliação via TEAMS"
                }, Formatting.Indented);

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = 
                    await _httpclient.PostAsync("https://prod-188.westeurope.logic.azure.com:443/workflows/540ad6ef9e2e4d8692e84d4a313cfb81/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=PhKC8KY0im_9hJdWPAczoj99UBvho4gaRovaDo2ZaII"
                    , content);*/

                return new JsonResult(new Response<dynamic>
                {
                    Data = new
                    {
                        responsavel = retorno,
                        demanda = demandaCompleta,
                        relacao = demanda
                    },
                    Succeeded = true,
                    Message = $"Tudo certo!",
                    Errors = null,
                }, options);
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = $"500 -> {ex.Message} ---------------------- {ex.ToString()}",
                    Succeeded = false,
                    Message = $"Algum erro ocorreu!",
                    Errors = null,
                });
            }
        }

        [HttpPost("GetDemandasList")]
        [ProducesResponseType(typeof(Response<PagedModelResponse<IEnumerable<PAINEL_DEMANDAS_CHAMADO_DTO>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDemandasList([FromBody] GenericPaginationModel<PaginationDemandasModel> filter)
        {
            try
            {
                if (!filter.Value.IsRealTime)
                {
                    var dataBeforeFilter = CD.CONTROLE_DE_DEMANDAS_CHAMADOs.AsQueryable();

                    if (filter.Value.matricula != 0)
                    {
                        dataBeforeFilter = dataBeforeFilter.Where(x => x.MATRICULA_SOLICITANTE == filter.Value.matricula.ToString());
                    }

                    if (filter.Value.datas is not null)
                    {
                        if (filter.Value.datas.Count() == 2)
                        {
                            dataBeforeFilter = dataBeforeFilter.Where(x => x.DATA_ABERTURA >= filter.Value.datas[0] &&
                            x.DATA_ABERTURA <= filter.Value.datas[1]);
                        }
                    }

                    if (filter.Value.regional is not null)
                    {

                        if (filter.Value.regional.Any())
                        {
                            dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.regional.Contains(x.REGIONAL));
                        }
                    }

                    if (filter.Value.status is not null)
                    {
                        if (filter.Value.status.Any())
                        {
                            dataBeforeFilter = dataBeforeFilter
                                        .Where(c => filter.Value.status.Contains(
                                            CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
                                                .Where(s => s.ID_STATUS_CHAMADO == c.ID_STATUS_CHAMADO)
                                                .OrderByDescending(s => s.DATA)
                                                .Select(s => s.STATUS)
                                                .FirstOrDefault()));
                        }
                    }

                    if (filter.Value.tipo_fila is not null)
                    {
                        if (filter.Value.tipo_fila.Any())
                        {
                            dataBeforeFilter = dataBeforeFilter.Where(k =>
                                CD.CONTROLE_DE_DEMANDAS_FILAs
                                    .Where(postAndMeta => filter.Value.tipo_fila.Select(x => x.TIPO_FILA).Contains(postAndMeta.TIPO_CHAMADO))
                                    .Select(l => l.ID).Contains(k.ID_FILA_CHAMADO));

                            if (filter.Value.fila is not null)
                            {
                                if (filter.Value.fila.Any())
                                {
                                    dataBeforeFilter = dataBeforeFilter.Where(k =>
                                    CD.CONTROLE_DE_DEMANDAS_FILAs
                                        .Where(postAndMeta => filter.Value.fila.Select(x => x.FILA).Contains(postAndMeta.FILA))
                                        .Select(l => l.ID).Contains(k.ID_FILA_CHAMADO));
                                }
                            }
                        }
                    }

                    if (filter.Value.responsável is not null)
                    {
                        if (filter.Value.responsável.Any())
                        {
                            dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.responsável.Select(y => y.Login).Contains(x.MATRICULA_RESPONSAVEL));
                        }
                    }

                    if (filter.Value.id_demandas is not null)
                    {
                        if (filter.Value.id_demandas.Any())
                        {
                            dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.id_demandas.Contains(x.ID.ToString()));
                        }
                    }

                    var dataAfterFilter = dataBeforeFilter.OrderByDescending(x => x.ID)
                   .Skip((filter.PageNumber - 1) * filter.PageSize)
                   .Take(filter.PageSize);

                    var demandas = dataAfterFilter.AsNoTracking()
                            .ProjectTo<PAINEL_DEMANDAS_CHAMADO_DTO>(_mapper.ConfigurationProvider)
                            .IgnoreAutoIncludes();


                    var totalRecords = dataBeforeFilter.Count();
                    var totalPages = ((double)totalRecords / (double)filter.PageSize);

                    return new JsonResult(new Response<PagedModelResponse<IEnumerable<PAINEL_DEMANDAS_CHAMADO_DTO>>>
                    {
                        Data = PagedResponse.CreatePagedReponse<PAINEL_DEMANDAS_CHAMADO_DTO, PaginationDemandasModel>(demandas, filter, totalRecords),
                        Succeeded = true,
                        Message = $"Tudo certo!",
                        Errors = null,
                    });
                }
                else
                {
                    var dataBeforeFilter = CD.CONTROLE_DE_DEMANDAS_CHAMADOs
                        .AsQueryable();

                    dataBeforeFilter = dataBeforeFilter
                                .Where(c =>
                                        CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
                                            .Where(s => s.ID_STATUS_CHAMADO == c.ID_STATUS_CHAMADO)
                                            .OrderByDescending(s => s.DATA)
                                            .Select(s => s.STATUS)
                                            .FirstOrDefault() == "EM ABERTO");

                    dataBeforeFilter = dataBeforeFilter
                        .Where(x =>
                            x.DATA_ABERTURA >= DateTime.Today.AddDays(-30)
                            && x.DATA_ABERTURA <= DateTime.Today);

                    var dataAfterFilter = dataBeforeFilter.OrderByDescending(x => x.ID)
                        .Skip((filter.PageNumber - 1) * filter.PageSize)
                        .Take(filter.PageSize);

                    var demanda = dataAfterFilter.AsNoTracking()
                            .ProjectTo<PAINEL_DEMANDAS_CHAMADO_DTO>(_mapper.ConfigurationProvider)
                            .IgnoreAutoIncludes();

                    var totalRecords = demanda.Count();
                    var totalPages = ((double)totalRecords / (double)filter.PageSize);
                    return new JsonResult(new Response<PagedModelResponse<IEnumerable<PAINEL_DEMANDAS_CHAMADO_DTO>>>
                    {
                        Data = PagedResponse.CreatePagedReponse<PAINEL_DEMANDAS_CHAMADO_DTO, PaginationDemandasModel>(demanda, filter, totalRecords),
                        Succeeded = true,
                        Message = $"Tudo certo!",
                        Errors = null,
                    });
                }
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

        [HttpGet("GetOperadoresSuporte")]
        [ProducesResponseType(typeof(Response<IEnumerable<DEMANDA_BD_OPERADORES_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        [OutputCache(PolicyName = "CachePost", Duration = int.MaxValue)]
        public JsonResult GetOperadoresSuporte(string regional)
        {
            try
            {
                var Dados_Operadores = CD.DEMANDA_BD_OPERADOREs
                    .Where(x => x.REGIONAL == regional)
                    .ProjectTo<DEMANDA_BD_OPERADORES_DTO>(_mapper.ConfigurationProvider)
                    .AsEnumerable();

                return new JsonResult(new Response<IEnumerable<DEMANDA_BD_OPERADORES_DTO>>
                {
                    Data = Dados_Operadores,
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpGet("GetAllEnableOperadores")]
        [ProducesResponseType(typeof(Response<IEnumerable<ACESSOS_MOBILE_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        [OutputCache(PolicyName = "CachePost", Duration = int.MaxValue)]
        public JsonResult GetAllEnableOperadores(string regional)
        {
            try
            {
                var OperadoresAtuais = CD.DEMANDA_BD_OPERADOREs.Select(x => x.MATRICULA);
                var Dados_Operadores = CD.ACESSOS_MOBILEs
                    .Where(x => !OperadoresAtuais.Contains(x.MATRICULA))
                    .Where(x => x.REGIONAL == regional)
                    .Where(x => x.STATUS == true)
                    .Where(x => x.CANAL == 2)
                    .AsNoTracking()
                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                    .ToList();

                return new JsonResult(new Response<IEnumerable<ACESSOS_MOBILE_DTO>>
                {
                    Data = Dados_Operadores,
                    Succeeded = true,
                    Errors = null,
                    Message = "Tudo Certo!"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações dos filtros",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Erro ao buscar informações dos filtros"
                });
            }
        }

        [HttpPost("AtivarOperadorSuporte")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> AtivarOperadorSuporte(int id)
        {
            try
            {
                var user = CD.DEMANDA_BD_OPERADOREs.Find(id);
                user.STATUS = true;

                var saida = CD.SaveChanges();
                await _cache.EvictByTagAsync("analistas-suporte", default);
                return new JsonResult(new Response<string>
                {
                    Data = "Tudo certo!",
                    Succeeded = true,
                    Errors = null,
                    Message = $"O operador(a) foi ativado com sucesso"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Ocorrreu um erro ao executar esta ação",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Ocorrreu um erro ao executar esta ação"
                });
            }
        }

        [HttpPost("DesativarOperadorSuporte")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> DesativarOperadorSuporte(int id)
        {
            try
            {
                var user = CD.DEMANDA_BD_OPERADOREs.Find(id);
                user.STATUS = false;

                var saida = CD.SaveChanges();
                await _cache.EvictByTagAsync("analistas-suporte", default);

                return new JsonResult(new Response<string>
                {
                    Data = "Tudo certo!",
                    Succeeded = true,
                    Errors = null,
                    Message = $"O operador(a) foi desativado com sucesso"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Ocorrreu um erro ao executar esta ação",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Ocorrreu um erro ao executar esta ação"
                });
            }
        }

        [HttpPost("AddOperadoresSuporte")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> AddOperadoresSuporte([FromBody] List<DEMANDA_BD_OPERADORES_DTO> newoperador)
        {
            try
            {
                CD.DEMANDA_BD_OPERADOREs.AddRange(
                        newoperador.Select(x => new DEMANDA_BD_OPERADORE
                        {
                            DT_MOD = x.DT_MOD,
                            MATRICULA = x.MATRICULA.MATRICULA,
                            MATRICULA_MOD = x.MATRICULA_MOD.MATRICULA,
                            REGIONAL = x.REGIONAL,
                            STATUS = true
                        })
                    );
                var saida = CD.SaveChanges();

                await _cache.EvictByTagAsync("analistas-suporte", default);

                if (saida > 0)
                {
                    return GetOperadoresSuporte(newoperador.First().REGIONAL);
                }
                return new JsonResult(new Response<string>
                {
                    Data = "Algum erro ocorreu ao tentar adicionar o operador",
                    Succeeded = false,
                    Errors = new string[] { "Algum erro ocorreu ao tentar adicionar o operador" },
                    Message = "Algum erro ocorreu ao adicionar o operador"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Ocorrreu um erro ao executar esta ação",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                    Message = "Ocorrreu um erro ao executar esta ação"
                });
            }
        }

        [HttpGet("GetDemandaById")]
        [ProducesResponseType(typeof(Response<DEMANDAS_CHAMADO_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetDemandaById(Guid IdDemanda)
        {
            try
            {
                var id = Demanda_BD.DEMANDA_RELACAO_CHAMADO.Find(IdDemanda);
                var demanda = GetDemandaByID(id.ID_CHAMADO);
                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(
                  new Response<DEMANDAS_CHAMADO_DTO>
                  {
                      Data = demanda,
                      Succeeded = true,
                      Message = "Tudo Certo"
                  }, options);

            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao encontrar buscar informações",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace,
                        ex.Source
                    },
                    Message = "Erro ao encontrar buscar informações"
                });
            }
        }

        [HttpGet("GetDesligamentoById")]
        [ProducesResponseType(typeof(Response<DESLIGAMENTO_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDesligamentoById(Guid idDesligamento)
        {
            try
            {
                var id = Demanda_BD.DEMANDA_RELACAO_CHAMADO.Find(idDesligamento);
                var demanda = GetDesligamentoByID(id.ID_CHAMADO);

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(
                  new Response<DESLIGAMENTO_DTO>
                  {
                      Data = demanda,
                      Succeeded = true,
                      Message = "Tudo Certo"
                  }, options);

            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao encontrar buscar informações",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace,
                        ex.Source
    },
                    Message = "Erro ao encontrar buscar informações"
                });
            }
        }

        [HttpGet("GetAcessoById")]
        [ProducesResponseType(typeof(Response<ACESSO_TERCEIROS_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetAcessoById(Guid IdAcesso)
        {
            try
            {
                var id = Demanda_BD.DEMANDA_RELACAO_CHAMADO.Find(IdAcesso);
                var demanda = GetAcessoByID(id.ID_CHAMADO);

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(
                  new Response<ACESSO_TERCEIROS_DTO>
                  {
                      Data = demanda,
                      Succeeded = true,
                      Message = "Tudo Certo"
                  }, options);

            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao encontrar buscar informações",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace,
                        ex.Source
                    },
                    Message = "Erro ao encontrar buscar informações"
                });
            }
        }

        [HttpPost("GetDataDash")]
        [ProducesResponseType(typeof(Response<DEMANDAS_CHAMADO_DTO>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> GetDataDash([FromBody] Tuple<IEnumerable<int>, IEnumerable<DateTime?>, IEnumerable<ACESSOS_MOBILE_DTO>?, DEMANDA_TIPO_FILA_DTO?, DEMANDA_SUB_FILA_DTO?> Data, string regional, int matricula,
            //Nullable Parameters
            string? status, bool? Prioridade)
        {
            try
            {
                IQueryable<DEMANDA_CHAMADO?> linqFiltered = Demanda_BD.DEMANDA_CHAMADO.Where(x => x.REGIONAL == regional);

                if (Data.Item1.Any(x => new int[] { 1, 20 }.Contains(x))) //filtra demandas por gerente
                {
                    if (!string.IsNullOrEmpty(status))
                        linqFiltered = linqFiltered.Where(x => x.Relacao.Status.Any(y => y.STATUS == status));

                    if (Data.Item3.Any())
                        linqFiltered = linqFiltered.Where(x => Data.Item3.Select(x => x.MATRICULA).Contains(x.MATRICULA_RESPONSAVEL.Value));
                }
                else if (Data.Item1.Any(x => new int[] { 14, 15 }.Contains(x))) //filtra demandas por analista
                {
                    linqFiltered.Where(x => x.MATRICULA_RESPONSAVEL == matricula);
                }
                else if (Data.Item1.Any(x => new int[] { 13 }.Contains(x))) //filtra demandas por solicitante
                {
                    linqFiltered.Where(x => x.MATRICULA_SOLICITANTE == matricula);
                }

                if (Data.Item2 is not null && Data.Item2.Count() > 1)
                    linqFiltered = linqFiltered.Where(x => x.DATA_ABERTURA >= Data.Item2.ElementAt(0) && x.DATA_ABERTURA <= Data.Item2.ElementAt(1));

                if (Prioridade.HasValue)
                    linqFiltered = linqFiltered.Where(x => Prioridade == true ? x.Relacao.PRIORIDADE : !x.Relacao.PRIORIDADE);

                if (Data.Item4 is not null)
                    linqFiltered = linqFiltered.Where(x => x.Fila.ID_TIPO_FILA == Data.Item4.ID_TIPO_FILA);

                if (Data.Item5 is not null)
                    linqFiltered = linqFiltered.Where(x => x.Fila.ID_SUB_FILA == Data.Item5.ID_SUB_FILA);


                var Total_de_Demandas = linqFiltered
                    .Count();

                int Concluído = 0;
                int Em_andamento = 0;
                double Porc_Primeiro_SLA_24h = 0.0;
                double Porc_Dentro_SLA = 0.0;
                int Aguardando_outra_área = 0;
                int Em_Aberto = 0;
                int Devolvido = 0;
                int DemandaPrioridade = 0;
                if (Total_de_Demandas > 0)
                {

                    Concluído = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS == "CONCLUÍDO")
                        .Count();

                    Em_andamento = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS != "CONCLUÍDO")
                        .Count();

                    var list24Diferences = linqFiltered
                          .Where(x => x.Relacao.Status.Count > 1)
                          .Select(x => calculeDate(x.Relacao.Status.OrderBy(k => k.DATA).First().DATA, x.Relacao.Status.OrderBy(k => k.DATA).ElementAt(1).DATA));

                    var Qtd_Primeiro_SLA_24h = list24Diferences.AsEnumerable()
                          .Where(x => x <= 24)
                          .Count();

                    Porc_Primeiro_SLA_24h = Math.Round((Qtd_Primeiro_SLA_24h / (double)Total_de_Demandas) * 100.0, 1);

                    var list_Dentro_SLA = linqFiltered
                          .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).Last().STATUS == "CONCLUÍDO")
                          .Select(x => new { lastdate = x.Relacao.Status.OrderBy(k => k.DATA).Last().DATA, dt_abertura = x.DATA_ABERTURA.Value, sla = x.Fila.SLA })
                          .AsEnumerable();

                    var Qtd_Dentro_SLA = list_Dentro_SLA.Where(x => calculeDate(x.lastdate, x.dt_abertura) <= x.sla).Count();

                    Porc_Dentro_SLA = Math.Round((Qtd_Dentro_SLA / (double)Total_de_Demandas) * 100.0, 1);

                    Aguardando_outra_área = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS == "AGUARDANDO OUTRA ÁREA")
                        .Count();
                    Em_Aberto = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS == "ABERTO")
                        .Count();
                    Devolvido = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS == "DEVOLVIDO AO ANALISTA")
                        .Count();
                    DemandaPrioridade = linqFiltered
                        .Where(x => x.Relacao.PRIORIDADE)
                        .Count();
                }

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(
                  new Response<dynamic>
                  {
                      Data = new
                      {
                          Total_de_Demandas,
                          Concluído,
                          Em_andamento,
                          Porc_Primeiro_SLA_24h,
                          Porc_Dentro_SLA,
                          Aguardando_outra_área,
                          Em_Aberto,
                          Devolvido,
                          Prioridade
                      },
                      Succeeded = true,
                      Message = "Tudo Certo"
                  }, options);

            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao encontrar buscar informações",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace,
                        ex.Source
                    },
                    Message = "Erro ao encontrar buscar informações"
                });
            }
        }

        [HttpGet("AnalistaSuporte/Get/IsSuporte={IsSuporte}/IsAcessoLogico={IsAcessoLogico}/SubFila={SubFila}/regional={regional}/matricula={matricula}")]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = int.MaxValue, NoStore = false, Location = ResponseCacheLocation.Any)]
        [OutputCache(Duration = int.MaxValue, Tags = new string[] { "analistas-suporte" }, NoStore = false, VaryByHeaderNames = new string[] { "User-Agent" })]
        public async Task<Results<Ok<IEnumerable<ACESSOS_MOBILE_DTO>>, BadRequest<Exception>>> GetAnalistaSuporte(bool IsSuporte, bool IsAcessoLogico, int SubFila, string regional, int matricula)
        {
            try
            {
                    //var queryanalogico = CD.ACESSOS_MOBILEs
                    //    .Where(x => x.REGIONAL == regional)
                    //    .Where(x => CD.PERFIL_USUARIOs
                    //                    .Where(y => y.id_Perfil == 15)
                    //                    .Select(y => y.MATRICULA)
                    //                    .Contains(x.MATRICULA))
                    //    .Distinct().AsEnumerable();

                    var matanalistas = CD.DEMANDA_BD_OPERADOREs
                        .Where(x => x.REGIONAL == regional)
                        .Select(x => x.MATRICULA).ToArray()
                        .Distinct();

                    var query = CD.ACESSOS_MOBILEs
                        .Where(x => matanalistas.Contains(x.MATRICULA));

                var saida = query
                .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                .AsEnumerable();
                //var demandas = Demanda_BD.DEMANDA_RELACAO_CHAMADO.ProjectTo<DEMANDA_DTO>(_mapper.ConfigurationProvider).ToList();

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return TypedResults.Ok(saida);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }

        [HttpGet("GetAllChamados")]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = int.MaxValue, NoStore = false, Location = ResponseCacheLocation.Any)]
        [OutputCache(Duration = int.MaxValue, Tags = new string[] { "AllDemandas" }, NoStore = false, VaryByHeaderNames = new string[] { "User-Agent" })]
        public IEnumerable<DEMANDA_DTO> GetAllChamados(int? matricula)
        {
            try
            {
                /*** Sempre utilizamos apenas os chamados do último ano ***/

                var dataBeforeFilter = Demanda_BD.DEMANDA_RELACAO_CHAMADO
                    .Where(x => x.Respostas.First().DATA_RESPOSTA >= DateTime.Now.AddYears(-1)
                        && x.Respostas.First().DATA_RESPOSTA <= DateTime.Now)
                    .AsNoTracking();

                var saida = dataBeforeFilter
                    .ProjectTo<DEMANDA_DTO>(_mapper.ConfigurationProvider);

                return saida.ToList();
            }
            catch (Exception ex)
            {
                return [];
            }
        }

        //------------------------------------------------------------------------------------
        private DEMANDAS_CHAMADO_DTO GetDemandaByID(int IdDemanda)
            => Demanda_BD.DEMANDA_CHAMADO
                    .IgnoreAutoIncludes()
                    .Include(x => x.Responsavel)
                    .Include(x => x.Solicitante)
                    .Include(x => x.Fila)
                        .ThenInclude(x => x.DEMANDA_RESPONSAVEL_FILAs)
                    .Include(x => x.Fila)
                        .ThenInclude(x => x.ID_TIPO_FILANavigation)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Responsavel)
                                .ThenInclude(x => x.DemandasResponsavel)
                                .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Status)
                                .ThenInclude(x => x.Quem_redirecionou)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Status)
                                .ThenInclude(x => x.Para_Quem_redirecionou)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Status)
                    .ProjectTo<DEMANDAS_CHAMADO_DTO>(_mapper.ConfigurationProvider)
                    .First(x => x.ID == IdDemanda);

        private ACESSO_TERCEIROS_DTO GetAcessoByID(int IdAcesso)
            => Demanda_BD.DEMANDA_ACESSOS
                    .Include(x => x.Responsavel)
                    .Include(x => x.Solicitante)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Responsavel)
                                .ThenInclude(x => x.ResponsavelDemandasTotais)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Status)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Status)
                                .ThenInclude(x => x.Quem_redirecionou)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Status)
                                .ThenInclude(x => x.Para_Quem_redirecionou)
                    .IgnoreAutoIncludes()
                    .ProjectTo<ACESSO_TERCEIROS_DTO>(_mapper.ConfigurationProvider)
                    .First(x => x.ID == IdAcesso);

        private DESLIGAMENTO_DTO GetDesligamentoByID(int IdDesligamento)
            => Demanda_BD.DEMANDA_DESLIGAMENTOS
                    .Include(x => x.Responsavel)
                    .Include(x => x.Solicitante)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Status)
                                .ThenInclude(x => x.Quem_redirecionou)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Respostas)
                            .ThenInclude(x => x.Status)
                                .ThenInclude(x => x.Para_Quem_redirecionou)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Responsavel)
                    .Include(x => x.Relacao)
                        .ThenInclude(x => x.Solicitante)
                    .IgnoreAutoIncludes()
                    .ProjectTo<DESLIGAMENTO_DTO>(_mapper.ConfigurationProvider)
                    .First(x => x.ID == IdDesligamento);

        public static byte[] ConvertFile(byte[] Unconvertedfiles)
        {
            try
            {
                byte[] decompressedBytes;
                using (MemoryStream memoryStream = new MemoryStream(Unconvertedfiles))
                {
                    using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                    {
                        using (MemoryStream decompressedStream = new MemoryStream())
                        {
                            gzipStream.CopyTo(decompressedStream);
                            decompressedBytes = decompressedStream.ToArray();
                        }
                    }
                }

                return decompressedBytes;
            }
            catch
            {
                return new byte[0];
            }
        }

        private static int calculeDate(DateTime startDate, DateTime endDate)
        {

            int days = 0;
            var saida = ObterFeriados(DateTime.Now.Year);
            while (startDate.Date <= endDate.Date)
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday
                   && startDate.DayOfWeek != DayOfWeek.Sunday
                   && !saida.Contains(startDate.Date))
                    days++;

                startDate = startDate.AddDays(1);
            }

            return days;
        }

        private static List<DateTime> ObterFeriados(int ano)
        {
            List<DateTime> feriados = new List<DateTime>
        {
            // Feriados fixos
            new DateTime(ano, 1, 1), // Ano Novo
            new DateTime(ano, 4, 21), // Tiradentes
            new DateTime(ano, 5, 1), // Dia do Trabalhador
            new DateTime(ano, 9, 7), // Independência do Brasil
            new DateTime(ano, 10, 12), // Nossa Senhora Aparecida
            new DateTime(ano, 11, 2), // Finados
            new DateTime(ano, 11, 15), // Proclamação da República
            new DateTime(ano, 12, 25), // Natal

            // Feriados móveis
            CalcularCarnaval(ano),
            CalcularSextaFeiraSanta(ano),
            CalcularCorpusChristi(ano)
        };

            return feriados;
        }

        // Função para calcular o Carnaval (terça-feira antes da Quarta-feira de Cinzas)
        private static DateTime CalcularCarnaval(int ano)
        {
            DateTime pascoa = CalcularPascoa(ano);
            return pascoa.AddDays(-47); // Carnaval é 47 dias antes da Páscoa
        }

        // Função para calcular a Sexta-feira Santa (2 dias antes da Páscoa)
        private static DateTime CalcularSextaFeiraSanta(int ano)
        {
            DateTime pascoa = CalcularPascoa(ano);
            return pascoa.AddDays(-2);
        }

        // Função para calcular o Corpus Christi (60 dias após a Páscoa)
        private static DateTime CalcularCorpusChristi(int ano)
        {
            DateTime pascoa = CalcularPascoa(ano);
            return pascoa.AddDays(60);
        }

        // Função para calcular a data da Páscoa (baseado no algoritmo de Meeus/Jones/Butcher)
        private static DateTime CalcularPascoa(int ano)
        {
            int a = ano % 19;
            int b = ano / 100;
            int c = ano % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int l = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * l) / 451;
            int mes = (h + l - 7 * m + 114) / 31;
            int dia = ((h + l - 7 * m + 114) % 31) + 1;

            return new DateTime(ano, mes, dia);
        }

    }
}
