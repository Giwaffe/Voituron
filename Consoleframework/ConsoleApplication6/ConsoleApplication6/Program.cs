using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {    
        public void Connect() { 
}
        static void Main(string[] args)
        {
            clsGWaySnelStart test = new clsGWaySnelStart();
            clsGWArtikel testProduct = new clsGWArtikel();
            clsGWayLoginSettings testLogin = new clsGWayLoginSettings();

            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");

            

            //StaffelKorting

            //Console.WriteLine(testProduct.mtdGWayVerkoopprijsGet(10292, 1, DateTime.Now));
            //Console.WriteLine(testProduct.mtdGWayVerkoopprijsGet(10292, 5, DateTime.Now));
            //Console.WriteLine(testProduct.mtdGWayVerkoopprijsGet(10292, 8, DateTime.Now));
            //Console.WriteLine(testProduct.mtdGWayVerkoopprijsGet(10292, 10, DateTime.Now));



            //testLogin.prpGWayDbAdministratieNaamSet = "Voorbeeldbedrijf";
            //var y = testLogin.prpGWayDbAdministratieNaamGet;
            //Console.WriteLine(y);

            //testLogin.OnlineAdministrationIdSet = 0;


            //var y = test.mtdGWayAdmiNamenGet();
            //var x = test.prpGWayAdmiFolderGet;
            //var z = test.prpGWayLoginSettingsGet;
            //z.prpGWayDbAdministratieNaamSet = "Voorbeeldbedrijf";
            //z.prpGWayDbSqlUserNameSet = "jan@e-force.nl";
            //z.prpGWayDbSqlPasswordSet = "E-F@ict16!";
            //z.prpGWayDbJetFolderSet = "Voorbeeldbedrijf";
            //z.prpGWayDbSqlConnectTypeWindowsSet = true;
            //z.prpGWayDbSqlServerNameSet = "(localdb)\\snelstart";

            //Console.WriteLine(z.prpGWayDbTypeOmschrijvingGet);
            //Console.WriteLine(z.prpGWayDbTypeJetGet);
            //Console.WriteLine(z.prpGWayDbSqlConnectTypeWindowsGet);


            //Console.WriteLine("Gegevens ingevuld");

            //test.Login("jan@e-force.nl", "E-F@ict16!", true);
            //test.GetSettingsForOnlineAdministrationByName("Voorbeeldbedrijf");

            //Console.WriteLine(y);
            //Console.WriteLine(x);


            //test.mtdGWayAdmiOpenenViaLoginSettings(0, z);

            // var a = z.prpGWayDbAdministratieNaamGet;
            // var b = z.prpGWayAdmiUserPasswordGet;
            // var c = z.prpGWayDbJetFolderGet;
            // var d = z.prpGWayDbSqlConnectTypeWindowsGet;
            // var e = z.prpGWayDbSqlPasswordGet;
            // var f = z.prpGWayDbSqlServerNameGet;
            // var g = z.prpGWayDbSqlUserNameGet;

            // Console.WriteLine("Administratie naam: " + a);
            // Console.WriteLine("Administatie wachtwoord: " + b);
            // Console.WriteLine("Jet folder naam: " + a);
            // Console.WriteLine("Connection type: " + d);
            // Console.WriteLine("Wachtwoord: " + e);
            // Console.WriteLine("Server Naam: " + f);
            // Console.WriteLine("User naam: " + g);

            //testProduct.mtdGWayArtikelRead("10032");

            //var x = testProduct.prpArtikelcodeGet;
            //var a = testProduct.prpOmschrijvingGet;                     // name of the product
            //var b = testProduct.prpVoorraadTechnischGet;                // quantity of the product
            //var c = testProduct.prpArtikelKortinggroepIDGet;            // discount group
            //var d = testProduct.prpMaxKortingsPercentageGet;            // max discount
            //var e = testProduct.prpVerkoopprijsGet;                     // price of the product

            //Console.WriteLine(x);
            //Console.WriteLine("Omschrijving: " + a);
            //Console.WriteLine("Eenheid: " + b);
            //Console.WriteLine("Kortingsgroep: " + c);
            //Console.WriteLine("Maximaal Kortingspercentage: " + d);
            //Console.WriteLine("Prijs: " + e);

            //Console.WriteLine("");

            //testProduct.mtdGWayArtikelReadNext();

            //var y = testProduct.prpArtikelcodeGet;
            //var f = testProduct.prpOmschrijvingGet;                     // name of the product
            //var g = testProduct.prpVoorraadTechnischGet;                // quantity of the product
            //var h = testProduct.prpArtikelKortinggroepIDGet;            // discount group
            //var i = testProduct.prpMaxKortingsPercentageGet;            // max discount
            //var j = testProduct.prpVerkoopprijsGet;                     // price of the product

            //Console.WriteLine(y);
            //Console.WriteLine("Omschrijving: " + f);
            //Console.WriteLine("Eenheid: " + g);
            //Console.WriteLine("Kortingsgroep: " + h);
            //Console.WriteLine("Maximaal Kortingspercentage: " + i);
            //Console.WriteLine("Prijs: " + j);

            //testProduct.mtdGWayArtikelRead("10031");
            //var j = testProduct.prpOmschrijvingGet;
            //Console.WriteLine("Omschrijving: " + a);
            while (1 == 1)
            {
                var key = Console.ReadKey().KeyChar;
                //var key = rk.KeyChar;
                if (key.Equals('s'))
                {
                    Console.WriteLine("taffelkortingen berekenen");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Artikel ophalen");
                    testProduct.mtdGWayArtikelRead(Console.ReadLine());
                    //testProduct.mtdGWayArtikelRead("10033"); //Hoofdschakelaar
                    Console.WriteLine(testProduct.prpArtikelcodeGet + "De opgehaalde artikelcode");
                    Console.WriteLine(testProduct.prpOmschrijvingGet);
                    Console.WriteLine(testProduct.mtdGWayVerkoopprijsGet(10292, 1, DateTime.Now) + "Prijs bij bestelling van 1 artikel.");
                    Console.WriteLine(testProduct.mtdGWayVerkoopprijsGet(10292, 5, DateTime.Now) + "Prijs bij bestelling van 5 artikelen.");
                    Console.WriteLine(testProduct.mtdGWayVerkoopprijsGet(10292, 10, DateTime.Now) + "Prijs bij bestelling van 10 artikelen.");
                }
                if (key.Equals('o'))
                {
                    Console.WriteLine("rder inschieten");
                    test.mtdGWayVerkoopOrderAanmakenA(1, 10292, DateTime.Today, "Test order maken");
                    test.mtdGWayVerkoopOrderRegelToevoegenTekst("Tekstregel");
                    test.mtdGWayVerkoopOrderRegelToevoegenArtikelA("10033", 3);
                    var x = test.mtdGWayVerkoopOrderSluitenGet();
                    Console.WriteLine(x);
                    Console.WriteLine("Open SnelStart en zoek de bovenstaande order ID");
                    Console.WriteLine("");
                    Console.ReadLine();
                }
                Console.WriteLine("");
                Console.WriteLine("Waiting for input...");
            }
        }

    }
}


