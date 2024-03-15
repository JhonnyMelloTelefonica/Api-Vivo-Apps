using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class DemandasContextMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Demandas");

            migrationBuilder.CreateTable(
                name: "DEMANDA_CHAMADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FILA_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: true),
                    MATRICULA_SOLICITANTE = table.Column<int>(type: "int", unicode: false, nullable: false),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_FECHAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRIORIDADE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_CHAMADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                        column: x => x.MATRICULA_SOLICITANTE,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_DEMANDA_SUB_FILA_ID_FILA_CHAMADO",
                        column: x => x.ID_FILA_CHAMADO,
                        principalSchema: "dbo",
                        principalTable: "DEMANDA_SUB_FILA",
                        principalColumn: "ID_SUB_FILA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_CAMPOS_CHAMADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    VALOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_CAMPOS_CHAMADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CAMPOS_CHAMADO_DEMANDA_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_CHAMADO_RESPOSTA",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RESPOSTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    DATA_RESPOSTA = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_CHAMADO_RESPOSTA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_RESPOSTA_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_RESPOSTA_DEMANDA_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_HISTORICO_PRIORIDADE",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    MAT_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    PRIORIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_HISTORICO_PRIORIDADE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_HISTORICO_PRIORIDADE_ACESSOS_MOBILE_MAT_RESPONSAVEL",
                        column: x => x.MAT_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DEMANDA_HISTORICO_PRIORIDADE_DEMANDA_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_ARQUIVOS_RESPOSTA",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_RESPOSTA = table.Column<int>(type: "int", nullable: false),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_ARQUIVOS_RESPOSTA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_ARQUIVOS_RESPOSTA_DEMANDA_CHAMADO_RESPOSTA_ID_RESPOSTA",
                        column: x => x.ID_RESPOSTA,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO_RESPOSTA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_STATUS_CHAMADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    ID_RESPOSTA = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MAT_QUEM_REDIRECIONOU = table.Column<int>(type: "int", unicode: false, nullable: true),
                    MAT_DESTINATARIO = table.Column<int>(type: "int", unicode: false, nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_STATUS_CHAMADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_ACESSOS_MOBILE_MAT_DESTINARARIO",
                        column: x => x.MAT_DESTINATARIO,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_ACESSOS_MOBILE_MAT_QUEM_REDIRECIONOU",
                        column: x => x.MAT_QUEM_REDIRECIONOU,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_CHAMADO_RESPOSTA_ID_RESPOSTA",
                        column: x => x.ID_RESPOSTA,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO_RESPOSTA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_ARQUIVOS_RESPOSTA_ID_RESPOSTA",
                schema: "Demandas",
                table: "DEMANDA_ARQUIVOS_RESPOSTA",
                column: "ID_RESPOSTA");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CAMPOS_CHAMADO_ID_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CAMPOS_CHAMADO",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_ID_FILA_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                column: "ID_FILA_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                column: "MATRICULA_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                column: "MATRICULA_SOLICITANTE");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_RESPOSTA_ID_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_RESPOSTA_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                column: "MATRICULA_RESPONSAVEL");

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

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_ID_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_ID_RESPOSTA",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "ID_RESPOSTA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_MAT_DESTINARARIO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "MAT_DESTINATARIO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_MAT_QUEM_REDIRECIONOU",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "MAT_QUEM_REDIRECIONOU");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEMANDA_ARQUIVOS_RESPOSTA",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_CAMPOS_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_HISTORICO_PRIORIDADE",
                schema: "Demandas");


            migrationBuilder.DropTable(
                name: "DEMANDA_STATUS_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_CHAMADO_RESPOSTA",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_CHAMADO",
                schema: "Demandas");

        }
    }
}
