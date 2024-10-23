using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class _WelcomeImageComponentPartial:ViewComponent
   {
     ResumePortfoliocontext _context=new ResumePortfoliocontext();

      public IViewComponentResult Invoke()
      {
         var values=_context.welcomeImage.ToList();
         return View(values);
      }
   }
}
