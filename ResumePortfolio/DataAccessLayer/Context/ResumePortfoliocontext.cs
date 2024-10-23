using Microsoft.EntityFrameworkCore;
using ResumePortfolio.DataAccessLayer.Entitiy;

namespace ResumePortfolio.DataAccessLayer.Context
{
   public class ResumePortfoliocontext:DbContext
   {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer("Server=LENOVA20VE\\SQLEXPRESS;initial Catalog=ResumeProtfolio;integrated Security=true;");
      }
        public DbSet<BlogPosts>? blogPosts { get; set; }
        public DbSet<OurMission>? ourMissions { get; set; }
        public DbSet<Reference>? references { get; set; }
        public DbSet<TabMenu1>? tabMenu1s { get; set; }
        public DbSet<TabMenu2>? tabMenu2s { get; set; }
        public DbSet<Tools1>? tools1s { get; set; }
        public DbSet<Welcome>? welcomes { get; set; }
        public DbSet<WhyUs>? whyUs { get; set; }
      public DbSet<WelcomeImage>? welcomeImage { get; set; }

    }
}
