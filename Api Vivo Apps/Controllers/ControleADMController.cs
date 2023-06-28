using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Vivo_Apps_API.Models;
using Vivo_Apps_API.Data;
using System.Drawing;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Vivo_Apps_API.Enums;
using NetTopologySuite.Algorithm;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControleADMController
    {
        private Vivo_MAISContext CD = new Vivo_MAISContext();

        private readonly ILogger<ControleADMController> _logger;

        public ControleADMController(ILogger<ControleADMController> logger)
        {
            _logger = logger;
        }

        // Metodos GET //
        [HttpGet("GetControleUsersFilters")]
        public JsonResult GetControleUsersFilters()
        {
            var data = CD.ACESSOS_MOBILEs.AsQueryable();
            var uf = data.Select(x => x.UF).Distinct().ToArray();
            var canal = data.Select(x => x.CANAL).Distinct().ToArray();
            var cargo = data.Select(x => x.CARGO).Distinct().ToArray();
            var regional = data.Select(x => x.REGIONAL).Distinct().ToArray();

            return new JsonResult(new
            {
                uf = uf,
                canal = canal,
                cargo = cargo,
                regional = regional
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
                    // Caso quem esteja acessando não seja do suporte
                    // só verá acesso que foram solicitados pelo mesmo

                    var MatriculasResponsavel = CD.ACESSOS_MOBILE_PENDENTEs
                        .Where(x => x.LOGIN_SOLICITANTE == filter.Matricula).Select(x => x.MATRICULA).Distinct();

                    pagedData = pagedData.Where(x => MatriculasResponsavel.Contains(x.MATRICULA));
                }
            }
            if (filter.Uf.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Uf.Contains(x.UF));
            }
            if (filter.Cargo.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Cargo.Contains(x.CARGO));
            }
            if (filter.Canal.Count() > 0)
            {
                pagedData = pagedData.Where(x => filter.Canal.Contains(x.CANAL));
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
            if (!string.IsNullOrEmpty(filter.Matricula) && filter.IsSuporte == true)
            {
                pagedData = pagedData.Where(x => x.MATRICULA.ToLower().Contains(filter.Matricula.ToLower()));
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

            return new JsonResult(PagedResponse.CreatePagedReponse<ACESSOS_MOBILE>(Data, filter, totalRecords));
        }
        private string DeParaDeCanalCargo(string cargo)
        {
            switch (cargo)
            {
                case "Guru":

                    return "Loja Própria";

                case "GGP":

                    return "MultCanal";

                case "Gerente Geral":

                    return "Loja Própria";

                case "GA":

                    return "MultCanal";

                case "GO":

                    return "Loja Própria";

                case "Supervisor PAP":

                    return "PAP";

                case "Vendedor PAP":

                    return "PAP";

                case "Gerente de Revenda":

                    return "Revenda";

                case "Vendedor Revenda":

                    return "Revenda";

                case "CN":

                    return "Loja Própria";

                case "Vendas_Adm":

                    return "Adm_Consumer";

                case "Adm_Consumer":

                    return "Adm_Consumer";

                default:

                    return "";
            }
        }

        private Canal DeParaDeCanalCargoEnum(Cargos cargo)
        {
            switch (cargo)
            {
                case Cargos.Vendedor_PAP:

                    return Canal.Venda_Externa;

                case Cargos.Gerente_Parceiros:
                    
                    return Canal.Consumer;

                case Cargos.Gerente_Geral:
                    
                    return Canal.Lojas_Próprias;

                case Cargos.Supervisor_PAP:
                    
                    return Canal.Venda_Externa;

                case Cargos.Vendedor_Revenda:
                    
                    return Canal.Revenda;

                case Cargos.Gerente_Revenda:
                    
                    return Canal.Revenda;

                case Cargos.Gerente_Área:
                    
                    return Canal.Canal_Vendas;

                case Cargos.Gerente_Operações:
                    
                    return Canal.Lojas_Próprias;

                case Cargos.Consultor_Negócios:
                    
                    return Canal.Lojas_Próprias;

                case Cargos.Consultor_Tecnológico:
                    
                    return Canal.Lojas_Próprias;

                case Cargos.Gerente_Vendas_B2C:
                    
                    return Canal.Canal_Vendas;

                case Cargos.Gerente_Senior_Territorial:
                    
                    return Canal.Canal_Vendas;

                case Cargos.Coordenador_Suporte_Vendas:
                    
                    return Canal.Consumer;

                case Cargos.Gerente_Suporte_Vendas:
                    
                    return Canal.Consumer;

                case Cargos.Diretora:
                    
                    return Canal.Consumer;

                case Cargos.Consultor_Gestão_Vendas:
                    
                    return Canal.Consumer;

                case Cargos.Analista_Suporte_Vendas_Senior:
                    
                    return Canal.Consumer;

                case Cargos.Analista_Suporte_Vendas_Pleno:
                    
                    return Canal.Consumer;

                case Cargos.Analista_Suporte_Vendas_Junior:
                    
                    return Canal.Consumer;

                case Cargos.Estagiário:
                    
                    return Canal.Consumer;

                case Cargos.Gerente_Senior_Gestão_Vendas:
                    
                    return Canal.Consumer;

                default:

                    return Canal.ADM;

            }
        }

        [HttpPost("UpdateUsuarios")]
        public async Task<JsonResult> UpdateUsuarios([FromBody] ACESSOS_MOBILE usuario,
            string? matricula,
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
                    CANAL = ((int)DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO))).ToString(),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    APROVACAO = false,
                    FIXA = usuario.FIXA,
                    DT_SOLICITACAO = DateTime.Now.ToString(),
                    DT_PRIMEIRO_RETORNO = null,
                    DT_RETORNO = null,
                    LOGIN_RESPONSAVEL = null,
                    LOGIN_SOLICITANTE = matricula,
                    ID_ACESSOS_MOBILE = ID_ACESSOS_MOBILE,
                    STATUS_USUARIO = usuario.STATUS,
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
                    DATA = DateTime.Now.ToString(),
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
        public async Task<JsonResult> BloquearUsuario(int id, string? matricula)
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
                    CANAL = ((int)DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO))).ToString(),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    APROVACAO = false,
                    FIXA = usuario.FIXA,
                    DT_SOLICITACAO = DateTime.Now.ToString(),
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
                    DATA = DateTime.Now.ToString(),
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
        public async Task<JsonResult> DesbloquearUsuario(int id, string matricula)
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
                    CANAL = ((int)DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO))).ToString(),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    APROVACAO = false,
                    FIXA = usuario.FIXA,
                    DT_SOLICITACAO = DateTime.Now.ToString(),
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
                    DATA = DateTime.Now.ToString(),
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
        // Metodos POST //
        [HttpPost("UpdateUsuariosSuporte")]
        public async Task<JsonResult> UpdateUsuariosSuporte([FromBody] ACESSOS_MOBILE usuario, string matricula)
        {
            try
            {
                using (CD = new Vivo_MAISContext())
                {
                    ACESSOS_MOBILE user = CD.ACESSOS_MOBILEs.Find(usuario.ID);

                    if (user.EMAIL != usuario.EMAIL && CD.ACESSOS_MOBILEs.Any(x => x.EMAIL.Contains(usuario.EMAIL))
                        || user.MATRICULA != usuario.MATRICULA && CD.ACESSOS_MOBILEs.Any(x => x.MATRICULA.Contains(usuario.MATRICULA)))
                    {
                        return new JsonResult(new Response<string>
                        {
                            Data = "Matricula ou email repetidas",
                            Succeeded = false,
                            Message = "Matricula ou email foi repetida com algum valor ja inserido no banco"
                        });
                    }
                    if (user != null)
                    {
                        user.EMAIL = usuario.EMAIL;
                        user.MATRICULA = usuario.MATRICULA;
                        user.SENHA = usuario.SENHA;
                        user.REGIONAL = usuario.REGIONAL;
                        user.CARGO = usuario.CARGO;
                        user.CANAL = ((int)DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO))).ToString();
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
                        user.DT_MOD = DateTime.Now.ToString();
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
        public async Task<JsonResult> BloquearUsuarioSuporte(string TP_AFASTAMENTO, string OBS, int id, string? matricula)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.ID == id).FirstOrDefault();
                user.STATUS = false;
                user.TP_AFASTAMENTO = TP_AFASTAMENTO;
                user.OBS = OBS;
                user.LOGIN_MOD = matricula;
                user.DT_MOD = DateTime.Now.ToString();
                await CD.SaveChangesAsync();
                return new JsonResult(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("DesbloquearUsuarioSuporte")]
        public async Task<JsonResult> DesbloquearUsuarioSuporte(int id, string matricula)
        {
            try
            {
                var user = CD.ACESSOS_MOBILEs.Where(x => x.ID == id).FirstOrDefault();
                user.STATUS = true;
                user.LOGIN_MOD = matricula;
                user.DT_MOD = DateTime.Now.ToString();
                await CD.SaveChangesAsync();
                return new JsonResult(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
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
        [HttpGet("ValidarMatricula")]
        public async Task<JsonResult> ValidarMatricula(string matricula)
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
                        Message = "Já existe uma solicitação de acesso ou um usuário com esta mátricula",
                        Errors = new string[] { "Mátricula existente!" },
                    });
                }

                return new JsonResult(new Response<string>
                {
                    Data = "Mátricula válida!",
                    Succeeded = true,
                    Message = "Mátricula válida!"
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
        public async Task<JsonResult> CriarUsuario([FromBody] ACESSOS_MOBILE usuario,
            string? matricula,
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
                    CANAL = ((int)DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO))).ToString(),
                    NOME = usuario.NOME,
                    UF = usuario.UF,
                    CPF = usuario.CPF,
                    PDV = usuario.PDV,
                    APROVACAO = false,
                    FIXA = usuario.FIXA,
                    DT_SOLICITACAO = DateTime.Now.ToString(),
                    DT_PRIMEIRO_RETORNO = null,
                    DT_RETORNO = null,
                    LOGIN_RESPONSAVEL = null,
                    LOGIN_SOLICITANTE = matricula,
                    STATUS_USUARIO = false,
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
                    DATA = DateTime.Now.ToString(),
                });

                await CD.SaveChangesAsync();


                return new JsonResult(new Response<ACESSOS_MOBILE_PENDENTE>
                {
                    Data = user,
                    Succeeded = true,
                    Message = "Tudo Certo!",
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

        [HttpPost("GetUsuariosPendentes")]
        public async Task<JsonResult> GetUsuariosPendentes(
            [FromBody] GenericPaginationModel<FilterUsuariosPendentesModel> filter)
        {
            try
            {
                var users = CD.ACESSOS_MOBILE_PENDENTEs.AsQueryable();

                // FILTRA PELA REGIONAL DO USUÁRIO
                users = users.Where(x => x.REGIONAL == filter.Value.REGIONAL);

                if (filter.Value.IsSuporte == true)
                {
                    // BUSCA APENAS OS QUE NÃO FORAM AUTORIZADOS AINDA
                    users = users.Where(x => x.APROVACAO == false);
                }
                else
                {
                    // BUSCA PELO LOGIN DO SOLICITANTE
                    users = users.Where(x => x.LOGIN_SOLICITANTE == filter.Value.LOGIN);
                }
                users = users.GroupBy(X => X.MATRICULA)
                    .AsEnumerable().Select(y => y.LastOrDefault()).AsQueryable();

                var lista = users.OrderBy(x => x.ID)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize);

                IEnumerable<ACESSOS_MOBILE_PENDENTE_MODEL> Data = lista.Select(x => new ACESSOS_MOBILE_PENDENTE_MODEL
                {
                    ID = x.ID,
                    EMAIL = x.EMAIL,
                    MATRICULA = x.MATRICULA,
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
                    SOLICITANTE = CD.ACESSOs.Where(y => y.Login == x.LOGIN_SOLICITANTE).FirstOrDefault(),
                    DT_SOLICITACAO = x.DT_SOLICITACAO,
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

        [HttpGet("GetAcessoPendenteById")]
        public JsonResult GetAcessoPendenteById(int IdAcesso)
        {
            try
            {
                var acesso = CD.ACESSOS_MOBILE_PENDENTEs.Find(IdAcesso);
                var respostas = CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Where(x => x.ID_ACESSOS_PENDENTE == IdAcesso)
                    .Select(x => new RespostasAcessosPendentesModel
                    {
                        ID = x.ID,
                        ID_ACESSOS_PENDENTE = x.ID_ACESSOS_PENDENTE,
                        MATRICULA = CD.ACESSOs.Where(y => y.Login == x.MATRICULA).FirstOrDefault(),
                        RESPOSTA = x.RESPOSTA,
                        STATUS = x.STATUS,
                        DATA = x.DATA,
                    });
                var retorno = new HistoricoAcessosPendentesModel
                {
                    ID = acesso.ID,
                    ID_ACESSOS_MOBILE = (acesso.TIPO.ToLower() == "alteração"
                    ? CD.ACESSOS_MOBILEs.Where(x => x.ID == acesso.ID_ACESSOS_MOBILE).FirstOrDefault()
                    : null),
                    EMAIL = acesso.EMAIL,
                    MATRICULA = acesso.MATRICULA,
                    SENHA = acesso.SENHA,
                    REGIONAL = acesso.REGIONAL,
                    CARGO = (Cargos)Convert.ToInt32(acesso.CARGO),
                    CANAL = DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(acesso.CARGO)),
                    NOME = acesso.NOME,
                    UF = acesso.UF,
                    CPF = acesso.CPF,
                    PDV = acesso.PDV,
                    APROVACAO = acesso.APROVACAO,
                    FIXA = acesso.FIXA,
                    TIPO = acesso.TIPO,
                    STATUS_USUARIO = acesso.STATUS_USUARIO,
                    LOGIN_SOLICITANTE = CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_SOLICITANTE).FirstOrDefault(),
                    LOGIN_RESPONSAVEL = (acesso.LOGIN_RESPONSAVEL == null ?
                                        CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_RESPONSAVEL).FirstOrDefault() :
                                        null),
                    DT_SOLICITACAO = acesso.DT_SOLICITACAO,
                    DT_RETORNO = acesso.DT_RETORNO,
                    STATUS = acesso.STATUS,
                    RESPOSTAS = respostas,
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

        [HttpPost("AnswerAcesso")]
        public async Task<JsonResult> AnswerAcesso(
            [FromBody] HistoricoAcessosPendentesModel? usuario,
              string matricula,
              int id,
              string resposta,
              string status,
              bool? aprovacaosuporte)
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
                    DATA = DateTime.Now.ToString()
                });

                var acesso = CD.ACESSOS_MOBILE_PENDENTEs.Find(id);
                acesso.STATUS = status;
                acesso.DT_RETORNO = DateTime.Now.ToString();

                if (acesso.LOGIN_SOLICITANTE != matricula)
                //Caso a resposta seja diferente do solicitante significa que veio do suporte
                {
                    if (string.IsNullOrEmpty(acesso.DT_PRIMEIRO_RETORNO))
                    // Caso a primeira resposta ainda não esteja defenida inserimos agora
                    {
                        acesso.DT_PRIMEIRO_RETORNO = DateTime.Now.ToString();
                    }

                    acesso.LOGIN_RESPONSAVEL = matricula;

                    if (aprovacaosuporte.Value == true)
                    // Caso tenha sido aprovado pelo suporte ele adiciona na tabela final
                    {
                        acesso.APROVACAO = true;
                        if (usuario.TIPO.ToLower() != "alteração")
                        {
                            CD.ACESSOS_MOBILEs.Add(new ACESSOS_MOBILE
                            {
                                EMAIL = usuario.EMAIL,
                                MATRICULA = usuario.MATRICULA,
                                SENHA = CryptSenha(usuario.SENHA),
                                REGIONAL = usuario.REGIONAL,
                                CARGO = ((int)usuario.CARGO).ToString(),
                                CANAL = ((int)DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO))).ToString(),
                                NOME = usuario.NOME,
                                UF = usuario.UF,
                                CPF = usuario.CPF,
                                PDV = usuario.PDV,
                                STATUS = true,
                                FIXA = usuario.FIXA,
                                OBS = resposta,
                                LOGIN_MOD = matricula,
                                DT_MOD = DateTime.Now.ToString(),
                            });
                            await CD.SaveChangesAsync();
                        }
                    }
                }
                else
                {
                    acesso.EMAIL = usuario.EMAIL;
                    acesso.MATRICULA = usuario.MATRICULA;
                    acesso.SENHA = usuario.SENHA;
                    acesso.REGIONAL = usuario.REGIONAL;
                    acesso.CARGO = ((int)usuario.CARGO).ToString();
                    acesso.CANAL = ((int)DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO))).ToString();
                    acesso.NOME = usuario.NOME;
                    acesso.UF = usuario.UF;
                    acesso.CPF = usuario.CPF;
                    acesso.PDV = usuario.PDV;
                    acesso.APROVACAO = usuario.APROVACAO;
                    acesso.FIXA = usuario.FIXA;
                    acesso.STATUS = status;
                    acesso.DT_RETORNO = DateTime.Now.ToString();
                }

                await CD.SaveChangesAsync();

                var respostas = CD.HISTORICO_ACESSOS_MOBILE_PENDENTEs.Where(x => x.ID_ACESSOS_PENDENTE == id)
                    .Select(x => new RespostasAcessosPendentesModel
                    {
                        ID = x.ID,
                        ID_ACESSOS_PENDENTE = x.ID_ACESSOS_PENDENTE,
                        MATRICULA = CD.ACESSOs.Where(y => y.Login == x.MATRICULA).FirstOrDefault(),
                        RESPOSTA = x.RESPOSTA,
                        STATUS = x.STATUS,
                        DATA = x.DATA,
                    });
                var retorno = new HistoricoAcessosPendentesModel
                {
                    ID = acesso.ID,
                    ID_ACESSOS_MOBILE = (acesso.TIPO.ToLower() == "alteração"
                    ? CD.ACESSOS_MOBILEs.Where(x => x.ID == acesso.ID_ACESSOS_MOBILE).FirstOrDefault()
                    : null),
                    EMAIL = acesso.EMAIL,
                    MATRICULA = acesso.MATRICULA,
                    SENHA = acesso.SENHA,
                    REGIONAL = acesso.REGIONAL,
                    CARGO = (Cargos)Convert.ToInt32(usuario.CARGO),
                    CANAL = DeParaDeCanalCargoEnum((Cargos)Convert.ToInt32(usuario.CARGO)),
                    NOME = acesso.NOME,
                    UF = acesso.UF,
                    CPF = acesso.CPF,
                    PDV = acesso.PDV,
                    APROVACAO = acesso.APROVACAO,
                    FIXA = acesso.FIXA,
                    TIPO = acesso.TIPO,
                    STATUS_USUARIO = acesso.STATUS_USUARIO,
                    LOGIN_SOLICITANTE = CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_SOLICITANTE).FirstOrDefault(),
                    LOGIN_RESPONSAVEL = (acesso.LOGIN_RESPONSAVEL == null ?
                                        CD.ACESSOs.Where(x => x.Login == acesso.LOGIN_RESPONSAVEL).FirstOrDefault() :
                                        null),
                    DT_SOLICITACAO = acesso.DT_SOLICITACAO,
                    DT_RETORNO = acesso.DT_RETORNO,
                    STATUS = acesso.STATUS,

                    RESPOSTAS = respostas,
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
    }


}
