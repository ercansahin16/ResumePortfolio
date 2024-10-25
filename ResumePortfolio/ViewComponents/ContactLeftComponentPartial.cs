using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class ContactLeftComponentPartial:ViewComponent
   {
      ResumePortfoliocontext _context=new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      { 
         var values =_context.contactLefts.ToList();
         return View(values); 
      
      }
   }
}
