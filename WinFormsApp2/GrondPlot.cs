using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Moon_0._2
{
    public class GrondPlot
    {
        public GrondPlot() { }
        public GrondPlot(string naam, int leeftijdPlantje)
        {
            Naam = naam;
            LeeftijdPlantje = leeftijdPlantje;
        }
        public string Naam
        {  get; set; }
        public int LeeftijdPlantje
        { get; set; }
    }
}
