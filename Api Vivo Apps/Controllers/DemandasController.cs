using Newtonsoft.Json;
using Vivo_Apps_API.Models;
using Vivo_Apps_API.Hubs;
using Microsoft.AspNetCore.Mvc;
using Shared_Class_Vivo_Apps.Data;
using Shared_Class_Vivo_Apps.Model_DTO;
using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using AutoMapper.QueryableExtensions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using Shared_Class_Vivo_Apps.Enums;
using System.Data;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemandasController : ControllerBase
    {
        private readonly ILogger<DemandasController> _logger;
        private readonly IMapper _mapper;
        private readonly IHubContext<VivoXHub> _hubContext;
        public DemandasController(ILogger<DemandasController> logger, IHubContext<VivoXHub> hubContext)
        {
            _logger = logger;
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<CONTROLE_DE_DEMANDAS_FILA, DEMANDAS_FILA_DTO>();
                //cfg.CreateMap<CONTROLE_DE_DEMANDAS_CAMPOS_FILA, DEMANDAS_CAMPOS_FILA_DTO>();                
                //cfg.CreateMap<CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA, DEMANDAS_CAMPO_COMBOBOX_FILA_DTO>();

                cfg.CreateMap<DEMANDA_TIPO_FILA, DEMANDA_TIPO_FILA_DTO>();
                cfg.CreateMap<DEMANDA_SUB_FILA, DEMANDA_SUB_FILA_DTO>()
                .ForMember(
                    dest => dest.Responsaveis,
                    opt => opt.MapFrom(src => CD.ACESSOS_MOBILEs.Where(y =>
                        CD.DEMANDA_RESPONSAVEL_FILAs
                                .Where(x => x.ID_SUB_FILA == src.ID_SUB_FILA)
                                .Select(x => x.MATRICULA_RESPONSAVEL)
                                .Distinct()
                                .Contains(y.MATRICULA)))
                    );
                cfg.CreateMap<DEMANDA_CAMPOS_FILA, DEMANDA_CAMPOS_FILA_DTO>()
                .ForMember(
                    dest => dest.DEMANDA_VALORES_CAMPOS_SUSPENSOs,
                    opt => opt.MapFrom(src => CD.DEMANDA_VALORES_CAMPOS_SUSPENSOs.Where(y => y.STATUS == true))
                    );
                cfg.CreateMap<DEMANDA_VALORES_CAMPOS_SUSPENSO, DEMANDA_VALORES_CAMPOS_SUSPENSO_DTO>();

                cfg.CreateMap<ACESSO, ACESSO_DTO>();
                cfg.CreateMap<ACESSOS_MOBILE, ACESSOS_MOBILE_DTO>()
                .ForMember(
                    dest => dest.CARGO,
                    opt => opt.MapFrom(src => (Cargos)src.CARGO)
                    )
                .ForMember(
                    dest => dest.CANAL,
                    opt => opt.MapFrom(src => (Canal)src.CANAL)
                    );

                cfg.CreateMap<CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO, DEMANDAS_STATUS_CHAMADO_DTO>()
                .ForMember(
                    dest => dest.RESPOSTAS,
                    opt => opt.MapFrom(src => CD.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTAs
                                .Where(x => x.ID == src.ID_RESPOSTA).FirstOrDefault())
                    )
                .ForMember(
                    dest => dest.MAT_QUEM_REDIRECIONOU,
                    opt => opt.MapFrom(src => CD.ACESSOs
                                .Where(x => x.Login == src.MAT_QUEM_REDIRECIONOU)
                                .FirstOrDefault())
                    );

                cfg.CreateMap<CONTROLE_DE_DEMANDAS_CHAMADO_ARQUIVO, DEMANDAS_CHAMADO_ARQUIVO_DTO>();
                cfg.CreateMap<CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADO, DEMANDAS_CAMPOS_CHAMADO_DTO>();
                cfg.CreateMap<CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTum, DEMANDAS_CHAMADO_RESPOSTA_DTO>()
                .ForMember(
                    dest => dest.MATRICULA_RESPONSAVEL,
                    opt => opt.MapFrom(src => CD.ACESSOs
                                .Where(x => x.Login == src.MATRICULA_RESPONSAVEL)
                                .FirstOrDefault())
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
                cfg.CreateMap<CONTROLE_DEMANDAS_ARQUIVOS_RESPOSTum, DEMANDAS_ARQUIVOS_RESPOSTA_DTO>();

                cfg.CreateMap<CONTROLE_DE_DEMANDAS_CHAMADO, PAINEL_DEMANDAS_CHAMADO_DTO>()
               .ForMember(
                   dest => dest.ID_FILA_CHAMADO,
                   opt => opt.MapFrom(src => CD.CONTROLE_DE_DEMANDAS_FILAs
                               .Where(x => x.ID == src.ID_FILA_CHAMADO).First())
                   )
               .ForMember(
                   dest => dest.ID_STATUS_CHAMADO,
                   opt => opt.MapFrom(src => CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
                               .Where(x => x.ID_STATUS_CHAMADO == src.ID_STATUS_CHAMADO))
                   )
               .ForMember(
                   dest => dest.MATRICULA_RESPONSAVEL,
                   opt => opt.MapFrom(src => CD.ACESSOs
                               .Where(x => x.Login == src.MATRICULA_RESPONSAVEL)
                               .FirstOrDefault())
                   )
               .ForMember(
                   dest => dest.MATRICULA_SOLICITANTE,
                   opt => opt.MapFrom(src => CD.ACESSOs
                               .Where(x => x.Login == src.MATRICULA_SOLICITANTE)
                               .FirstOrDefault()));

                //cfg.CreateMap<CONTROLE_DE_DEMANDAS_CHAMADO, DEMANDAS_CHAMADO_DTO>()
                //.ForMember(
                //    dest => dest.CAMPOS,
                //    opt => opt.MapFrom(src => CD.CONTROLE_DE_DEMANDAS_CAMPOS_CHAMADOs.Where(x => x.ID_CHAMADO == src.ID).AsEnumerable())
                //    )
                //.ForMember(
                //    dest => dest.STATUS,
                //    opt => opt.MapFrom(src => CD.CONTROLE_DE_DEMANDAS_STATUS_CHAMADOs.Where(x => x.ID_CHAMADO == src.ID).AsEnumerable())
                //    )
                //.ForMember(
                //    dest => dest.FILA,
                //    opt => opt.MapFrom(src => src.ID_FILA_CHAMADONavigation)
                //    )
                //.ForMember(
                //    dest => dest.ANEXOS_ABERTURA,
                //    opt => opt.MapFrom(src => src.CONTROLE_DE_DEMANDAS_CHAMADO_ARQUIVOs)
                //    )
                //.ForMember(
                //    dest => dest.RESPOSTAS,
                //    opt => opt.MapFrom(src => src.CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTa)
                //    )
                //.ForMember(
                //    dest => dest.RESPONSAVEL,
                //    opt => opt.MapFrom(src => CD.ACESSOs
                //                .Where(x => x.Login == src.MATRICULA_RESPONSAVEL)
                //                .FirstOrDefault()))
                //.ForMember(
                //    dest => dest.SOLICITANTE,
                //    opt => opt.MapFrom(src => CD.ACESSOs
                //                .Where(x => x.Login == src.MATRICULA_SOLICITANTE)
                //                .FirstOrDefault())
                //    );
            });
            _mapper = config.CreateMapper();
        }

        private Vivo_MaisContext CD = new Vivo_MaisContext();

        [HttpGet("GetAnalistasByRegional")]
        [ProducesResponseType(typeof(Response<IEnumerable<ACESSOS_MOBILE_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetAnalistasByRegional(string regional)
        {
            try
            {
                var AnalistaSuporte = CD.ACESSOS_MOBILEs.Where(x =>
                    CD.CONTROLE_DE_DEMANDAS_OPERADOREs.Where(y => y.UF == regional)
                            .Select(x => x.LOGIN)
                            .Distinct()
                            .Contains(x.MATRICULA)
                ).ProjectTo<ACESSOS_MOBILE_DTO>(_mapper.ConfigurationProvider).ToList();

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
        public JsonResult AddNewFila([FromBody] DEMANDA_TIPO_FILA_DTO data, string matricula, string regional)
        {
            try
            {
                var NewFila = CD.DEMANDA_TIPO_FILAs.Add(new DEMANDA_TIPO_FILA
                {
                    DT_CRIACAO = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    MAT_CRIADOR = int.Parse(matricula),
                    NOME_TIPO_FILA = data.NOME_TIPO_FILA,
                    REGIONAL = regional,
                    STATUS_TIPO_FILA = true
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
                            MAT_CRIADOR = int.Parse(matricula),
                            NOME_SUB_FILA = sub_fila.NOME_SUB_FILA,
                            REGIONAL = regional,
                            STATUS_SUB_FILA = true
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
                                    MAT_CRIADOR = int.Parse(matricula),
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
        public JsonResult AddNewSubFila([FromBody] DEMANDA_TIPO_FILA_DTO data, string matricula, string regional)
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
                            MAT_CRIADOR = int.Parse(matricula),
                            NOME_SUB_FILA = sub_fila.NOME_SUB_FILA,
                            REGIONAL = regional,
                            STATUS_SUB_FILA = true
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
                                    MAT_CRIADOR = int.Parse(matricula),
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
        public JsonResult EditSubFila([FromBody] DEMANDA_SUB_FILA_DTO data, string matricula, string regional)
        {
            try
            {
                var NewSubFila = CD.DEMANDA_SUB_FILAs.Find(data.ID_SUB_FILA);

                NewSubFila.CAMPOS_AUTO = data.CAMPOS_AUTO;
                NewSubFila.CAMPOS_IDENT_USER = data.CAMPOS_IDENT_USER;
                NewSubFila.NOME_SUB_FILA = data.NOME_SUB_FILA;
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
                                    MAT_CRIADOR = int.Parse(matricula),
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
                        List<string> listaOperadores = CD.DEMANDA_RESPONSAVEL_FILAs.Where(x =>
                            x.ID_SUB_FILA == data.ID_SUB_FILA).Select(x => x.MATRICULA_RESPONSAVEL).ToList();
                        // Buscando todas os responsaveis que já existe dentro da fila
                        if (data.Responsaveis.Count > listaOperadores.Count) // Usuário adicionado
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
                        else if (data.Responsaveis.Count < listaOperadores.Count) // Usuário Excluido
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
                var fila = CD.DEMANDA_SUB_FILAs.Where(x => x.ID_SUB_FILA == id)
                        .ProjectTo<DEMANDA_SUB_FILA_DTO>(_mapper.ConfigurationProvider).FirstOrDefault();

                return new JsonResult(new Response<DEMANDA_SUB_FILA_DTO>
                {
                    Data = fila,
                    Succeeded = true,
                    Message = "",
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
                        dataBeforeFilter = dataBeforeFilter.Where(k =>
                            CD.DEMANDA_TIPO_FILAs
                                .Where(postAndMeta => filter.Value.tipo_fila.Select(x => x.ID_TIPO_FILA).Contains(postAndMeta.ID_TIPO_FILA))
                                .Select(l => l.ID_TIPO_FILA).Contains(k.ID_TIPO_FILA));

                        if (filter.Value.fila is not null)
                        {
                            if (filter.Value.fila.Any())
                            {
                                dataBeforeFilter = dataBeforeFilter.Where(k =>
                                CD.DEMANDA_SUB_FILAs
                                    .Where(postAndMeta => filter.Value.fila.Select(x => x.ID_SUB_FILA).Contains(postAndMeta.ID_SUB_FILA))
                                    .Select(l => l.ID_TIPO_FILA).Contains(k.ID_TIPO_FILA));
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
                                    .Where(postAndMeta => filter.Value.responsável.Select(x => x.Login).Contains(postAndMeta.MATRICULA_RESPONSAVEL))
                                    .Select(l => l.ID_SUB_FILA).Contains(k.ID_SUB_FILA)
                        );
                    }
                }

                var dataAfterFilter = dataBeforeFilter.OrderByDescending(x => x.ID_SUB_FILA)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize);

                var demandas = dataAfterFilter
                        //.ProjectTo<PAINEL_DEMANDAS_CHAMADO_DTO>(_mapper.ConfigurationProvider)
                        .ToList();

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

                datafilters.filas = CD.DEMANDA_TIPO_FILAs
                    .Where(x => x.REGIONAL == regional)
                    .IgnoreAutoIncludes()
                    .ProjectTo<DEMANDA_TIPO_FILA_DTO>(_mapper.ConfigurationProvider);

                datafilters.tipo_filas = CD.DEMANDA_SUB_FILAs
                    .Where(x => x.REGIONAL == regional)
                    .IgnoreAutoIncludes()
                    .ProjectTo<DEMANDA_SUB_FILA_DTO>(_mapper.ConfigurationProvider);

                datafilters.AnalistaSuporte = CD.ACESSOs.Where(x =>
                    CD.DEMANDA_RESPONSAVEL_FILAs
                            .Select(x => x.MATRICULA_RESPONSAVEL)
                            .Distinct()
                            .Contains(x.Login)
                ).ProjectTo<ACESSO_DTO>(_mapper.ConfigurationProvider).ToList();

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
                var fila = CD.CONTROLE_DE_DEMANDAS_FILAs.Where(x => x.REGIONAL == regional)
                    .GroupBy(x => new { FILA = x.FILA, TIPO_FILA = x.TIPO_CHAMADO })
                    .Select(y => new
                    {
                        FILA = y.Key.FILA,
                        TIPO_FILA = y.Key.TIPO_FILA,
                    });

                var analistassuporte = CD.ACESSOs.Where(k => k.Regional == regional).Where(k =>
                    CD.DEMANDA_RESPONSAVEL_FILAs.Select(x => x.MATRICULA_RESPONSAVEL).Distinct().Contains(k.Login)
                    );
                var status = CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs.Select(k => k.STATUS).Distinct();

                return new JsonResult(new Response<object>
                {
                    Data = new
                    {
                        analistassuporte,
                        fila,
                        status
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


        [HttpGet("GetFilas")]
        [ProducesResponseType(typeof(Response<IEnumerable<DEMANDA_TIPO_FILA_DTO>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetFilas()
        {
            try
            {
                var Dados_Fila = CD.DEMANDA_TIPO_FILAs
                    .Include(x => x.DEMANDA_SUB_FILAs)
                        .ThenInclude(x => x.DEMANDA_RESPONSAVEL_FILAs)
                    .ProjectTo<DEMANDA_TIPO_FILA_DTO>(_mapper.ConfigurationProvider)
                    .AsEnumerable();

                return new JsonResult(new Response<IEnumerable<DEMANDA_TIPO_FILA_DTO>>
                {
                    Data = Dados_Fila,
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

        [HttpGet("GetDadosFilaByID")]
        [ProducesResponseType(typeof(Response<DATA_CRIAR_DEMANDA>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDadosFilaByID(int id)
        {
            try
            {
                var Dados_Fila = CD.DEMANDA_TIPO_FILAs.Where(x => x.ID_TIPO_FILA == id)
                    .ProjectTo<DEMANDA_TIPO_FILA_DTO>(_mapper.ConfigurationProvider).FirstOrDefault();

                var Carteira = CD.Carteira_NEs.Where(x => x.ANOMES == CD.Carteira_NEs.Max(y => y.ANOMES));
                var Sap = CD.CNS_BASE_TERCEIROS_SAP_GTs.ToList();

                return new JsonResult(new Response<DATA_CRIAR_DEMANDA>
                {
                    Data = new DATA_CRIAR_DEMANDA
                    {
                        Dados_Fila = Dados_Fila ?? new DEMANDA_TIPO_FILA_DTO(),
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
                    ID_RESPOSTA = chamado.ID,
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
                    ID_RESPOSTA = retorno.ID
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
        public string AbrirDemanda(AbrirDemandaModel data)
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

        [HttpPost("GetDemandasList")]
        [ProducesResponseType(typeof(Response<PagedModelResponse<IEnumerable<PAINEL_DEMANDAS_CHAMADO_DTO>>>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public JsonResult GetDemandasList([FromBody] GenericPaginationModel<PaginationDemandasModel> filter)
        {
            try
            {
                var dataBeforeFilter = CD.CONTROLE_DE_DEMANDAS_CHAMADOs.AsQueryable();

                //if (!string.IsNullOrEmpty(filter.Value.matricula))
                //{
                //    dataBeforeFilter = dataBeforeFilter.Where(x => x.MATRICULA_SOLICITANTE == filter.Value.matricula);
                //}

                //if (filter.Value.datas is not null)
                //{
                //    if (filter.Value.datas.Count() == 2)
                //    {
                //        dataBeforeFilter = dataBeforeFilter.Where(x => x.DATA_ABERTURA >= filter.Value.datas[0] &&
                //        x.DATA_ABERTURA <= filter.Value.datas[1]);
                //    }
                //}

                //if (filter.Value.regional is not null)
                //{

                //    if (filter.Value.regional.Any())
                //    {
                //        dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.regional.Contains(x.REGIONAL));
                //    }
                //}

                //if (filter.Value.status is not null)
                //{
                //    if (filter.Value.status.Any())
                //    {
                //        dataBeforeFilter = dataBeforeFilter
                //                    .Where(c => filter.Value.status.Contains(
                //                        CD.CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADOs
                //                            .Where(s => s.ID_STATUS_CHAMADO == c.ID_STATUS_CHAMADO)
                //                            .OrderByDescending(s => s.DATA)
                //                            .Select(s => s.STATUS)
                //                            .FirstOrDefault()));
                //    }
                //}

                //if (filter.Value.tipo_fila is not null)
                //{
                //    if (filter.Value.tipo_fila.Any())
                //    {
                //        dataBeforeFilter = dataBeforeFilter.Where(k =>
                //            CD.CONTROLE_DE_DEMANDAS_FILAs
                //                .Where(postAndMeta => filter.Value.tipo_fila.Select(x => x.TIPO_FILA).Contains(postAndMeta.TIPO_CHAMADO))
                //                .Select(l => l.ID).Contains(k.ID_FILA_CHAMADO));

                //        if (filter.Value.fila is not null)
                //        {
                //            if (filter.Value.fila.Any())
                //            {
                //                dataBeforeFilter = dataBeforeFilter.Where(k =>
                //                CD.CONTROLE_DE_DEMANDAS_FILAs
                //                    .Where(postAndMeta => filter.Value.fila.Select(x => x.FILA).Contains(postAndMeta.FILA))
                //                    .Select(l => l.ID).Contains(k.ID_FILA_CHAMADO));
                //            }
                //        }
                //    }
                //}

                //if (filter.Value.responsável is not null)
                //{
                //    if (filter.Value.responsável.Any())
                //    {
                //        dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.responsável.Select(y => y.Login).Contains(x.MATRICULA_RESPONSAVEL));
                //    }
                //}

                //if (filter.Value.id_demandas is not null)
                //{
                //    if (filter.Value.id_demandas.Any())
                //    {
                //        dataBeforeFilter = dataBeforeFilter.Where(x => filter.Value.id_demandas.Contains(x.ID.ToString()));
                //    }
                //}

                var dataAfterFilter = dataBeforeFilter.OrderByDescending(x => x.ID)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize);

                var demandas = dataAfterFilter.AsNoTracking()
                        .ProjectTo<PAINEL_DEMANDAS_CHAMADO_DTO>(_mapper.ConfigurationProvider).AsEnumerable();

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
        public JsonResult AtivarOperadorSuporte(int id)
        {
            try
            {
                var user = CD.DEMANDA_BD_OPERADOREs.Find(id);
                user.STATUS = true;

                var saida = CD.SaveChanges();
                
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
        public JsonResult DesativarOperadorSuporte(int id)
        {
            try
            {
                var user = CD.DEMANDA_BD_OPERADOREs.Find(id);
                user.STATUS = false;

                var saida = CD.SaveChanges();
                
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
        public JsonResult AddOperadoresSuporte([FromBody] List<DEMANDA_BD_OPERADORES_DTO> newoperador)
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

    }
}
