using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class AddDesligamentoFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_DESLIGAMENTOS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                column: "ID_RELACAO",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_DESLIGAMENTOS_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                column: "ID_RELACAO",
                principalSchema: "Demandas",
                principalTable: "DEMANDA_RELACAO_CHAMADO",
                principalColumn: "ID_RELACAO",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_DESLIGAMENTOS_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropIndex(
                name: "IX_DEMANDA_DESLIGAMENTOS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");
        }
    }
}
