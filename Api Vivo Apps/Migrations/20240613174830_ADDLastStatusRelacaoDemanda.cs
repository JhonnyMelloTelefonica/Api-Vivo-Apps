using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class ADDLastStatusRelacaoDemanda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastStatus",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastStatus",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO");
        }
    }
}
