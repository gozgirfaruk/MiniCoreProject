using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;


namespace MiniCoreProject.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
       MiniCoreContext context = new MiniCoreContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
             return View(values); 
        }
    }
}
