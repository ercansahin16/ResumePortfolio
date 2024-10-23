﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResumePortfolio.DataAccessLayer.Context;

#nullable disable

namespace ResumePortfolio.Migrations
{
    [DbContext(typeof(ResumePortfoliocontext))]
    [Migration("20241023195431_WelcomeDesciriptionAdd")]
    partial class WelcomeDesciriptionAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Title")
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
