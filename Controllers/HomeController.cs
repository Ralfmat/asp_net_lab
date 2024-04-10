using asp_net_lab.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp_net_lab.Controllers
{
    public class HomeController : Controller
    {
        FilmyContext db;

        public HomeController(FilmyContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            var kategorie = db.C.ToList();
            return View(kategorie);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }
    }
}
