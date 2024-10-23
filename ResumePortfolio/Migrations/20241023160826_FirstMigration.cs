using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePortfolio.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogPosts",
                columns: table => new
                {
                    BlogPostsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    catTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HrefTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogPosts", x => x.BlogPostsID);
                });

            migrationBuilder.CreateTable(
                name: "ourMissions",
                columns: table => new
                {
                    OurMissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurMissionDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurMissionDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurMissionImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ourMissions", x => x.OurMissionID);
                });

            migrationBuilder.CreateTable(
                name: "references",
                columns: table => new
                {
                    ReferenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blockquote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_references", x => x.ReferenceID);
                });

            migrationBuilder.CreateTable(
                name: "tabMenu1s",
                columns: table => new
                {
                    TabMenu1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabMenu1s", x => x.TabMenu1ID);
                });

            migrationBuilder.CreateTable(
                name: "tabMenu2s",
                columns: table => new
                {
                    TabMenu2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabMenu2s", x => x.TabMenu2ID);
                });

            migrationBuilder.CreateTable(
                name: "tools1s",
                columns: table => new
                {
                    Tools1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tools1s", x => x.Tools1ID);
                });

            migrationBuilder.CreateTable(
                name: "welcomes",
                columns: table => new
                {
                    WelcomeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desciription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_welcomes", x => x.WelcomeID);
                });

            migrationBuilder.CreateTable(
                name: "whyUs",
                columns: table => new
                {
                    WhyUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desciription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desciription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number1 = table.Column<int>(type: "int", nullable: false),
                    Number2 = table.Column<int>(type: "int", nullable: false),
                    Number3 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_whyUs", x => x.WhyUsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogPosts");

            migrationBuilder.DropTable(
                name: "ourMissions");

            migrationBuilder.DropTable(
                name: "references");

            migrationBuilder.DropTable(
                name: "tabMenu1s");

            migrationBuilder.DropTable(
                name: "tabMenu2s");

            migrationBuilder.DropTable(
                name: "tools1s");

            migrationBuilder.DropTable(
                name: "welcomes");

            migrationBuilder.DropTable(
                name: "whyUs");
        }
    }
}
