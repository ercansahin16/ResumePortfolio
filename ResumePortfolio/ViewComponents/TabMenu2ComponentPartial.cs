using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class TabMenu2ComponentPartial:ViewComponent
   {
      ResumePortfoliocontext _context = new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
        
         var values = _context.tabMenu2s.ToList();
         return View(values);
      }
   }
}
