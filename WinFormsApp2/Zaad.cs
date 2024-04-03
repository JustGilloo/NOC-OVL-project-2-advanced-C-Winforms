namespace Harvest_Moon_0._2
{
    public class Zaad
    {
        public Zaad()
        {

        }
        public Zaad(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }
        public Zaad(string naam, int hoeveelheidZaad, int leeftijd, int zaadTijd, int halfGroeiTijd, int groeiTijd, int hoeveelheidUnitsBijOogst, double waardeVerkoopUnit, double waardeZaad, string beschrijving)
        {
            Naam = naam;
            HoeveelZaad = hoeveelheidZaad;
            Leeftijd = leeftijd;
            ZaadTijd = zaadTijd;
            HalfGroeiTijd = halfGroeiTijd;
            GroeiTijd = groeiTijd;
            OogstHoeveelheidUnits = hoeveelheidUnitsBijOogst;
            OogstOpbrengst = waardeVerkoopUnit;
            WaardeZaad = waardeZaad;
            Beschrijving = beschrijving;
        }
        public string Naam { get; set; }
        public int HoeveelZaad { get; set; }
        public int Leeftijd { get; set; }
        public int ZaadTijd { get; set; } //tot hoelang het zaadjes zijn
        public int HalfGroeiTijd { get; set; } //vanaf wanneer het half gegroeid is
        public int GroeiTijd { get; set; } //vanaf wanneer het volgroed is
        public int OogstHoeveelheidUnits { get; set; } //hoeveel "Naam" je krijgt bij oogsten
        public double OogstOpbrengst { get; set; } //hoeveel centjes je verdient bij het verkopen van volgroeide items
        public double WaardeZaad { get; set; }
        public bool IsGegroeid { get; set; }
        public string Beschrijving { get; set; }
        public void OogstZaad(Zaad zaad) //was een test, werkte niet
        {
            zaad = null;
        }
    }
}
