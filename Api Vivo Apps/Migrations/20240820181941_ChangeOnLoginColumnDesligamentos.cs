using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOnLoginColumnDesligamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
