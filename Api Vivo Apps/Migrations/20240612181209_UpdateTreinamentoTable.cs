using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTreinamentoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DT_MOD",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MAT_MOD",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Modo_Inclusao",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DT_MOD",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO");

            migrationBuilder.DropColumn(
                name: "MAT_MOD",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO");

            migrationBuilder.DropColumn(
                name: "Modo_Inclusao",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO");
        }
    }
}
