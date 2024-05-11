using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class ACESSOFKAcessosTerceiros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_SOLICITANTE",
                principalTable: "ACESSOS_MOBILE",
                principalColumn: "MATRICULA",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_SOLICITANTE",
                principalTable: "ACESSOS_MOBILE",
                principalColumn: "MATRICULA",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
