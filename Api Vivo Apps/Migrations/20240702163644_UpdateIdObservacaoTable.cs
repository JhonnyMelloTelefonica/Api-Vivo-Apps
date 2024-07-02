using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdObservacaoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DEMANDA_OBSERVACOES_ANALISTAS",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MAT_ANALISTA = table.Column<int>(type: "int", unicode: false, nullable: false),
                    OBSERVACAO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_OBSERVACOES_ANALISTAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_OBSERVACOES_ANALISTAS_ACESSOS_MOBILE_MAT_ANALISTA",
                        column: x => x.MAT_ANALISTA,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_OBSERVACOES_ANALISTAS_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID_RELACAO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_OBSERVACOES_ANALISTAS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_OBSERVACOES_ANALISTAS",
                column: "ID_RELACAO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEMANDA_OBSERVACOES_ANALISTAS",
                schema: "Demandas");
        }
    }
}
