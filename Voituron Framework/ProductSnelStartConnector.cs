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
        public static void Connect()
        {
            clsGWaySnelStart test = new clsGWaySnelStart();
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            //test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");
            test.mtdGWayAdmiOpenen("C:\\SnelStart\\Administraties", "Voituron Handelsonderneming");
        }

        public static ProductSnelStart Get(string Id)
        {
            Connect();

            var product = new ProductSnelStart();            

            clsGWArtikel testProduct = new clsGWArtikel();

            testProduct.mtdGWayArtikelRead(Id);

            product.fpArtikelcode = testProduct.prpArtikelcodeGet;                                              // Id of the Product
            product.fpOmschrijving = testProduct.prpOmschrijvingGet;                                            // Name of the Product
            product.fpVerkoopPrijs = testProduct.prpVerkoopprijsGet;                                            // Price of the Product
            product.fpAutomatischePrijs = testProduct.prpAutomatischePrijsGet;
            product.fpArtikelKortinggroepID = testProduct.prpArtikelKortinggroepIDGet;                          // Discountgroup of the Product
            product.fpMaxKortingsPercentage = testProduct.prpMaxKortingsPercentageGet;                          // MaxDiscount of the Product
            product.fpVoorraad = testProduct.prpVoorraadTechnischGet;                                           // Quantity in Storage
            product.fpArtikelOmzetgroep = testProduct.prpArtikelOmzetgroepIDGet;
            product.fpBestelEenheid = testProduct.prpBestelEenheidGet;
            product.fpEenheid = testProduct.prpEenheidGet;
            product.fpInkoopPrijs = testProduct.prpInkoopprijsGet;
            product.fpLeverancierID = testProduct.prpLeverancierIDGet;
            product.fpMaxKortingsPercentageGebruiken = testProduct.prpMaxKortingsPercentageGebruikenGet;
            product.fpMinimaalBestelAantal = testProduct.prpMinimaalBestelAantalGet;
            product.fpMinimumVoorraad = testProduct.prpMinimumVoorraadGet;
            product.fpNonActief = testProduct.prpNonActiefGet;
            product.fpVoorraadControle = testProduct.prpVoorraadControleGet;
            product.fpVoorraadGewenst = testProduct.prpVoorraadGewenstGet;
            product.fpVoorraadVrij = testProduct.prpVoorraadVrijGet;

            return product;
        }
        public static List<ProductSnelStart> ListProductsGet()
        {
            Connect();
            List<ProductSnelStart> products = new List<ProductSnelStart>();
            clsGWArtikel product = new clsGWArtikel();

            while (product.mtdGWayArtikelReadNext() == true)
            {
                var listproduct = new ProductSnelStart();
                listproduct.fpArtikelcode = product.prpArtikelcodeGet;                          // Id of the Product
                //listproduct.fpOmschrijving = product.prpOmschrijvingGet;                        // Name of the Product
                //listproduct.fpVerkoopPrijs = product.prpVerkoopprijsGet;                        // Price of the Product
                //listproduct.fpAutomatischePrijs = product.prpAutomatischePrijsGet;
                //listproduct.fpArtikelKortinggroepID = product.prpArtikelKortinggroepIDGet;      // Discountgroup of the Product
                //listproduct.fpMaxKortingsPercentage = product.prpMaxKortingsPercentageGet;      // MaxDiscount of the Product
                //listproduct.fpVoorraad = product.prpVoorraadTechnischGet;                       // Quantity in Storage
                //listproduct.fpArtikelOmzetgroep = product.prpArtikelOmzetgroepIDGet;
                //listproduct.fpBestelEenheid = product.prpBestelEenheidGet;
                //listproduct.fpEenheid = product.prpEenheidGet;
                //listproduct.fpInkoopPrijs = product.prpInkoopprijsGet;
                //listproduct.fpLeverancierID = product.prpLeverancierIDGet;
                //listproduct.fpMaxKortingsPercentageGebruiken = product.prpMaxKortingsPercentageGebruikenGet;
                //listproduct.fpMinimaalBestelAantal = product.prpMinimaalBestelAantalGet;
                //listproduct.fpMinimumVoorraad = product.prpMinimumVoorraadGet;
                //listproduct.fpNonActief = product.prpNonActiefGet;
                //listproduct.fpVoorraadControle = product.prpVoorraadControleGet;
                //listproduct.fpVoorraadGewenst = product.prpVoorraadGewenstGet;
                //listproduct.fpVoorraadVrij = product.prpVoorraadVrijGet;
                products.Add(listproduct);
            }
            return products;
        }
    }
}
