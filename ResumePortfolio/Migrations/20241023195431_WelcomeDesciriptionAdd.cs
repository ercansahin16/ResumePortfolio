using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePortfolio.Migrations
{
    public partial class WelcomeDesciriptionAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desciription",
                table: "welcomes",
                newName: "Desciription2");

            migrationBuilder.AddColumn<string>(
                name: "Desciription1",
                table: "welcomes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desciription1",
                table: "welcomes");

            migrationBuilder.RenameColumn(
                name: "Desciription2",
                table: "welcomes",
                newName: "Desciription");
        }
    }
}
