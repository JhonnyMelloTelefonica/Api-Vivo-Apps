using Newtonsoft.Json;
using Vivo_Apps_API.Models;
using Vivo_Apps_API.Hubs;
using Shared_Razor_Components.Services;
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
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.Drawing.Charts;
using Shared_Razor_Components.FundamentalModels;
using Shared_Static_Class.Model_DTO.FilterModels;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using Microsoft.Office.Interop.Excel;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Presentation;

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
        private readonly IPWService _service;
        private static Vivo_MaisContext CD;
        private static HttpClient _httpclient;
        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext Demanda_BD;
        public DemandasController(
            IPWService service,
            ILogger<DemandasController> logger
            , ISuporteDemandaHub hubContext
            , Vivo_MaisContext bd_context
            , IDbContextFactory<DemandasContext> dbContextFactory
            , HttpClient httpclient
            , IOutputCacheStore cache)
        {
            _service = service;
            _cache = cache;
            _httpclient = httpclient;
            DbFactory = dbContextFactory;
            Demanda_BD = DbFactory.CreateDbContext();
            CD = bd_context;
            _hubContext = hubContext;
            _logger = logger;
            var config = new MapperConfiguration(cfg =>
            {
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
                   dest => dest.Perfis,
                   opt => opt.MapFrom(src => Demanda_BD.PERFIL_USUARIO.Where(x => x.MATRICULA == src.MATRICULA))
                   );

                cfg.CreateMap<DEMANDA_RELACAO_CHAMADO, DEMANDA_DTO>()
                   .ForMember(x => x.Respostas, opt => opt.Ignore())
                   .ForMember(x => x.Status, opt => opt.Ignore());

                cfg.CreateMap<DEMANDA_CHAMADO, PAINEL_DEMANDAS_CHAMADO_DTO>();
                cfg.CreateMap<DEMANDA_ACESSOS, DEMANDA_ACESSOS_PAINEL>();
                cfg.CreateMap<DEMANDA_DESLIGAMENTOS, DEMANDA_DESLIGAMENTOS_PAINEL>();

                cfg.CreateMap<DEMANDA_TIPO_FILA, DEMANDA_TIPO_FILA_DTO>();
                cfg.CreateMap<DEMANDA_SUB_FILA, PAINEL_DEMANDA_SUB_FILA_DTO>();
                cfg.CreateMap<DEMANDA_SUB_FILA, DEMANDA_SUB_FILA_DTO>()
                .ForMember(
                    dest => dest.Responsaveis,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE.Where(y =>
                        Demanda_BD.DEMANDA_RESPONSAVEL_FILA
                                .Where(x =>
                                    Demanda_BD.DEMANDA_BD_OPERADORES
                                    .Where(y => y.STATUS == true)
                                    .Select(y => y.MATRICULA)
                                    .Contains(x.MATRICULA_RESPONSAVEL))
                                .Where(x => x.ID_SUB_FILA == src.ID_SUB_FILA)
                                .Select(x => x.MATRICULA_RESPONSAVEL)
                                .Distinct()
                                .Contains(y.MATRICULA))
                        )
                    );

                cfg.CreateMap<DEMANDA_CAMPOS_FILA, DEMANDA_CAMPOS_FILA_DTO>();

                cfg.CreateMap<DEMANDA_VALORES_CAMPOS_SUSPENSO, DEMANDA_VALORES_CAMPOS_SUSPENSO_DTO>();

                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_NO_RELATIONS>()
               .ForMember(
                   dest => dest.CARGO,
                   opt => opt.MapFrom(src => (Cargos)src.CARGO))
               .ForMember(
                   dest => dest.CANAL,
                   opt => opt.MapFrom(src => (Canal)src.CANAL));

                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_DTO>()
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => (Cargos)src.CARGO)
                    )
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => (Canal)src.CANAL)
                    );


                cfg.CreateMap<DEMANDA_BD_OPERADORE, DEMANDA_BD_OPERADORES_DTO>()
                .ForMember(
                    dest => dest.MATRICULA,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE
                                .Where(x => x.MATRICULA == src.MATRICULA)
                                .FirstOrDefault()))
                .ForMember(
                    dest => dest.MATRICULA_MOD,
                    opt => opt.MapFrom(src => Demanda_BD.ACESSOS_MOBILE
                                .Where(x => x.MATRICULA == src.MATRICULA_MOD)
                                .FirstOrDefault())
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
                var Arquivos = Demanda_BD.DEMANDA_ARQUIVOS_RESPOSTA.Where(x => x.ID_RESPOSTA == IdResposta);

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
                    List<DEMANDA_CAMPOS_FILA> camposAntigos = CD.DEMANDA_CAMPOS_FILAs.Where(x => x.ID_SUB_FILA == data.ID_SUB_FILA).ToList();
                    List<DEMANDA_CAMPOS_FILA> camposAtualizados = data.DEMANDA_CAMPOS_FILAs.Select(x => new DEMANDA_CAMPOS_FILA
                    {
                        ID_CAMPOS = x.ID_CAMPOS,
                        ID_SUB_FILA = data.ID_SUB_FILA,
                        CAMPO = x.CAMPO,
                        MASCARA = x.MASCARA,
                        CAMPO_SUSPENSO = x.CAMPO_SUSPENSO,
                        REGIONAL = regional,
                        DT_CRIACAO = DateTime.Now.ToString(),
                        STATUS_CAMPOS_FILA = x.STATUS_CAMPOS_FILA,
                        MAT_CRIADOR = matricula,
                        DEMANDA_VALORES_CAMPOS_SUSPENSOs = x.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Select(y => new DEMANDA_VALORES_CAMPOS_SUSPENSO
                        {
                            ID_VALORES = y.ID_VALORES,
                            VALOR = y.VALOR,
                            ID_CAMPOS = x.ID_CAMPOS,
                            STATUS = y.STATUS
                        }).ToList(),
                    }).ToList();

                    IEnumerable<DEMANDA_CAMPOS_FILA> NovaFicha = camposAntigos.Union(camposAtualizados).ToList();
                    /** Une os perfis que estão no banco e os inseridos pelo usuário em uma lista, dá o distinct automaticamente **/
                    IEnumerable<DEMANDA_CAMPOS_FILA> FichaExcluida = camposAntigos.ExceptBy(camposAtualizados.Select(x => x.ID_CAMPOS), x => x.ID_CAMPOS).ToList();
                    /** Perfis que estão no banco e que não estão na união entre as 2 listas **/


                    foreach (var ficha in NovaFicha)
                    {
                        if (ficha.ID_CAMPOS == 0)
                        { /* Caso não haja Id Adicionamos*/
                            CD.DEMANDA_CAMPOS_FILAs.Add(ficha);
                        }
                        else
                        {/* Caso haja Id Atualizamos sua propriedades*/
                            var fichainDB = CD.DEMANDA_CAMPOS_FILAs.Find(ficha.ID_CAMPOS);

                            fichainDB.ID_CAMPOS = ficha.ID_CAMPOS;
                            fichainDB.ID_SUB_FILA = ficha.ID_SUB_FILA;
                            fichainDB.CAMPO = ficha.CAMPO;
                            fichainDB.MASCARA = ficha.MASCARA;
                            fichainDB.CAMPO_SUSPENSO = ficha.CAMPO_SUSPENSO;
                            fichainDB.REGIONAL = ficha.REGIONAL;
                            fichainDB.DT_CRIACAO = ficha.DT_CRIACAO;
                            fichainDB.STATUS_CAMPOS_FILA = ficha.STATUS_CAMPOS_FILA;
                            fichainDB.MAT_CRIADOR = ficha.MAT_CRIADOR;

                            List<DEMANDA_VALORES_CAMPOS_SUSPENSO> valorescamposAntigos = CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Where(x => x.ID_CAMPOS == ficha.ID_CAMPOS).ToList();

                            IEnumerable<DEMANDA_VALORES_CAMPOS_SUSPENSO> NovaFichavalores = valorescamposAntigos.Union(ficha.DEMANDA_VALORES_CAMPOS_SUSPENSOs).ToList();
                            /** Une os perfis que estão no banco e os inseridos pelo usuário em uma lista, dá o distinct automaticamente **/
                            IEnumerable<DEMANDA_VALORES_CAMPOS_SUSPENSO> FichaExcluidavalores = valorescamposAntigos.ExceptBy(ficha.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Select(x => x.ID_VALORES), x => x.ID_VALORES).ToList();

                            foreach (var valor in NovaFichavalores)
                            {
                                if (valor.ID_VALORES == 0)
                                { /* Caso não haja Id Adicionamos*/
                                    CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Add(valor);
                                }
                                else
                                {/* Caso haja Id Atualizamos sua propriedades*/
                                    var valorinDB = CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Find(valor.ID_VALORES);

                                    valorinDB.ID_VALORES = valor.ID_VALORES;
                                    valorinDB.VALOR = valor.VALOR;
                                    valorinDB.ID_CAMPOS = valor.ID_CAMPOS;
                                    valorinDB.STATUS = valor.STATUS;
                                }
                            }
                            foreach (var valor in FichaExcluidavalores)
                            {
                                /* Caso Esteja na lista é uma imagem deletada*/
                                CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Remove(valor);
                            }
                        }
                    }

                    foreach (var ficha in FichaExcluida)
                    {
                        /* Caso Esteja na lista é uma imagem deletada*/
                        CD.DEMANDA_CAMPOS_FILAs.Remove(ficha);
                    }
                    /***
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
                     * ***/

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

                if (filter.Value.fila_macro is not null)
                {
                    if (filter.Value.fila_macro.Any())
                    {
                        List<int> tipo_fila = filter.Value.fila_macro;

                        dataBeforeFilter = dataBeforeFilter.Where(k =>
                            tipo_fila.Contains(k.ID_TIPO_FILA));

                        if (filter.Value.sub_fila is not null)
                        {
                            if (filter.Value.sub_fila.Any())
                            {
                                List<int> sub_fila = filter.Value.sub_fila;

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
        public JsonResult GetFiltersFilas(string regional, [FromQuery] int[] Filas, [FromQuery] int[] SubFilas, bool RefreshFilas = true)
        {
            try
            {
                var datafilters = new FilterFilaDemandasModel();
                if (RefreshFilas)
                {
                    datafilters.filas = Demanda_BD.DEMANDA_SUB_FILA
                        .Where(x => x.REGIONAL == regional)
                        .Include(x => x.DEMANDA_RESPONSAVEL_FILAs)
                        .Select(x => new RELACAO_FILA_SUB_FILA(x.ID_TIPO_FILA, x.ID_TIPO_FILANavigation.NOME_TIPO_FILA, x.ID_SUB_FILA, x.NOME_SUB_FILA, x.DEMANDA_RESPONSAVEL_FILAs.Select(y => y.MATRICULA_RESPONSAVEL.Value).ToArray()))
                        .AsSplitQuery()
                        .ToList();
                }

                IQueryable<DEMANDA_RESPONSAVEL_FILA> parcial_result = Demanda_BD.DEMANDA_RESPONSAVEL_FILA;

                if (Filas.Any())
                {
                    var sub_from_macro = Demanda_BD.DEMANDA_SUB_FILA.Where(x => Filas.Contains(x.ID_TIPO_FILA)).Select(x => x.ID_SUB_FILA);
                    parcial_result = parcial_result.Where(x => sub_from_macro.Contains(x.ID_SUB_FILA.Value));

                    if (SubFilas.Any())
                    {
                        parcial_result = parcial_result.Where(x => SubFilas.Contains(x.ID_SUB_FILA.Value));
                    }
                }

                var list_matriculas = parcial_result
                            .Select(x => x.MATRICULA_RESPONSAVEL)
                            .Distinct().ToList();

                var resultanalista = Demanda_BD.ACESSOS_MOBILE
                    .Where(x => list_matriculas.Contains(x.MATRICULA));


                datafilters.AnalistaSuporte = resultanalista.Where(x => x.REGIONAL == regional).ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider).ToList();

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
                var fila = Demanda_BD.DEMANDA_SUB_FILA
                .Where(x => x.REGIONAL == regional)
                .Include(x => x.DEMANDA_RESPONSAVEL_FILAs)
                .Select(x => new RELACAO_FILA_SUB_FILA(x.ID_TIPO_FILA, x.ID_TIPO_FILANavigation.NOME_TIPO_FILA, x.ID_SUB_FILA, x.NOME_SUB_FILA, x.DEMANDA_RESPONSAVEL_FILAs.Select(y => y.MATRICULA_RESPONSAVEL.Value).ToArray()));

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
        [ProducesResponseType(typeof(Response<IEnumerable<OptionFilas>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetFilas(string regional)
        {
            try
            {
                var Dados_Fila = Demanda_BD.DEMANDA_TIPO_FILA.Where(x => x.STATUS_TIPO_FILA == true && x.REGIONAL == regional && x.DEMANDA_SUB_FILAs.Any(x => x.STATUS_SUB_FILA == true)).Select(x => new OptionFilas(x.ID_TIPO_FILA, x.NOME_TIPO_FILA, x.DESCRICAO)).Distinct().AsEnumerable();

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                return new JsonResult(new Response<IEnumerable<OptionFilas>>
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
        [ProducesResponseType(typeof(Response<object>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDadosFilaByID(int id_fila)
        {
            try
            {
                var Carteira = CD.Carteira_NEs.Where(x => x.ANOMES == CD.Carteira_NEs.Max(y => y.ANOMES));
                var Sap = CD.CNS_BASE_TERCEIROS_SAP_GTs.AsQueryable();
                var Dados_Fila = Demanda_BD.DEMANDA_SUB_FILA.Where(x => x.STATUS_SUB_FILA == true && x.ID_TIPO_FILA == id_fila).Select(x => new OptionFilas(x.ID_SUB_FILA, x.NOME_SUB_FILA, x.DESCRICAO)).Distinct().AsEnumerable();
                string Descricao = Demanda_BD.DEMANDA_TIPO_FILA.Find(id_fila).DESCRICAO ?? string.Empty;

                return new JsonResult(new Response<object>
                {
                    Data = new
                    {
                        DATA_CRIAR_DEMANDA = new DATA_CRIAR_DEMANDA
                        {
                            Carteira = Carteira,
                            Sap = Sap
                        },
                        sub_fila = Dados_Fila,
                        descricao = Descricao
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


        [HttpGet("GetDadosFilaSubFila")]
        [ProducesResponseType(typeof(Response<object>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public IActionResult GetDadosFilaBy(string regional)
        {          

            try
            {
                
                var demandaSubDemandas = Demanda_BD.DEMANDA_TIPO_FILA
                .Where(d => d.REGIONAL == regional)
                .Select(fila => new DEMANDA_TIPO_FILA_DTO

                {

                    ID_TIPO_FILA = fila.ID_TIPO_FILA,

                    NOME_TIPO_FILA = fila.NOME_TIPO_FILA,

                    DEMANDA_SUB_FILAs = Demanda_BD.DEMANDA_SUB_FILA

                .Where(subFila => subFila.ID_TIPO_FILA == fila.ID_TIPO_FILA)

                .Select(subFila => new DEMANDA_SUB_FILA_DTO

                {

                    ID_TIPO_FILA = subFila.ID_TIPO_FILA,

                    ID_SUB_FILA = subFila.ID_SUB_FILA,

                    NOME_SUB_FILA = subFila.NOME_SUB_FILA

                }).ToList() // Cria uma lista de subfilas

                });

               return Ok(demandaSubDemandas);

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


        /// <summary>
        /// Responde a demnanda alterando o status de alguma forma
        /// </summary>
        /// <param name="data"></param>
        /// <param name="tabela"></param>
        /// <returns>
        /// Object que pode ser do tipo DEMANDAS_CHAMADO_DTO,ACESSO_TERCEIROS_DTO ou DESLIGAMENTO_DTO 
        /// </returns>

        [HttpPost("InsertRespostaChangeStatus")]
        [ProducesResponseType(typeof(Response<object>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> InsertRespostaChangeStatus([FromBody] RespostaDemandaModel data, Tabela_Demanda tabela)
        {
            try
            {
                object demanda = null;

                ACESSOS_MOBILE responsavel_resposta = Demanda_BD.ACESSOS_MOBILE.First(x => x.MATRICULA == data.MATRICULA);
                ACESSOS_MOBILE_DTO solicitante = null;

                ACESSOS_MOBILE_DTO? responsavel = null;

                SendEmailModel email = null;

                List<ACESSOS_MOBILE_DTO> emailsender = [];

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
                }).Entity;

                //Demanda_BD.SaveChanges();
                Demanda_BD.SaveChanges();

                int MATRICULA_SOLICITANTE = 0;
                int? MATRICULA_RESPONSAVEL = null;
                int? MATRICULA_ANTIGO_RESPONSAVEL = null;

                var chamado_relacao = Demanda_BD.DEMANDA_RELACAO_CHAMADO.Find(data.ID_RELACAO);
                chamado_relacao.LastStatus = data.Status;

                if (data.MATRICULA_REDIRECIONADO.HasValue)
                {
                    chamado_relacao.MATRICULA_RESPONSAVEL = data.MATRICULA_REDIRECIONADO.Value;
                    switch (tabela)
                    {
                        case Tabela_Demanda.ChamadoRelacao:
                            var chamadored = Demanda_BD.DEMANDA_CHAMADO.Find(data.IdChamado);
                            MATRICULA_ANTIGO_RESPONSAVEL = chamadored.MATRICULA_RESPONSAVEL;
                            chamadored.MATRICULA_RESPONSAVEL = data.MATRICULA_REDIRECIONADO.Value;
                            MATRICULA_SOLICITANTE = chamadored.MATRICULA_SOLICITANTE;
                            MATRICULA_RESPONSAVEL = chamadored.MATRICULA_RESPONSAVEL;
                            break;

                        case Tabela_Demanda.AcessoRelacao:
                            var acessored = Demanda_BD.DEMANDA_ACESSOS.Find(data.IdChamado);
                            MATRICULA_ANTIGO_RESPONSAVEL = acessored.MATRICULA_RESPONSAVEL;
                            acessored.MATRICULA_RESPONSAVEL = data.MATRICULA_REDIRECIONADO.Value;
                            MATRICULA_SOLICITANTE = acessored.MATRICULA_SOLICITANTE;
                            MATRICULA_RESPONSAVEL = acessored.MATRICULA_RESPONSAVEL;
                            break;

                        case Tabela_Demanda.DesligamentoRelacao:
                            var desligared = Demanda_BD.DEMANDA_DESLIGAMENTOS.Find(data.IdChamado);
                            MATRICULA_ANTIGO_RESPONSAVEL = desligared.MATRICULA_RESPONSAVEL;
                            desligared.MATRICULA_RESPONSAVEL = data.MATRICULA_REDIRECIONADO.Value;
                            MATRICULA_SOLICITANTE = desligared.MATRICULA_SOLICITANTE;
                            MATRICULA_RESPONSAVEL = desligared.MATRICULA_RESPONSAVEL;
                            break;
                    }

                    Demanda_BD.SaveChanges();
                    if (MATRICULA_ANTIGO_RESPONSAVEL.HasValue)
                    {
                        var antigo_responsavel = Demanda_BD.ACESSOS_MOBILE
                            .Where(x => x.MATRICULA == MATRICULA_ANTIGO_RESPONSAVEL)
                            .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                            .First();
                        emailsender.Add(antigo_responsavel);
                    }


                    solicitante = Demanda_BD.ACESSOS_MOBILE
                        .Where(x => x.MATRICULA == MATRICULA_SOLICITANTE)
                        .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                        .First();

                    emailsender.Add(solicitante);

                    if (MATRICULA_RESPONSAVEL.HasValue)
                    {
                        responsavel = Demanda_BD.ACESSOS_MOBILE
                            .Where(x => x.MATRICULA == data.MATRICULA_REDIRECIONADO)
                            .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                            .First();
                        emailsender.Add(responsavel);
                    }

                    email = new SendEmailModel(emailsender.Select(x => x.EMAIL), null,
                                $"Vivo X :: Controle de Demandas :: Sua demanda N {chamado_relacao.Sequence} foi encaminhada para outro analista", $"",
                                $"Caro usuário,</p><br/><p>Sua demanda aberta no Vivo X (Módulo Controle de Demandas) sob o número <b>{chamado_relacao.Sequence}</b>" +
                                $" foi encaminhada para {responsavel?.DISPLAY_NOME} em {DateTime.Now.Date.ToString("dd/MM/yyyy")} as {DateTime.Now.Hour}h.</p>" +
                                $"<br/><p><b><u>Com a seguinte observação:</u></b></p><br/>" +
                                $"{data.resposta}" +
                                $"<p>Para maiores informações acessar chamado clicando <b><a href=\"http://brtdtbgs0090sl:8083/demandas/consultar/{retorno.ID_RELACAO}\">aqui<a/>.</b></p>" +
                                $"<br/><p style=\"color:red\">Caso tenha algum problema com a ferramenta, contate nosso suporte via e-mail NE_AUTOMACAO (<a href=\"mailto:ne_automacao.br@telefonica.com\">ne_automacao.br@telefonica.com</a>).</p>" +
                                $"<br/><p>Atenciosamente,</p>", null, new string[] { "ne_automacao.br@telefonica.com" });
                }

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

                        if (!data.MATRICULA_REDIRECIONADO.HasValue)
                        {
                            MATRICULA_SOLICITANTE = chamado_relacao.MATRICULA_SOLICITANTE;
                            MATRICULA_RESPONSAVEL = chamado_relacao.MATRICULA_RESPONSAVEL;

                            solicitante = Demanda_BD.ACESSOS_MOBILE
                                .Where(x => x.MATRICULA == MATRICULA_SOLICITANTE)
                                .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                                .First();

                            if (MATRICULA_RESPONSAVEL.HasValue)
                            {
                                responsavel = Demanda_BD.ACESSOS_MOBILE
                                    .Where(x => x.MATRICULA == MATRICULA_RESPONSAVEL)
                                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                                    .First();
                            }

                            switch (data.Status)
                            {
                                case "ABERTO":
                                    emailsender.Add(responsavel);
                                    break;
                                case "AGUARDANDO OUTRA ÁREA":
                                    emailsender.Add(solicitante);
                                    break;
                                case "AGUARDANDO ANALISTA":
                                    emailsender.Add(responsavel);
                                    break;
                                case "DEVOLVIDO PARA SOLICITANTE":
                                    emailsender.Add(solicitante);
                                    break;
                                case "CANCELADO":
                                    if (data.MATRICULA == MATRICULA_SOLICITANTE)
                                    {
                                        emailsender.Add(solicitante);
                                    }
                                    else
                                    {
                                        if (responsavel != null)
                                        {
                                            emailsender.Add(responsavel);
                                        }
                                    }
                                    break;
                                case "REPROVADO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "APROVADO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "REABERTO":
                                    emailsender.Add(responsavel);
                                    break;
                                default:
                                    break;
                            }

                            //email = new SendEmailModel(emailsender.Select(x => x.EMAIL), null, $"Mudança na demanda N {chamado.Relacao.Sequence}",
                            //    $"Status da demanda alterado por {responsavel_resposta.NOME}",
                            //    $"A demanda teve seu status alterado para {data.Status}, com o responsável principal: {responsavel?.DISPLAY_NOME}.</p>" +
                            //    $"<p>Acesse clicando <b><a href=\"http://brtdtbgs0090sl:8083/demandas/consultar/{retorno.ID_RELACAO}\">aqui<a/>.</b>", null,
                            //    new string[] { "ne_automacao.br@telefonica.com" });

                            email = new SendEmailModel(emailsender.Select(x => x.EMAIL), null,
                                    $"Vivo X :: Controle de Demandas :: Mudança na demanda N {chamado_relacao.Sequence}", $"",
                                    $"Caro usuário,</p><br/><p>Sua demanda aberta no Vivo X (Módulo Controle de Demandas) sob o número <b>{chamado_relacao.Sequence}</b>" +
                                    $" teve seu status alterado para {data.Status} em {DateTime.Now.Date.ToString("dd/MM/yyyy")} as {DateTime.Now.Hour}h.</p>" +
                                    $"<br/><p><b><u>Com a seguinte observação:</u></b></p><br/>" +
                                    $"{data.resposta}" +
                                    $"<p>Para maiores informações acessar chamado clicando <b><a href=\"http://brtdtbgs0090sl:8083/demandas/consultar/{retorno.ID_RELACAO}\">aqui<a/>.</b></p>" +
                                    $"<br/><p style=\"color:red\">Caso tenha algum problema com a ferramenta, contate nosso suporte via e-mail NE_AUTOMACAO (<a href=\"mailto:ne_automacao.br@telefonica.com\">ne_automacao.br@telefonica.com</a>).</p>" +
                                    $"<br/><p>Atenciosamente,</p>", null, new string[] { "ne_automacao.br@telefonica.com" });
                        }

                        Task.Run(() => _hubContext.UpdateDemanda(demanda as DEMANDAS_CHAMADO_DTO));
                        break;

                    case Tabela_Demanda.AcessoRelacao:
                        demanda = GetAcessoByID(data.IdChamado);

                        if (!data.MATRICULA_REDIRECIONADO.HasValue)
                        {
                            var acesso = demanda as ACESSO_TERCEIROS_DTO;
                            MATRICULA_SOLICITANTE = acesso.Solicitante.MATRICULA;
                            MATRICULA_RESPONSAVEL = acesso.Responsavel.MATRICULA;

                            solicitante = Demanda_BD.ACESSOS_MOBILE
                                .Where(x => x.MATRICULA == MATRICULA_SOLICITANTE)
                                .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                                .First();
                            if (MATRICULA_RESPONSAVEL.HasValue)
                            {
                                responsavel = Demanda_BD.ACESSOS_MOBILE
                                    .Where(x => x.MATRICULA == MATRICULA_RESPONSAVEL)
                                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                                    .First();
                            }

                            switch (data.Status)
                            {
                                case "ABERTO":
                                    emailsender.Add(responsavel);
                                    break;
                                case "AGUARDANDO OUTRA ÁREA":
                                    emailsender.Add(solicitante);
                                    break;
                                case "AGUARDANDO ANALISTA":
                                    emailsender.Add(responsavel);
                                    break;
                                case "DEVOLVIDO PARA SOLICITANTE":
                                    emailsender.Add(solicitante);
                                    break;
                                case "CANCELADO":
                                    if (data.MATRICULA == MATRICULA_SOLICITANTE)
                                    {
                                        emailsender.Add(solicitante);
                                    }
                                    else
                                    {
                                        if (responsavel != null)
                                        {
                                            emailsender.Add(responsavel);
                                        }
                                    }
                                    break;
                                case "AGUARDANDO TREINAMENTO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "AGUARDANDO CRIAÇÃO DE ACESSO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "REPROVADO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "APROVADO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "REABERTO":
                                    emailsender.Add(responsavel);
                                    break;
                                default:
                                    break;
                            }

                            //email = new SendEmailModel(emailsender.Select(x => x.EMAIL), null, $"Mudança na solicitação de acesso N {acesso.Relacao.Sequence}",
                            //    $"Status de solicitação de acesso alterado por {responsavel_resposta.NOME}",
                            //    $"A solicitação de acesso teve seu status alterado para {data.Status}, com o responsável principal: {responsavel?.DISPLAY_NOME}.</p>" +
                            //    $"<p>Acesse clicando <b><a href=\"http://brtdtbgs0090sl:8083/acessos/consultar/{retorno.ID_RELACAO}\">aqui<a/>.</b>", null,
                            //    new string[] { "ne_automacao.br@telefonica.com" });

                            email = new SendEmailModel(emailsender.Select(x => x.EMAIL), null,
                                    $"Vivo X :: Controle de Demandas :: Mudança na solicitação de acesso N {chamado_relacao.Sequence}", $"",
                                    $"Caro usuário,</p><br/><p>Sua solicitação de acesso aberta no Vivo X (Módulo Controle de Demandas) sob o número <b>{chamado_relacao.Sequence}</b>" +
                                    $" teve seu status alterado para {data.Status} em {DateTime.Now.Date.ToString("dd/MM/yyyy")} as {DateTime.Now.Hour}h.</p>" +
                                    $"<br/><p><b><u>Com a seguinte observação:</u></b></p><br/>" +
                                    $"{data.resposta}" +
                                    $"<p>Para maiores informações acessar chamado clicando <b><a href=\"http://brtdtbgs0090sl:8083/acessos/consultar/{retorno.ID_RELACAO}\">aqui<a/>.</b></p>" +
                                    $"<br/><p style=\"color:red\">Caso tenha algum problema com a ferramenta, contate nosso suporte via e-mail NE_AUTOMACAO (<a href=\"mailto:ne_automacao.br@telefonica.com\">ne_automacao.br@telefonica.com</a>).</p>" +
                                    $"<br/><p>Atenciosamente,</p>", null, new string[] { "ne_automacao.br@telefonica.com" });
                        }
                        break;

                    case Tabela_Demanda.DesligamentoRelacao:
                        var desligamento = Demanda_BD.DEMANDA_DESLIGAMENTOS.Find(data.IdChamado);
                        var mat_Desligada = Demanda_BD.DEMANDA_RELACAO_TREINAMENTO_FINALIZADO.FirstOrDefault(x => x.MATRICULA == desligamento.Matricula);

                        if (data.Status == STATUS_ACESSOS_PENDENTES.APROVADO.Value && mat_Desligada != null)
                        {
                            mat_Desligada.STATUS_MATRICULA = "INATIVO";
                            await Demanda_BD.SaveChangesAsync();
                        }

                        demanda = GetDesligamentoByID(data.IdChamado);

                        if (!data.MATRICULA_REDIRECIONADO.HasValue)
                        {
                            MATRICULA_SOLICITANTE = desligamento.Solicitante.MATRICULA;
                            MATRICULA_RESPONSAVEL = desligamento.Responsavel.MATRICULA;

                            solicitante = Demanda_BD.ACESSOS_MOBILE
                                .Where(x => x.MATRICULA == MATRICULA_SOLICITANTE)
                                .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                                .First();
                            if (MATRICULA_RESPONSAVEL.HasValue)
                            {
                                responsavel = Demanda_BD.ACESSOS_MOBILE
                                    .Where(x => x.MATRICULA == MATRICULA_RESPONSAVEL)
                                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                                    .First();
                            }

                            switch (data.Status)
                            {
                                case "ABERTO":
                                    emailsender.Add(responsavel);
                                    break;
                                case "AGUARDANDO OUTRA ÁREA":
                                    emailsender.Add(solicitante);
                                    break;
                                case "AGUARDANDO ANALISTA":
                                    emailsender.Add(responsavel);
                                    break;
                                case "DEVOLVIDO PARA SOLICITANTE":
                                    emailsender.Add(solicitante);
                                    break;
                                case "CANCELADO":
                                    if (data.MATRICULA == MATRICULA_SOLICITANTE)
                                    {
                                        emailsender.Add(solicitante);
                                    }
                                    else
                                    {
                                        if (responsavel != null)
                                        {
                                            emailsender.Add(responsavel);
                                        }
                                    }
                                    break;
                                case "AGUARDANDO TREINAMENTO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "AGUARDANDO CRIAÇÃO DE ACESSO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "REPROVADO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "APROVADO":
                                    emailsender.Add(solicitante);
                                    break;
                                case "REABERTO":
                                    emailsender.Add(responsavel);
                                    break;
                                default:
                                    break;
                            }

                            //email = new SendEmailModel(emailsender.Select(x => x.EMAIL), null, $"Mudança na solicitação de desligamento N {desligamento.Relacao.Sequence}",
                            //    $"Status de solicitação de desligamento alterado por {responsavel_resposta.NOME}",
                            //    $"A solicitação de desligamento teve seu status alterado para {data.Status}, com o responsável principal: {responsavel?.DISPLAY_NOME}.</p>" +
                            //    $"<p>Para ver todos os detalhes do chamado clique <b><a href=\"http://brtdtbgs0090sl:8083/acessos/consultar/{retorno.ID_RELACAO}\">aqui<a/>.</b>"
                            //    , null, new string[] { "ne_automacao.br@telefonica.com" });

                            email = new SendEmailModel(emailsender.Select(x => x.EMAIL), null,
                                $"Vivo X :: Controle de Demandas :: Mudança na solicitação de desligamento N {chamado_relacao.Sequence}", $"",
                                $"Caro usuário,</p><br/><p>Sua solicitação de desligamento aberta no Vivo X (Módulo Controle de Demandas) sob o número <b>{chamado_relacao.Sequence}</b>" +
                                $" teve seu status alterado para {data.Status} em {DateTime.Now.Date.ToString("dd/MM/yyyy")} as {DateTime.Now.Hour}h.</p>" +
                                $"<br/><p><b><u>Com a seguinte observação:</u></b></p><br/>" +
                                $"{data.resposta}" +
                                $"<p>Para maiores informações acessar chamado clicando <b><a href=\"http://brtdtbgs0090sl:8083/desligamentos/consultar/{retorno.ID_RELACAO}\">aqui<a/>.</b></p>" +
                                $"<br/><p style=\"color:red\">Caso tenha algum problema com a ferramenta, contate nosso suporte via e-mail NE_AUTOMACAO (<a href=\"mailto:ne_automacao.br@telefonica.com\">ne_automacao.br@telefonica.com</a>).</p>" +
                                $"<br/><p>Atenciosamente,</p>", null, new string[] { "ne_automacao.br@telefonica.com" });
                        }
                        break;
                    default:
                        demanda = null;
                        break;
                }

                await Demanda_BD.SaveChangesAsync();

                await _hubContext.NewStatusDemanda(data.Status, data.ID_RELACAO);

                await _service.SendEmail(email);
                email.Footer = "<div></div>";

                Task.Run(() => _service.SendTeams(email));

                Task.Run(() => _hubContext.UpdateStatusChamado(chamado_relacao));

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
                /* Necessário o ToList() para que os dois contextos do banco não tent<em executar consultas juntos e gerem erro */
                var opera_disp = CD.DEMANDA_BD_OPERADOREs.Where(x => x.STATUS == true && x.REGIONAL == data.REGIONAL).Select(x => x.MATRICULA).ToList();

                var fila = Demanda_BD.DEMANDA_SUB_FILA.Include(x => x.DEMANDA_RESPONSAVEL_FILAs.Where(y => opera_disp.Contains(y.MATRICULA_RESPONSAVEL)))
                    .First(x => x.ID_SUB_FILA == data.FILA_DTO.ID_SUB_FILA);
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
                    LastStatus = STATUS_ACESSOS_PENDENTES.ABERTO.Value,
                    REGIONAL = data.REGIONAL,
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
                    STATUS = STATUS_ACESSOS_PENDENTES.ABERTO.Value,
                    ID_RESPOSTA = demanda.Respostas.First().ID,
                    DATA = DateTime.Now
                });

                await Demanda_BD.SaveChangesAsync();

                var retorno = Demanda_BD.ACESSOS_MOBILE
                    .Where(x => x.MATRICULA == demanda.ChamadoRelacao.MATRICULA_RESPONSAVEL)
                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                    .First();

                var solicitante = Demanda_BD.ACESSOS_MOBILE
                    .Where(x => x.MATRICULA == demanda.ChamadoRelacao.MATRICULA_SOLICITANTE)
                    .ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider)
                    .First();

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };


                var matriculas = fila.DEMANDA_RESPONSAVEL_FILAs.Select(x => x.MATRICULA_RESPONSAVEL ?? 0).AsEnumerable();
                matriculas = matriculas.Append(demanda.MATRICULA_SOLICITANTE);

                await _hubContext.NewDemanda(demanda.ID_RELACAO, matriculas);

                await _hubContext.NewNotificationByUser(responsavel, demanda.ChamadoRelacao);
                await _hubContext.NewNotificationByUser(int.Parse(data.MAT_SOLICITANTE), demanda.ChamadoRelacao);

                var demandaCompleta = GetDemandaByID(demanda.ChamadoRelacao.ID);

                SendEmailModel email = new SendEmailModel(new string[] { retorno.EMAIL }, null, $"Nova demanda N {demandaCompleta.Relacao.Sequence}",
                    $"Nova demanda aberta por {solicitante.DISPLAY_NOME}",
                    $"Uma demanda demanda do tipo {demandaCompleta.Fila.ID_TIPO_FILANavigation.NOME_TIPO_FILA} e sub-fila {demandaCompleta.Fila.NOME_SUB_FILA} acaba de ser criada" +
                $" com o responsável principal {retorno.DISPLAY_NOME}, o sla para esta fila é de {(demandaCompleta.Fila.SLA > 24 ? $"{(demandaCompleta.Fila.SLA / 24)} dias" : $"{demandaCompleta.Fila.SLA} horas")} dias.</p>" +
                $"<p>Acesse clicando <b><a href=\"http://brtdtbgs0090sl:8083/demandas/consultar/{demanda.ID_RELACAO}\">aqui<a/>.</b>", null,
                new string[] { "ne_automacao.br@telefonica.com" });

                Task.Run(() => _service.SendEmail(email));
                email.Footer = "<div></div>";
                Task.Run(() => _service.SendTeams(email));

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
                        ex.InnerException.Message,
                        ex.Message,
                        ex.StackTrace,
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
                var Dados_Operadores = Demanda_BD.DEMANDA_BD_OPERADORES
                    .AsSplitQuery()
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
        public async Task<JsonResult> GetDataDash([FromBody] Tuple<IEnumerable<int>, IEnumerable<DateTime>, IEnumerable<ACESSOS_MOBILE_DTO>?, int?, int?> Data, string regional, int matricula,
            //Nullable Parameters
            string? status, bool Comprioridade, bool Semprioridade)
        {
            try
            {
                IQueryable<DEMANDA_CHAMADO?> linqFiltered = Demanda_BD.DEMANDA_CHAMADO.Where(x => x.REGIONAL == regional);

                if (Data.Item1.Any(x => new int[] { 1, 20 }.Contains(x))) //filtra demandas por gerente
                {
                    if (Data.Item3.Any()) // filtro pro Analista
                        linqFiltered = linqFiltered.Where(x => Data.Item3.Select(x => x.MATRICULA).Contains(x.MATRICULA_RESPONSAVEL.Value));

                    if (!string.IsNullOrEmpty(status)) // filtro por status
                        linqFiltered = linqFiltered.Include(x => x.Relacao)
                            .Where(x => x.Relacao.Status.Any() && x.Relacao.Status.OrderBy(y => y.DATA).Last().STATUS == status);
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

                if (Comprioridade || Semprioridade)
                {
                    if (Comprioridade)
                        linqFiltered = linqFiltered.Where(x => x.Relacao.PRIORIDADE == true);
                    else if (Semprioridade)
                        linqFiltered = linqFiltered.Where(x => x.Relacao.PRIORIDADE == false);
                }

                if (Data.Item4 is not null && Data.Item4 != 0)
                    linqFiltered = linqFiltered.Where(x => x.Fila.ID_TIPO_FILA == Data.Item4);

                if (Data.Item5 is not null && Data.Item5 != 0)
                    linqFiltered = linqFiltered.Where(x => x.Fila.ID_SUB_FILA == Data.Item5);


                var Total_de_Demandas = linqFiltered
                    .Count();

                int Concluído = 0;
                int Em_andamento = 0;
                double Porc_Primeiro_SLA_24h = 0.0;
                double Porc_Dentro_SLA = 0.0;
                int Qtd_Dentro_SLA = 0;
                int Aguardando_outra_área = 0;
                int Em_Aberto = 0;
                int Devolvido = 0;
                int DemandaPrioridade = 0;
                if (Total_de_Demandas > 0)
                {

                    Concluído = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS == STATUS_ACESSOS_PENDENTES.APROVADO.Value)
                        .Count();

                    Em_andamento = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS != STATUS_ACESSOS_PENDENTES.APROVADO.Value)
                        .Count();

                    var list24Diferences = linqFiltered
                          .Where(x => x.Relacao.Status.Count > 1)
                          .Select(x => calculeDate(x.Relacao.Status.OrderBy(k => k.DATA).First().DATA, x.Relacao.Status.OrderBy(k => k.DATA).ElementAt(1).DATA));

                    var Qtd_Primeiro_SLA_24h = list24Diferences.AsEnumerable()
                          .Where(x => x <= 24)
                          .Count();

                    Porc_Primeiro_SLA_24h = Math.Round((Qtd_Primeiro_SLA_24h / (double)Total_de_Demandas) * 100.0, 1);

                    var list_Dentro_SLA = linqFiltered
                          .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).Last().STATUS == STATUS_ACESSOS_PENDENTES.APROVADO.Value)
                          .Select(x => new { lastdate = x.Relacao.Status.OrderBy(k => k.DATA).Last().DATA, dt_abertura = x.DATA_ABERTURA.Value, sla = x.Fila.SLA })
                          .AsEnumerable();

                    Qtd_Dentro_SLA = list_Dentro_SLA.Where(x => calculeDate(x.lastdate, x.dt_abertura) <= x.sla).Count();

                    Porc_Dentro_SLA = Math.Round((Qtd_Dentro_SLA / (double)Total_de_Demandas) * 100.0, 1);

                    Aguardando_outra_área = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS == STATUS_ACESSOS_PENDENTES.AGUARDANDO_OUTRA_AREA.Value)
                        .Count();
                    Em_Aberto = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS == STATUS_ACESSOS_PENDENTES.ABERTO.Value)
                        .Count();
                    Devolvido = linqFiltered
                        .Where(x => x.Relacao.Status.OrderBy(k => k.DATA).LastOrDefault().STATUS == STATUS_ACESSOS_PENDENTES.AGUARDANDO_ANALISTA.Value)
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
                          Qtd_Dentro_SLA,
                          Aguardando_outra_área,
                          Em_Aberto,
                          Devolvido,
                          DemandaPrioridade
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

        [HttpGet("AnalistaSuporte/Get/{IsSuporte}/{IsAcessoLogico}/{SubFila}/{regional}/{matricula}")]
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
                    .Where(x => x.REGIONAL == regional && x.STATUS == true)
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

        [HttpPost("GetAllChamados")]
        //[ResponseCache(VaryByHeader = "User-Agent", Duration = int.MaxValue, NoStore = false, Location = ResponseCacheLocation.Any)]
        //[OutputCache(Duration = int.MaxValue, Tags = new string[] { "AllDemandas" }, NoStore = false, VaryByHeaderNames = new string[] { "User-Agent" })]
        public IActionResult GetAllChamados([FromBody] GenericPaginationModel<PainelChamadosModel> filter)
        {
            try
            {
                /*** Sempre utilizamos apenas os chamados do último ano ***/
                IQueryable<DEMANDA_RELACAO_CHAMADO> data = Demanda_BD.DEMANDA_RELACAO_CHAMADO.AsSplitQuery()
                    .Where(x => x.REGIONAL == filter.Value.regional && x.Respostas.First().DATA_RESPOSTA >= DateTime.Now.AddYears(-1)
                        && x.Respostas.First().DATA_RESPOSTA <= DateTime.Now)
                    .AsNoTracking().AsQueryable();


                var list_ids = Demanda_BD.DEMANDA_RESPONSAVEL_FILA
                    .Where(x => x.MATRICULA_RESPONSAVEL == filter.Value.matricula)
                    .Select(x => x.ID_SUB_FILA).AsEnumerable();

                switch (filter.Value.role)
                {
                    /** Consulta para usuários básicos **/
                    case Controle_Demanda_role.BASICO:

                        data = data.Where(x => x.MATRICULA_SOLICITANTE == filter.Value.matricula);
                        break;

                    /** Consulta para analistas do suporte que não tratam solicitação de acessos terceiro **/
                    case Controle_Demanda_role.ANALISTA:

                        data = data.Where(x => x.Tabela == Tabela_Demanda.ChamadoRelacao
                        && x.ChamadoRelacao != null && list_ids.Contains(x.ChamadoRelacao.Fila.ID_SUB_FILA)
                        && x.REGIONAL == filter.Value.regional);
                        break;

                    /** Consulta para analistas do suporte que tratam solicitação de acessos terceiro **/
                    case Controle_Demanda_role.ANALISTA_ACESSO:

                        //var datademandaanalistaacesso = data.Where(x => x.Tabela == Tabela_Demanda.ChamadoRelacao
                        //    && x.ChamadoRelacao != null && list_ids.Contains(x.ChamadoRelacao.Fila.ID_SUB_FILA));

                        //var dataacessoanalistaacesso = data.Where(x => x.Tabela == Tabela_Demanda.AcessoRelacao);

                        //data = datademandaanalistaacesso.UnionBy(dataacessoanalistaacesso, x => x.ID_RELACAO);
                        data = data.Where(x => (x.Tabela == Tabela_Demanda.ChamadoRelacao
                            && x.ChamadoRelacao != null && list_ids.Contains(x.ChamadoRelacao.Fila.ID_SUB_FILA)) || (x.Tabela == Tabela_Demanda.AcessoRelacao));

                        break;

                    /** Consulta para gerente do suporte **/
                    case Controle_Demanda_role.GERENTE:

                        break;
                }

                var lista = data.OrderBy(x => x.Sequence)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize);

                var totalRecords = data.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                var Data = lista.AsSplitQuery()
                    .Include(x => x.AcessoRelacao)
                    .Include(x => x.ChamadoRelacao)
                    .Include(x => x.DesligamentoRelacao)
                    .Include(x => x.Solicitante)
                    .Include(x => x.Responsavel)
                    .ProjectTo<DEMANDA_DTO>(_mapper.ConfigurationProvider);

                return Ok(new Response<PagedModelResponse<IEnumerable<DEMANDA_DTO>>>
                {
                    Data = PagedResponse.CreatePagedReponse(Data, filter, totalRecords),
                    Message = "Sucessfull",
                    Errors = [],
                    Succeeded = true
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<string>
                {
                    Data = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitação da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.InnerException.Message,
                        ex.Message,
                        ex.StackTrace,
                    },
                });
            }
        }

        [HttpGet("GetAllIndexChamado")]
        public async Task<IActionResult> GetAllIndexChamado(int MATRICULA, Controle_Demanda_role role, string regional)
        {
            try
            {
                IEnumerable<DEMANDA_DTO> data = new DEMANDA_DTO[0];

                /*** Sempre utilizamos apenas os chamados do último ano ***/
                var dataBeforeFilter = Demanda_BD.DEMANDA_RELACAO_CHAMADO
                   .Where(x => x.Respostas.First().DATA_RESPOSTA >= DateTime.Now.AddYears(-1)
                       && x.Respostas.First().DATA_RESPOSTA <= DateTime.Now && x.REGIONAL == regional)
                   .AsNoTracking();

                var first20 = dataBeforeFilter
                    .ProjectTo<DEMANDA_DTO>(_mapper.ConfigurationProvider)
                    .OrderByDescending(x => x.PRIORIDADE)
                    .ThenByDescending(x => x.PRIORIDADE_SEGMENTO)
                    .ThenBy(x => x.Sequence).Take(20).ToList();

                var dataresp = dataBeforeFilter
                    .Where(x => x.MATRICULA_SOLICITANTE == MATRICULA)
                    .ProjectTo<DEMANDA_DTO>(_mapper.ConfigurationProvider)
                    .Take(20).ToList();

                data = dataresp.UnionBy(first20, x => x.ID_RELACAO);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(new DEMANDA_DTO[0]);
            }
        }

        [HttpGet("GetAnalistaObservacao")]
        public IEnumerable<DEMANDA_OBSERVACOES_ANALISTAS> GetAnalistaObservacao(Guid idChamado, int matricula, bool takeall)
        {
            try
            {
                var data = Demanda_BD.DEMANDA_OBSERVACOES_ANALISTAS
                    .Where(x => x.ID_RELACAO == idChamado && x.MAT_ANALISTA == matricula)
                    .IgnoreAutoIncludes()
                    .AsNoTracking().ToList();

                if (takeall)
                    return data;
                else
                    return data.Take(1);
            }
            catch (Exception ex)
            {
                return [];
            }
        }

        [HttpPost("PostAnalistaObservacao")]
        public IEnumerable<DEMANDA_OBSERVACOES_ANALISTAS> PostAnalistaObservacao(Guid idChamado, int matricula, string Observacao)
        {
            try
            {
                Demanda_BD.DEMANDA_OBSERVACOES_ANALISTAS.Add(new DEMANDA_OBSERVACOES_ANALISTAS(idChamado, DateTime.Now, matricula, Observacao));
                Demanda_BD.SaveChanges();

                var data = Demanda_BD.DEMANDA_OBSERVACOES_ANALISTAS
                    .Where(x => x.ID_RELACAO == idChamado && x.MAT_ANALISTA == matricula)
                    .IgnoreAutoIncludes()
                    .AsNoTracking();

                return data;
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
            /* Feriados de Recife */
            new DateTime(ano, 6, 24), // São João
            new DateTime(ano, 7, 16), // Nossa senhora do Carmo
            new DateTime(ano, 12, 8), // Nosa Senhora da Conceição

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
