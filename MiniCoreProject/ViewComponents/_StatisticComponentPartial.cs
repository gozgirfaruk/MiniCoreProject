using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        MiniCoreContext context = new MiniCoreContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.first = context.Referances.Count();
            ViewBag.second = context.Portfolios.Count();
            ViewBag.third=context.Skills.Count();
            ViewBag.fourth=context.Messages.Count();
            return View();
        }
    }
}
