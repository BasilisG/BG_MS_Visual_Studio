using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmVat : BaseViewModel
    {
        public Guid VatID { get; set; }                             // ID
        public string Code { get; set; }                            // Κωδικός
        public string Description { get; set; }                     // Περιγραφή
        public decimal VatRate_1 { get; set; }                      // Ποσοστό ΦΠΑ Κανονικό
        public decimal VatRate_2 { get; set; }                      // Ποσοστό ΦΠΑ Μειωμένο
        public decimal VatRate_3 { get; set; }                      // Ποσοστό ΦΠΑ άλλο
        public Guid UserID { get; set; }                            // ID ΧΕΙΡΙΣΤΗ 
    }
}
