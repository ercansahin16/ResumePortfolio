using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class _WelcomeComponentPartial : ViewComponent
   {
      ResumePortfoliocontext context=new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
         var values=context.welcomes.ToList();
         ViewData["message"] = "İndirdiğiniz için Teşekkür Ederim :)";
         return View(values);
      }
   }
}
