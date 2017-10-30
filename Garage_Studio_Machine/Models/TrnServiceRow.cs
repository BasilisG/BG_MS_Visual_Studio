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
    public class TrnServiceRow : BaseEntity
    {
        public TrnServiceRow()
        {}

        // Entity TrnServiceRow fields

        public Guid TrnServiceRowID { get; set; }
        public Guid TrnServiceHeaderID { get; set; }
        [Required]
        public int LineNumber { get; set; }
        [Required]
        public Guid ItemTypeID { get; set; }
        [Required]
        public Guid ItemID { get; set; }
        public double QtyA { get; set; }
        public double UnitPrice { get; set; }
        public double GrossValue { get; set; }
        public double ItemDiscountPcnt { get; set; }
        public double ItemDiscountValue { get; set; }
        public double NetValue { get; set; }
        [Required]
        public Guid VatID { get; set; }
        public double VatValue { get; set; }
        public double VatPcnt { get; set; }
        public double TotalValue { get; set; }
        public string Comments { get; set; }
        [Required]
        public Guid UserID { get; set; }

        // 1:1 Relation [Navigation]
        public virtual TrnServiceHeader TrnServiceHeader { get; set; }
        public virtual Item Item { get; set; }



    }
}
