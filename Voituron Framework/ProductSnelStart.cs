using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public class ProductSnelStart
    {
        // All properties of our framework for Products. "fp" stands for Framework Property.
        public string fpArtikelcode { get; set; }                           // Article Code, ID of the product
        public string fpOmschrijving { get; set; }                          // Description
        public decimal fpVerkoopPrijs { get; set; }                         // Price
        public bool fpAutomatischePrijs { get; set; }                       // Automatic price
        public int fpArtikelKortinggroepID { get; set; }                    // Discount group ID
        public decimal fpVoorraad { get; set; }                             // Warehouse
        public int fpArtikelOmzetgroep { get; set; }                        // Article revenue group
        public decimal fpBestelEenheid { get; set; }                        // Order unit
        public string fpEenheid { get; set; }                               // unit
        public decimal fpInkoopPrijs { get; set; }                          // stock acquisition
        public int fpLeverancierID { get; set; }                            // Supplier ID
        public bool fpMaxKortingsPercentageGebruiken { get; set; }          // boolean whether to use maximum discount percentage
        public decimal fpMaxKortingsPercentage { get; set; }                // Set maximum discount percentage
        public decimal fpMinimaalBestelAantal { get; set; }                 // Minimum order amount
        public decimal fpMinimumVoorraad { get; set; }                      // Minimum warehouse
        public bool fpNonActief { get; set; }                               // Boolean whether inactive
        public bool fpVoorraadControle { get; set; }                        // Boolean whether Warehouse is checked
        public decimal fpVoorraadGewenst { get; set; }                      // Desired warehouse
        public decimal fpVoorraadVrij { get; set; }                         // Free warehouse
    }
}
