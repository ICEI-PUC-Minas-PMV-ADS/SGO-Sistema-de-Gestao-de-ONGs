using Microsoft.EntityFrameworkCore.Migrations;

namespace proj_ong_backend.Migrations
{
    public partial class M00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doadores",
                columns: table => new
                {
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doadores");
        }
    }
}
