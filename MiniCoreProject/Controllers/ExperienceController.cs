using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;
using MiniCoreProject.DTO.Entities;

namespace MiniCoreProject.Controllers
{
	public class ExperienceController : Controller
	{
		MiniCoreContext context = new MiniCoreContext();
		public IActionResult ExpList()
		{
			var values = context.Experiences.ToList();	
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiences.Add(experience);
			context.SaveChanges();
			return RedirectToAction("ExpList");
		}

		[HttpGet]
		public IActionResult UpdateExperience(int id) 
		{
			var values = context.Experiences.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			context.Experiences.Update(experience);
			context.SaveChanges();
			return RedirectToAction("ExpList");
		}

		public IActionResult DeleteExperience(int id)
		{
			var values = context.Experiences.Find(id);
			context.Experiences.Remove(values);
			context.SaveChanges();
			return RedirectToAction("ExpList");
		}
	}
}
