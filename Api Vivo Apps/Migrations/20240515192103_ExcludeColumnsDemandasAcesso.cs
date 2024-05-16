using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class ExcludeColumnsDemandasAcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AceiteSenha",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "Area",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "Login",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "NomeMae",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "Obs",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "Perfil",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "Senha",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "SubArea",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "TipoAcesso",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AceiteSenha",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Area",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Obs",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubArea",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoAcesso",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
