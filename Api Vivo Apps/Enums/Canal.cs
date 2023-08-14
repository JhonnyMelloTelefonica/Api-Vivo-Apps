using System.ComponentModel.DataAnnotations;

namespace Vivo_Apps_API.Enums
{
    public enum Canal
    {
        [Display(Name = "Administrador")]
        ADM = 0,
        [Display(Name = "Venda Externa")]
        Venda_Externa = 1,
        [Display(Name = "Consumer")]
        Consumer = 2,
        [Display(Name = "Lojas Próprias")]
        Lojas_Próprias = 3,
        [Display(Name = "Revenda")]
        Revenda = 4,
        [Display(Name = "Canal de Vendas")]
        Canal_Vendas = 5
    }
}
