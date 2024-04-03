using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Afdeling
    {
        private string _naam;
        private Guid _guid;
        private string? _omschrijving;
        public Afdeling()
        {
            _guid = Guid.NewGuid();
        }
        public Afdeling(string eenNaam, string? eenOmschrijving)
        {
            _naam = eenNaam;
            _guid = Guid.NewGuid();
            _omschrijving = eenOmschrijving;
        }
        public string Naam { get { return _naam; } set { _naam = value; } }
        public Guid Guid { get { return _guid; } set { _guid = value; } }
        public string Omschrijving { get { return _omschrijving; } set { _omschrijving = value; } }
        public override string ToString() { return Naam; }
    }
}
