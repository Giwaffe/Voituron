using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public class ProductSnelStart
    {
        public string vfArtikelcode { get; set; }
        public string vfOmschrijving { get; set; }
        public decimal vfVerkoopPrijs { get; set; }
        public bool vfAutomatischePrijs { get; set; }
        public int vfArtikelKortinggroepID { get; set; }
        public decimal vfVoorraad { get; set; }
        public int vfArtikelOmzetgroep { get; set; }
        public decimal vfBestelEenheid { get; set; }
        public string vfEenheid { get; set; }
        public decimal vfInkoopPrijs { get; set; }
        public int vfLeverancierID { get; set; }
        public bool vfMaxKortingsPercentageGebruiken { get; set; }
        public decimal vfMaxKortingsPercentage { get; set; }
        public decimal vfMinimaalBestelAantal { get; set; }
        public decimal vfMinimumVoorraad { get; set; }
        public bool vfNonActief { get; set; }
        public bool vfVoorraadControle { get; set; }
        public decimal vfVoorraadGewenst { get; set; }
        public decimal vfVoorraadVrij { get; set; }
    }
}
