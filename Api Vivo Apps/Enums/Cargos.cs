using System.ComponentModel.DataAnnotations;

namespace Vivo_Apps_API.Enums
{
    public enum Cargos
    {

        [Display(Name = "Administrador")]
        ADM = 0,
        [Display(Name = "Vendedor PAP")]
        Vendedor_PAP = 1,
        [Display(Name = "Gerente Parceiros")]
        Gerente_Parceiros = 2,
        [Display(Name = "Gerente geral")]
        Gerente_Geral = 3,
        [Display(Name = "Supervisor PAP")]
        Supervisor_PAP = 4,
        [Display(Name = "Vendedor Revenda")]
        Vendedor_Revenda = 5,
        [Display(Name = "Gerente Revenda")]
        Gerente_Revenda = 6,
        [Display(Name = "Gerente de Área")]
        Gerente_Área = 7,
        [Display(Name = "Gerente Operações")]
        Gerente_Operações = 8,
        [Display(Name = "Consultor de Negócios")]
        Consultor_Negócios = 9,
        [Display(Name = "Guru")]
        Consultor_Tecnológico = 10,
        [Display(Name = "Gerente de Vendas B2C")]
        Gerente_Vendas_B2C = 11,
        [Display(Name = "Gerente Senior Territórial")]
        Gerente_Senior_Territorial = 12,
        [Display(Name = "Coordenador Suporte de Vendas")]
        Coordenador_Suporte_Vendas = 13,
        [Display(Name = "Gerente Suporte de Vendas")]
        Gerente_Suporte_Vendas = 14,
        [Display(Name = "Diretor(a)")]
        Diretora = 15,
        [Display(Name = "Consultor Gestão de Vendas")]
        Consultor_Gestão_Vendas = 16,
        [Display(Name = "Analista Suporte de Vendas Senior")]
        Analista_Suporte_Vendas_Senior = 17,
        [Display(Name = "Analista Suporte de Vendas Pleno")]
        Analista_Suporte_Vendas_Pleno = 18,
        [Display(Name = "Analista Suporte de Vendas Júnior")]
        Analista_Suporte_Vendas_Junior = 19,
        [Display(Name = "Estagiário")]
        Estagiário = 20,
        [Display(Name = "Gerente Senior Gestão de Vendas")]
        Gerente_Senior_Gestão_Vendas = 21
    }
}
