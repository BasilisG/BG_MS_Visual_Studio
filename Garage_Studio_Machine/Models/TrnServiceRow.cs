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
        { }

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

        public static class TrnServiceRowExtensions
        {
            public static vmTrnServiceRow ToViewModel(this TrnServiceRow rec)
            {
                return new vmTrnServiceRow
                {
                    TrnServiceRowID = rec.TrnServiceRowID,
                    TrnServiceHeaderID = rec.TrnServiceHeaderID,
                    LineNumber = rec.LineNumber,
                    ItemTypeID = rec.ItemTypeID,
                    ItemID = rec.ItemID,
                    QtyA = rec.QtyA,
                    UnitPrice = rec.UnitPrice,
                    ItemDiscountPcnt = rec.ItemDiscountPcnt,
                    ItemDiscountValue = rec.ItemDiscountValue,
                    NetValue = rec.NetValue,
                    VatID = rec.VatID,
                    VatValue = rec.VatValue,
                    VatPcnt = rec.VatPcnt,
                    TotalValue = rec.TotalValue,
                    Comments = rec.Comments,
                    UserID = rec.UserID
                };
            }

            public static TrnServiceRow FromViewModel(this TrnServiceRow rec, vmTrnServiceRow vm)
            {
                rec.TrnServiceRowID = vm.TrnServiceRowID;
                rec.TrnServiceHeaderID = vm.TrnServiceHeaderID;
                rec.LineNumber = vm.LineNumber;
                rec.ItemTypeID = vm.ItemTypeID;
                rec.ItemID = vm.ItemID;
                rec.QtyA = vm.QtyA;
                rec.UnitPrice = vm.UnitPrice;
                rec.ItemDiscountPcnt = vm.ItemDiscountPcnt;
                rec.ItemDiscountValue = vm.ItemDiscountValue;
                rec.NetValue = vm.NetValue;
                rec.VatID = vm.VatID;
                rec.VatValue = vm.VatValue;
                rec.VatPcnt = vm.VatPcnt;
                rec.TotalValue = vm.TotalValue;
                rec.Comments = vm.Comments;
                rec.UserID = vm.UserID;
                rec.Date_Ins = DateTime.Now;
                rec.Date_Upd = DateTime.Now;

                return rec;
            }
        }

   
}
