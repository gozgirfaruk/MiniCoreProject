using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.Controllers
{
    public class StatisticController : Controller
    {
        MiniCoreContext context = new MiniCoreContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Mesajs.Count();
            ViewBag.v3 = context.Mesajs.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Mesajs.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
