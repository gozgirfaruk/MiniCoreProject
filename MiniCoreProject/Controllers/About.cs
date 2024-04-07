using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;
using MiniCoreProject.DTO.Entities;

namespace MiniCoreProject.Controllers
{
    public class About : Controller
    {
        MiniCoreContext context = new MiniCoreContext();
        public IActionResult AboutList()
        {
            var values = context.Abouts.ToList();   
            return View(values);
        }

    }
}
