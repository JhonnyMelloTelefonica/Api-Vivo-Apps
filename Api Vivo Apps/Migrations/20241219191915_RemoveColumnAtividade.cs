using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColumnAtividade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Atividade",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Atividade",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
