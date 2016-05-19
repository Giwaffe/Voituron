using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public static class CustomerSnelStartConnector
    {
        public static void Connect()
        {
            clsGWaySnelStart test = new clsGWaySnelStart();
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");
        }
        public static CustomerSnelStart Get(int Id)
        {
            Connect();
        
            var Customer = new CustomerSnelStart();

            clsGWKlant testCustomer = new clsGWKlant();

            testCustomer.mtdGWayKlantRead(Id);

            //Get all Customer properties and set them in CustomerSnelStart object Customer.
            Customer.vfRelatieCode = testCustomer.prpRelatieCode;                                                
            Customer.vfNaam = testCustomer.prpNaam;                 
            Customer.vfEmail = testCustomer.prpEmail;             
            Customer.vfIban = testCustomer.prpIban;                 
            Customer.vfCreditCardNummer2 = testCustomer.prpCreditCardNummer2;
            Customer.vfTelefoon = testCustomer.prpTelefoon;           
            Customer.vfTelefoonMobiel = testCustomer.prpTelefoonMobiel;
            Customer.vfMemo = testCustomer.prpMemo;
            Customer.vfBic = testCustomer.prpBic;
            Customer.vfBtwNummer = testCustomer.prpBtwNummer;
            Customer.vfAanmanen = testCustomer.prpAanmanen;
            Customer.vfAanmaningEmailen = testCustomer.prpAanmaningEmailen;
            Customer.vfAanmaningEmailAdres = testCustomer.prpAanmaningEmailAdres;
            Customer.vfAanmaningCcEmailAdres = testCustomer.prpAanmaningCcEmailAdres;
            Customer.vfBevestigingEmailen = testCustomer.prpBevestigingEmailen;
            Customer.vfBevestigingEmailAdres = testCustomer.prpBevestigingEmailAdres;
            Customer.vfBevestigingCcEmailAdres = testCustomer.prpBevestigingCcEmailAdres;
            Customer.vfCorrespondentieAdres = testCustomer.prpCorrespondentieAdres;
            Customer.vfCorrespondentieAdresContactPersoon = testCustomer.prpCorrespondentieAdresContactpersoon;
            Customer.vfCorrespondentieAdresAfwijkend = testCustomer.prpCorrespondentieAdresAfwijkend;
            Customer.vfCorrespondentieAdresLandID = testCustomer.prpCorrespondentieAdresLandID;
            Customer.vfCorrespondentieAdresPlaats = testCustomer.prpCorrespondentieAdresPlaats;
            Customer.vfCorrespondentieAdresPostCode = testCustomer.prpCorrespondentieAdresPostcode;
            Customer.vfElektronischFactureren = testCustomer.prpElektronischFactureren;
            Customer.vfFax = testCustomer.prpFax;
            Customer.vfFactuurEmailAdres = testCustomer.prpFactuurEmailAdres;
            Customer.vfFactuurCcEmailAdres = testCustomer.prpFactuurCcEmailAdres;
            Customer.vfFactuurKorting = testCustomer.prpFactuurKorting;
            Customer.vfIncasseren = testCustomer.prpIncasseren;
            Customer.vfKredietLimiet = testCustomer.prpKredietLimiet;
            Customer.vfKredietTermijn = testCustomer.prpKrediettermijn;
            Customer.vfKvkNummer = testCustomer.prpKvkNummer;
            Customer.vfNonActiefGet = testCustomer.prpNonActiefGet;
            Customer.vfOfferteEmailen = testCustomer.prpOfferteEmailen;
            Customer.vfOfferteEmailAdres = testCustomer.prpOfferteEmailAdres;
            Customer.vfOfferteCcEmailAdres = testCustomer.prpOfferteCcEmailAdres;
            Customer.vfOpenstaandSaldo = testCustomer.prpOpenstaandSaldo;
            Customer.vfRekeningnummerBank2 = testCustomer.prpRekeningnummerBank2;
            Customer.vfRekeningnummerNaamHouder = testCustomer.prpRekeningnummerNaamHouder;
            Customer.vfRekeningnummerPlaatsHouder = testCustomer.prpRekeningnummerPlaatsHouder;
            Customer.vfRelatieCodeFactuurNaar = testCustomer.prpRelatieCodeFactuurNaar;
            Customer.vfUblBestandAlsBijlage = testCustomer.prpUblBestandAlsBijlage;
            Customer.vfVestigingAdres = testCustomer.prpVestigingAdres;
            Customer.vfVestigingAdresContactPersoon = testCustomer.prpVestigingAdresContactpersoon;
            Customer.vfVestigingAdresLandID = testCustomer.prpVestigingAdresLandID;
            Customer.vfVestigingAdresPlaats = testCustomer.prpVestigingAdresPlaats;
            Customer.vfVestigingAdresPostcode = testCustomer.prpVestigingAdresPostcode;
            Customer.vfWebSiteUrl = testCustomer.prpWebSiteUrl;

            return Customer;
        }
        public static List<CustomerSnelStart> ListCustomersGet()
        {
            Connect();
            List<CustomerSnelStart> customers = new List<CustomerSnelStart>();
            clsGWKlant customer = new clsGWKlant();
            var x = 0;
            while(customer.mtdGWayKlantReadNext() == true && x <= 19)
            {
                var listCustomer = new CustomerSnelStart();
                listCustomer.vfRelatieCode = customer.prpRelatieCode;
                listCustomer.vfNaam = customer.prpNaam;
                listCustomer.vfEmail = customer.prpEmail;
                listCustomer.vfIban = customer.prpIban;
                listCustomer.vfCreditCardNummer2 = customer.prpCreditCardNummer2;
                listCustomer.vfTelefoon = customer.prpTelefoon;
                listCustomer.vfTelefoonMobiel = customer.prpTelefoonMobiel;
                listCustomer.vfMemo = customer.prpMemo;
                listCustomer.vfBic = customer.prpBic;
                listCustomer.vfBtwNummer = customer.prpBtwNummer;
                listCustomer.vfAanmanen = customer.prpAanmanen;
                listCustomer.vfAanmaningEmailen = customer.prpAanmaningEmailen;
                listCustomer.vfAanmaningEmailAdres = customer.prpAanmaningEmailAdres;
                listCustomer.vfAanmaningCcEmailAdres = customer.prpAanmaningCcEmailAdres;
                listCustomer.vfBevestigingEmailen = customer.prpBevestigingEmailen;
                listCustomer.vfBevestigingEmailAdres = customer.prpBevestigingEmailAdres;
                listCustomer.vfBevestigingCcEmailAdres = customer.prpBevestigingCcEmailAdres;
                listCustomer.vfCorrespondentieAdres = customer.prpCorrespondentieAdres;
                listCustomer.vfCorrespondentieAdresContactPersoon = customer.prpCorrespondentieAdresContactpersoon;
                listCustomer.vfCorrespondentieAdresAfwijkend = customer.prpCorrespondentieAdresAfwijkend;
                listCustomer.vfCorrespondentieAdresLandID = customer.prpCorrespondentieAdresLandID;
                listCustomer.vfCorrespondentieAdresPlaats = customer.prpCorrespondentieAdresPlaats;
                listCustomer.vfCorrespondentieAdresPostCode = customer.prpCorrespondentieAdresPostcode;
                listCustomer.vfElektronischFactureren = customer.prpElektronischFactureren;
                listCustomer.vfFax = customer.prpFax;
                listCustomer.vfFactuurEmailAdres = customer.prpFactuurEmailAdres;
                listCustomer.vfFactuurCcEmailAdres = customer.prpFactuurCcEmailAdres;
                listCustomer.vfFactuurKorting = customer.prpFactuurKorting;
                listCustomer.vfIncasseren = customer.prpIncasseren;
                listCustomer.vfKredietLimiet = customer.prpKredietLimiet;
                listCustomer.vfKredietTermijn = customer.prpKrediettermijn;
                listCustomer.vfKvkNummer = customer.prpKvkNummer;
                listCustomer.vfNonActiefGet = customer.prpNonActiefGet;
                listCustomer.vfOfferteEmailen = customer.prpOfferteEmailen;
                listCustomer.vfOfferteEmailAdres = customer.prpOfferteEmailAdres;
                listCustomer.vfOfferteCcEmailAdres = customer.prpOfferteCcEmailAdres;
                listCustomer.vfOpenstaandSaldo = customer.prpOpenstaandSaldo;
                listCustomer.vfRekeningnummerBank2 = customer.prpRekeningnummerBank2;
                listCustomer.vfRekeningnummerNaamHouder = customer.prpRekeningnummerNaamHouder;
                listCustomer.vfRekeningnummerPlaatsHouder = customer.prpRekeningnummerPlaatsHouder;
                listCustomer.vfRelatieCodeFactuurNaar = customer.prpRelatieCodeFactuurNaar;
                listCustomer.vfUblBestandAlsBijlage = customer.prpUblBestandAlsBijlage;
                listCustomer.vfVestigingAdres = customer.prpVestigingAdres;
                listCustomer.vfVestigingAdresContactPersoon = customer.prpVestigingAdresContactpersoon;
                listCustomer.vfVestigingAdresLandID = customer.prpVestigingAdresLandID;
                listCustomer.vfVestigingAdresPlaats = customer.prpVestigingAdresPlaats;
                listCustomer.vfVestigingAdresPostcode = customer.prpVestigingAdresPostcode;
                listCustomer.vfWebSiteUrl = customer.prpWebSiteUrl;
                customers.Add(listCustomer);
                x++;
            }
            return customers;
        }
    }
}
