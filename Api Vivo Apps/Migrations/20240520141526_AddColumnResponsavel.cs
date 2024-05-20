using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnResponsavel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_RESPONSAVEL",
                principalTable: "ACESSOS_MOBILE",
                principalColumn: "MATRICULA");

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                column: "MATRICULA_RESPONSAVEL",
                principalTable: "ACESSOS_MOBILE",
                principalColumn: "MATRICULA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropColumn(
                name: "MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropColumn(
                name: "MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");
        }
    }
}
