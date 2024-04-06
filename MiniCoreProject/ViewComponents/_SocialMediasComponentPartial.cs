using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.ViewComponents
{
    public class _SocialMediasComponentPartial : ViewComponent
    {
        MiniCoreContext context = new MiniCoreContext();
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
}
