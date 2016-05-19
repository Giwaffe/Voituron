using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public static class ProductSnelStartConnector
    {

        public static ProductSnelStart Get(string Id)
        {
            var product = new ProductSnelStart();            

            clsGWaySnelStart test = new clsGWaySnelStart();
            //var z = test.prpGWayLoginSettingsGet;
            //test.mtdGWayAdmiOpenenViaLoginSettings(0, z);
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");

            clsGWArtikel testProduct = new clsGWArtikel();

            testProduct.mtdGWayArtikelRead(Id);

            product.vfArtikelcode = testProduct.prpArtikelcodeGet;                          // Id of the Product
            product.vfOmschrijving = testProduct.prpOmschrijvingGet;                        // Name of the Product
            product.vfVerkoopPrijs = testProduct.prpVerkoopprijsGet;                        // Price of the Product
            product.vfAutomatischePrijs = testProduct.prpAutomatischePrijsGet;
            product.vfArtikelKortinggroepID = testProduct.prpArtikelKortinggroepIDGet;      // Discountgroup of the Product
            product.vfMaxKortingsPercentage = testProduct.prpMaxKortingsPercentageGet;      // MaxDiscount of the Product
            product.vfVoorraad = testProduct.prpVoorraadTechnischGet;                       // Quantity in Storage
            product.vfArtikelOmzetgroep = testProduct.prpArtikelOmzetgroepIDGet;
            product.vfBestelEenheid = testProduct.prpBestelEenheidGet;
            product.vfEenheid = testProduct.prpEenheidGet;
            product.vfInkoopPrijs = testProduct.prpInkoopprijsGet;
            product.vfLeverancierID = testProduct.prpLeverancierIDGet;
            product.vfMaxKortingsPercentageGebruiken = testProduct.prpMaxKortingsPercentageGebruikenGet;
            product.vfMinimaalBestelAantal = testProduct.prpMinimaalBestelAantalGet;
            product.vfMinimumVoorraad = testProduct.prpMinimumVoorraadGet;
            product.vfNonActief = testProduct.prpNonActiefGet;
            product.vfVoorraadControle = testProduct.prpVoorraadControleGet;
            product.vfVoorraadGewenst = testProduct.prpVoorraadGewenstGet;
            product.vfVoorraadVrij = testProduct.prpVoorraadVrijGet;

            return product;
        }
    }
}
