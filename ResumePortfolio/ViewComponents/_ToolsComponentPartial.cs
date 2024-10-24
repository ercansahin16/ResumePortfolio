﻿using Microsoft.AspNetCore.Mvc;
using ResumePortfolio.DataAccessLayer.Context;

namespace ResumePortfolio.ViewComponents
{
   public class _ToolsComponentPartial:ViewComponent
   {
      ResumePortfoliocontext _context = new ResumePortfoliocontext();
      public IViewComponentResult Invoke()
      {
         var values = _context.tools1s.ToList();
         return View(values);
      }
   }
}
