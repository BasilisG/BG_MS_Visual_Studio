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
    public class Customer : BaseEntity
    {

        public Customer()
        { }

        // Entity CUSTOMER fields

        public Guid CustomerID { get; set; }                // ID
        [MaxLength(50)]
        [Index("IDX_UNQ_Customer_Code", 1, IsUnique = true), Required]
        public string Code { get; set; }                    // ΚΩΔΙΚΟΣ
        [MaxLength(200)]
        public string TaxName { get; set; }                 // ΦΟΡΟΛΟΓΙΚΗ ΕΠΩΝΥΜΙΑ
        [MaxLength(20)]
        public string TaxNumber { get; set; }               // ΑΦΜ
        [MaxLength(100)]
        public string FirstName { get; set; }               // ΟΝΟΜΑ
        [MaxLength(100)]
        public string LastName { get; set; }                // ΕΠΩΝΥΜΟ
        public Guid ProffesionID { get; set; }              // ΕΠΑΓΓΕΛΜΑ ID
        [MaxLength(100)]
        public string AdrStreet { get; set; }               // ΟΔΟΣ
        [MaxLength(20)]
        public string AdrNumber { get; set; }               // ΑΡΙΘΜΟΣ
        [MaxLength(100)]
        public string AdrCity { get; set; }                 // ΠΟΛΗ
        [MaxLength(100)]
        public string AdrDistrict { get; set; }             // ΠΕΡΙΟΧΗ
        [MaxLength(20)]
        public string AdrZipCode { get; set; }              // ΤΚ
        [MaxLength(50)]
        public string AdrPhone1 { get; set; }               // ΤΗΛΕΦΩΝΟ 1
        [MaxLength(50)]
        public string AdrPhone2 { get; set; }               // ΤΗΛΕΦΩΝΟ 2
        [MaxLength(50)]
        public string AdrPhone3 { get; set; }               // ΤΗΛΕΦΩΝΟ 3
        [MaxLength(50)]
        public string AdrFax { get; set; }                  // FAX
        [MaxLength(100)]
        public string AdrEmail { get; set; }                // EMAIL
        [MaxLength(500)]
        public string Comment { get; set; }                 // ΣΧΟΛΙΑ
        [MaxLength(500)]
        public string AlertMessage { get; set; }            // ΜΗΝΥΜΑ ΓΙΑ ΤΙΣ ΚΙΝΗΣΕΙΣ
        [Required]
        public Guid UserID { get; set; }                    // ID ΧΕΙΡΙΣΤΗ 

        // One to One Relation [Navigation]
        public Proffesion Proffesion { get; set; }        
    }

    public static class CustomerExtensions
    {
        public static vmCustomer ToViewModel(this Customer rec)
        {
            return new vmCustomer
            {
                CustomerID = rec.CustomerID,
                Code = rec.Code,
                TaxName = rec.TaxName,
                TaxNumber = rec.TaxNumber,
                FirstName = rec.FirstName,
                LastName = rec.LastName,
                ProffesionID = rec.ProffesionID,
                AdrStreet = rec.AdrStreet,
                AdrNumber = rec.AdrNumber,
                AdrCity = rec.AdrCity,
                AdrDistrict = rec.AdrDistrict,
                AdrZipCode = rec.AdrZipCode,
                AdrPhone1 = rec.AdrPhone1,
                AdrPhone2 = rec.AdrPhone2,
                AdrPhone3 = rec.AdrPhone3,
                AdrFax = rec.AdrFax,
                AdrEmail = rec.AdrEmail,
                Comment = rec.Comment,
                AlertMessage = rec.AlertMessage,
                UserID = rec.UserID
            };
        }

        public static Customer FromViewModel(this Customer rec, vmCustomer vm)
        {
            rec.CustomerID = vm.CustomerID;
            rec.Code  = vm.Code;
            rec.TaxName = vm.TaxName;
            rec.TaxNumber = vm.TaxNumber;
            rec.FirstName = vm.FirstName;
            rec.LastName = vm.LastName;
            rec.ProffesionID = vm.ProffesionID;
            rec.AdrStreet = vm.AdrStreet;
            rec.AdrNumber = vm.AdrNumber;
            rec.AdrCity = vm.AdrCity;
            rec.AdrDistrict = vm.AdrDistrict;
            rec.AdrZipCode = vm.AdrZipCode;
            rec.AdrPhone1 = vm.AdrPhone1;
            rec.AdrPhone2 = vm.AdrPhone2;
            rec.AdrPhone3 = vm.AdrPhone3;
            rec.AdrFax = vm.AdrFax;
            rec.AdrEmail = vm.AdrEmail;
            rec.Comment = vm.Comment;
            rec.AlertMessage = vm.AlertMessage;
            rec.UserID = vm.UserID;
            return rec;
        }
    }
}
