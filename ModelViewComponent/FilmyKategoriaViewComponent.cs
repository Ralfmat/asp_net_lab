using asp_net_lab.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp_net_lab.ModelViewComponent
{
    public class FilmyKategoriaViewComponent : ViewComponent
    {
        FilmyContext db;

        public FilmyKategoriaViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string nazwaKategorii)
        {
            var model = db.Kategorie.Include("Filmy").Where(k => k.Nazwa.ToUpper() == nazwaKategorii.ToUpper()).Single().Filmy.ToList();

            return await Task.FromResult((IViewComponentResult)View("_FilmyKategorii", model));
        }
    }
}
