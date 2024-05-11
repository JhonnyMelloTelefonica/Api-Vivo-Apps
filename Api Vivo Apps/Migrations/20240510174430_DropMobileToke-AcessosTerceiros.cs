using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class DropMobileTokeAcessosTerceiros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.AddForeignKey(
                           name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                           schema: "Demandas",
                           table: "DEMANDA_ACESSOS",
                           column: "MATRICULA_SOLICITANTE",
                           principalTable: "ACESSOS_MOBILE",
                           principalColumn: "MATRICULA",
                           onDelete: ReferentialAction.NoAction);

            migrationBuilder.DropColumn(
                name: "DataContratoFim",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.DropColumn(
                name: "MobileToken",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataContratoInicio",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataContratoInicio",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataContratoFim",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MobileToken",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_ACESSOS_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_SOLICITANTE");

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
