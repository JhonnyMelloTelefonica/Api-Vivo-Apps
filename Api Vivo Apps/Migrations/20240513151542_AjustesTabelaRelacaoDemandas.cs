using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class AjustesTabelaRelacaoDemandas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRIORIDADE",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO");

            migrationBuilder.RenameColumn(
                name: "Regional",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                newName: "REGIONAL");

            migrationBuilder.RenameColumn(
                name: "HoraAbertura",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                newName: "DATA_ABERTURA");

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_ABERTURA",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "PRIORIDADE",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PRIORIDADE_SEGMENTO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_RELACAO_CHAMADO_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                column: "MATRICULA_SOLICITANTE");

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                column: "MATRICULA_SOLICITANTE",
                principalTable: "ACESSOS_MOBILE",
                principalColumn: "MATRICULA",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropIndex(
                name: "IX_DEMANDA_RELACAO_CHAMADO_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropColumn(
                name: "DATA_ABERTURA",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropColumn(
                name: "MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropColumn(
                name: "PRIORIDADE",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropColumn(
                name: "PRIORIDADE_SEGMENTO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.RenameColumn(
                name: "REGIONAL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                newName: "Regional");

            migrationBuilder.RenameColumn(
                name: "DATA_ABERTURA",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                newName: "HoraAbertura");

            migrationBuilder.AddColumn<string>(
                name: "PRIORIDADE",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                type: "varchar(550)",
                unicode: false,
                maxLength: 550,
                nullable: true);
        }
    }
}
