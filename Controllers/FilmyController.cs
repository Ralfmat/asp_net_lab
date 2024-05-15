using asp_net_lab.DAL;
using asp_net_lab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp_net_lab.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;
        IWebHostEnvironment hostEnvironment;

        public FilmyController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista(string nazwaKategorii)
        {
            var kategorie = db.Kategorie.Include("Filmy").Where(k => k.Nazwa.ToUpper() == nazwaKategorii.ToUpper()).Single();
            var filmy = kategorie.Filmy.ToList();
            ViewBag.Title = nazwaKategorii;
            return View(filmy);
        }

        public IActionResult Szczegoly(int idFilmu)
        {
            var kategorie = db.Kategorie.Find(db.Filmy.Find(idFilmu).KategoriaId);
            var film = db.Filmy.Find(idFilmu);

            return View(film);
        }

        [HttpGet]
        public IActionResult DodajFilm()
        {
            DodawanieFilmow dodaj = new DodawanieFilmow();
            var kategorie = db.Kategorie.ToList();
            dodaj.kategorie = kategorie;
            return View(dodaj);
        }

        [HttpPost]
        public IActionResult DodajFilm(DodawanieFilmow obj)
        {
            obj.film.DataDodania = DateTime.Now;
            var sciezkaPlakatu = Path.Combine(hostEnvironment.WebRootPath, "content");
            var nazwaPlakatu = Guid.NewGuid() + "_" + obj.plakat.FileName;
            var sciezkaDoPlakatu = Path.Combine(sciezkaPlakatu, nazwaPlakatu);
            obj.plakat.CopyTo(new FileStream(sciezkaDoPlakatu, FileMode.Create));
            obj.film.Plakat = nazwaPlakatu;
            db.Filmy.Add(obj.film);
            db.SaveChanges();
            return RedirectToAction("Szczegoly", new { idFilmu = obj.film.Id });
        }
    }
}
