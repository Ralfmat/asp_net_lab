namespace asp_net_lab.Models
{
    public class DodawanieFilmow
    {
        public Film film { get; set; }
        public IFormFile plakat { get; set; }
        public List<Kategoria> kategorie { get; set; }
    }
}
