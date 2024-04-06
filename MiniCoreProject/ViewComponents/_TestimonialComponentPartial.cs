using Microsoft.AspNetCore.Mvc;

namespace MiniCoreProject.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
