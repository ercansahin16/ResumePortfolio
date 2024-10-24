using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class _ReferenceComponentPartial:ViewComponent
   {
      ResumePortfoliocontext _context=new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
         var values=_context.references.ToList();
         return View(values);
      }
   }
}
