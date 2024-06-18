using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnAreaSubAre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_DEMANDA_ACESSOS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO");

            migrationBuilder.RenameColumn(
                name: "Origem",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                newName: "SubArea");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.DropIndex(
                name: "IX_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO");

            migrationBuilder.DropColumn(
                name: "ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO");

            migrationBuilder.AddColumn<Guid>(
                name: "ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
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
                name: "FK_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO");

            migrationBuilder.DropColumn(
                name: "Area",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.RenameColumn(
                name: "SubArea",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                newName: "Origem");

            migrationBuilder.AlterColumn<int>(
                name: "ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_DEMANDA_ACESSOS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                column: "ID_RELACAO",
                principalSchema: "Demandas",
                principalTable: "DEMANDA_ACESSOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
