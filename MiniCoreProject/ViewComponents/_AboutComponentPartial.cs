using Microsoft.AspNetCore.Mvc;

namespace MiniCoreProject.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
