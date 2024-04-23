using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Vivo_Apps_API.Models;
using Shared_Static_Class.Data;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Enums;
using System.Linq;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.StaticFiles;
using static Vivo_Apps_API.Models.Converters.Converters;


namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControleADMController : ControllerBase
    {
        private Vivo_MaisContext CD = new Vivo_MaisContext();

        private readonly ILogger<ControleADMController> _logger;

        public ControleADMController(ILogger<ControleADMController> logger)
        { 
            _logger = logger;
        }

        [HttpPost("UpdateSenhaUser")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> UpdateSenhaUser(string old, string newone, string confirmnewone, int matricula)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == matricula).FirstOrDefault();
                if (user.SENHA != CryptSenha(old))
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "A senha antiga informada está incorreta",
                        Succeeded = false,
                        Errors = new string[] {
                            "A senha antiga informada está incorreta"
                        },
                        Message = "A senha antiga informada está incorreta, por favor tente novamente"
                    });
                }
                else if (newone != confirmnewone)
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "A nova senha informada não é igual a senha de confirmação",
                        Succeeded = false,
                        Errors = new string[] {
                            "A nova senha informada não é igual a senha de confirmação"
                        },
                        Message = "A nova senha informada não é igual a senha de confirmação, por favor tente novamente"
                    });
                }
                else
                {
                    user.SENHA = CryptSenha(newone);
                    await CD.SaveChangesAsync();
                    return new JsonResult(new Response<string>
                    {
                        Data = "Tudo certo, sua senha foi alterada com sucesso!",
                        Succeeded = true,
                        Message = "Tudo certo, sua senha foi alterada com sucesso!"
                    });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = ex.Message,
                    Succeeded = false,
                    Errors = new string[] {
                    ex.Message
                    },
                    Message = "Houve algum erro ao executar esta ação"
                });
            }
        }

        [HttpPost("UpdateSenhaUserByMatricula")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> UpdateSenhaUserByMatricula(string newone, string confirmnewone, int matricula)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == matricula).FirstOrDefault();

                if (newone != confirmnewone)
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "A nova senha informada não é igual a senha de confirmação",
                        Succeeded = false,
                        Errors = new string[] {
                            "A nova senha informada não é igual a senha de confirmação"
                        },
                        Message = "A nova senha informada não é igual a senha de confirmação, por favor tente novamente"
                    });
                }
                else
                {
                    user.SENHA = CryptSenha(newone);
                    await CD.SaveChangesAsync();
                    return new JsonResult(new Response<string>
                    {
                        Data = "Tudo certo, sua senha foi alterada com sucesso!",
                        Succeeded = true,
                        Message = "Tudo certo, sua senha foi alterada com sucesso!"
                    });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = ex.Message,
                    Succeeded = false,
                    Errors = new string[] {
                    ex.Message
                    },
                    Message = "Houve algum erro ao executar esta ação"
                });
            }
        }

        [HttpPost("ValidateEmailByMatricula")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        [ProducesResponseType(typeof(Response<string>), 500)]
        public async Task<JsonResult> ValidateEmailByMatricula(int matricula)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.MATRICULA == matricula).FirstOrDefault();

                if (user is null)
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Usuário não existe em nossa base de usuários do Vivo Task",
                        Succeeded = false,
                        Errors = new string[] {
                            "Usuário não existe em nossa base de usuários do Vivo Task"
                        },
                        Message = "Usuário não existe em nossa base de usuários do Vivo Task, por favor informe a matrícula corretamente"
                    });
                }
                else
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = user.EMAIL,
                        Succeeded = true,
                        Message = "Usuário encontrado, retornamos o e-mail do mesmo."
                    });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = ex.Message,
                    Succeeded = false,
                    Errors = new string[] {
                    ex.Message
                    },
                    Message = "Houve algum erro ao executar esta ação"
                });
            }
        }

        // GET LISTA DE ACESSOS PENDENTES //
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpPost("GetUsuariosPendentes")]
        public async Task<JsonResult> GetUsuariosPendentes(
            [FromBody] GenericPaginationModel<FilterUsuariosPendentesModel> filter)
        {
            try
            {
                var users = CD.ACESSOS_MOBILE_PENDENTEs.AsQueryable();

                // FILTRA PELA REGIONAL DO USUÁRIO
                if (!filter.Value.IsMaster)
                {
                    users = users.Where(x => x.REGIONAL == filter.Value.REGIONAL);
                }

                // BUSCA PELO LOGIN DO SOLICITANTE
                if (!filter.Value.IsSuporte.Value)
                {
                    users = users.Where(x => x.LOGIN_SOLICITANTE == filter.Value.LOGIN_SOLICITANTE);
                }

                if (filter.Value.NomeSolicitante is not null)
                {
                    if (!string.IsNullOrEmpty(filter.Value.NomeSolicitante))
                    {
                        //users = users.Where(x => CD.ACESSOS_MOBILEs.Where(y => y.MATRICULA == x.LOGIN_SOLICITANTE).Select(y => y.NOME.ToLower()).Contains(filter.Value.NomeSolicitante.ToLower()));
                        var matriculasSolicitantes = users
                        .Where(x =>
                            CD.ACESSOS_MOBILEs
                            .Where(y =>
                                y.NOME.ToLower()
                                    .Contains(filter.Value.NomeSolicitante.ToLower()))
                                    .Select(y => y.MATRICULA)
                                    .Contains(x.LOGIN_SOLICITANTE))
                        .Select(y => y.LOGIN_SOLICITANTE).Distinct();

                        users = users.Where(x => matriculasSolicitantes.Contains(x.LOGIN_SOLICITANTE)
                        );
                    }
                }

                if (filter.Value.Canal is not null)
                {
                    if (filter.Value.Canal.Any())
                    {
                        users = users.Where(x => filter.Value.Canal.Contains((Canal)x.CANAL));
                    }
                }

                if (filter.Value.Cargos is not null)
                {
                    if (filter.Value.Cargos.Any())
                    {
                        users = users.Where(x => filter.Value.Cargos.Contains((Cargos)x.CARGO));
                    }
                }

                if (filter.Value.Tipo is not null)
                {
                    if (filter.Value.Tipo.Any())
                    {
                        users = users.Where(x => filter.Value.Tipo.Contains(x.TIPO));
                    }
                }

                if (filter.Value.REGIONAIS_FILTER is not null)
                {
                    if (filter.Value.REGIONAIS_FILTER.Any())
                    {
                        users = users.Where(x => filter.Value.REGIONAIS_FILTER.Contains(x.REGIONAL));
                    }
                }

                if (filter.Value.MATRICULA is not null)
                {
                    if (filter.Value.MATRICULA.Any())
                    {
                        users = users.Where(x => filter.Value.MATRICULA.Contains(x.MATRICULA));
                    }
                }

                if (filter.Value.UF is not null)
                {
                    if (filter.Value.UF.Any())
                    {
                        users = users.Where(x => filter.Value.UF.Contains(x.UF));
                    }
                }

                if (filter.Value.ID is not null)
                {
                    if (filter.Value.ID.Any())
                    {
                        users = users.Where(x => filter.Value.ID.Contains(x.ID.ToString()));
                    }
                }

                if (filter.Value.DT_SOLICITACAO is not null)
                {
                    if (filter.Value.DT_SOLICITACAO.Count() >= 2)
                    {
                        users = users.ToList().Where(x => filter.Value.DT_SOLICITACAO[0] <= Convert.ToDateTime(x.DT_SOLICITACAO) && filter.Value.DT_SOLICITACAO[1] >= Convert.ToDateTime(x.DT_SOLICITACAO)).AsQueryable();
                    }
                }

                if (filter.Value.STATUS is not null)
                {
                    if (filter.Value.STATUS.Any())
                    {
                        users = users.Where(c => filter.Value.STATUS.Contains(
                                        CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs
                                            .Where(s => s.ID_ACESSOS_PENDENTE == c.ID)
                                            .OrderByDescending(s => s.ID)
                                            .Select(s => s.STATUS)
                                            .FirstOrDefault()));
                    }
                }

                var lista = users.OrderBy(x => x.ID)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize);

                IEnumerable<ACESSOS_MOBILE_PENDENTE_MODEL> Data = lista.Select(x => new ACESSOS_MOBILE_PENDENTE_MODEL
                {
                    ID = x.ID,
                    EMAIL = x.EMAIL,
                    MATRICULA = x.MATRICULA.Value,
                    SENHA = x.SENHA,
                    REGIONAL = x.REGIONAL,
                    CARGO = x.CARGO,
                    CANAL = x.CANAL,
                    NOME = x.NOME,
                    UF = x.UF,
                    APROVACAO = x.APROVACAO,
                    FIXA = x.FIXA,
                    TIPO = x.TIPO,
                    CPF = x.CPF,
                    PDV = x.PDV,
                    ULTIMO_STATUS = CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Where(y => y.ID_ACESSOS_PENDENTE == x.ID).OrderByDescending(y => y.ID).FirstOrDefault().STATUS,
                    SOLICITANTE = CD.ACESSOS_MOBILEs.Where(y => y.MATRICULA == x.LOGIN_SOLICITANTE).FirstOrDefault(),
                    DT_SOLICITACAO = x.DT_SOLICITACAO.Value,
                    LOGIN_RESPONSAVEL = x.LOGIN_RESPONSAVEL,
                    DT_RETORNO = x.DT_RETORNO,
                    DT_PRIMEIRO_RETORNO = x.DT_PRIMEIRO_RETORNO
                });

                var totalRecords = users.Count();
                var totalPages = ((double)totalRecords / (double)filter.PageSize);

                return new JsonResult(new Response<PagedModelResponse<IEnumerable<ACESSOS_MOBILE_PENDENTE_MODEL>>>
                {
                    Data = PagedResponse.CreatePagedReponse<ACESSOS_MOBILE_PENDENTE_MODEL, FilterUsuariosPendentesModel>(Data, filter, totalRecords),
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdAcesso"></param>
        /// <returns></returns>
        [HttpGet("GetAcessoPendenteById")]
        public JsonResult GetAcessoPendenteById(int IdAcesso)
        {
            try
            {
                var acesso = CD.ACESSOS_MOBILE_PENDENTEs.Find(IdAcesso);
                var ids = CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == IdAcesso);
                var perfis = CD.PERFIL_PLATAFORMAS_VIVOs.Where(x => ids.Select(k => k.ID_PERFIL).Contains(x.ID_PERFIL));

                var respostas = CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Where(x => x.ID_ACESSOS_PENDENTE == IdAcesso)
                    .Select(x => new RespostasAcessosPendentesModel
                    {
                        ID = x.ID,
                        ID_ACESSOS_PENDENTE = x.ID_ACESSOS_PENDENTE,
                        MATRICULA = CD.ACESSOS_MOBILEs.Where(y => y.MATRICULA == x.MATRICULA).FirstOrDefault(),
                        RESPOSTA = x.RESPOSTA,
                        STATUS = x.STATUS,
                        DATA = x.DATA.Value,
                    });

                var retorno = new HistoricoAcessosPendentesModel
                {
                    ID = acesso.ID,
                    ID_ACESSOS_MOBILE = (acesso.TIPO.ToLower() == "alteração"
                    ? CD.ACESSOS_MOBILEs.Where(x => x.ID == acesso.ID_ACESSOS_MOBILE).Select(x => new ControleUsuariosModel
                    {
                        ID = x.ID,
                        EMAIL = x.EMAIL,
                        MATRICULA = x.MATRICULA.Value,
                        SENHA = x.SENHA,
                        REGIONAL = x.REGIONAL,
                        CARGO = x.CARGO,
                        CANAL = x.CANAL,
                        PDV = x.PDV,
                        CPF = x.CPF,
                        NOME = x.NOME,
                        UF = x.UF,
                        STATUS = x.STATUS,
                        FIXA = x.FIXA,
                        TP_AFASTAMENTO = x.TP_AFASTAMENTO,
                        OBS = x.OBS,
                        UserAvatar = x.UserAvatar,
                        LOGIN_MOD = x.LOGIN_MOD,
                        DT_MOD = x.DT_MOD,
                        ELEGIVEL = x.ELEGIVEL.Value,
                        Perfil = CD.PERFIL_USUARIOs.Where(y => y.MATRICULA == x.MATRICULA).Select(y => y.id_Perfil.Value).ToList(),
                    }).FirstOrDefault()
                    : null),
                    EMAIL = acesso.EMAIL,
                    MATRICULA = acesso.MATRICULA.Value,
                    SENHA = acesso.SENHA,
                    REGIONAL = acesso.REGIONAL,
                    CARGO = (Cargos)Convert.ToInt32(acesso.CARGO),
                    CANAL = DePara.CanalCargoEnum((Cargos)Convert.ToInt32(acesso.CARGO)),
                    NOME = acesso.NOME,
                    UF = acesso.UF,
                    CPF = acesso.CPF,
                    PDV = acesso.PDV,
                    APROVACAO = acesso.APROVACAO,
                    FIXA = acesso.FIXA,
                    TIPO = acesso.TIPO,
                    STATUS_USUARIO = acesso.STATUS_USUARIO,
                    LOGIN_SOLICITANTE = CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_SOLICITANTE.ToString()).FirstOrDefault(),
                    LOGIN_RESPONSAVEL = (acesso.LOGIN_RESPONSAVEL == null ?
                                        CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_RESPONSAVEL.ToString()).FirstOrDefault() :
                                        null),
                    DT_SOLICITACAO = acesso.DT_SOLICITACAO.Value,
                    DT_RETORNO = acesso.DT_RETORNO,
                    STATUS = acesso.STATUS,
                    UserAvatar = acesso.UserAvatar,
                    RESPOSTAS = respostas,
                    PERFIS_SOLICITADOS = perfis
                };

                return new JsonResult(
                  new Response<HistoricoAcessosPendentesModel>
                  {
                      Data = retorno,
                      Succeeded = true,
                      Message = "Tudo Certo"
                  });

            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Erro ao buscar informações",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace,
                        ex.Source
                    },
                    Message = "Erro ao buscar informações"
                });
            }
        }

        [HttpGet("GetControleUsersFilters")]
        public JsonResult GetControleUsersFilters()
        {
            var datacarteira = CD.JORNADA_BD_HIERARQUIAs.AsQueryable();
            var dataCanal_Cargo = CD.JORNADA_BD_CARGOS_CANALs.AsQueryable();
            return new JsonResult(new
            {
                datacarteira = datacarteira,
                dataCanal_Cargo = dataCanal_Cargo
            });
        }

        [HttpPost("GetUsuarios")]
        public JsonResult GetUsuarios([FromBody] PaginationControleAcessoModel filter)
        {
            var pagedData = CD.ACESSOS_MOBILEs.AsQueryable();

            if (filter.IsSuporte is not null)
            {
                if (filter.IsSuporte == false)
                {
                    var listaPerfisADM = new List<int>{
                        1,
                        2,
                        3,
                        4,
                        5,
                        6,
                        7,
                        8,
                        9,
                        10
                    };
                    var listaMatricula = CD.ACESSOS_MOBILEs.Where(x => listaPerfisADM.Contains(x.CARGO)).Select(x => x.MATRICULA);

                    // Busca as matriculas que não pertencem a este perfil
                    pagedData = pagedData.Where(x => listaMatricula.Contains(x.MATRICULA));

                }
            }

            if (filter.Uf.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Uf.Contains(x.UF));
            }
            if (filter.Cargo.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Cargo.Contains(x.CARGO.ToString()));
            }
            if (filter.Canal.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Canal.Contains(x.CANAL.ToString()));
            }
            if (filter.Regional.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Regional.Contains(x.REGIONAL));
            }
            if (filter.Fixa.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Fixa.Contains(x.FIXA.Value));
            }
            if (!string.IsNullOrEmpty(filter.Nome))
            {
                pagedData = pagedData.Where(x => x.NOME.ToLower().Contains(filter.Nome.ToLower()));
            }
            if (filter.MatriculaDivisao != null && filter.MatriculaDivisao.Any())
                //if (!string.IsNullOrEmpty(filter.MatriculaDivisao))
              {
                pagedData = pagedData.Where(x =>
                    CD.JORNADA_BD_CARTEIRA_DIVISAOs
                        .Where(y => y.DIVISAO != null)
                        //.Where(y => y.DIVISAO.Value.ToString() == filter.MatriculaDivisao)
                        .Where(y => filter.MatriculaDivisao.Contains(y.DIVISAO.Value.ToString()))
                        .Select(y => y.Vendedor).Contains(x.PDV)
                    );
            }
           if (filter.Matricula is not null)
           {
               pagedData = pagedData.Where(x => x.MATRICULA.Value == filter.Matricula);
            }
            if (!string.IsNullOrEmpty(filter.Pdv))
            {
                pagedData = pagedData.Where(x => x.PDV.ToLower().Contains(filter.Pdv.ToLower()));
            }
            if (!string.IsNullOrEmpty(filter.email))
            {
                pagedData = pagedData.Where(x => x.EMAIL.ToLower().Contains(filter.email.ToLower()));
            }

            var Data = pagedData.OrderBy(x => x.ID)
                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .ToList();

            var totalRecords = pagedData.Count();
            var totalPages = ((double)totalRecords / (double)filter.PageSize);

            var DataFinal = Data.Select(x => new ControleUsuariosModel
            {
                ID = x.ID,
                EMAIL = x.EMAIL,
                MATRICULA = x.MATRICULA.Value,
                SENHA = x.SENHA,
                REGIONAL = x.REGIONAL,
                CARGO = x.CARGO,
                CANAL = x.CANAL,
                PDV = x.PDV,
                CPF = x.CPF,
                NOME = x.NOME,
                UF = x.UF,
                STATUS = x.STATUS,
                FIXA = x.FIXA,
                TP_AFASTAMENTO = x.TP_AFASTAMENTO,
                OBS = x.OBS,
                UserAvatar = x.UserAvatar,
                LOGIN_MOD = x.LOGIN_MOD,
                DT_MOD = x.DT_MOD,
                ELEGIVEL = x.ELEGIVEL == null ? false : x.ELEGIVEL.Value,
                Perfil = CD.PERFIL_USUARIOs.Where(k => k.MATRICULA == x.MATRICULA).Select(x => x.id_Perfil.Value).ToList()
            });

            return new JsonResult(PagedResponse.CreatePagedReponse<ControleUsuariosModel>(DataFinal, filter, totalRecords));
        }

        // GET LISTA DE ACESSOS PENDENTES //

        // SOLICITANTE //
        [HttpPost("UpdateUsuarios")]
        public async Task<JsonResult> UpdateUsuarios([FromBody] ControleUsuariosModel usuario,
            int? matricula,
            int ID_ACESSOS_MOBILE)
        {
            try
            {
                if (CD.ACESSOS_MOBILE_PENDENTEs.Where(x => x.TIPO.ToLower() == "alteração"
                && (x.STATUS.ToLower() != "finalizado" && x.STATUS.ToLower() != "reprovado"))
                    .Any(x => x.ID_ACESSOS_MOBILE == ID_ACESSOS_MOBILE))
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Já existe uma solicitação de edição de dados para este usuário em andamento",
                        Succeeded = false,
                        Message = "Já existe uma solicitação de edição de dados para este usuário em andamento"
                    });
                }

                var user = CD.ACESSOS_MOBILE_PENDENTEs.Add(new ACESSOS_MOBILE_PENDENTE
                {
                    EMAIL = usuario.EMAIL,
                    MATRICULA = usuario.MATRICULA,
                    SENHA = usuario.SENHA,
                    REGIONAL = usuario.REGIONAL,
                    CARGO = usuario.CARGO,
                    CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    APROVACAO = false,
                    FIXA = usuario.FIXA,
                    DT_SOLICITACAO = DateTime.Now,
                    DT_PRIMEIRO_RETORNO = null,
                    DT_RETORNO = null,
                    LOGIN_RESPONSAVEL = null,
                    LOGIN_SOLICITANTE = matricula,
                    ID_ACESSOS_MOBILE = ID_ACESSOS_MOBILE,
                    STATUS_USUARIO = usuario.STATUS,
                    UserAvatar = usuario.UserAvatar,
                    STATUS = "ABERTO",
                    TIPO = "ALTERAÇÃO"
                }).Entity;

                await CD.SaveChangesAsync();

                CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_PENDENTE = user.ID,
                    MATRICULA = user.LOGIN_SOLICITANTE,
                    RESPOSTA = usuario.OBS,
                    STATUS = "ABERTO",
                    DATA = DateTime.Now,
                });

                await CD.SaveChangesAsync();


                return new JsonResult(new Response<ACESSOS_MOBILE_PENDENTE>
                {
                    Data = user,
                    Succeeded = true,
                    Message = "Tudo certo, alteração solicitada com sucesso!",
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

        [HttpPost("BloquearUsuario")]
        public async Task<JsonResult> BloquearUsuario(int id, int? matricula)
        {
            try
            {
                if (CD.ACESSOS_MOBILE_PENDENTEs.Where(x => x.TIPO.ToLower() == "alteração"
                && (x.STATUS.ToLower() != "finalizado" && x.STATUS.ToLower() != "reprovado"))
                    .Any(x => x.ID_ACESSOS_MOBILE == id))
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Já existe uma solicitação de edição de dados para este usuário em andamento",
                        Succeeded = false,
                        Message = "Já existe uma solicitação de edição de dados para este usuário em andamento"
                    });
                }

                var usuario = CD.ACESSOS_MOBILEs.Where(x => x.ID == id).FirstOrDefault();


                var user = CD.ACESSOS_MOBILE_PENDENTEs.Add(new ACESSOS_MOBILE_PENDENTE
                {
                    EMAIL = usuario.EMAIL,
                    MATRICULA = usuario.MATRICULA,
                    SENHA = usuario.SENHA,
                    REGIONAL = usuario.REGIONAL,
                    CARGO = usuario.CARGO,
                    CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    APROVACAO = false,
                    FIXA = usuario.FIXA,
                    DT_SOLICITACAO = DateTime.Now,
                    DT_PRIMEIRO_RETORNO = null,
                    DT_RETORNO = null,
                    LOGIN_RESPONSAVEL = null,
                    LOGIN_SOLICITANTE = matricula,
                    ID_ACESSOS_MOBILE = id,
                    STATUS_USUARIO = !usuario.STATUS,
                    STATUS = "ABERTO",
                    TIPO = "ALTERAÇÃO"
                }).Entity;

                await CD.SaveChangesAsync();

                CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_PENDENTE = user.ID,
                    MATRICULA = user.LOGIN_SOLICITANTE,
                    RESPOSTA = "SOLICITAÇÃO DE INATIVAÇÃO DE USUÁRIO",
                    STATUS = "ABERTO",
                    DATA = DateTime.Now,
                });

                await CD.SaveChangesAsync();
                return new JsonResult(new Response<string>
                {
                    Data = "Tudo certo, alteração solicitada com sucesso!",
                    Succeeded = true,
                    Message = "Tudo certo, alteração solicitada com sucesso!"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("DesbloquearUsuario")]
        public async Task<JsonResult> DesbloquearUsuario(int id, int matricula)
        {
            try
            {
                if (CD.ACESSOS_MOBILE_PENDENTEs.Where(x => x.TIPO.ToLower() == "alteração"
                && (x.STATUS.ToLower() != "finalizado" && x.STATUS.ToLower() != "reprovado"))
                    .Any(x => x.ID_ACESSOS_MOBILE == id))
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Já existe uma solicitação de edição de dados para este usuário em andamento",
                        Succeeded = false,
                        Message = "Já existe uma solicitação de edição de dados para este usuário em andamento"
                    });
                }

                var usuario = CD.ACESSOS_MOBILEs.Where(x => x.ID == id).FirstOrDefault();


                var user = CD.ACESSOS_MOBILE_PENDENTEs.Add(new ACESSOS_MOBILE_PENDENTE
                {
                    EMAIL = usuario.EMAIL,
                    MATRICULA = usuario.MATRICULA,
                    SENHA = usuario.SENHA,
                    REGIONAL = usuario.REGIONAL,
                    CARGO = usuario.CARGO,
                    CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    APROVACAO = false,
                    FIXA = usuario.FIXA,
                    DT_SOLICITACAO = DateTime.Now,
                    DT_PRIMEIRO_RETORNO = null,
                    DT_RETORNO = null,
                    LOGIN_RESPONSAVEL = null,
                    LOGIN_SOLICITANTE = matricula,
                    ID_ACESSOS_MOBILE = id,
                    STATUS_USUARIO = !usuario.STATUS,
                    STATUS = "ABERTO",
                    TIPO = "ALTERAÇÃO"
                }).Entity;

                await CD.SaveChangesAsync();

                CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_PENDENTE = user.ID,
                    MATRICULA = user.LOGIN_SOLICITANTE,
                    RESPOSTA = "SOLICITAÇÃO DE ATIVAÇÃO DE USUÁRIO",
                    STATUS = "ABERTO",
                    DATA = DateTime.Now,
                });

                await CD.SaveChangesAsync();

                return new JsonResult(new Response<string>
                {
                    Data = "Tudo certo, alteração solicitada com sucesso!",
                    Succeeded = true,
                    Message = "Tudo certo, alteração solicitada com sucesso!"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // SOLICITANTE //

        // SUPORTE //
        [HttpPost("UpdateUsuariosSuporte")]
        public async Task<JsonResult> UpdateUsuariosSuporte([FromBody] ControleUsuariosModel usuario, int matricula)
        {
            try
            {
                using (CD = new Vivo_MaisContext())
                {
                    ACESSOS_MOBILE user = CD.ACESSOS_MOBILEs.Find(usuario.ID);

                    if (user.EMAIL != usuario.EMAIL && CD.ACESSOS_MOBILEs.Any(x => x.EMAIL.Contains(usuario.EMAIL))
                        || user.MATRICULA != usuario.MATRICULA && CD.ACESSOS_MOBILEs.Any(x => x.MATRICULA.Value == usuario.MATRICULA))
                    {
                        return new JsonResult(new Response<string>
                        {
                            Data = "Matricula ou email repetidas",
                            Succeeded = false,
                            Message = "Matricula ou email foi repetida com algum valor ja inserido no banco"
                        });
                    }

                    user.EMAIL = usuario.EMAIL;
                    user.MATRICULA = usuario.MATRICULA;
                    user.SENHA = CryptSenha(usuario.SENHA);
                    user.REGIONAL = usuario.REGIONAL;
                    user.CARGO = usuario.CARGO;
                    user.CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO));
                    user.PDV = usuario.PDV;
                    user.CPF = usuario.CPF;
                    user.NOME = usuario.NOME;
                    user.UF = usuario.UF;
                    user.STATUS = usuario.STATUS;
                    user.FIXA = usuario.FIXA;
                    user.TP_AFASTAMENTO = usuario.TP_AFASTAMENTO;
                    user.OBS = usuario.OBS;
                    user.UserAvatar = usuario.UserAvatar;
                    user.LOGIN_MOD = matricula;
                    user.DT_MOD = DateTime.Now;

                    var ActualPerfis = CD.PERFIL_USUARIOs.Where(x => x.MATRICULA == user.MATRICULA); // Busco todos os Perfis que o usuário já tem
                    if (usuario.Perfil.Any())
                    {
                        var perfis = CD.PERFIL_PLATAFORMAS_VIVOs.Where(x => usuario.Perfil.Contains(x.ID_PERFIL)).ToList();
                        if (ActualPerfis.Any())
                        {
                            CD.PERFIL_USUARIOs.RemoveRange(ActualPerfis);
                        }
                        await CD.SaveChangesAsync();
                        foreach (var item in perfis.Select(x => new PERFIL_USUARIO
                        {
                            DT_MOD = DateTime.Now,
                            id_Perfil = x.ID_PERFIL,
                            MATRICULA = usuario.MATRICULA,
                            LOGIN_MOD = matricula
                        }).Distinct())
                        {
                            CD.PERFIL_USUARIOs.Add(item);
                        }
                        CD.SaveChanges();
                    }

                    var result = await CD.SaveChangesAsync();

                    return new JsonResult(user);
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Algum erro nao identificado aconteceu ao executar esta acao",
                    Succeeded = false,
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace,
                        ex.HelpLink,
                        ex.HResult.ToString()
                    },
                    Message = "Algum erro nao identificado aconteceu ao executar esta acao"
                });
            }
        }
        [HttpPost("BloquearUsuarioSuporte")]
        public async Task<JsonResult> BloquearUsuarioSuporte(string TP_AFASTAMENTO, string OBS, int id, int? matricula)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.ID == id).FirstOrDefault();
                user.STATUS = false;
                user.TP_AFASTAMENTO = TP_AFASTAMENTO;
                user.OBS = OBS;
                user.LOGIN_MOD = matricula;
                user.DT_MOD = DateTime.Now;
                await CD.SaveChangesAsync();
                return new JsonResult(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("DesbloquearUsuarioSuporte")]
        public async Task<JsonResult> DesbloquearUsuarioSuporte(int id, int matricula)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.ID == id).FirstOrDefault();
                user.STATUS = true;
                user.LOGIN_MOD = matricula;
                user.DT_MOD = DateTime.Now;
                await CD.SaveChangesAsync();
                return new JsonResult(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // SUPORTE //

        // VALIDAÇÕES //
        [HttpGet("ValidarEmail")]
        public async Task<JsonResult> ValidarEmail(string email)
        {
            try
            {
                if (CD.ACESSOS_MOBILE_PENDENTEs.Select(x => x.EMAIL.ToLower()).Contains(email.ToLower())
                    || CD.ACESSOS_MOBILEs.Select(x => x.EMAIL.ToLower()).Contains(email.ToLower()))
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Solicitação já existente!",
                        Succeeded = false,
                        Message = "Já existe uma solicitação de acesso com este e-mail",
                        Errors = new string[] { "Solicitação já existente!" },
                    });
                }

                return new JsonResult(new Response<string>
                {
                    Data = "E-mail válido!",
                    Succeeded = true,
                    Message = "E-mail válido!"
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        [HttpGet("ValidarMatricula")]
        public async Task<JsonResult> ValidarMatricula(int matricula)
        {
            try
            {
                if (CD.ACESSOS_MOBILE_PENDENTEs.Where(x => x.TIPO.ToLower() != "alteração").Select(x => x.MATRICULA).Contains(matricula)
                    || CD.ACESSOS_MOBILEs.Select(x => x.MATRICULA).Contains(matricula))
                {
                    return new JsonResult(new Response<string>
                    {
                        Data = "Solicitação já existente!",
                        Succeeded = false,
                        Message = "Já existe uma solicitação de acesso ou um usuário com esta matrícula",
                        Errors = new string[] { "matrícula existente!" },
                    });
                }

                return new JsonResult(new Response<string>
                {
                    Data = "matrícula válida!",
                    Succeeded = true,
                    Message = "matrícula válida!"
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

        [HttpGet("GetPerfilByCargo")]
        public async Task<JsonResult> GetPerfilByCargo(string cargo)
        {
            try
            {
                var perfilbycargo = CD.PERFIL_PLATAFORMAS_VIVOs
                    .Where(x => x.CARGO != null)
                    .ToList()
                    .Where(x => x.CARGO.Split(new[] { ';' }).Select(p => int.Parse(p)).Contains(int.Parse(cargo)));

                return new JsonResult(new Response<IEnumerable<PERFIL_PLATAFORMAS_VIVO>>
                {
                    Data = perfilbycargo,
                    Succeeded = true,
                    Message = "matrícula válida!"
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
        // VALIDAÇÕES //

        private string CryptSenha(string senha)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(senha);
            byte[] hash = md5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        [HttpPost("CriarUsuario")]
        public async Task<JsonResult> CriarUsuario([FromBody] ControleUsuariosModel usuario,
            int? matricula,
            string OBS)
        {
            try
            {
                var user = CD.ACESSOS_MOBILE_PENDENTEs.Add(new ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_MOBILE = null,
                    EMAIL = usuario.EMAIL,
                    MATRICULA = usuario.MATRICULA,
                    SENHA = usuario.SENHA,
                    REGIONAL = usuario.REGIONAL,
                    CARGO = usuario.CARGO,
                    CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    APROVACAO = false,
                    FIXA = usuario.FIXA,
                    DT_SOLICITACAO = DateTime.Now,
                    DT_PRIMEIRO_RETORNO = null,
                    DT_RETORNO = null,
                    LOGIN_RESPONSAVEL = null,
                    LOGIN_SOLICITANTE = matricula,
                    STATUS_USUARIO = false,
                    UserAvatar = usuario.UserAvatar,
                    STATUS = "ABERTO",
                    TIPO = "INCLUSÃO"
                }).Entity;
                await CD.SaveChangesAsync();

                CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_PENDENTE = user.ID,
                    MATRICULA = user.LOGIN_SOLICITANTE,
                    RESPOSTA = OBS,
                    STATUS = "ABERTO",
                    DATA = DateTime.Now,
                });
                await CD.SaveChangesAsync();

                if (usuario.Perfil is not null)
                {
                    foreach (var item in usuario.Perfil)
                    {
                        CD.PERFIL_USUARIO_PENDENTEs.Add(new PERFIL_USUARIO_PENDENTE
                        {
                            ID_ACESSO_PENDENTE = user.ID,
                            ID_PERFIL = item
                        });
                    }
                    await CD.SaveChangesAsync();
                }



                return new JsonResult(new Response<ACESSOS_MOBILE_PENDENTE>
                {
                    Data = user,
                    Succeeded = true,
                    Message = $"O id da solicitação é {user.ID}, acesse o módulo do painel de usuários para acompanhar a solicitação",
                    Errors = null,
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<string>
                {
                    Data = "Recebemos a solicitaçõa da ação mas não conseguimos executa-lá",
                    Succeeded = false,
                    Message = "Recebemos a solicitaçõa da ação mas não conseguimos executa-lá",
                    Errors = new string[]
                    {
                        ex.Message,
                        ex.StackTrace
                    },
                });
            }
        }

        [HttpPost("AnswerAcessoChangeStatus")]
        public async Task<JsonResult> AnswerAcessoChangeStatus(
            [FromBody] HistoricoAcessosPendentesModel? usuario,
              int matricula,
              int id,
              string resposta,
              string status)
        {
            try
            //Este tipo de resposta apenas insere mais uma linha de histórico no banco
            {
                CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_PENDENTE = id,
                    MATRICULA = matricula,
                    RESPOSTA = resposta,
                    STATUS = status,
                    DATA = DateTime.Now
                });

                var acesso = CD.ACESSOS_MOBILE_PENDENTEs.Find(id);
                acesso.STATUS = status;
                acesso.DT_RETORNO = DateTime.Now;

                await CD.SaveChangesAsync();

                var respostas = CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Where(x => x.ID_ACESSOS_PENDENTE == id) //Insere mais uma linha no historico desta conversa
                    .Select(x => new RespostasAcessosPendentesModel
                    {
                        ID = x.ID,
                        ID_ACESSOS_PENDENTE = x.ID_ACESSOS_PENDENTE,
                        MATRICULA = CD.ACESSOS_MOBILEs.Where(y => y.MATRICULA == x.MATRICULA).FirstOrDefault(),
                        RESPOSTA = x.RESPOSTA,
                        STATUS = x.STATUS,
                        DATA = x.DATA.Value,
                    });

                var ids = CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == id);
                var perfis = CD.PERFIL_PLATAFORMAS_VIVOs.Where(x => ids.Select(k => k.ID_PERFIL).Contains(x.ID_PERFIL));

                var retorno = new HistoricoAcessosPendentesModel // Apenas o retorno com a atualização
                {
                    ID = acesso.ID,
                    ID_ACESSOS_MOBILE = (acesso.TIPO.ToLower() == "alteração"
                    ? CD.ACESSOS_MOBILEs.Where(x => x.ID == acesso.ID_ACESSOS_MOBILE).Select(x => new ControleUsuariosModel
                    {
                        ID = x.ID,
                        EMAIL = x.EMAIL,
                        MATRICULA = x.MATRICULA.Value,
                        SENHA = x.SENHA,
                        REGIONAL = x.REGIONAL,
                        CARGO = x.CARGO,
                        CANAL = x.CANAL,
                        PDV = x.PDV,
                        CPF = x.CPF,
                        NOME = x.NOME,
                        UF = x.UF,
                        STATUS = x.STATUS,
                        FIXA = x.FIXA,
                        TP_AFASTAMENTO = x.TP_AFASTAMENTO,
                        OBS = x.OBS,
                        UserAvatar = x.UserAvatar,
                        LOGIN_MOD = x.LOGIN_MOD,
                        DT_MOD = x.DT_MOD,
                        ELEGIVEL = x.ELEGIVEL.Value,
                        Perfil = CD.PERFIL_USUARIOs.Where(y => y.MATRICULA == x.MATRICULA).Select(y => y.id_Perfil.Value).ToList(),
                    }).FirstOrDefault()
                    : null),
                    EMAIL = acesso.EMAIL,
                    MATRICULA = acesso.MATRICULA.Value,
                    SENHA = acesso.SENHA,
                    REGIONAL = acesso.REGIONAL,
                    CARGO = (Cargos)Convert.ToInt32(usuario.CARGO),
                    CANAL = DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = acesso.NOME,
                    UF = acesso.UF,
                    CPF = acesso.CPF,
                    PDV = acesso.PDV,
                    APROVACAO = acesso.APROVACAO,
                    FIXA = acesso.FIXA,
                    TIPO = acesso.TIPO,
                    STATUS_USUARIO = acesso.STATUS_USUARIO,
                    LOGIN_SOLICITANTE = CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_SOLICITANTE.ToString()).FirstOrDefault(),
                    LOGIN_RESPONSAVEL = (acesso.LOGIN_RESPONSAVEL == null ?
                                        CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_RESPONSAVEL.ToString()).FirstOrDefault() :
                                        null),
                    DT_SOLICITACAO = acesso.DT_SOLICITACAO.Value,
                    DT_RETORNO = acesso.DT_RETORNO,
                    STATUS = acesso.STATUS,
                    UserAvatar = acesso.UserAvatar,
                    RESPOSTAS = respostas,
                    PERFIS_SOLICITADOS = perfis
                };


                return new JsonResult(
                     new Response<HistoricoAcessosPendentesModel>
                     {
                         Data = retorno,
                         Succeeded = true,
                         Message = "Tudo Certo"
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

        [HttpPost("AnswerAcessoInsert")]
        public async Task<JsonResult> AnswerAcessoInsert(
            [FromBody] HistoricoAcessosPendentesModel? usuario,
              int matricula,
              int id,
              string resposta,
              string status)
        {
            try
            //Independente do tipo de usuário/status ele insere a resposta com a respectiva matricula
            {
                CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_PENDENTE = id,
                    MATRICULA = matricula,
                    RESPOSTA = resposta,
                    STATUS = status,
                    DATA = DateTime.Now
                });

                var acesso = CD.ACESSOS_MOBILE_PENDENTEs.Find(id);
                acesso.STATUS = status;
                acesso.DT_RETORNO = DateTime.Now;

                if (!acesso.DT_PRIMEIRO_RETORNO.HasValue)
                // Caso a primeira resposta ainda não esteja defenida inserimos agora
                {
                    acesso.DT_PRIMEIRO_RETORNO = DateTime.Now;
                }

                acesso.LOGIN_RESPONSAVEL = matricula;
                acesso.APROVACAO = true;

                CD.ACESSOS_MOBILEs.Add(new ACESSOS_MOBILE
                {
                    EMAIL = usuario.EMAIL,
                    MATRICULA = usuario.MATRICULA,
                    SENHA = CryptSenha(usuario.SENHA),
                    REGIONAL = usuario.REGIONAL,
                    CARGO = (int)usuario.CARGO,
                    CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    STATUS = true,
                    FIXA = usuario.FIXA,
                    OBS = resposta,
                    UserAvatar = usuario.UserAvatar,
                    LOGIN_MOD = matricula,
                    DT_MOD = DateTime.Now,
                });

                foreach (var item in usuario.PERFIS_SOLICITADOS)
                {
                    CD.PERFIL_USUARIOs.Add(new PERFIL_USUARIO
                    {
                        MATRICULA = usuario.MATRICULA,
                        id_Perfil = item.ID_PERFIL,
                        DT_MOD = DateTime.Now,
                        LOGIN_MOD = matricula,
                    });
                }

                await CD.SaveChangesAsync();

                var respostas = CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Where(x => x.ID_ACESSOS_PENDENTE == id) //Insere mais uma linha no historico desta conversa
                    .Select(x => new RespostasAcessosPendentesModel
                    {
                        ID = x.ID,
                        ID_ACESSOS_PENDENTE = x.ID_ACESSOS_PENDENTE,
                        MATRICULA = CD.ACESSOS_MOBILEs.Where(y => y.MATRICULA == x.MATRICULA).FirstOrDefault(),
                        RESPOSTA = x.RESPOSTA,
                        STATUS = x.STATUS,
                        DATA = x.DATA.Value,
                    });

                var ids = CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == id);
                var perfis = CD.PERFIL_PLATAFORMAS_VIVOs.Where(x => ids.Select(k => k.ID_PERFIL).Contains(x.ID_PERFIL));

                var retorno = new HistoricoAcessosPendentesModel // Apenas o retorno com a atualização
                {
                    ID = acesso.ID,
                    ID_ACESSOS_MOBILE = (acesso.TIPO.ToLower() == "alteração"
                    ? CD.ACESSOS_MOBILEs.Where(x => x.ID == acesso.ID_ACESSOS_MOBILE).Select(x => new ControleUsuariosModel
                    {
                        ID = x.ID,
                        EMAIL = x.EMAIL,
                        MATRICULA = x.MATRICULA.Value,
                        SENHA = x.SENHA,
                        REGIONAL = x.REGIONAL,
                        CARGO = x.CARGO,
                        CANAL = x.CANAL,
                        PDV = x.PDV,
                        CPF = x.CPF,
                        NOME = x.NOME,
                        UF = x.UF,
                        STATUS = x.STATUS,
                        FIXA = x.FIXA,
                        TP_AFASTAMENTO = x.TP_AFASTAMENTO,
                        OBS = x.OBS,
                        UserAvatar = x.UserAvatar,
                        LOGIN_MOD = x.LOGIN_MOD,
                        DT_MOD = x.DT_MOD,
                        ELEGIVEL = x.ELEGIVEL.Value,
                        Perfil = CD.PERFIL_USUARIOs.Where(y => y.MATRICULA == x.MATRICULA).Select(y => y.id_Perfil.Value).ToList(),
                    }).FirstOrDefault()
                    : null),
                    EMAIL = acesso.EMAIL,
                    MATRICULA = acesso.MATRICULA.Value,
                    SENHA = acesso.SENHA,
                    REGIONAL = acesso.REGIONAL,
                    CARGO = (Cargos)Convert.ToInt32(usuario.CARGO),
                    CANAL = DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = acesso.NOME,
                    UF = acesso.UF,
                    CPF = acesso.CPF,
                    PDV = acesso.PDV,
                    APROVACAO = acesso.APROVACAO,
                    FIXA = acesso.FIXA,
                    TIPO = acesso.TIPO,
                    STATUS_USUARIO = acesso.STATUS_USUARIO,
                    LOGIN_SOLICITANTE = CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_SOLICITANTE.ToString()).FirstOrDefault(),
                    LOGIN_RESPONSAVEL = (acesso.LOGIN_RESPONSAVEL == null ?
                                        CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_RESPONSAVEL.ToString()).FirstOrDefault() :
                                        null),
                    DT_SOLICITACAO = acesso.DT_SOLICITACAO.Value,
                    DT_RETORNO = acesso.DT_RETORNO,
                    STATUS = acesso.STATUS,
                    UserAvatar = acesso.UserAvatar,
                    RESPOSTAS = respostas,
                    PERFIS_SOLICITADOS = perfis
                };


                return new JsonResult(
                     new Response<HistoricoAcessosPendentesModel>
                     {
                         Data = retorno,
                         Succeeded = true,
                         Message = "Tudo Certo"
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


        [HttpPost("AnswerAcessoSolicitante")]
        public async Task<JsonResult> AnswerAcessoSolicitante(
            [FromBody] HistoricoAcessosPendentesModel? usuario,
              int matricula,
              int id,
              string resposta,
              string status)
        {
            try
            //Independente do tipo de usuário/status ele insere a resposta com a respectiva matricula
            {
                CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_PENDENTE = id,
                    MATRICULA = matricula,
                    RESPOSTA = resposta,
                    STATUS = status,
                    DATA = DateTime.Now
                });

                var acesso = CD.ACESSOS_MOBILE_PENDENTEs.Find(id);
                acesso.STATUS = status;
                acesso.DT_RETORNO = DateTime.Now;

                acesso.EMAIL = usuario.EMAIL;
                acesso.MATRICULA = usuario.MATRICULA;
                acesso.SENHA = usuario.SENHA;
                acesso.REGIONAL = usuario.REGIONAL;
                acesso.CARGO = (int)usuario.CARGO;
                acesso.CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO));
                acesso.NOME = usuario.NOME;
                acesso.UF = usuario.UF;
                acesso.CPF = usuario.CPF;
                acesso.PDV = usuario.PDV;
                acesso.APROVACAO = usuario.APROVACAO;
                acesso.FIXA = usuario.FIXA;
                acesso.UserAvatar = usuario.UserAvatar;
                acesso.STATUS = status;
                acesso.DT_RETORNO = DateTime.Now;

                var perfilbymatricula = CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == acesso.ID);

                CD.PERFIL_USUARIO_PENDENTEs.RemoveRange(perfilbymatricula);
                await CD.SaveChangesAsync();

                foreach (var item in usuario.PERFIS_SOLICITADOS)
                {
                    CD.PERFIL_USUARIO_PENDENTEs.Add(new PERFIL_USUARIO_PENDENTE
                    {
                        ID_ACESSO_PENDENTE = acesso.ID,
                        ID_PERFIL = item.ID_PERFIL,
                    });
                }

                await CD.SaveChangesAsync();

                var respostas = CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Where(x => x.ID_ACESSOS_PENDENTE == id) //Insere mais uma linha no historico desta conversa
                    .Select(x => new RespostasAcessosPendentesModel
                    {
                        ID = x.ID,
                        ID_ACESSOS_PENDENTE = x.ID_ACESSOS_PENDENTE,
                        MATRICULA = CD.ACESSOS_MOBILEs.Where(y => y.MATRICULA == x.MATRICULA).FirstOrDefault(),
                        RESPOSTA = x.RESPOSTA,
                        STATUS = x.STATUS,
                        DATA = x.DATA.Value,
                    });

                var ids = CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == id);
                var perfis = CD.PERFIL_PLATAFORMAS_VIVOs.Where(x => ids.Select(k => k.ID_PERFIL).Contains(x.ID_PERFIL));

                var retorno = new HistoricoAcessosPendentesModel // Apenas o retorno com a atualização
                {
                    ID = acesso.ID,
                    ID_ACESSOS_MOBILE = (acesso.TIPO.ToLower() == "alteração"
                    ? CD.ACESSOS_MOBILEs.Where(x => x.ID == acesso.ID_ACESSOS_MOBILE).Select(x => new ControleUsuariosModel
                    {
                        ID = x.ID,
                        EMAIL = x.EMAIL,
                        MATRICULA = x.MATRICULA.Value,
                        SENHA = x.SENHA,
                        REGIONAL = x.REGIONAL,
                        CARGO = x.CARGO,
                        CANAL = x.CANAL,
                        PDV = x.PDV,
                        CPF = x.CPF,
                        NOME = x.NOME,
                        UF = x.UF,
                        STATUS = x.STATUS,
                        FIXA = x.FIXA,
                        TP_AFASTAMENTO = x.TP_AFASTAMENTO,
                        OBS = x.OBS,
                        UserAvatar = x.UserAvatar,
                        LOGIN_MOD = x.LOGIN_MOD,
                        DT_MOD = x.DT_MOD,
                        ELEGIVEL = x.ELEGIVEL.Value,
                        Perfil = CD.PERFIL_USUARIOs.Where(y => y.MATRICULA == x.MATRICULA).Select(y => y.id_Perfil.Value).ToList(),
                    }).FirstOrDefault()
                    : null),
                    EMAIL = acesso.EMAIL,
                    MATRICULA = acesso.MATRICULA.Value,
                    SENHA = acesso.SENHA,
                    REGIONAL = acesso.REGIONAL,
                    CARGO = (Cargos)Convert.ToInt32(usuario.CARGO),
                    CANAL = DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = acesso.NOME,
                    UF = acesso.UF,
                    CPF = acesso.CPF,
                    PDV = acesso.PDV,
                    APROVACAO = acesso.APROVACAO,
                    FIXA = acesso.FIXA,
                    TIPO = acesso.TIPO,
                    STATUS_USUARIO = acesso.STATUS_USUARIO,
                    LOGIN_SOLICITANTE = CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_SOLICITANTE.ToString()).FirstOrDefault(),
                    LOGIN_RESPONSAVEL = (acesso.LOGIN_RESPONSAVEL == null ?
                                        CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_RESPONSAVEL.ToString()).FirstOrDefault() :
                                        null),
                    DT_SOLICITACAO = acesso.DT_SOLICITACAO.Value,
                    DT_RETORNO = acesso.DT_RETORNO,
                    STATUS = acesso.STATUS,
                    UserAvatar = acesso.UserAvatar,
                    RESPOSTAS = respostas,
                    PERFIS_SOLICITADOS = perfis
                };


                return new JsonResult(
                     new Response<HistoricoAcessosPendentesModel>
                     {
                         Data = retorno,
                         Succeeded = true,
                         Message = "Tudo Certo"
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

        [HttpPost("AnswerAcessoAlteracao")]
        public async Task<JsonResult> AnswerAcessoAlteracao(
            [FromBody] HistoricoAcessosPendentesModel? usuario,
              int matricula,
              int id,
              string resposta,
              string status)
        {
            try
            //Independente do tipo de usuário/status ele insere a resposta com a respectiva matricula
            {
                CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                {
                    ID_ACESSOS_PENDENTE = id,
                    MATRICULA = matricula,
                    RESPOSTA = resposta,
                    STATUS = status,
                    DATA = DateTime.Now
                });

                var acesso = CD.ACESSOS_MOBILEs.Find(usuario.ID_ACESSOS_MOBILE.ID);
                acesso.EMAIL = usuario.EMAIL;
                acesso.MATRICULA = usuario.MATRICULA;
                acesso.SENHA = CryptSenha(usuario.SENHA);
                acesso.REGIONAL = usuario.REGIONAL;
                acesso.CARGO = (int)usuario.CARGO;
                acesso.CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO));
                acesso.NOME = usuario.NOME;
                acesso.UF = usuario.UF;
                acesso.CPF = usuario.CPF;
                acesso.PDV = usuario.PDV;
                acesso.FIXA = usuario.FIXA;
                acesso.STATUS = usuario.STATUS_USUARIO;
                acesso.UserAvatar = usuario.UserAvatar;
                acesso.DT_MOD = DateTime.Now;
                acesso.LOGIN_MOD = matricula;
                acesso.OBS = resposta;

                var perfilbymatricula = CD.PERFIL_USUARIOs.Where(x => x.MATRICULA == acesso.MATRICULA);

                CD.PERFIL_USUARIOs.RemoveRange(perfilbymatricula);
                await CD.SaveChangesAsync();

                foreach (var item in usuario.PERFIS_SOLICITADOS)
                {
                    CD.PERFIL_USUARIOs.Add(new PERFIL_USUARIO
                    {
                        MATRICULA = acesso.MATRICULA,
                        id_Perfil = item.ID_PERFIL,
                        DT_MOD = DateTime.Now,
                        LOGIN_MOD = matricula,
                    });
                }

                var acesso_pendente = CD.ACESSOS_MOBILE_PENDENTEs.Find(id);
                acesso_pendente.STATUS = status;
                acesso_pendente.DT_RETORNO = DateTime.Now;
                if (!acesso_pendente.DT_PRIMEIRO_RETORNO.HasValue)
                // Caso a primeira resposta ainda não esteja defenida inserimos agora
                {
                    acesso_pendente.DT_PRIMEIRO_RETORNO = DateTime.Now;
                }

                acesso_pendente.LOGIN_RESPONSAVEL = matricula;
                acesso_pendente.APROVACAO = true;
                await CD.SaveChangesAsync();

                var respostas = CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Where(x => x.ID_ACESSOS_PENDENTE == id) //Insere mais uma linha no historico desta conversa
                    .Select(x => new RespostasAcessosPendentesModel
                    {
                        ID = x.ID,
                        ID_ACESSOS_PENDENTE = x.ID_ACESSOS_PENDENTE,
                        MATRICULA = CD.ACESSOS_MOBILEs.Where(y => y.MATRICULA == x.MATRICULA).FirstOrDefault(),
                        RESPOSTA = x.RESPOSTA,
                        STATUS = x.STATUS,
                        DATA = x.DATA.Value,
                    });


                var ids = CD.PERFIL_USUARIO_PENDENTEs.Where(x => x.ID_ACESSO_PENDENTE == id);
                var perfis = CD.PERFIL_PLATAFORMAS_VIVOs.Where(x => ids.Select(k => k.ID_PERFIL).Contains(x.ID_PERFIL));

                var retorno = new HistoricoAcessosPendentesModel // Apenas o retorno com a atualização
                {
                    ID = acesso_pendente.ID,
                    ID_ACESSOS_MOBILE = (acesso_pendente.TIPO.ToLower() == "alteração"
                    ? CD.ACESSOS_MOBILEs.Where(x => x.ID == acesso_pendente.ID_ACESSOS_MOBILE).Select(x => new ControleUsuariosModel
                    {
                        ID = x.ID,
                        EMAIL = x.EMAIL,
                        MATRICULA = x.MATRICULA.Value,
                        SENHA = x.SENHA,
                        REGIONAL = x.REGIONAL,
                        CARGO = x.CARGO,
                        CANAL = x.CANAL,
                        PDV = x.PDV,
                        CPF = x.CPF,
                        NOME = x.NOME,
                        UF = x.UF,
                        STATUS = x.STATUS,
                        FIXA = x.FIXA,
                        TP_AFASTAMENTO = x.TP_AFASTAMENTO,
                        OBS = x.OBS,
                        UserAvatar = x.UserAvatar,
                        LOGIN_MOD = x.LOGIN_MOD,
                        DT_MOD = x.DT_MOD,
                        ELEGIVEL = x.ELEGIVEL.Value,
                        Perfil = CD.PERFIL_USUARIOs.Where(y => y.MATRICULA == x.MATRICULA).Select(y => y.id_Perfil.Value).ToList(),
                    }).FirstOrDefault()
                    : null),
                    EMAIL = acesso_pendente.EMAIL,
                    MATRICULA = acesso_pendente.MATRICULA.Value,
                    SENHA = acesso_pendente.SENHA,
                    REGIONAL = acesso_pendente.REGIONAL,
                    CARGO = (Cargos)Convert.ToInt32(usuario.CARGO),
                    CANAL = DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = acesso_pendente.NOME,
                    UF = acesso_pendente.UF,
                    CPF = acesso_pendente.CPF,
                    PDV = acesso_pendente.PDV,
                    APROVACAO = acesso_pendente.APROVACAO,
                    FIXA = acesso_pendente.FIXA,
                    UserAvatar = acesso_pendente.UserAvatar,
                    TIPO = acesso_pendente.TIPO,
                    STATUS_USUARIO = acesso_pendente.STATUS_USUARIO,
                    LOGIN_SOLICITANTE = CD.ACESSOs.Where(x => x.Login == acesso_pendente.LOGIN_SOLICITANTE.Value.ToString()).FirstOrDefault(),
                    LOGIN_RESPONSAVEL = (acesso_pendente.LOGIN_RESPONSAVEL == null ?
                                        CD.ACESSOs.Where(x => x.Login == acesso_pendente.LOGIN_RESPONSAVEL.Value.ToString()).FirstOrDefault() :
                                        null),
                    DT_SOLICITACAO = acesso_pendente.DT_SOLICITACAO.Value,
                    DT_RETORNO = acesso_pendente.DT_RETORNO,
                    STATUS = acesso_pendente.STATUS,
                    RESPOSTAS = respostas,
                    PERFIS_SOLICITADOS = perfis
                };


                return new JsonResult(
                     new Response<HistoricoAcessosPendentesModel>
                     {
                         Data = retorno,
                         Succeeded = true,
                         Message = "Tudo Certo"
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

        [HttpPost("CriarUsuarioMassivo")]
        public async Task<JsonResult> CriarUsuarioMassivo([FromBody] List<ControleUsuariosModel> usuarios, int matricula, string OBS)
        {
            try
            {
                foreach (var usuario in usuarios)
                {
                    var user = CD.ACESSOS_MOBILE_PENDENTEs.Add(new ACESSOS_MOBILE_PENDENTE
                    {
                        ID_ACESSOS_MOBILE = null,
                        EMAIL = usuario.EMAIL,
                        MATRICULA = usuario.MATRICULA,
                        SENHA = CryptSenha("Vivo@2024"),
                        REGIONAL = usuario.REGIONAL,
                        CARGO = usuario.CARGO,
                        CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                        NOME = usuario.NOME,
                        UF = usuario.UF,
                        CPF = usuario.CPF,
                        PDV = usuario.PDV,
                        APROVACAO = false,
                        FIXA = usuario.FIXA,
                        DDD = usuario.DDD,
                        ELEGIVEL = usuario.ELEGIVEL,
                        UserAvatar = System.IO.File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates", "usericon.png")),
                        DT_SOLICITACAO = DateTime.Now,
                        DT_PRIMEIRO_RETORNO = null,
                        DT_RETORNO = null,
                        LOGIN_RESPONSAVEL = null,
                        LOGIN_SOLICITANTE = matricula,
                        STATUS_USUARIO = false,
                        STATUS = "ABERTO",
                        TIPO = "INCLUSÃO"
                    }).Entity;

                    await CD.SaveChangesAsync();

                    foreach (var perfil in usuario.Perfil)
                    {
                        CD.PERFIL_USUARIO_PENDENTEs.Add(new PERFIL_USUARIO_PENDENTE
                        {
                            ID_ACESSO_PENDENTE = user.ID,
                            ID_PERFIL = perfil,
                        });
                    }

                    CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                    {
                        ID_ACESSOS_PENDENTE = user.ID,
                        MATRICULA = user.LOGIN_SOLICITANTE,
                        RESPOSTA = OBS,
                        STATUS = "ABERTO",
                        DATA = DateTime.Now,
                    });

                }
                await CD.SaveChangesAsync();

                return new JsonResult(new Response<string>
                {
                    Data = "Foi criado uma solicitação de acesso para todos os usuários no arquivo",
                    Succeeded = true,
                    Message = "Foi criado uma solicitação de acesso para todos os usuários no arquivo",
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

        [HttpPost("UpdateUsuarioMassivo")]
        public async Task<JsonResult> EditarUsuarioMassivo([FromBody] List<ControleUsuariosModel> usuarios, int matricula)
        {
            try
            {
                foreach (var usuario in usuarios)
                {
                    var User = CD.ACESSOS_MOBILEs.Where(x=>x.MATRICULA == usuario.MATRICULA).FirstOrDefault();

                    if (User is not null)
                    {
                        if (CD.ACESSOS_MOBILE_PENDENTEs.Where(x => x.TIPO.ToLower() == "alteração"
                             && (x.STATUS.ToLower() != "finalizado" && x.STATUS.ToLower() != "reprovado"))
                            .Any(x => x.ID_ACESSOS_MOBILE == User.MATRICULA))
                        {
                            return new JsonResult(new Response<string>
                            {
                                Data = "Já existe uma solicitação de edição de dados para algum dos usuários dentro deste arquivo",
                                Succeeded = false,
                                Message = "Já existe uma solicitação de edição de dados para algum dos usuários dentro deste arquivo"
                            });
                        }

                        var user = CD.ACESSOS_MOBILE_PENDENTEs.Add(new ACESSOS_MOBILE_PENDENTE
                        {
                            EMAIL = usuario.EMAIL,
                            MATRICULA = usuario.MATRICULA,
                            SENHA = usuario.SENHA,
                            REGIONAL = usuario.REGIONAL,
                            CARGO = usuario.CARGO,
                            CANAL = (int)DePara.CanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                            NOME = usuario.NOME,
                            UF = usuario.UF,
                            CPF = usuario.CPF,
                            PDV = usuario.PDV,
                            APROVACAO = false,
                            FIXA = usuario.FIXA,
                            DT_SOLICITACAO = DateTime.Now,
                            DT_PRIMEIRO_RETORNO = null,
                            DT_RETORNO = null,
                            LOGIN_RESPONSAVEL = null,
                            LOGIN_SOLICITANTE = matricula,
                            ID_ACESSOS_MOBILE = User.ID,
                            STATUS_USUARIO = usuario.STATUS,
                            UserAvatar = usuario.UserAvatar,
                            STATUS = "ABERTO",
                            DDD = usuario.DDD,
                            ELEGIVEL = usuario.ELEGIVEL,
                            TIPO = "ALTERAÇÃO"
                        }).Entity;

                        await CD.SaveChangesAsync();

                        foreach (var perfil in usuario.Perfil)
                        {
                            CD.PERFIL_USUARIO_PENDENTEs.Add(new PERFIL_USUARIO_PENDENTE
                            {
                                ID_ACESSO_PENDENTE = user.ID,
                                ID_PERFIL = perfil,
                            });
                        }

                        CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Add(new HISTORICO_ACESSOS_MOBILE_PENDENTE
                        {
                            ID_ACESSOS_PENDENTE = user.ID,
                            MATRICULA = user.LOGIN_SOLICITANTE,
                            RESPOSTA = usuario.OBS,
                            STATUS = "ABERTO",
                            DATA = DateTime.Now,
                        });
                        await CD.SaveChangesAsync();
                    }
                }
                await CD.SaveChangesAsync();

                return new JsonResult(new Response<string>
                {
                    Data = "Foi criado uma solicitação de acesso para todos os usuários no arquivo",
                    Succeeded = true,
                    Message = "Foi criado uma solicitação de acesso para todos os usuários no arquivo",
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

        [HttpPost("GetUsuariosExcel")]
        public async Task<JsonResult> GetUsuariosExcel([FromBody] PaginationControleAcessoModel filter)
        {
            try
            {
                var pagedData = CD.ACESSOS_MOBILEs.AsQueryable();

                if (filter.IsSuporte is not null)
                {
                    if (filter.IsSuporte == false)
                    {
                        var listaPerfisADM = new List<int>{
                        1,
                        2,
                        3,
                        4,
                        5,
                        6,
                        7,
                        8,
                        9,
                        10
                    };
                        var listaMatricula = CD.ACESSOS_MOBILEs.Where(x => listaPerfisADM.Contains(x.CARGO)).Select(x => x.MATRICULA);

                        // Busca as matriculas que não pertencem a este perfil
                        pagedData = pagedData.Where(x => listaMatricula.Contains(x.MATRICULA));

                    }
                }

                if (filter.Uf.Count() > 0)
                {
                    pagedData = pagedData.Where(x => filter.Uf.Contains(x.UF));
                }
                if (filter.Cargo.Count() > 0)
                {
                    pagedData = pagedData.Where(x => filter.Cargo.Contains(x.CARGO.ToString()));
                }
                if (filter.Canal.Count() > 0)
                {
                    pagedData = pagedData.Where(x => filter.Canal.Contains(x.CANAL.ToString()));
                }
                if (filter.Regional.Count() > 0)
                {
                    pagedData = pagedData.Where(x => filter.Regional.Contains(x.REGIONAL));
                }
                if (filter.Fixa.Count() > 0)
                {
                    pagedData = pagedData.Where(x => filter.Fixa.Contains(x.FIXA.Value));
                }
                if (!string.IsNullOrEmpty(filter.Nome))
                {
                    pagedData = pagedData.Where(x => x.NOME.ToLower().Contains(filter.Nome.ToLower()));
                }
                //if (!string.IsNullOrEmpty(filter.MatriculaDivisao))
                //{
                //    pagedData = pagedData.Where(x =>
                //        CD.JORNADA_BD_CARTEIRA_DIVISAOs
                //            .Where(y => y.DIVISAO != null)
                //            .Where(y => y.DIVISAO.Value.ToString() == filter.MatriculaDivisao)
                //            .Select(y => y.Vendedor).Contains(x.PDV)
                //        );
                //}
                if (filter.MatriculaDivisao != null && filter.MatriculaDivisao.Any())
                {
                    pagedData = pagedData.Where(x =>
                        CD.JORNADA_BD_CARTEIRA_DIVISAOs
                            .Where(y => y.DIVISAO != null)
                            .Where(y => filter.MatriculaDivisao.Contains(y.DIVISAO.Value.ToString()))
                            .Select(y => y.Vendedor)
                            .Contains(x.PDV)
                    );
                }
                if (filter.Matricula is not null)
                {
                    pagedData = pagedData.Where(x => x.MATRICULA.Value == filter.Matricula);
                }
                if (!string.IsNullOrEmpty(filter.Pdv))
                {
                    pagedData = pagedData.Where(x => x.PDV.ToLower().Contains(filter.Pdv.ToLower()));
                }
                if (!string.IsNullOrEmpty(filter.email))
                {
                    pagedData = pagedData.Where(x => x.EMAIL.ToLower().Contains(filter.email.ToLower()));
                }

                var dataAfterEntity = pagedData.Select(x => new ControleUsuariosModel
                {
                    ID = x.ID,
                    EMAIL = x.EMAIL,
                    MATRICULA = x.MATRICULA.Value,
                    SENHA = x.SENHA,
                    REGIONAL = x.REGIONAL,
                    CARGO = x.CARGO,
                    CANAL = x.CANAL,
                    PDV = x.PDV,
                    CPF = x.CPF,
                    NOME = x.NOME,
                    UF = x.UF,
                    STATUS = x.STATUS,
                    FIXA = x.FIXA,
                    TP_AFASTAMENTO = x.TP_AFASTAMENTO,
                    OBS = x.OBS,
                    UserAvatar = x.UserAvatar,
                    LOGIN_MOD = x.LOGIN_MOD,
                    DT_MOD = x.DT_MOD,
                    ELEGIVEL = x.ELEGIVEL == null ? false : x.ELEGIVEL.Value,
                    Perfil = CD.PERFIL_USUARIOs.Where(k => k.MATRICULA == x.MATRICULA).Select(x => x.id_Perfil.Value).ToList()
                });

                string templatepath = Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates//Acessos_Mobile_Model.html");
                string htmldata = System.IO.File.ReadAllText(templatepath);

                var excelstring = new System.Text.StringBuilder();

                foreach (var blocao in dataAfterEntity)
                {
                    excelstring.Append("<tr>");
                    excelstring.Append($"<td>{blocao.ID}</td>");
                    excelstring.Append($"<td>{blocao.EMAIL}</td>");
                    excelstring.Append($"<td>{blocao.MATRICULA}</td>");
                    excelstring.Append($"<td>{blocao.SENHA}</td>");
                    excelstring.Append($"<td>{blocao.REGIONAL}</td>");
                    excelstring.Append($"<td>{blocao.CARGO}</td>");
                    excelstring.Append($"<td>{((Cargos)blocao.CARGO).GetDisplayName()}</td>");
                    excelstring.Append($"<td>{blocao.NOME}</td>");
                    excelstring.Append($"<td>{blocao.UF}</td>");
                    excelstring.Append($"<td>{blocao.PDV}</td>");
                    excelstring.Append($"<td>{blocao.FIXA}</td>");
                    excelstring.Append($"<td>Escreva o motivo da solicitação aqui</td>");
                    excelstring.Append($"<td>{blocao.ELEGIVEL}</td>");
                    excelstring.Append($"<td>{blocao.DDD}</td>");
                    excelstring.Append($"<td>{string.Join(";", blocao.Perfil.Select(x => x.ToString()))}</td>");
                    excelstring.Append("</tr>");
                }
                htmldata = htmldata.Replace("@@ActualData", excelstring.ToString());

                // Convertendo HTML para DataTable
                DataTable dataTable = ConvertHtmlTableToDataTable(htmldata);

                // Convertendo DataTable para XLSX
                string StoredFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "FilesTemplates", "Excel_Saida.xlsx");

                if (System.IO.File.Exists(StoredFilePath))
                {
                    System.IO.File.Delete(StoredFilePath);
                }

                ExportToExcel(dataTable, StoredFilePath);

                var provider = new FileExtensionContentTypeProvider();

                if (!provider.TryGetContentType(StoredFilePath, out var contentType))
                {
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                }

                var bytes = await System.IO.File.ReadAllBytesAsync(StoredFilePath);

                System.IO.File.Delete(StoredFilePath);
                return new JsonResult(new Response<FileContentResult>
                {
                    Data = File(bytes, contentType, System.IO.Path.Combine(StoredFilePath)),
                    Succeeded = true,
                    Message = "O excel foi gerado corretamente baseando-se nos filtros atuais, aguarde o download."
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

        [HttpPost("ValidateUsuarioMassivo")]
        public async Task<JsonResult> ValidateUsuarioMassivo([FromBody] List<ControleUsuariosModel> usuarios)
        {
            try
            {
                if (CD.ACESSOS_MOBILE_PENDENTEs
                    .Where(x => x.TIPO != "ALTERAÇÃO" && x.STATUS != "REPROVADO")
                    .Select(x => x.EMAIL.ToLower()).Any(x => usuarios.Select(y => y.EMAIL.ToLower()).Contains(x)))
                {
                    IEnumerable<string> list = CD.ACESSOS_MOBILE_PENDENTEs.Select(x => x.EMAIL.ToLower()).Where(x => usuarios.Select(y => y.EMAIL.ToLower()).Contains(x)).Select(x => x + "\n");
                    return new JsonResult(new Response<IEnumerable<string>>
                    {
                        Data = list.Distinct(),
                        Succeeded = false,
                        Message = "Já existe uma solicitação de acesso em andamento com este e-mail",
                        Errors = new string[] { "Solicitação já existente!" },
                    });
                }
                else if (CD.ACESSOS_MOBILEs.Select(x => x.EMAIL.ToLower()).Any(x => usuarios.Select(y => y.EMAIL.ToLower()).Contains(x)))
                {
                    IEnumerable<string> list = CD.ACESSOS_MOBILEs.Select(x => x.EMAIL.ToLower()).Where(x => usuarios.Select(y => y.EMAIL.ToLower()).Contains(x)).Select(x => x + "\n");
                    return new JsonResult(new Response<IEnumerable<string>>
                    {
                        Data = list.Distinct(),
                        Succeeded = false,
                        Message = "Já existe um usuário ativo com o e-mail enviado no arquivo",
                        Errors = new string[] { "Solicitação já existente!" },
                    });
                }
                else if (CD.ACESSOS_MOBILE_PENDENTEs
                    .Where(x => x.TIPO != "ALTERAÇÃO" && x.STATUS != "REPROVADO")
                    .Select(x => x.MATRICULA).Any(x => usuarios.Select(y => y.MATRICULA).ToList().Contains(x.Value)))
                {
                    IEnumerable<string> list = CD.ACESSOS_MOBILE_PENDENTEs.Where(x => x.TIPO.ToLower() != "alteração").Select(x => x.MATRICULA).Where(x => usuarios.Select(y => y.MATRICULA).ToList().Contains(x.Value)).Select(x => x + "\n");

                    return new JsonResult(new Response<IEnumerable<string>>
                    {
                        Data = list.Distinct(),
                        Succeeded = false,
                        Message = "Já existe uma solicitação de acesso em andamento com esta matrícula",
                        Errors = new string[] { "matrícula existente!" },
                    });
                }
                else if (CD.ACESSOS_MOBILEs.Select(x => x.MATRICULA).Any(x => usuarios.Select(y => y.MATRICULA).ToList().Contains(x.Value)))
                {
                    IEnumerable<string> list = CD.ACESSOS_MOBILEs.Select(x => x.MATRICULA).Where(x => usuarios.Select(y => y.MATRICULA).ToList().Contains(x.Value)).Select(x => x + "\n");

                    return new JsonResult(new Response<IEnumerable<string>>
                    {
                        Data = list.Distinct(),
                        Succeeded = false,
                        Message = "Já existe um usuário ativo com esta matrícula",
                        Errors = new string[] { "matrícula existente!" },
                    });
                }

                return new JsonResult(new Response<string>
                {
                    Data = "Foi criado uma solicitação de acesso para todos os usuários no arquivo",
                    Succeeded = true,
                    Message = "Informações do arquivo validadas",
                    Errors = null,
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new Response<IEnumerable<string>>
                {
                    Data = new string[] { ex.Message, ex.StackTrace, ex.InnerException.Message, ex.Source },
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

        [HttpGet("GetPerfisUsuario")]
        public async Task<JsonResult> GetPerfisUsuario()
        {
            try
            {
                var perfis = CD.PERFIL_PLATAFORMAS_VIVOs.AsEnumerable();

                return new JsonResult(new Response<IEnumerable<PERFIL_PLATAFORMAS_VIVO>>
                {
                    Data = perfis,
                    Succeeded = true,
                    Message = "Foi criado uma solicitação de acesso para todos os usuários no arquivo",
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

        //[HttpGet, DisableRequestSizeLimit]
        //public IActionResult Download()
        //{
        //    var memory = new MemoryStream();
        //    using (var stream = new FileStream(@"pathToLocalFile", FileMode.Open))
        //    {
        //        stream.CopyToAsync(memory);
        //    }
        //    memory.Position = 0;
        //    //set correct content type here
        //    return File(memory, "application/octet-stream", "fileNameToBeUsedForSave");
        //}
    }

}
