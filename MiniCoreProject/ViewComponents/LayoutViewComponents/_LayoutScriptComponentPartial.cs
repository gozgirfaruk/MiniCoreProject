using Microsoft.AspNetCore.Mvc;

namespace MiniCoreProject.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
