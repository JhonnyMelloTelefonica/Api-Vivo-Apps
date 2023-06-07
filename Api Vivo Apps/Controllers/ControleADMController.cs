using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;
using Api_Vivo_Apps.Models;
using Api_Vivo_Apps.Data;

namespace Api_Vivo_Apps.Controllers
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
                pagedData = pagedData.Where(x => filter.Fixa.Contains(x.FIXA));
            }
            if (!string.IsNullOrEmpty(filter.Nome))
            {
                pagedData = pagedData.Where(x => x.NOME.ToLower().Contains(filter.Nome.ToLower()));
            }
            if (!string.IsNullOrEmpty(filter.Matricula))
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
        // Metodos POST //
        [HttpPost("UpdateUsuarios")]
        public async Task<JsonResult> UpdateUsuarios([FromBody] ACESSOS_MOBILE usuario, string matricula)
        {
            try
            {
                using (CD = new Vivo_MAISContext())
                {
                    usuario.SENHA = CryptSenha(usuario.SENHA);
                    usuario.CANAL = DeParaDeCanalCargo(usuario.CARGO);
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
                        user.CANAL = usuario.CANAL;
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
        [HttpPost("BloquearUsuario")]
        public async Task<JsonResult> BloquearUsuario(string TP_AFASTAMENTO, string OBS, int id, string matricula)
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

        [HttpPost("DesbloquearUsuario")]
        public async Task<JsonResult> DesbloquearUsuario(int id, string matricula)
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

    }
}
