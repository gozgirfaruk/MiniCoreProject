using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MiniCoreContext context = new MiniCoreContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values); 
        }
    }
}
