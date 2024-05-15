using asp_net_lab.Controllers;
using asp_net_lab.Helpers;
using asp_net_lab.Models;

namespace asp_net_lab.Managers
{
    public class KoszykManager
    {
        public static int UsunZKoszyk(ISession session, int id)
        {
            var koszyk = PobierzKoszyk(session);
            var usuwamyFilm = koszyk.Find(i => i.film.Id == id);
            int ilosc = 0;
            if (usuwamyFilm != null)
            {
                return ilosc
            }

            if(usuwamyFilm.Ilosc > 1)
            {
                usuwamyFilm.Ilosc--;
                ilosc = usuwamyFilm.Ilosc;
            }
            else
            {
                koszyk.Remove(usuwamyFilm);
            }

            session.SetObjectAsJson("placeholder", koszyk);
        }

        public static object 
    }
}
