using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;
using ResumePortfolio.DataAccessLayer.Entitiy;

namespace ResumePortfolio.Controllers
{
   public class AdminController : Controller
   {
      ResumePortfoliocontext _context=new ResumePortfoliocontext();
      public IActionResult Index()
      {
         return View();
      }

      [HttpGet]
      public IActionResult AdminLogin()
      {
         return View();
      }
      [HttpPost]
      public IActionResult AdminLogin( Login login)
      {
       var user= _context.logins.FirstOrDefault(x=>x.Email==login.Email && x.password==login.password);
         if(user!=null)
         {
            return RedirectToAction("Index");
         }
         {
            TempData["ErrorMessage"] = "Geçersiz kullanıcı adı veya şifre.";
         }
        
         return View();
      }
      public IActionResult BlogPost()
      {
        var values= _context.blogPosts.ToList();
         return View(values);
      }
   }
}
