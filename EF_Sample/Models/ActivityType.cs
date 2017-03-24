using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Sample.Models
{
    [Table("ActivityTypes")]
    public class ActivityType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}
