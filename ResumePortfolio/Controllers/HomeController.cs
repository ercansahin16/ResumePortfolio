using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;
using ResumePortfolio.DataAccessLayer.Entitiy;

namespace ResumePortfolio.Controllers
{
   public class HomeController : Controller
   {
      ResumePortfoliocontext _context=new ResumePortfoliocontext();
      public IActionResult Index()
      {
        
         return View();
      }
      public IActionResult Welcome()
      {
        
         return View();
      }
      public IActionResult About()
      {
         return View();
      }
      public IActionResult Services() 
      {
         return View();
      }
      public IActionResult Portfolio()
      {
         var values = _context.portfolios?.ToList();
         return View(values);
      }

      public IActionResult Team()
      {
         var values=_context.teams?.ToList();
         return View(values);
      }
      public IActionResult Blog()
      {
         return View();
      }
      public IActionResult Contact(ContactRight contactRight)
      {
         _context.contactRights.Add(contactRight);
         _context.SaveChanges();
         return View();
      }
   
   }
}
