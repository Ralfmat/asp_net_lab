using System.ComponentModel.DataAnnotations;

namespace asp_net_lab.Models
{
    public class Kategoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Podaj nazwe")]
        public string Nazwa { get; set; }
        [StringLength(500)]
        [Required(ErrorMessage = "Podaj opis")]
        public string Opis { get; set; }

        public ICollection<Film> Filmy { get; set; }
    }
}
