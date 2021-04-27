using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionRestau.Migrations
{
    public partial class serveur_addresse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adresse",
                table: "Serveurs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adresse",
                table: "Serveurs");
        }
    }
}
