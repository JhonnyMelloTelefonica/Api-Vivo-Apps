using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class AddTableTreinamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    ID_RELACAO = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Data_Admissão = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    Canal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Data_Conclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STATUS_MATRICULA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_DEMANDA_ACESSOS_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_ACESSOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                column: "ID_RELACAO",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                schema: "Demandas");
        }
    }
}
