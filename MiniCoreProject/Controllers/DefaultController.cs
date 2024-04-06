using Microsoft.AspNetCore.Mvc;

namespace MiniCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
