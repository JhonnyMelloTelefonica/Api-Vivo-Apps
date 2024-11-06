using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class RelacaoAcessosUF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "DEMANDA_ACESSO_RESPONSAVEL_UF",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_ACESSO_RESPONSAVEL_UF", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_ACESSO_RESPONSAVEL_UF_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_ACESSO_RESPONSAVEL_UF_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSO_RESPONSAVEL_UF",
                column: "MATRICULA_RESPONSAVEL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEMANDA_ACESSO_RESPONSAVEL_UF",
                schema: "Demandas");
        }
    }
}
