using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels;

namespace Models
{
    public class Vat : BaseEntity
    {

        public Vat()
        {
        }

        // Entity VAT fields
        public Guid VatID { get; set; }                             // ID
        [MinLength(3), MaxLength(50)]
        [Index("IDX_UNQ_Vat_Code", 1, IsUnique = true), Required]
        public string Code { get; set; }                            // Κωδικός
        [MinLength(3), MaxLength(200)]
        [Required]
        public string Description { get; set; }                     // Περιγραφή
        [Required]
        public decimal VatRate_1 { get; set; }                      // Ποσοστό ΦΠΑ Κανονικό
        public decimal VatRate_2 { get; set; }                      // Ποσοστό ΦΠΑ Μειωμένο
        public decimal VatRate_3 { get; set; }                      // Ποσοστό ΦΠΑ άλλο
        [Required]
        public Guid UserID { get; set; }                            // ID ΧΕΙΡΙΣΤΗ 
    }

    public static class VatExtensions
    {
        public static vmVat ToViewModel(this Vat rec)
        {
            return new vmVat
            {
                VatID = rec.VatID,
                Code = rec.Code,
                Description = rec.Description,
                VatRate_1 = rec.VatRate_1,
                VatRate_2 = rec.VatRate_2,
                VatRate_3 = rec.VatRate_3,
                UserID = rec.UserID
            };
        }

        public static Vat FromViewModel(this Vat rec, vmVat vm)
        {
            rec.VatID = vm.VatID;
            rec.Code = vm.Code;
            rec.Description = vm.Description;
            rec.VatRate_1 = vm.VatRate_1;
            rec.VatRate_2 = vm.VatRate_2;
            rec.VatRate_3 = vm.VatRate_3;
            rec.UserID = vm.UserID;
            rec.Date_Ins = DateTime.Now;            
            rec.Date_Upd = DateTime.Now;
            return rec;
        }
    }
}
