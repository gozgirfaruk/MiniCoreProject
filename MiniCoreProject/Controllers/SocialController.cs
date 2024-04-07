using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;
using MiniCoreProject.DTO.Entities;

namespace MiniCoreProject.Controllers
{
    public class SocialController : Controller
    {
        MiniCoreContext context=new MiniCoreContext();
        public IActionResult SocialList()
        {
            var values = context.SocialMedias.ToList(); 
            return View(values);
        }

        public IActionResult SocialDelete(int id)
        {
            var values = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SocialList");
        }
        [HttpGet]
        public IActionResult CreateSocial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatedSocial(SocialMedia media)
        {
            context.SocialMedias.Add(media);
            context.SaveChanges();
            return RedirectToAction("SocialList");

        }
        [HttpGet]
        public IActionResult EditSocial(int id)
        {
            var values = context.SocialMedias.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult EditSocial(SocialMedia media)
        {
            context.SocialMedias.Update(media);
            context.SaveChanges();
            return RedirectToAction("SocialList");
        }

	}
}
