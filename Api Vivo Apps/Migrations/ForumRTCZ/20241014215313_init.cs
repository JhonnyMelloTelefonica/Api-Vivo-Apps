using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations.ForumRTCZ
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Fórum");

            migrationBuilder.CreateTable(
                name: "FORUM_PUBLICACAO_SOLICITACAO",
                schema: "Fórum",
                columns: table => new
                {
                    ID_SOLICITACAO_PUBLICACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TEXT_PUBLICACAO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SUB_TEMA = table.Column<int>(type: "int", nullable: false),
                    MAT_RESPONSAVEL = table.Column<int>(type: "int", nullable: false),
                    HORA = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORUM_PUBLICACAO_SOLICITACAO", x => x.ID_SOLICITACAO_PUBLICACAO);
                    table.ForeignKey(
                        name: "FK_FORUM_PUBLICACAO_SOLICITACAO_ACESSOS_MOBILE_MAT_RESPONSAVEL",
                        column: x => x.MAT_RESPONSAVEL,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FORUM_PUBLICACAO_SOLICITACAO_JORNADA_BD_TEMAS_SUB_TEMAS_SUB_TEMA",
                        column: x => x.SUB_TEMA,
                        principalTable: "JORNADA_BD_TEMAS_SUB_TEMAS",
                        principalColumn: "ID_SUB_TEMAS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FORUM_RESPONSAVEL_TEMA",
                schema: "Fórum",
                columns: table => new
                {
                    ID_RESPONSAVEL_TEMA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", nullable: false),
                    SUB_TEMA = table.Column<int>(type: "int", nullable: false),
                    HORA = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORUM_RESPONSAVEL_TEMA", x => x.ID_RESPONSAVEL_TEMA);
                    table.ForeignKey(
                        name: "FK_FORUM_RESPONSAVEL_TEMA_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FORUM_RESPONSAVEL_TEMA_JORNADA_BD_TEMAS_SUB_TEMAS_SUB_TEMA",
                        column: x => x.SUB_TEMA,
                        principalTable: "JORNADA_BD_TEMAS_SUB_TEMAS",
                        principalColumn: "ID_SUB_TEMAS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FORUM_PUBLICACAO",
                schema: "Fórum",
                columns: table => new
                {
                    ID_PUBLICACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SOLICITACAO_PUBLICACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HORA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MAT_SOLICITANTE = table.Column<int>(type: "int", nullable: false),
                    TEXT_PUBLICACAO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SUB_TEMA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORUM_PUBLICACAO", x => x.ID_PUBLICACAO);
                    table.ForeignKey(
                        name: "FK_FORUM_PUBLICACAO_ACESSOS_MOBILE_MAT_SOLICITANTE",
                        column: x => x.MAT_SOLICITANTE,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FORUM_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO",
                        column: x => x.ID_PUBLICACAO,
                        principalSchema: "Fórum",
                        principalTable: "FORUM_PUBLICACAO_SOLICITACAO",
                        principalColumn: "ID_SOLICITACAO_PUBLICACAO",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FORUM_PUBLICACAO_JORNADA_BD_TEMAS_SUB_TEMAS_SUB_TEMA",
                        column: x => x.SUB_TEMA,
                        principalTable: "JORNADA_BD_TEMAS_SUB_TEMAS",
                        principalColumn: "ID_SUB_TEMAS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FORUM_AVALIACAO_PUBLICACAO",
                schema: "Fórum",
                columns: table => new
                {
                    ID_AVALIACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_PUBLICACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", nullable: false),
                    AVALIACAO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORUM_AVALIACAO_PUBLICACAO", x => x.ID_AVALIACAO);
                    table.ForeignKey(
                        name: "FK_FORUM_AVALIACAO_PUBLICACAO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO",
                        column: x => x.ID_PUBLICACAO,
                        principalSchema: "Fórum",
                        principalTable: "FORUM_PUBLICACAO",
                        principalColumn: "ID_PUBLICACAO");
                    table.ForeignKey(
                        name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO",
                        column: x => x.ID_PUBLICACAO,
                        principalSchema: "Fórum",
                        principalTable: "FORUM_PUBLICACAO_SOLICITACAO",
                        principalColumn: "ID_SOLICITACAO_PUBLICACAO");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_AVALIACAO_PUBLICACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                column: "ID_PUBLICACAO");

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_AVALIACAO_PUBLICACAO_MATRICULA_RESPONSAVEL",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                column: "MATRICULA_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_PUBLICACAO_MAT_SOLICITANTE",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                column: "MAT_SOLICITANTE");

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_PUBLICACAO_SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                column: "SUB_TEMA");

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_PUBLICACAO_SOLICITACAO_MAT_RESPONSAVEL",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                column: "MAT_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_PUBLICACAO_SOLICITACAO_SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                column: "SUB_TEMA");

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_RESPONSAVEL_TEMA_MATRICULA_RESPONSAVEL",
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                column: "MATRICULA_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_RESPONSAVEL_TEMA_SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                column: "SUB_TEMA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FORUM_AVALIACAO_PUBLICACAO",
                schema: "Fórum");

            migrationBuilder.DropTable(
                name: "FORUM_RESPONSAVEL_TEMA",
                schema: "Fórum");

            migrationBuilder.DropTable(
                name: "FORUM_PUBLICACAO",
                schema: "Fórum");

            migrationBuilder.DropTable(
                name: "FORUM_PUBLICACAO_SOLICITACAO",
                schema: "Fórum");
        }
    }
}
