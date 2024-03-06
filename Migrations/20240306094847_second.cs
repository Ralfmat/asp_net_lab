using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp_net_lab.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rezyser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Cena = table.Column<float>(type: "real", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmy_Kategorie_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[,]
                {
                    { 1, "Dramat", "Filmy o poważnej tematyce, często poruszające trudne i emocjonalne kwestie." },
                    { 2, "Science fiction", "Filmy o tematyce fantastyczno-naukowej, często rozgrywające się w przyszłości lub w innych światach." },
                    { 3, "Komedia", "Filmy o charakterze humorystycznym, mające na celu rozśmieszyć widza." },
                    { 4, "Horror", "Filmy mające na celu wzbudzić strach i napięcie u widza." },
                    { 5, "Animowane", "Filmy rysunkowe lub komputerowe, przeznaczone dla dzieci i dorosłych." },
                    { 6, "Kryminał", "Filmy dotyczące przestępstw, śledztw i wymiaru sprawiedliwości." },
                    { 7, "Fantasy", "Filmy zawierające elementy magiczne, mityczne stworzenia, nadprzyrodzone światy." }
                });

            migrationBuilder.InsertData(
                table: "Filmy",
                columns: new[] { "Id", "Cena", "DataDodania", "KategoriaId", "Opis", "Rezyser", "Tytul" },
                values: new object[,]
                {
                    { 1, 39.9f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "amerykański dramat obyczajowy z 1997 roku w reżyserii Gusa Van Santa, nagrodzony dwoma Oscarami: za najlepszy scenariusz stworzony przez Bena Afflecka i Matta Damona i najlepszą rolę drugoplanową – psychoterapeuty Seana Maguire'a, w którego wcielił się Robin Williams.", "Gus Van Sant", "Buntownik z wyboru" },
                    { 2, 24.9f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "amerykański film kryminalny z 1994 roku w reżyserii Quentina Tarantino, oparty na scenariuszu Tarantino i Rogera Avary’ego. Film, w którym występują John Travolta, Samuel L. Jackson, Bruce Willis, Tim Roth, Ving Rhames i Uma Thurman, opowiada kilka epizodów rozgrywających się w przestępczym Los Angeles.", "Quentin Tarantino", "Pulp Fiction" },
                    { 3, 40.5f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "apoński film animowany w reżyserii Hayao Miyazakiego, wyprodukowany przez Studio Ghibli. Jego japońska premiera miała miejsce 14 lipca 2023 r. Polska premiera kinowa miała miejsce 19 stycznia 2024 r.", "Hayao Miyazaki", "Chłopiec i Czapla" },
                    { 4, 59.9f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "amerykańsko-kanadyjski film science fiction z 2021 roku w reżyserii Denisa Villeneuve’a, zrealizowany na podstawie powieści Franka Herberta o tym samym tytule, adaptujący jej pierwszą połowę; zdobył sześć Oscarów. Film zadebiutował 3 września 2021 w ramach 78. MFF w Wenecji.", "Denis Villeneuve", "Diuna 1" },
                    { 5, 64.9f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "amerykańsko-kanadyjski film science fiction z 2024 roku w reżyserii Denisa Villeneuve’a. Druga część ekranizacji powieści Franka Herberta o tym samym tytule, bezpośrednia kontynuacja filmu z 2021 roku. Film zadebiutował 6 lutego 2024 w Auditorio Nacional w mieście Meksyk.", "Denis Villeneuve", "Diuna 2" },
                    { 6, 29.9f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "amerykański film gangsterski z 1972 roku w reżyserii Francisa Forda Coppoli, z Marlonem Brando i Alem Pacino w rolach głównych. Adaptacja powieści Mario Puzo o tym samym tytule. Film opowiada historię rodziny Corleone, potężnego klanu mafijnego z Nowego Jorku, w latach 1945–1955.", "Francis Ford Coppola", "Ojciec chrzestny" },
                    { 7, 24.9f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "amerykański dramat filmowy z 1994 roku w reżyserii Franka Darabonta, oparty na opowiadaniu Stephena Kinga 'Rita Hayworth and Shawshank Redemption' z 1982 roku. W rolach głównych wystąpili Tim Robbins i Morgan Freeman. Film opowiada historię Andy'ego Dufresne'a (Robbins), niesłusznie skazanego za morderstwo i wysłanego do więzienia Shawshank.", "Frank Darabont", "Skazani na Shawshank" },
                    { 8, 39.9f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "amerykański film fantasy z 2001 roku w reżyserii Petera Jacksona, oparty na powieści J.R.R. Tolkiena 'Władca Pierścieni: Drużyna Pierścienia' z 1954 roku. Jest to pierwszy film z trylogii 'Władca Pierścieni'. W filmie wystąpili Elijah Wood, Ian McKellen, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, Bernard Hill, Christopher Lee, Billy Boyd, Dominic Monaghan, Orlando Bloom, Hugo Weaving i Ian Holm.", "Peter Jackson", "Władca Pierścieni: Drużyna Pierścienia" },
                    { 9, 29.9f, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "amerykański film komediowo-dramatyczny z 1994 roku w reżyserii Roberta Zemeckisa, oparty na powieści Winstona Grooma 'Forrest Gump' z 1986 roku. W filmie wystąpił Tom Hanks jako Forrest Gump, mężczyzna o niskim IQ, który staje się świadkiem i uczestnikiem wielu kluczowych wydarzeń w historii XX wieku. Film zdobył sześć Oscarów, w tym za najlepszy film i najlepszego aktora dla Hanksa.", "Robert Zemeckis", "Forrest Gump" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmy_KategoriaId",
                table: "Filmy",
                column: "KategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmy");

            migrationBuilder.DropTable(
                name: "Kategorie");
        }
    }
}
