using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public class OrderSnelStart
    {
        // Getters, fp stands for Framework Property                // Translation
        public int fpRegelIDGetSS { get; }                            // Order Line ID
        public decimal fpAantalInkoopGetSS { get; }                   // Amount stock acquisition
        public decimal fpAantalVerkochtGetSS { get; }                 // Amount sold
        public string fpArtikelCodeGetSS { get; }                     // Article code (ID)
        public int fpExtraDataCountSS { get; }                        // Extra Data amount
        public int fpExtraDataGetSS { get; }                          // Get Extra Data
        public decimal fpKortingGetSS { get; }                        // Discount
        public int fpKostenPlaatsNummerGetSS { get; }                 // cost center number
        public string fpOmschrijvingGetSS { get; }                    // Get description
        public decimal fpPrijsGetSS { get; }                          // Price
        public enmGWayUpdateStatus fpUpdateStatusGetSS { get; }       // Get update status

        // Setters, fp stands for Framework Property
        public int fpRelatieCode { get; set; }                      // Customer's realation code
        public decimal fpAantalInkoop { get; set; }                 // Set Amount stock acquisition
        public decimal fpAantalVerkocht { get; set; }               // Set amount sold
        public string fpArtikelCode { get; set; }                   // Set Article code (ID)
        public int fpExtraData { get; set; }                        // Set Extra Data
        public decimal fpKorting { get; set; }                      // Set Discount
        public int fpKostenPlaatsNummer { get; set; }               // Set cost center number
        public string fpOmschrijving { get; set; }                  // Set description
        public decimal fpPrijs { get; set; }                        // Set price
    }
}
