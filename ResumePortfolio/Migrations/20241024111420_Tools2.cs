using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePortfolio.Migrations
{
    public partial class Tools2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "tools1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "tools1s",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description2",
                table: "tools1s");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "tools1s");
        }
    }
}
