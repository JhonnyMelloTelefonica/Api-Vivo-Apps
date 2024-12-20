using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnasNomeSocialAtividade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.AddColumn<string>(
                name: "Atividade",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NOME_SOCIAL",
                schema: "dbo",
                table: "ACESSOS_MOBILE",
                type: "nvarchar(max)",
                defaultValue:"-",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_RESPONSAVEL",
                principalSchema: "dbo",
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

            migrationBuilder.DropColumn(
                name: "Atividade",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "NOME_SOCIAL",
                schema: "dbo",
                table: "ACESSOS_MOBILE");

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_RESPONSAVEL",
                principalSchema: "dbo",
                principalTable: "ACESSOS_MOBILE",
                principalColumn: "ID");
        }
    }
}
