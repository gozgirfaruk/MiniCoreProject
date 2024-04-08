using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;
using MiniCoreProject.DTO.Entities;

namespace MiniCoreProject.Controllers
{
	public class FeatureController : Controller
	{
		MiniCoreContext context = new MiniCoreContext();
		public IActionResult FeatureList()
		{
			var values = context.Features.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult FeatureUpdate(int id)
		{
			var values = context.Features.Find(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult FeatureUpdate(Feature feature)
		{
			context.Update(feature);
			context.SaveChanges();
			return RedirectToAction("FeatureList");
		}
	}
}
