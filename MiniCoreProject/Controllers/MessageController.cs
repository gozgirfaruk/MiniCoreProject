using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.Controllers
{
	public class MessageController : Controller
	{
		MiniCoreContext context = new MiniCoreContext();
		public IActionResult Inbox()
		{
			var values = context.Mesajs.ToList();
			return View(values);
		}

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = context.Mesajs.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = context.Mesajs.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = context.Mesajs.Find(id);
            context.Mesajs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult MessageDetail(int id)
        {
            var value = context.Mesajs.Find(id);
            return View(value);
        }
    }
}
