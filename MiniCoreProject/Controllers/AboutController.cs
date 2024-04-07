using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;
using MiniCoreProject.DTO.Entities;

namespace MiniCoreProject.Controllers
{
    public class AboutController : Controller
    {
        MiniCoreContext context = new MiniCoreContext();
        public IActionResult AboutList()
        {
            var values = context.Abouts.ToList();   
            return View(values);
        }

        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var values = context.Abouts.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }


	}
}
