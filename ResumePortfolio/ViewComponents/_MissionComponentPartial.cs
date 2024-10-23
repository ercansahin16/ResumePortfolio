using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class _MissionComponentPartial:ViewComponent
   {
      ResumePortfoliocontext _context=new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
         var values=_context.ourMissions.ToList();
         return View(values);
      }
   }
}
