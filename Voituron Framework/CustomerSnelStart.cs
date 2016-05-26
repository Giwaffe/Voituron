using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public class CustomerSnelStart
    {
        // All properties of our framework for Customers. "fp" stands for Framework Property.
        public int fpRelatieCode { get; set; }
        public string fpNaam { get; set; }
        public string fpEmail { get; set; }
        public string fpIban { get; set; }
        public string fpCreditCardNummer2 { get; set; }
        public string fpTelefoon { get; set; }
        public string fpTelefoonMobiel { get; set; }
        public string fpMemo { get; set; }
        public string fpBic { get; set; }
        public string fpBtwNummer { get; set; }
        public enmGWayAanmanen fpAanmanen { get; set; }
        public bool fpAanmaningEmailen { get; set; }
        public string fpAanmaningEmailAdres { get; set; }
        public string fpAanmaningCcEmailAdres { get; set; }
        public bool fpBevestigingEmailen { get; set; }
        public string fpBevestigingEmailAdres { get; set; }
        public string fpBevestigingCcEmailAdres { get; set; }
        public string fpCorrespondentieAdres { get; set; }
        public string fpCorrespondentieAdresContactPersoon { get; set; }
        public bool fpCorrespondentieAdresAfwijkend { get; set; }
        public int fpCorrespondentieAdresLandID { get; set; }
        public string fpCorrespondentieAdresPlaats { get; set; }
        public string fpCorrespondentieAdresPostCode { get; set; }
        public bool fpElektronischFactureren { get; set; }
        public string fpFactuurEmailAdres { get; set; }
        public string fpFactuurCcEmailAdres { get; set; }
        public decimal fpFactuurKorting { get; set; }
        public string fpFax { get; set; }
        public bool fpIncasseren { get; set; }
        public decimal fpKredietLimiet { get; set; }
        public int fpKredietTermijn { get; set; }
        public int fpKvkNummer { get; set; }
        public bool fpNonActiefGet { get; set; }
        public bool fpOfferteEmailen { get; set; }
        public string fpOfferteEmailAdres { get; set; }
        public string fpOfferteCcEmailAdres { get; set; }
        public decimal fpOpenstaandSaldo { get; set; }
        public decimal fpRekeningnummerBank2 { get; set; }
        public string fpRekeningnummerNaamHouder { get; set; }
        public string fpRekeningnummerPlaatsHouder { get; set; }
        public int fpRelatieCodeFactuurNaar { get; set; }
        public bool fpUblBestandAlsBijlage { get; set; }
        public string fpVestigingAdres { get; set; }
        public string fpVestigingAdresContactPersoon { get; set; }
        public int fpVestigingAdresLandID { get; set; }
        public string fpVestigingAdresPlaats { get; set; }
        public string fpVestigingAdresPostcode { get; set; }
        public string fpWebSiteUrl { get; set; }
    }
}
