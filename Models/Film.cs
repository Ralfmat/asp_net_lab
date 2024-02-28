using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_net_lab.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Podaj tytul")]
        public string Tytul { get; set; }
        [Required(ErrorMessage = "Podaj rezysera")]
        public string Rezyser { get; set; }
        [StringLength(500)]
        [Required(ErrorMessage = "Podaj opis")]
        public string Opis { get; set; }
        [Required(ErrorMessage = "Podaj cene")]
        public float Cena { get; set; }
        [Required(ErrorMessage = "Podaj date dodania")]
        public DateTime DataDodania { get; set; }

        [ForeignKey("Kategoria")]
        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
