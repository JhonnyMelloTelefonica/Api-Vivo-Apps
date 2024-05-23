using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class RenameIdGuidColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHAMADO_HISTORICO_PRIORIDADE_DEMANDA_RELACAO_CHAMADO_ID_CHAMADO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE");

            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_CHAMADO_RESPOSTA_DEMANDA_RELACAO_CHAMADO_ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA");

            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO");

            migrationBuilder.RenameColumn(
                name: "ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                newName: "ID_RELACAO");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                newName: "ID_RELACAO");

            migrationBuilder.RenameColumn(
                name: "ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                newName: "ID_RELACAO");

            migrationBuilder.RenameIndex(
                name: "IX_DEMANDA_CHAMADO_RESPOSTA_ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                newName: "IX_DEMANDA_CHAMADO_RESPOSTA_ID_RELACAO");

            migrationBuilder.RenameColumn(
                name: "ID_CHAMADO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                newName: "ID_RELACAO");

            migrationBuilder.RenameIndex(
                name: "IX_CHAMADO_HISTORICO_PRIORIDADE_ID_CHAMADO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                newName: "IX_CHAMADO_HISTORICO_PRIORIDADE_ID_RELACAO");

            migrationBuilder.AddForeignKey(
                name: "FK_CHAMADO_HISTORICO_PRIORIDADE_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                column: "ID_RELACAO",
                principalSchema: "Demandas",
                principalTable: "DEMANDA_RELACAO_CHAMADO",
                principalColumn: "ID_RELACAO",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_CHAMADO_RESPOSTA_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                column: "ID_RELACAO",
                principalSchema: "Demandas",
                principalTable: "DEMANDA_RELACAO_CHAMADO",
                principalColumn: "ID_RELACAO",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "ID_RELACAO",
                principalSchema: "Demandas",
                principalTable: "DEMANDA_RELACAO_CHAMADO",
                principalColumn: "ID_RELACAO",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHAMADO_HISTORICO_PRIORIDADE_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE");

            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_CHAMADO_RESPOSTA_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA");

            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO");

            migrationBuilder.RenameColumn(
                name: "ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                newName: "ID_RELACAO_CHAMADO");

            migrationBuilder.RenameColumn(
                name: "ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                newName: "ID_RELACAO_CHAMADO");

            migrationBuilder.RenameIndex(
                name: "IX_DEMANDA_CHAMADO_RESPOSTA_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                newName: "IX_DEMANDA_CHAMADO_RESPOSTA_ID_RELACAO_CHAMADO");

            migrationBuilder.RenameColumn(
                name: "ID_RELACAO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                newName: "ID_CHAMADO");

            migrationBuilder.RenameIndex(
                name: "IX_CHAMADO_HISTORICO_PRIORIDADE_ID_RELACAO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                newName: "IX_CHAMADO_HISTORICO_PRIORIDADE_ID_CHAMADO");

            migrationBuilder.AddForeignKey(
                name: "FK_CHAMADO_HISTORICO_PRIORIDADE_DEMANDA_RELACAO_CHAMADO_ID_CHAMADO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                column: "ID_CHAMADO",
                principalSchema: "Demandas",
                principalTable: "DEMANDA_RELACAO_CHAMADO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_CHAMADO_RESPOSTA_DEMANDA_RELACAO_CHAMADO_ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                column: "ID_RELACAO_CHAMADO",
                principalSchema: "Demandas",
                principalTable: "DEMANDA_RELACAO_CHAMADO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "ID_RELACAO_CHAMADO",
                principalSchema: "Demandas",
                principalTable: "DEMANDA_RELACAO_CHAMADO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
