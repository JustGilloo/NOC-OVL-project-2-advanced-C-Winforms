namespace WinFormsApp2
{
    public class Grondstof
    {
        private int _hoeveelheidInStock;
        private string _naam;
        //private DateTime _vervaldatum;
        private double _verkoopPrijs;
        public Grondstof() //basic
        { }
        public Grondstof(string eenNaam) //basic
        {
            Naam = eenNaam;
        }
        public Grondstof(string eenNaam, int eenHoeveelheid, double eenPrijs) //voor aanvullen en verminderen
        {
            Naam = eenNaam;
            Aantal = eenHoeveelheid;
            Prijs = eenPrijs;
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int Aantal
        {
            get { return _hoeveelheidInStock; }
            set { _hoeveelheidInStock = value; }
        }
        public double Prijs
        {
            get { return _verkoopPrijs; }
            set
            {
                _verkoopPrijs = value;
            }
        }
        public void AanvullenStock(int aantal)
        {
            Aantal += aantal;
        }
        public void VerminderenStock(int aantal)
        { Aantal -= aantal; }
        public double Berekenprijs(int aantal)
        {
            double totaalprijs = aantal * Prijs;
            return totaalprijs;
        }
        public override string ToString()
        {
            return "Naam: " + Naam + " - Aantal: " + Aantal + " -  Prijs: €" + Prijs; //Todo: Padleft? Stockbeheer scherm
        }
        public override bool Equals(object? obj)
        {
            bool resultaat = false;
            if (obj != null)
            {
                if (GetType() == obj.GetType())
                {
                    Grondstof g = (Grondstof)obj;
                    if (this.Naam == g.Naam)
                    {
                        resultaat = true;
                    }
                }
            }
            return resultaat;
        }
    }
}
