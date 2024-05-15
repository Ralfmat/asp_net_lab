using asp_net_lab.DAL;
using asp_net_lab.Helpers;
using asp_net_lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_lab.Controllers
{
    public class KoszykController : Controller

    {

        FilmyContext db;

        public KoszykController(FilmyContext db)

        {

            this.db = db;

        }

        public IActionResult Index()

        {

            var koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, "placeholder");

            if (koszyk != null)

            {

                ViewBag.CalaSuma = koszyk.Sum(f => f.Film.Cena * f.Ilosc);

            }

            else

            {

                ViewBag.CalaSuma = 0;

            }

            return View(koszyk);

        }

        [Route("Kup/{id}")]

        public IActionResult Kup(int id)

        {

            var film = db.Filmy.Find(id);

            if (SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, "placeholder") == null)

            {

                List<ElementKoszyka> koszyk = new List<ElementKoszyka>

                {

                new ElementKoszyka { Film = film, Ilosc = 1, Wartosc = film.Cena }

                };

                SessionHelper.SetObjectAsJson(HttpContext.Session, "placeholder", koszyk);

            }

            else

            {

                List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, "placeholder");

                var index = koszyk.FindIndex(i => i.Film.Id == id);

                if (index != -1)

                {

                    koszyk[index].Ilosc++;

                }

                else

                {

                    koszyk.Add(new ElementKoszyka { Film = film, Ilosc = 1, Wartosc = film.Cena });

                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, "placeholder", koszyk);

            }

            return RedirectToAction("Index");

        }

        public IActionResult UsunZKoszyk(int id)
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, "placeholder");

            int index = koszyk.FindIndex(i=>i.Film.Id==id);
            koszyk.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "placeholder", koszyk);
            return RedirectToAction("Index");
        }

        public int PobierzIloscRezczyWKoszyku()
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, "placeholder");
            return koszyk.Sum(i => i.Ilosc);
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.CalaSuma = PobierzIloscRezczyWKoszyku();
            return await Task.FromResult((IViewComponentResult)View("_Menu", db.Kategorie.ToList()));
        }
    }
}
