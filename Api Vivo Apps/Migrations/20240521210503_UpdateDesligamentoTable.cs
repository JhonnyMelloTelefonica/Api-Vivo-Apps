using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDesligamentoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropColumn(
                name: "ADABAS",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "CONFIRMA_DESLIGAMENTO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "DATA_CADASTRO_DESLIGAMENTO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "DATA_CONFIRMA_DESLIGAMENTO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "DDD",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "LOGIN_FUNCIONARIO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "MATRICULA_FUNCIONARIO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "MOTIVO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "NOME_FUNCIONARIO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "REGIONAL",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "UF",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "USUARIO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.RenameColumn(
                name: "CPF",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                newName: "Cpf");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_ABERTURA",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Login",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Matricula",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_DESLIGAMENTOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
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
                name: "FK_DEMANDA_DESLIGAMENTOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropForeignKey(
                name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");

            migrationBuilder.DropIndex(
                name: "IX_DEMANDA_DESLIGAMENTOS_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "DATA_ABERTURA",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "Login",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "Matricula",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.DropColumn(
                name: "Nome",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                newName: "CPF");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ADABAS",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONFIRMA_DESLIGAMENTO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_CADASTRO_DESLIGAMENTO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_CONFIRMA_DESLIGAMENTO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DDD",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LOGIN_FUNCIONARIO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MATRICULA_FUNCIONARIO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MOTIVO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NOME_FUNCIONARIO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REGIONAL",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "USUARIO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                column: "MATRICULA_RESPONSAVEL",
                principalTable: "ACESSOS_MOBILE",
                principalColumn: "ID");
        }
    }
}
