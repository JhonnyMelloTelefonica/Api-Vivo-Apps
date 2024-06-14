using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vivo_Apps_API.Migrations.CardapioDigital
{
    /// <inheritdoc />
    public partial class AddingDataToNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxParcelasSemJuros",
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO",
                columns: new[] { "ID_PRODUTO", "Avaliacao", "Categoria", "Cor", "DATA_INCLUSÃO", "DATA_MODIFICAÇÃO", "Descrição", "Fabricante", "Imagens", "IsOferta", "MAT_INCLUSÃO", "MAT_MODIFICAÇÃO", "MaxParcelas", "MaxParcelasSemJuros", "Nome", "Valor" },
                values: new object[] { new Guid("91f76882-dd4e-4967-8e18-c5367477b5bc"), 65, 0, "Preta", new DateTime(2024, 6, 13, 18, 2, 44, 304, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 6, 13, 18, 2, 44, 304, DateTimeKind.Local).AddTicks(8674), "Apenas um Celular", "Samsung", "[]", false, 151191, 151191, 24, 10, "Samsung A54 5G", 799.0m });

            migrationBuilder.InsertData(
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO_FICHA_TECNICA",
                columns: new[] { "ID_FICHA", "Especificação", "ID_PRODUTO", "IsImportant", "IsInfoAdicional", "Valor" },
                values: new object[,]
                {
                    { new Guid("5869506b-fa33-4781-81e4-493aa7896a17"), "Memória", new Guid("91f76882-dd4e-4967-8e18-c5367477b5bc"), true, false, "128GB" },
                    { new Guid("9ab9ac7a-80d4-4794-929d-0339d9ce9662"), "Tela", new Guid("91f76882-dd4e-4967-8e18-c5367477b5bc"), true, false, "6.5 polegadas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO_FICHA_TECNICA",
                keyColumn: "ID_FICHA",
                keyValue: new Guid("5869506b-fa33-4781-81e4-493aa7896a17"));

            migrationBuilder.DeleteData(
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO_FICHA_TECNICA",
                keyColumn: "ID_FICHA",
                keyValue: new Guid("9ab9ac7a-80d4-4794-929d-0339d9ce9662"));

            migrationBuilder.DeleteData(
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO",
                keyColumn: "ID_PRODUTO",
                keyValue: new Guid("91f76882-dd4e-4967-8e18-c5367477b5bc"));

            migrationBuilder.DropColumn(
                name: "MaxParcelasSemJuros",
                schema: "Cardapio",
                table: "PRODUTOS_CARDAPIO");
        }
    }
}
