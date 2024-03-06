using asp_net_lab.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_net_lab.DAL
{
    public class FilmyContext : DbContext
    {
        DbSet<Film> Filmy { get; set; }
        DbSet<Kategoria> Kategorie { get; set; }

        public FilmyContext(DbContextOptions<FilmyContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(
                new Film()
                {
                    Id = 1,
                    Tytul = "Buntownik z wyboru",
                    Rezyser = "Gus Van Sant",
                    Opis = "amerykański dramat obyczajowy z 1997 roku w reżyserii Gusa Van Santa, nagrodzony dwoma Oscarami: za najlepszy scenariusz stworzony przez Bena Afflecka i Matta Damona i najlepszą rolę drugoplanową – psychoterapeuty Seana Maguire'a, w którego wcielił się Robin Williams.",
                    Cena = 39.90F,
                    DataDodania = new DateTime(2024,3,6),
                    KategoriaId = 1,
                },
                new Film 
                {
                    Id = 2,
                    Tytul = "Pulp Fiction",
                    Rezyser = "Quentin Tarantino",
                    Opis = "amerykański film kryminalny z 1994 roku w reżyserii Quentina Tarantino, oparty na scenariuszu Tarantino i Rogera Avary’ego. Film, w którym występują John Travolta, Samuel L. Jackson, Bruce Willis, Tim Roth, Ving Rhames i Uma Thurman, opowiada kilka epizodów rozgrywających się w przestępczym Los Angeles.",
                    Cena = 24.90F,
                    DataDodania = new DateTime(2024, 3, 6),
                    KategoriaId = 6,
                },
                new Film
                {
                    Id = 3,
                    Tytul = "Chłopiec i Czapla",
                    Rezyser = "Hayao Miyazaki",
                    Opis = "apoński film animowany w reżyserii Hayao Miyazakiego, wyprodukowany przez Studio Ghibli. Jego japońska premiera miała miejsce 14 lipca 2023 r. Polska premiera kinowa miała miejsce 19 stycznia 2024 r.",
                    Cena = 40.50F,
                    DataDodania = new DateTime(2024, 3, 6),
                    KategoriaId = 5,
                },
                new Film
                {
                    Id = 4,
                    Tytul = "Diuna 1",
                    Rezyser = "Denis Villeneuve",
                    Opis = "amerykańsko-kanadyjski film science fiction z 2021 roku w reżyserii Denisa Villeneuve’a, zrealizowany na podstawie powieści Franka Herberta o tym samym tytule, adaptujący jej pierwszą połowę; zdobył sześć Oscarów. Film zadebiutował 3 września 2021 w ramach 78. MFF w Wenecji.",
                    Cena = 59.90F,
                    DataDodania = new DateTime(2024, 3, 6),
                    KategoriaId = 2,
                },
                new Film
                {
                    Id = 5,
                    Tytul = "Diuna 2",
                    Rezyser = "Denis Villeneuve",
                    Opis = "amerykańsko-kanadyjski film science fiction z 2024 roku w reżyserii Denisa Villeneuve’a. Druga część ekranizacji powieści Franka Herberta o tym samym tytule, bezpośrednia kontynuacja filmu z 2021 roku. Film zadebiutował 6 lutego 2024 w Auditorio Nacional w mieście Meksyk.",
                    Cena = 64.90F,
                    DataDodania = new DateTime(2024, 3, 6),
                    KategoriaId = 2,
                },
                new Film
                {
                    Id = 6,
                    Tytul = "Ojciec chrzestny",
                    Rezyser = "Francis Ford Coppola",
                    Opis = "amerykański film gangsterski z 1972 roku w reżyserii Francisa Forda Coppoli, z Marlonem Brando i Alem Pacino w rolach głównych. Adaptacja powieści Mario Puzo o tym samym tytule. Film opowiada historię rodziny Corleone, potężnego klanu mafijnego z Nowego Jorku, w latach 1945–1955.",
                    Cena = 29.90F,
                    DataDodania = new DateTime(2024, 3, 6),
                    KategoriaId = 1,
                },
                new Film
                {
                    Id = 7,
                    Tytul = "Skazani na Shawshank",
                    Rezyser = "Frank Darabont",
                    Opis = "amerykański dramat filmowy z 1994 roku w reżyserii Franka Darabonta, oparty na opowiadaniu Stephena Kinga 'Rita Hayworth and Shawshank Redemption' z 1982 roku. W rolach głównych wystąpili Tim Robbins i Morgan Freeman. Film opowiada historię Andy'ego Dufresne'a (Robbins), niesłusznie skazanego za morderstwo i wysłanego do więzienia Shawshank.",
                    Cena = 24.90F,
                    DataDodania = new DateTime(2024, 3, 6),
                    KategoriaId = 1,
                },
                new Film {
                    Id = 8,
                    Tytul = "Władca Pierścieni: Drużyna Pierścienia",
                    Rezyser = "Peter Jackson",
                    Opis = "amerykański film fantasy z 2001 roku w reżyserii Petera Jacksona, oparty na powieści J.R.R. Tolkiena 'Władca Pierścieni: Drużyna Pierścienia' z 1954 roku. Jest to pierwszy film z trylogii 'Władca Pierścieni'. W filmie wystąpili Elijah Wood, Ian McKellen, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, Bernard Hill, Christopher Lee, Billy Boyd, Dominic Monaghan, Orlando Bloom, Hugo Weaving i Ian Holm.",
                    Cena = 39.90F,
                    DataDodania = new DateTime(2024, 3, 6),
                    KategoriaId = 7,
                },
                new Film
                {
                    Id = 9,
                    Tytul = "Forrest Gump",
                    Rezyser = "Robert Zemeckis",
                    Opis = "amerykański film komediowo-dramatyczny z 1994 roku w reżyserii Roberta Zemeckisa, oparty na powieści Winstona Grooma 'Forrest Gump' z 1986 roku. W filmie wystąpił Tom Hanks jako Forrest Gump, mężczyzna o niskim IQ, który staje się świadkiem i uczestnikiem wielu kluczowych wydarzeń w historii XX wieku. Film zdobył sześć Oscarów, w tym za najlepszy film i najlepszego aktora dla Hanksa.",
                    Cena = 29.90F,
                    DataDodania = new DateTime(2024, 3, 6),
                    KategoriaId = 3,
                }
                );
            modelBuilder.Entity<Kategoria>().HasData(
                new Kategoria
                {
                    Id = 1,
                    Nazwa = "Dramat",
                    Opis = "Filmy o poważnej tematyce, często poruszające trudne i emocjonalne kwestie."
                },
                new Kategoria
                {
                    Id = 2,
                    Nazwa = "Science fiction",
                    Opis = "Filmy o tematyce fantastyczno-naukowej, często rozgrywające się w przyszłości lub w innych światach."
                },
                new Kategoria
                {
                    Id = 3,
                    Nazwa = "Komedia",
                    Opis = "Filmy o charakterze humorystycznym, mające na celu rozśmieszyć widza."
                },
                new Kategoria
                {
                    Id = 4,
                    Nazwa = "Horror",
                    Opis = "Filmy mające na celu wzbudzić strach i napięcie u widza."
                },
                new Kategoria
                {
                    Id = 5,
                    Nazwa = "Animowane",
                    Opis = "Filmy rysunkowe lub komputerowe, przeznaczone dla dzieci i dorosłych."
                },
                new Kategoria
                {
                    Id = 6,
                    Nazwa = "Kryminał",
                    Opis = "Filmy dotyczące przestępstw, śledztw i wymiaru sprawiedliwości."
                },
                new Kategoria
                {
                    Id = 7,
                    Nazwa = "Fantasy",
                    Opis = "Filmy zawierające elementy magiczne, mityczne stworzenia, nadprzyrodzone światy."
                }
            );
        }
    }
}
