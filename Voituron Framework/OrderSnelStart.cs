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
        public int fpRegelIDGet { get; }                            // Order Line ID
        public decimal fpAantalInkoopGet { get; }                   // Amount stock acquisition
        public decimal fpAantalVerkochtGet { get; }                 // Amount sold
        public string fpArtikelCodeGet { get; }                     // Article code (ID)
        public int fpExtraDataCount { get; }                        // Extra Data amount
        public int fpExtraDataGet { get; }                          // Get Extra Data
        public decimal fpKortingGet { get; }                        // Discount
        public int fpKostenPlaatsNummerGet { get; }                 // cost center number
        public string fpOmschrijvingGet { get; }                    // Get description
        public decimal fpPrijsGet { get; }                          // Price
        public enmGWayUpdateStatus fpUpdateStatusGet { get; }       // Get update status

        // Setters, fp stands for Framework Property
        public decimal fpAantalInkoopLet { get; set; }              // Set Amount stock acquisition
        public decimal fpAantalVerkochtLet { get; set; }            // Set amount sold
        public string fpArtikelCodeLet { get; set; }                // Set Article code (ID)
        public int fpExtraDataSet { get; set; }                     // Set Extra Data
        public decimal fpKortingLet { get; set; }                   // Set Discount
        public int fpKostenPlaatsNummerLet { get; set; }            // Set cost center number
        public string fpOmschrijvingLet { get; set; }               // Set description
        public decimal fpPrijsLet { get; set; }                     // Set price
    }
}
