using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Sample.Models
{
    [Table("Activities")]
    public class Activity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }
        public DateTime DateInserted { get; set; }
        public int  ActivityTypeID { get; set; }
        public Guid ContactID { get; set; }
        [MaxLength(255)]
        public string Comments { get; set; }

        [ForeignKey("ActivityTypeID")]
        public virtual ActivityType ActivityType { get; set; }

        [ForeignKey("ContactID")]
        public virtual Contact Contact { get; set; }
    }
}
