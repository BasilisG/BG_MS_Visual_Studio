using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmTrnServiceRow : BaseViewModel
    {
        public Guid TrnServiceRowID { get; set; }
        public Guid TrnServiceHeaderID { get; set; }
        public int LineNumber { get; set; }
        public Guid ItemTypeID { get; set; }
        public Guid ItemID { get; set; }
        public double QtyA { get; set; }
        public double UnitPrice { get; set; }
        public double GrossValue { get; set; }
        public double ItemDiscountPcnt { get; set; }
        public double ItemDiscountValue { get; set; }
        public double NetValue { get; set; }
        public Guid VatID { get; set; }
        public double VatValue { get; set; }
        public double VatPcnt { get; set; }
        public double TotalValue { get; set; }
        public string Comments { get; set; }
        public Guid UserID { get; set; }
    }
}
