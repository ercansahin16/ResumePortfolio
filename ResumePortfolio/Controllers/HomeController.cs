using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.Controllers
{
   public class HomeController : Controller
   {
      ResumePortfoliocontext context=new ResumePortfoliocontext();
      public IActionResult Index()
      {
        
         return View();
      }
      public IActionResult Welcome()
      {
         var values=context.welcomes.ToList();
         return View();
      }
   }
}
