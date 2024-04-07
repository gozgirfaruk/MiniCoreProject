using Microsoft.AspNetCore.Mvc;

namespace MiniCoreProject.Controllers
{
	public class ExperienceController : Controller
	{
		public IActionResult ExpList()
		{
			return View();
		}
	}
}
