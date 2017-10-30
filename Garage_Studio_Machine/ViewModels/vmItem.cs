using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmItem : BaseViewModel
    {
        public Guid ItemID { get; set; }                            // ID     
        public string Code { get; set; }                            // ΚΩΔΙΚΟΣ
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ
        public Boolean isActive { get; set; }                       // ΕΙΝΑΙ ΕΝΕΡΓΟ
        public Guid ItemTypeID { get; set; }                        // ΤΥΠΟΣ ΕΙΔΟΥΣ 1-ΚΑΝΟΝΙΚΟ , 2 - ΥΠΗΡΕΣΙΑ
        public Guid UnitID { get; set; }                            // ID ΜΟΝΑΔΑΣ ΜΕΤΡΗΣΗΣ
        public Guid VatID { get; set; }                             // ID ΚΑΤΗΓΟΡΙΑΣ ΦΠΑ
        public double CostPrice { get; set; }                       // ΤΙΜΗ ΚΟΣΤΟΥΣ ΑΝΑΦΟΡΑΣ
        public double LastCostPrice { get; set; }                   // ΤΕΛΕΥΤΑΙΑ ΤΙΜΗ ΑΓΟΡΑΣ
        public double GrossPrice { get; set; }                      // ΤΙΜΗ ΧΟΝΔΡΙΚΗΣ
        public double RetailPrice { get; set; }                     // ΤΙΜΗ ΛΙΑΝΙΚΗΣ
        public double Pricce2 { get; set; }                         // ΤΙΜΗ 2
        public double Pricce3 { get; set; }                         // ΤΙΜΗ 3
        public double Pricce4 { get; set; }                         // ΤΙΜΗ 4
        public double Pricce5 { get; set; }                         // ΤΙΜΗ 51
        public double ItemDiscount { get; set; }                    // ΕΚΠΤΩΣΗ ΕΙΔΟΥΣ
        public double ItemMaxDiscount { get; set; }                 // ΜΕΓΙΣΤΗ ΕΚΠΤΩΣΗ ΕΙΔΟΥΣ
        public string Comments { get; set; }                        // ΣΧΟΛΙΑ ΕΙΔΟΥΣ
        public string AlertMessage { get; set; }                    // ΜΥΝΗΜΑ ΤΙΜΟΛΟΓΗΣΗΣ
        public Guid BrandNameID { get; set; }                       // ID ΟΙΚΟΥ
        public string GroupCode { get; set; }                       // ΚΩΔΙΚΟΣ ΟΜΑΔΟΠΟΙΗΣΗΣ
        public string RefCode { get; set; }                         // ΚΩΔΙΚΟΣ ΑΝΑΦΟΡΑΣ
        public string Barcode1 { get; set; }                        // BARCODE 1
        public string Barcode2 { get; set; }                        // BARCODE 2
        public string Barcode3 { get; set; }                        // BARCODE 3
        public Guid UserID { get; set; }                            // ID ΧΕΙΡΙΣΤΗ 
    }
}
