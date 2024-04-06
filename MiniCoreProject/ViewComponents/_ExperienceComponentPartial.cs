using Microsoft.AspNetCore.Mvc;

namespace MiniCoreProject.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
