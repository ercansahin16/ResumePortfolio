using Microsoft.AspNetCore.Mvc;

namespace ResumePortfolio.ViewComponents
{
   public class _LayoutScriptsComponentPartial:ViewComponent
   {
      public IViewComponentResult Invoke()
         { return View(); }
   }
}
