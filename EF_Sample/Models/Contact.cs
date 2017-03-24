using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Sample.vwModels.ViewModels;

namespace EF_Sample.Models
{
    [Table("Contacts")]
    public class Contact : BaseViewModel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(255)]
        public string Comments { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }

    //________________________________________________________________________________________
    public static class ContactExtensions
    {
        //________________________________________________________________________________________
        public static vmContact ToViewModel(this Contact rec)
        {
            return new vmContact
            {
                ID = rec.ID,
                FirstName = rec.FirstName,
                LastName = rec.LastName,
                IsActive = rec.IsActive

            };
        }

        //________________________________________________________________________________________
        public static Contact FromViewModel(this Contact rec, vmContact vm)
        {
            rec.ID = vm.ID;
            rec.FirstName = vm.FirstName;
            rec.LastName = vm.LastName;
            rec.IsActive = vm.IsActive;
            return rec;            
        }
    }

}
