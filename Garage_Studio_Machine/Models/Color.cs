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
    public class Color : BaseEntity
    {
        public Color() 
        {}

        // Entity COLOR Fields 

        public Guid ColorID { get; set; }                            // ID 
        [MaxLength(50)]
        [Index("IDX_Color_Descr", 1, IsUnique = true), Required]        
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ
    }

    public static class ColorExtensions
    {
        public static vmColor ToViewModel(this Color rec)
        {
            return new vmColor
            {
                ColorID = rec.ColorID,
                Description = rec.Description
            };
        }

        public static Color FromViewModel(this Color rec,vmColor vm)
        {
            rec.ColorID = vm.ColorID;
            rec.Description = vm.Description;
            return rec;
        }
    }


}
