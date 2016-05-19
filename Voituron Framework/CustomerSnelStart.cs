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
        public int vfRelatieCode { get; set; }
        public string vfNaam { get; set; }
        public string vfEmail { get; set; }
        public string vfIban { get; set; }
        public string vfCreditCardNummer2 { get; set; }
        public string vfTelefoon { get; set; }
        public string vfTelefoonMobiel { get; set; }
        public string vfMemo { get; set; }
        public string vfBic { get; set; }
        public string vfBtwNummer { get; set; }
        public enmGWayAanmanen vfAanmanen { get; set; }
        public bool vfAanmaningEmailen { get; set; }
        public string vfAanmaningEmailAdres { get; set; }
        public string vfAanmaningCcEmailAdres { get; set; }
        public bool vfBevestigingEmailen { get; set; }
        public string vfBevestigingEmailAdres { get; set; }
        public string vfBevestigingCcEmailAdres { get; set; }
        public string vfCorrespondentieAdres { get; set; }
        public string vfCorrespondentieAdresContactPersoon { get; set; }
        public bool vfCorrespondentieAdresAfwijkend { get; set; }
        public int vfCorrespondentieAdresLandID { get; set; }
        public string vfCorrespondentieAdresPlaats { get; set; }
        public string vfCorrespondentieAdresPostCode { get; set; }
        public bool vfElektronischFactureren { get; set; }
        public string vfFactuurEmailAdres { get; set; }
        public string vfFactuurCcEmailAdres { get; set; }
        public decimal vfFactuurKorting { get; set; }
        public string vfFax { get; set; }
        public bool vfIncasseren { get; set; }
        public decimal vfKredietLimiet { get; set; }
        public int vfKredietTermijn { get; set; }
        public int vfKvkNummer { get; set; }
        public bool vfNonActiefGet { get; set; }
        public bool vfOfferteEmailen { get; set; }
        public string vfOfferteEmailAdres { get; set; }
        public string vfOfferteCcEmailAdres { get; set; }
        public decimal vfOpenstaandSaldo { get; set; }
        public decimal vfRekeningnummerBank2 { get; set; }
        public string vfRekeningnummerNaamHouder { get; set; }
        public string vfRekeningnummerPlaatsHouder { get; set; }
        public int vfRelatieCodeFactuurNaar { get; set; }
        public bool vfUblBestandAlsBijlage { get; set; }
        public string vfVestigingAdres { get; set; }
        public string vfVestigingAdresContactPersoon { get; set; }
        public int vfVestigingAdresLandID { get; set; }
        public string vfVestigingAdresPlaats { get; set; }
        public string vfVestigingAdresPostcode { get; set; }
        public string vfWebSiteUrl { get; set; }
    }
}
