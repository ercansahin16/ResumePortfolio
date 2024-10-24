using Microsoft.AspNetCore.Mvc;

namespace ResumePortfolio.ViewComponents
{
   public class _LayoutHeadComponentPartial:ViewComponent
   {
      public IViewComponentResult Invoke()
      {
         return View();
      }
   }
}
