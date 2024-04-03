namespace WinFormsApp2
{
    public class Gebruiker
    {

        private Guid _guid;
        private string _gebruikersNaam;
        private string _gebruikersVoornaam;
        private string _paswoord;
        private GebruikersRol _gebruikersRol;
        private bool _kanBewerkenXml;
        private bool _kanAanmakenXml;
        private bool _kanLezenXml;
        private bool _kanEncrypterenXml;
        private bool _kanBewerkenTxt;
        private bool _kanAanmakenTxt;
        private bool _kanLezenTxt;
        private bool _kanEncrypterenTxt;
        private bool _kanBewerkenJson;
        private bool _kanAanmakenJson;
        private bool _kanLezenJson;
        private bool _kanEncrypterenJson;
        private List<Afdeling> _lijstAfdelingen;

        public Gebruiker()
        {
            _guid = Guid.NewGuid();
        }
        public Gebruiker(GebruikersRol eenRol, string gebruikersNaam, string gebruikersVoornaam, string paswoord, List<Afdeling> eenLijstAfdelingen)//hier zijn ze niet null
        {
            Guid = Guid.NewGuid();
            GebruikersNaam = gebruikersNaam;
            GebruikersVoornaam = gebruikersVoornaam;
            Paswoord = paswoord;
            LijstAfdelingen = eenLijstAfdelingen;
            GebruikersRol = eenRol;

            _kanBewerkenXml = eenRol.KanBewerkenXml;
            _kanAanmakenXml = eenRol.KanAanmakenXml;
            _kanLezenXml = eenRol.KanLezenXml;
            _kanEncrypterenXml = eenRol.KanEncrypterenXml;
            _kanBewerkenTxt = eenRol.KanBewerkenTxt;
            _kanAanmakenTxt = eenRol.KanAanmakenTxt;
            _kanLezenTxt = eenRol.KanLezenTxt;
            _kanEncrypterenTxt = eenRol.KanEncrypterenTxt;
            _kanBewerkenJson = eenRol.KanBewerkenJson;
            _kanAanmakenJson = eenRol.KanAanmakenJson;
            _kanLezenJson = eenRol.KanLezenJson;
            _kanEncrypterenJson = eenRol.KanEncrypterenJson;
        }
        public string GebruikersNaam { get { return _gebruikersNaam; } set { _gebruikersNaam = value; } }
        public string GebruikersVoornaam { get { return _gebruikersVoornaam; } set { _gebruikersVoornaam = value; } }
        public string Paswoord { get { return _paswoord; } set { _paswoord = value; } }
        public Guid Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }
        public List<Afdeling> LijstAfdelingen { get { return _lijstAfdelingen; } set { _lijstAfdelingen = value; } }
        public GebruikersRol GebruikersRol { get { return _gebruikersRol; } set { _gebruikersRol = value; } }
        public override string ToString()
        {
            return GebruikersNaam.ToString();
        }
    }
}
