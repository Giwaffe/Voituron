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

            //Get all Customer properties and set them in CustomerSnelStart object Customer.                            // Translations and small description
            Customer.fpRelatieCode = testCustomer.prpRelatieCode;                                                       // Relation code, (unique customer code)
            Customer.fpNaam = testCustomer.prpNaam;                                                                     // Name
            Customer.fpEmail = testCustomer.prpEmail;                                                                   // E-mail
            Customer.fpIban = testCustomer.prpIban;                                                                     // IBAN number
            Customer.fpCreditCardNummer2 = testCustomer.prpCreditCardNummer2;                                           // Creditcard number
            Customer.fpTelefoon = testCustomer.prpTelefoon;                                                             // Phone number
            Customer.fpTelefoonMobiel = testCustomer.prpTelefoonMobiel;                                                 // Mobile phone number
            Customer.fpMemo = testCustomer.prpMemo;                                                                     // Memo
            Customer.fpBic = testCustomer.prpBic;                                                                       // Bic
            Customer.fpBtwNummer = testCustomer.prpBtwNummer;                                                           // VAT number (product taxes)
            Customer.fpAanmanen = testCustomer.prpAanmanen;                                                             // Admonition
            Customer.fpAanmaningEmailen = testCustomer.prpAanmaningEmailen;                                             // Sent adminition email boolean
            Customer.fpAanmaningEmailAdres = testCustomer.prpAanmaningEmailAdres;                                       // E-mail address to send admonition to
            Customer.fpAanmaningCcEmailAdres = testCustomer.prpAanmaningCcEmailAdres;                                   // CC e-mail address to send admonition to
            Customer.fpBevestigingEmailen = testCustomer.prpBevestigingEmailen;                                         // Sent confirmation email boolean
            Customer.fpBevestigingEmailAdres = testCustomer.prpBevestigingEmailAdres;                                   // E-mail address to send confimation to
            Customer.fpBevestigingCcEmailAdres = testCustomer.prpBevestigingCcEmailAdres;                               // CC e-mail address to send confirmation to
            Customer.fpCorrespondentieAdres = testCustomer.prpCorrespondentieAdres;                                     // Correspondence address
            Customer.fpCorrespondentieAdresContactPersoon = testCustomer.prpCorrespondentieAdresContactpersoon;         // Correspondence contact person
            Customer.fpCorrespondentieAdresAfwijkend = testCustomer.prpCorrespondentieAdresAfwijkend;                   // Alternative/deviating correspondence address
            Customer.fpCorrespondentieAdresLandID = testCustomer.prpCorrespondentieAdresLandID;                         // Correspondence address country ID
            Customer.fpCorrespondentieAdresPlaats = testCustomer.prpCorrespondentieAdresPlaats;                         // Correspondence address townname
            Customer.fpCorrespondentieAdresPostCode = testCustomer.prpCorrespondentieAdresPostcode;                     // Correspondence address ZIP code
            Customer.fpElektronischFactureren = testCustomer.prpElektronischFactureren;                                 // Boolean whether to send electronic invoice/bill
            Customer.fpFax = testCustomer.prpFax;                                                                       // Fax address
            Customer.fpFactuurEmailAdres = testCustomer.prpFactuurEmailAdres;                                           // E-mail address to send invoice/bill to
            Customer.fpFactuurCcEmailAdres = testCustomer.prpFactuurCcEmailAdres;                                       // CC e-mail address to send invoice/bill to
            Customer.fpFactuurKorting = testCustomer.prpFactuurKorting;                                                 // Invoice/bill discount
            Customer.fpIncasseren = testCustomer.prpIncasseren;                                                         // "Incasseren" means to cash, to collect money
            Customer.fpKredietLimiet = testCustomer.prpKredietLimiet;                                                   // Credit limit
            Customer.fpKredietTermijn = testCustomer.prpKrediettermijn;                                                 // Credit period
            Customer.fpKvkNummer = testCustomer.prpKvkNummer;                                                           // Chamber of Commerce number
            Customer.fpNonActiefGet = testCustomer.prpNonActiefGet;                                                     // Boolean whether customer is active/inactive "InActiveGet"
            Customer.fpOfferteEmailen = testCustomer.prpOfferteEmailen;                                                 //
            Customer.fpOfferteEmailAdres = testCustomer.prpOfferteEmailAdres;
            Customer.fpOfferteCcEmailAdres = testCustomer.prpOfferteCcEmailAdres;
            Customer.fpOpenstaandSaldo = testCustomer.prpOpenstaandSaldo;
            Customer.fpRekeningnummerBank2 = testCustomer.prpRekeningnummerBank2;
            Customer.fpRekeningnummerNaamHouder = testCustomer.prpRekeningnummerNaamHouder;
            Customer.fpRekeningnummerPlaatsHouder = testCustomer.prpRekeningnummerPlaatsHouder;
            Customer.fpRelatieCodeFactuurNaar = testCustomer.prpRelatieCodeFactuurNaar;
            Customer.fpUblBestandAlsBijlage = testCustomer.prpUblBestandAlsBijlage;
            Customer.fpVestigingAdres = testCustomer.prpVestigingAdres;
            Customer.fpVestigingAdresContactPersoon = testCustomer.prpVestigingAdresContactpersoon;
            Customer.fpVestigingAdresLandID = testCustomer.prpVestigingAdresLandID;
            Customer.fpVestigingAdresPlaats = testCustomer.prpVestigingAdresPlaats;
            Customer.fpVestigingAdresPostcode = testCustomer.prpVestigingAdresPostcode;
            Customer.fpWebSiteUrl = testCustomer.prpWebSiteUrl;

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
                listCustomer.fpRelatieCode = customer.prpRelatieCode;
                listCustomer.fpNaam = customer.prpNaam;
                listCustomer.fpEmail = customer.prpEmail;
                listCustomer.fpIban = customer.prpIban;
                listCustomer.fpCreditCardNummer2 = customer.prpCreditCardNummer2;
                listCustomer.fpTelefoon = customer.prpTelefoon;
                listCustomer.fpTelefoonMobiel = customer.prpTelefoonMobiel;
                listCustomer.fpMemo = customer.prpMemo;
                listCustomer.fpBic = customer.prpBic;
                listCustomer.fpBtwNummer = customer.prpBtwNummer;
                listCustomer.fpAanmanen = customer.prpAanmanen;
                listCustomer.fpAanmaningEmailen = customer.prpAanmaningEmailen;
                listCustomer.fpAanmaningEmailAdres = customer.prpAanmaningEmailAdres;
                listCustomer.fpAanmaningCcEmailAdres = customer.prpAanmaningCcEmailAdres;
                listCustomer.fpBevestigingEmailen = customer.prpBevestigingEmailen;
                listCustomer.fpBevestigingEmailAdres = customer.prpBevestigingEmailAdres;
                listCustomer.fpBevestigingCcEmailAdres = customer.prpBevestigingCcEmailAdres;
                listCustomer.fpCorrespondentieAdres = customer.prpCorrespondentieAdres;
                listCustomer.fpCorrespondentieAdresContactPersoon = customer.prpCorrespondentieAdresContactpersoon;
                listCustomer.fpCorrespondentieAdresAfwijkend = customer.prpCorrespondentieAdresAfwijkend;
                listCustomer.fpCorrespondentieAdresLandID = customer.prpCorrespondentieAdresLandID;
                listCustomer.fpCorrespondentieAdresPlaats = customer.prpCorrespondentieAdresPlaats;
                listCustomer.fpCorrespondentieAdresPostCode = customer.prpCorrespondentieAdresPostcode;
                listCustomer.fpElektronischFactureren = customer.prpElektronischFactureren;
                listCustomer.fpFax = customer.prpFax;
                listCustomer.fpFactuurEmailAdres = customer.prpFactuurEmailAdres;
                listCustomer.fpFactuurCcEmailAdres = customer.prpFactuurCcEmailAdres;
                listCustomer.fpFactuurKorting = customer.prpFactuurKorting;
                listCustomer.fpIncasseren = customer.prpIncasseren;
                listCustomer.fpKredietLimiet = customer.prpKredietLimiet;
                listCustomer.fpKredietTermijn = customer.prpKrediettermijn;
                listCustomer.fpKvkNummer = customer.prpKvkNummer;
                listCustomer.fpNonActiefGet = customer.prpNonActiefGet;
                listCustomer.fpOfferteEmailen = customer.prpOfferteEmailen;
                listCustomer.fpOfferteEmailAdres = customer.prpOfferteEmailAdres;
                listCustomer.fpOfferteCcEmailAdres = customer.prpOfferteCcEmailAdres;
                listCustomer.fpOpenstaandSaldo = customer.prpOpenstaandSaldo;
                listCustomer.fpRekeningnummerBank2 = customer.prpRekeningnummerBank2;
                listCustomer.fpRekeningnummerNaamHouder = customer.prpRekeningnummerNaamHouder;
                listCustomer.fpRekeningnummerPlaatsHouder = customer.prpRekeningnummerPlaatsHouder;
                listCustomer.fpRelatieCodeFactuurNaar = customer.prpRelatieCodeFactuurNaar;
                listCustomer.fpUblBestandAlsBijlage = customer.prpUblBestandAlsBijlage;
                listCustomer.fpVestigingAdres = customer.prpVestigingAdres;
                listCustomer.fpVestigingAdresContactPersoon = customer.prpVestigingAdresContactpersoon;
                listCustomer.fpVestigingAdresLandID = customer.prpVestigingAdresLandID;
                listCustomer.fpVestigingAdresPlaats = customer.prpVestigingAdresPlaats;
                listCustomer.fpVestigingAdresPostcode = customer.prpVestigingAdresPostcode;
                listCustomer.fpWebSiteUrl = customer.prpWebSiteUrl;
                customers.Add(listCustomer);
                x++;
            }
            return customers;
        }
    }
}
