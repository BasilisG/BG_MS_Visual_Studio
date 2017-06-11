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
    public class ItemType : BaseEntity
    {
        public ItemType()
        { }

        // Entity ITEM TYPE Fields ( Stock or Service )

        public Guid ItemTypeID { get; set; }                            // ID 
        [MaxLength(50)]
        [Index("IDX_ItemType_Code", 1, IsUnique = true), Required]
        public string Code { get; set; }                            // ΚΩΔΙΚΟΣ
        [Required, MinLength(4), MaxLength(100)]
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ
    }

    public static class ItemTypeExtensions
    {
        public static vmItemType ToViewModel(this ItemType rec)
        {
            return new vmItemType
            {
                ItemTypeID = rec.ItemTypeID,
                Code = rec.Code,
                Description = rec.Description
            };
        }

        public static ItemType FromViewModel(this ItemType rec, vmItemType vm)
        {
            rec.ItemTypeID = vm.ItemTypeID;
            rec.Code = vm.Code;
            rec.Description = vm.Description;
            return rec;
        }
    }

}
