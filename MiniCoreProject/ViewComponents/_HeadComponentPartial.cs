using Microsoft.AspNetCore.Mvc;

namespace MiniCoreProject.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
