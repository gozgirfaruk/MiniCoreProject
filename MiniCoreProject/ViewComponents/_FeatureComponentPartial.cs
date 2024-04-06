using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    { 
        MiniCoreContext context=new MiniCoreContext();
        public IViewComponentResult Invoke()
        {
            var values =context.Features.ToList();
            return View(values);
        }
    }
}
