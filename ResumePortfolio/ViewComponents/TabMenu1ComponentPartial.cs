using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
  
   public class TabMenu1ComponentPartial : ViewComponent
   {
  ResumePortfoliocontext _context=new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
      
         var values=_context.tabMenu1s.ToList();
         return View(values);
      }
   }
}
