using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MiniCoreContext context = new MiniCoreContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Referances.ToList(); 
            return View(values);
        }
    }
}
