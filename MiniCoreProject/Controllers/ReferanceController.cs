using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;
using MiniCoreProject.DTO.Entities;

namespace MiniCoreProject.Controllers
{
    public class ReferanceController : Controller
    {
        MiniCoreContext context = new MiniCoreContext();
        public IActionResult Index()
        {
            var values = context.Referances.ToList();
            return View(values);
        }

        public IActionResult ReferanceDelete(int id)
        {
			var values = context.Referances.Find(id);
			context.Referances.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Referance referance)
        {
            context.Referances.Add(referance);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateRef(int id)
        {
            var values = context.Referances.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateRef(Referance referance)
        {
            context.Referances.Update(referance);
            context.SaveChanges();  
            return RedirectToAction("Index");
        }

	}
}
