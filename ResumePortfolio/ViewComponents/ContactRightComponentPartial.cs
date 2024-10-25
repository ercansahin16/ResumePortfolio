using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;
using ResumePortfolio.DataAccessLayer.Entitiy;

namespace ResumePortfolio.ViewComponents
{
   public class ContactRightComponentPartial : ViewComponent
   {
      ResumePortfoliocontext _context = new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
    

         return View();

      }

   }
}
