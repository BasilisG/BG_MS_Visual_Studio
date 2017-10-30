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
    public class TrnServiceHeader : BaseEntity
    {
		public TrnServiceHeader()
        {}

        // Entity TrnServiceHeader fields

		public Guid TrnServiceHeaderID { get; set; }
        [Index("IDX_TrnServiceHeader_Composite1", 3, IsUnique = false)]
        public DateTime DateTrnIssue { get; set; }
        [Required]
        public DateTime DateTrnIn { get; set; }
        public DateTime DateTrnOut { get; set; }
        public DateTime DateTrnPrint { get; set; }
        [Required]
        [Index("IDX_TrnServiceHeader_Composite1", 1, IsUnique = false)]
        public Guid CustomerID { get; set; }
        [Required]
        [Index("IDX_TrnServiceHeader_Composite1", 2, IsUnique = false)]
        public Guid VehicleID { get; set; }
        public int Kilometers { get; set; }
        [MaxLength(2048)]
        public string Comments { get; set; }
        [Required]
        public Guid UserID { get; set; }

        // 1:1 Relation [Navigation]
        public virtual Customer Customer { get; set; }     
        public virtual Vehicle Vehicle { get; set; }

        // 1:N Relation [Navigation]
        public virtual ICollection<TrnServiceRow> TrnServiceRows { get; set; }
    }
        
	public static class TrnServiceHeaderExtensions
    {
		public static vmTrnServiceHeader ToViewModel(this TrnServiceHeader rec)
        {
			return new vmTrnServiceHeader
			{
				TrnServiceHeaderID = rec.TrnServiceHeaderID,
				DateTrnIssue = rec.DateTrnIssue,
				DateTrnIn = rec.DateTrnIn,
				DateTrnOut = rec.DateTrnOut,
				DateTrnPrint = rec.DateTrnPrint,
				CustomerID = rec.CustomerID,
				VehicleID = rec.VehicleID,
				Kilometers = rec.Kilometers,
				Comments = rec.Comments,
				UserID = rec.UserID
            };
        }

		public static TrnServiceHeader FromViewModel(this TrnServiceHeader rec, vmTrnServiceHeader vm)
        {

            rec.TrnServiceHeaderID = vm.TrnServiceHeaderID;
			rec.DateTrnIssue = vm.DateTrnIssue;
			rec.DateTrnIn = vm.DateTrnIn;
			rec.DateTrnOut = vm.DateTrnOut;
			rec.DateTrnPrint = vm.DateTrnPrint;
			rec.CustomerID = vm.CustomerID;
			rec.VehicleID = vm.VehicleID;
			rec.Kilometers = vm.Kilometers;
			rec.Comments = vm.Comments;
            rec.UserID = vm.UserID;
            rec.Date_Ins = DateTime.Now;
            rec.Date_Upd = DateTime.Now;

            return rec;
        }
	}

	
}
