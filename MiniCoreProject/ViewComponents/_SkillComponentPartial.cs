using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MiniCoreContext context = new MiniCoreContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
