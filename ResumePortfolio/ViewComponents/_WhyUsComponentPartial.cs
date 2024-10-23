using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class _WhyUsComponentPartial : ViewComponent
   {
      ResumePortfoliocontext _context=new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
         ViewBag.SubTitle = _context.whyUs.Select(x=>x.SubTitle).FirstOrDefault();
         ViewBag.title=_context.whyUs.Select(x=>x.Title).FirstOrDefault();
         ViewBag.Desciription1 = _context.whyUs.Select(x=>x.Desciription1).FirstOrDefault();
         ViewBag.Desciription2 = _context.whyUs.Select(x=>x.Desciription2).FirstOrDefault();
         ViewBag.Number1 = _context.whyUs.Select(x=>x.Number1).FirstOrDefault();
         ViewBag.Number2 = _context.whyUs.Select(x=>x.Number2).FirstOrDefault();
         ViewBag.Number3 = _context.whyUs.Select(x=>x.Number3).FirstOrDefault();
         return View();
      }
   }
}
