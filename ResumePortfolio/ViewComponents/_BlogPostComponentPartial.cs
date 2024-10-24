using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class _BlogPostComponentPartial:ViewComponent
   {
      ResumePortfoliocontext _context=new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
         var values=_context.blogPosts.ToList();
         return View(values);
      }
   }
}
