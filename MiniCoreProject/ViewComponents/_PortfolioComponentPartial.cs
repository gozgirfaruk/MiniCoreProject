using Microsoft.AspNetCore.Mvc;

namespace MiniCoreProject.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View(); 
        }
    }
}
