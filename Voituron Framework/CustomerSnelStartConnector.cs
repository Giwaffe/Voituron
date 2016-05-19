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
        public static CustomerSnelStart Get(int Id)
        {
            var Customer = new CustomerSnelStart();

            clsGWaySnelStart test = new clsGWaySnelStart();
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");

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
    }
}
