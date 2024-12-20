﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResumePortfolio.DataAccessLayer.Context;

#nullable disable

namespace ResumePortfolio.Migrations
{
    [DbContext(typeof(ResumePortfoliocontext))]
    partial class ResumePortfoliocontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.BlogPosts", b =>
                {
                    b.Property<int>("BlogPostsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogPostsID"), 1L, 1);

                    b.Property<string>("DateTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrefTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("catTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogPostsID");

                    b.ToTable("blogPosts");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.ContactLeft", b =>
                {
                    b.Property<int>("ContactLeftID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactLeftID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactLeftID");

                    b.ToTable("contactLefts");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.ContactRight", b =>
                {
                    b.Property<int>("ContactRightID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactRightID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactRightID");

                    b.ToTable("contactRights");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginID");

                    b.ToTable("logins");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.OurMission", b =>
                {
                    b.Property<int>("OurMissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OurMissionID"), 1L, 1);

                    b.Property<string>("OurMissionDescription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurMissionDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurMissionImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OurMissionID");

                    b.ToTable("ourMissions");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.Portfolio", b =>
                {
                    b.Property<int>("PortfolioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PortfolioID"), 1L, 1);

                    b.Property<string>("Class1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PortfolioID");

                    b.ToTable("portfolios");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.Reference", b =>
                {
                    b.Property<int>("ReferenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReferenceID"), 1L, 1);

                    b.Property<string>("Blockquote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferenceID");

                    b.ToTable("references");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.TabMenu1", b =>
                {
                    b.Property<int>("TabMenu1ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TabMenu1ID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TabMenu1ID");

                    b.ToTable("tabMenu1s");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.TabMenu2", b =>
                {
                    b.Property<int>("TabMenu2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TabMenu2ID"), 1L, 1);

                    b.Property<string>("Description1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TabMenu2ID");

                    b.ToTable("tabMenu2s");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamID"), 1L, 1);

                    b.Property<string>("BtnUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desciription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.ToTable("teams");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.Tools1", b =>
                {
                    b.Property<int>("Tools1ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tools1ID"), 1L, 1);

                    b.Property<string>("Delay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İcon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tools1ID");

                    b.ToTable("tools1s");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.Welcome", b =>
                {
                    b.Property<int>("WelcomeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WelcomeID"), 1L, 1);

                    b.Property<string>("Desciription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desciription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WelcomeID");

                    b.ToTable("welcomes");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.WelcomeImage", b =>
                {
                    b.Property<int>("WelcomeImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WelcomeImageID"), 1L, 1);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WelcomeImageID");

                    b.ToTable("welcomeImage");
                });

            modelBuilder.Entity("ResumePortfolio.DataAccessLayer.Entitiy.WhyUs", b =>
                {
                    b.Property<int>("WhyUsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WhyUsID"), 1L, 1);

                    b.Property<string>("Desciription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desciription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number1")
                        .HasColumnType("int");

                    b.Property<int>("Number2")
                        .HasColumnType("int");

                    b.Property<int>("Number3")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WhyUsID");

                    b.ToTable("whyUs");
                });
#pragma warning restore 612, 618
        }
    }
}
