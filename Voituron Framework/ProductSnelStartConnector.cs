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
            //var z = test.prpGWayLoginSettingsGet;
            //test.mtdGWayAdmiOpenenViaLoginSettings(0, z);
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");
        }

        public static ProductSnelStart Get(string Id)
        {
            Connect();

            var product = new ProductSnelStart();            

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
        public static List<ProductSnelStart> GetList()
        {
            Connect();
            List<ProductSnelStart> products = new List<ProductSnelStart>();
            clsGWArtikel product = new clsGWArtikel();
            var x = 0;
            while (product.mtdGWayArtikelReadNext() == true && x <= 19)
            {
                var listproduct = new ProductSnelStart();
                listproduct.vfArtikelcode = product.prpArtikelcodeGet;                          // Id of the Product
                listproduct.vfOmschrijving = product.prpOmschrijvingGet;                        // Name of the Product
                listproduct.vfVerkoopPrijs = product.prpVerkoopprijsGet;                        // Price of the Product
                listproduct.vfAutomatischePrijs = product.prpAutomatischePrijsGet;
                listproduct.vfArtikelKortinggroepID = product.prpArtikelKortinggroepIDGet;      // Discountgroup of the Product
                listproduct.vfMaxKortingsPercentage = product.prpMaxKortingsPercentageGet;      // MaxDiscount of the Product
                listproduct.vfVoorraad = product.prpVoorraadTechnischGet;                       // Quantity in Storage
                listproduct.vfArtikelOmzetgroep = product.prpArtikelOmzetgroepIDGet;
                listproduct.vfBestelEenheid = product.prpBestelEenheidGet;
                listproduct.vfEenheid = product.prpEenheidGet;
                listproduct.vfInkoopPrijs = product.prpInkoopprijsGet;
                listproduct.vfLeverancierID = product.prpLeverancierIDGet;
                listproduct.vfMaxKortingsPercentageGebruiken = product.prpMaxKortingsPercentageGebruikenGet;
                listproduct.vfMinimaalBestelAantal = product.prpMinimaalBestelAantalGet;
                listproduct.vfMinimumVoorraad = product.prpMinimumVoorraadGet;
                listproduct.vfNonActief = product.prpNonActiefGet;
                listproduct.vfVoorraadControle = product.prpVoorraadControleGet;
                listproduct.vfVoorraadGewenst = product.prpVoorraadGewenstGet;
                listproduct.vfVoorraadVrij = product.prpVoorraadVrijGet;
                products.Add(listproduct);
                x++;
            }
            return products;
        }
    }
}
