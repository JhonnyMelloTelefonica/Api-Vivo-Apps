using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations.CardapioDigital
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Cardapio");

            migrationBuilder.CreateTable(
                name: "PRODUTOS_CARDAPIO",
                schema: "Cardapio",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Descrição = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: true),
                    Avaliacao = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOferta = table.Column<bool>(type: "bit", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxParcelas = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA_INCLUSÃO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATA_MODIFICAÇÃO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MAT_INCLUSÃO = table.Column<int>(type: "int", nullable: false),
                    MAT_MODIFICAÇÃO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS_CARDAPIO", x => x.ID_PRODUTO);
                    table.ForeignKey(
                        name: "FK_PRODUTOS_CARDAPIO_ACESSOS_MOBILE_MAT_INCLUSÃO",
                        column: x => x.MAT_INCLUSÃO,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                    table.ForeignKey(
                        name: "FK_PRODUTOS_CARDAPIO_ACESSOS_MOBILE_MAT_MODIFICAÇÃO",
                        column: x => x.MAT_MODIFICAÇÃO,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS_CARDAPIO_FICHA_TECNICA",
                schema: "Cardapio",
                columns: table => new
                {
                    ID_FICHA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_PRODUTO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Especificação = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsImportant = table.Column<bool>(type: "bit", nullable: false),
                    IsInfoAdicional = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS_CARDAPIO_FICHA_TECNICA", x => x.ID_FICHA);
                    table.ForeignKey(
                        name: "FK_PRODUTOS_CARDAPIO_FICHA_TECNICA_PRODUTOS_CARDAPIO_ID_PRODUTO",
                        column: x => x.ID_PRODUTO,
                        principalSchema: "Cardapio",
                        principalTable: "PRODUTOS_CARDAPIO",
                        principalColumn: "ID_PRODUTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CARDAPIO_MAT_INCLUSÃO",
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO",
                column: "MAT_INCLUSÃO");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CARDAPIO_MAT_MODIFICAÇÃO",
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO",
                column: "MAT_MODIFICAÇÃO");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CARDAPIO_FICHA_TECNICA_ID_PRODUTO",
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO_FICHA_TECNICA",
                column: "ID_PRODUTO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTOS_CARDAPIO_FICHA_TECNICA",
                schema: "Cardapio");

            migrationBuilder.DropTable(
                name: "PRODUTOS_CARDAPIO",
                schema: "Cardapio");
        }
    }
}
