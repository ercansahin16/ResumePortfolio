using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePortfolio.Migrations
{
    public partial class addWelcomeImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "welcomes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "welcomes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
