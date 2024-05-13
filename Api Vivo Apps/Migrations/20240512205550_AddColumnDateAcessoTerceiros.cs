using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnDateAcessoTerceiros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraAbertura",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "HoraAbertura",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_SOLICITANTE",
                principalTable: "ACESSOS_MOBILE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
