using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public abstract class BaseEntity
    {

        // [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[DefaultValue("getutcdate()")]
        public DateTime? Date_Ins { get; set; }       
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("getutcdate()")]        
        public DateTime? Date_Upd { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
