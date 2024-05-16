using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class AjustesFKHistoricoChamados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEMANDA_HISTORICO_PRIORIDADE",
                schema: "Demandas");

            migrationBuilder.CreateTable(
                name: "CHAMADO_HISTORICO_PRIORIDADE",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MAT_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    PRIORIDADE = table.Column<bool>(type: "bit", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMADO_HISTORICO_PRIORIDADE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CHAMADO_HISTORICO_PRIORIDADE_ACESSOS_MOBILE_MAT_RESPONSAVEL",
                        column: x => x.MAT_RESPONSAVEL,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CHAMADO_HISTORICO_PRIORIDADE_DEMANDA_RELACAO_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHAMADO_HISTORICO_PRIORIDADE_ID_CHAMADO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMADO_HISTORICO_PRIORIDADE_MAT_RESPONSAVEL",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                column: "MAT_RESPONSAVEL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHAMADO_HISTORICO_PRIORIDADE",
                schema: "Demandas");

            migrationBuilder.CreateTable(
                name: "DEMANDA_HISTORICO_PRIORIDADE",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    MAT_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false),
                    PRIORIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_HISTORICO_PRIORIDADE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_HISTORICO_PRIORIDADE_ACESSOS_MOBILE_MAT_RESPONSAVEL",
                        column: x => x.MAT_RESPONSAVEL,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_HISTORICO_PRIORIDADE_DEMANDA_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_HISTORICO_PRIORIDADE_ID_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_HISTORICO_PRIORIDADE",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_HISTORICO_PRIORIDADE_MAT_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_HISTORICO_PRIORIDADE",
                column: "MAT_RESPONSAVEL");
        }
    }
}
