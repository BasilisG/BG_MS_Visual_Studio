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
    public class Item : BaseEntity
    {
        public Item()
        {
            isActive = true;
        }

        // Entity ITEM Fields

        public Guid ItemID { get; set; }                            // ID     
        [MaxLength(50)]
        [Index("IDX_UNQ_Item_Code", 1, IsUnique = true), Required]
        public string Code { get; set; }                            // ΚΩΔΙΚΟΣ
        [Required, MaxLength(200)]
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ
        [Required]
        public Boolean isActive { get; set; }                       // ΕΙΝΑΙ ΕΝΕΡΓΟ
        [Required]
        public Guid ItemTypeID { get; set; }                           // ΤΥΠΟΣ ΕΙΔΟΥΣ 1-ΚΑΝΟΝΙΚΟ , 2 - ΥΠΗΡΕΣΙΑ
        [Required]
        public Guid UnitID { get; set; }                            // ID ΜΟΝΑΔΑΣ ΜΕΤΡΗΣΗΣ
        [Required]
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
        [MaxLength(100)]
        public string GroupCode { get; set; }                       // ΚΩΔΙΚΟΣ ΟΜΑΔΟΠΟΙΗΣΗΣ
        [MaxLength(100)]
        public string RefCode { get; set; }                         // ΚΩΔΙΚΟΣ ΑΝΑΦΟΡΑΣ
        [MaxLength(50)]
        public string Barcode1 { get; set; }                        // BARCODE 1
        [MaxLength(50)]
        public string Barcode2 { get; set; }                        // BARCODE 2
        [MaxLength(50)]
        public string Barcode3 { get; set; }                        // BARCODE 3
        [Required]
        public Guid UserID { get; set; }                            // ID ΧΕΙΡΙΣΤΗ 

        // One to One Relation [Navigation]     
        public Unit Unit { get; set; }
        public Vat Vat { get; set; }
        public ItemType ItemType { get; set; }
    }

    public static class ItemExtensions
    {
        public static vmItem ToViewModel(this Item rec)
        {
            return new vmItem
            {
                ItemID = rec.ItemID,
                Code = rec.Code,
                Description = rec.Description,
                isActive = rec.isActive,
                ItemTypeID = rec.ItemTypeID,
                UnitID = rec.UnitID,
                VatID = rec.VatID,
                CostPrice = rec.CostPrice,
                LastCostPrice = rec.LastCostPrice,
                GrossPrice = rec.GrossPrice,
                RetailPrice = rec.RetailPrice,
                Pricce2 = rec.Pricce2,
                Pricce3 = rec.Pricce3,
                Pricce4 = rec.Pricce4,
                Pricce5 = rec.Pricce5,
                ItemDiscount = rec.ItemDiscount,
                ItemMaxDiscount = rec.ItemMaxDiscount,
                Comments = rec.Comments,
                AlertMessage = rec.AlertMessage,
                BrandNameID = rec.BrandNameID,
                GroupCode = rec.GroupCode,
                RefCode = rec.RefCode,
                Barcode1 = rec.Barcode1,
                Barcode2 = rec.Barcode2,
                Barcode3 = rec.Barcode3,
                UserID = rec.UserID
            };
        }

        public static Item FromViewModel(this Item rec, vmItem vm)
        {
                rec.ItemID = vm.ItemID;
                rec.Code = vm.Code;
                rec.Description = vm.Description;
                rec.isActive = vm.isActive;
                rec.ItemTypeID = vm.ItemTypeID;
                rec.UnitID = vm.UnitID;
                rec.VatID = vm.VatID;
                rec.CostPrice = vm.CostPrice;
                rec.LastCostPrice = vm.LastCostPrice;
                rec.GrossPrice = vm.GrossPrice;
                rec.RetailPrice = vm.RetailPrice;
                rec.Pricce2 = vm.Pricce2;
                rec.Pricce3 = vm.Pricce3;
                rec.Pricce4 = vm.Pricce4;
                rec.Pricce5 = vm.Pricce5;
                rec.ItemDiscount = vm.ItemDiscount;
                rec.ItemMaxDiscount = vm.ItemMaxDiscount;
                rec.Comments = vm.Comments;
                rec.AlertMessage = vm.AlertMessage;
                rec.BrandNameID = vm.BrandNameID;
                rec.GroupCode = vm.GroupCode;
                rec.RefCode = vm.RefCode;
                rec.Barcode1 = vm.Barcode1;
                rec.Barcode2 = vm.Barcode2;
                rec.Barcode3 = vm.Barcode3;
                rec.UserID = vm.UserID;
                rec.Date_Ins = DateTime.Now;
                rec.Date_Upd = DateTime.Now;
            return rec;
        }

    }
}
