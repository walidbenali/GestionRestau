using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionRestau.Migrations
{
    public partial class serveur_nom_unique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Serveurs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Serveurs_Nom",
                table: "Serveurs",
                column: "Nom",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Serveurs_Nom",
                table: "Serveurs");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Serveurs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
