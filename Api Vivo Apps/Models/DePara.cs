using Vivo_Apps_API.Enums;

namespace Vivo_Apps_API.Models
{
    public class DePara
    {
        public static string CanalCargo(string cargo)
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

        public static Canal CanalCargoEnum(Cargos cargo)
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
        public static Canal CanalCargoEnum(string cargostring)
        {
            Cargos cargo = (Cargos)int.Parse(cargostring);
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
    }
}
