using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmCustomer : BaseViewModel
    {
        public Guid CustomerID { get; set; }                // ID
        public string Code { get; set; }                    // ΚΩΔΙΚΟΣ
        public string TaxName { get; set; }                 // ΦΟΡΟΛΟΓΙΚΗ ΕΠΩΝΥΜΙΑ
        public string TaxNumber { get; set; }               // ΑΦΜ
        public string FirstName { get; set; }               // ΟΝΟΜΑ
        public string LastName { get; set; }                // ΕΠΩΝΥΜΟ
        public Guid ProffesionID { get; set; }              // ΕΠΑΓΓΕΛΜΑ ID
        public string AdrStreet { get; set; }               // ΟΔΟΣ
        public string AdrNumber { get; set; }               // ΑΡΙΘΜΟΣ
        public string AdrCity { get; set; }                 // ΠΟΛΗ
        public string AdrDistrict { get; set; }             // ΠΕΡΙΟΧΗ
        public string AdrZipCode { get; set; }              // ΤΚ
        public string AdrPhone1 { get; set; }               // ΤΗΛΕΦΩΝΟ 1
        public string AdrPhone2 { get; set; }               // ΤΗΛΕΦΩΝΟ 2
        public string AdrPhone3 { get; set; }               // ΤΗΛΕΦΩΝΟ 3
        public string AdrFax { get; set; }                  // FAX
        public string AdrEmail { get; set; }                // EMAIL
        public string Comment { get; set; }                 // ΣΧΟΛΙΑ
        public string AlertMessage { get; set; }            // ΜΗΝΥΜΑ ΓΙΑ ΤΙΣ ΚΙΝΗΣΕΙΣ
        public Guid UserID { get; set; }                    // ID ΧΕΙΡΙΣΤΗ 
    }
}
