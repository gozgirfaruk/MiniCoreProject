using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MiniCoreContext context = new MiniCoreContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.header = context.Abouts.Select(x=>x.Header).FirstOrDefault();
            ViewBag.sub=context.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.description=context.Abouts.Select(x=>x.Description).FirstOrDefault();   
            return View();
        }
    }
}
