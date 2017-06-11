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
    public class Proffesion : BaseEntity
    {

        public Proffesion()
        {
        }

        // Entity PROFFESION fields

        public Guid ProffesionID { get; set; }
        [MaxLength(200)]
        [Index("IDX_UNQ_Proffession_Descr", 1, IsUnique = true), Required]
        public string Description { get; set; }
        [Required]
        public Guid UserID { get; set; }
    }
        public static class ProffesionExtensions
        {
            public static  vmProffesion ToViewModel(this Proffesion rec)
            {
                return new vmProffesion
                {
                    ProffesionID = rec.ProffesionID,
                    Description = rec.Description,
                    UserID = rec.UserID
                };
            }

            public static Proffesion FromViewModel(this Proffesion rec, vmProffesion vm)
            {
                rec.ProffesionID = vm.ProffesionID;
                rec.Description = vm.Description;
                rec.UserID = vm.UserID;
                return rec;
            }
        }
   
}
