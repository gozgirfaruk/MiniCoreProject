using Microsoft.AspNetCore.Mvc;
using MiniCoreProject.DTO.Context;

namespace MiniCoreProject.Controllers
{
    public class StatisticController : Controller
    {
        MiniCoreContext context = new MiniCoreContext();
        public IActionResult Index()
        {
            ViewBag.v1=context.Mesajs.Where(x=>x.MessageID==1).Select(y=>y.NameSurname).FirstOrDefault();
            ViewBag.v2 = context.Mesajs.Count();
            ViewBag.v3 = context.Mesajs.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Mesajs.Where(x => x.IsRead == true).Count();

            ViewBag.a1 = context.Experiences.Count();
            ViewBag.a2=context.Experiences.Where(x=>x.Date== "2019-2024").Select(y=>y.Header).FirstOrDefault();
            ViewBag.a3 = context.Referances.Count();
            ViewBag.a4 = context.Skills.Count();


            ViewBag.c1= context.Abouts.Count();
            ViewBag.c2=context.Portfolios.Count();
            ViewBag.c3 = context.Portfolios.Where(x => x.Title == "Mini Portfolyo").Select(y=>y.Title).FirstOrDefault();    
            ViewBag.c4=context.ToDoLists.Count();   

            ViewBag.b1=context.ToDoLists.Where(x=>x.Status==true).Count();
            ViewBag.b2=context.ToDoLists.Where(x=>x.Status==false).Count();
            ViewBag.b3 = context.ToDoLists.Count();
            return View();
        }
    }
}
