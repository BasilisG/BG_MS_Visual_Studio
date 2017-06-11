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
    public class Unit : BaseEntity 
    {

        public Unit()
        { }

        // Entity UNIT fields

        public Guid UnitID { get; set; }                            // ID 
        [MinLength(3), MaxLength(50)]
        [Index("IDX_Unit_Code", 1, IsUnique = true), Required]
        public string Code { get; set; }                            // ΚΩΔΙΚΟΣ
        [Required, MinLength(4), MaxLength(200)]
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ
        [Required]
        public Guid UserID { get; set; }                            // ID ΧΕΙΡΙΣΤΗ 
    }

    public static class UnitExtensions
    {
        public static vmUnit ToViewModel(this Unit rec)
        {
            return new vmUnit
            {
                UnitID = rec.UnitID,
                Code = rec.Code,
                Description = rec.Description
            };
        }

        public static Unit FromViewModel(this Unit rec, vmUnit vm)
        {
            rec.UnitID = vm.UnitID;
            rec.Code = vm.Code;
            rec.Description = vm.Description;
            return rec;
        }
    }
}
