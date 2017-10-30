using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmTrnServiceHeader : BaseViewModel
    {
        public Guid TrnServiceHeaderID { get; set; }
        public DateTime DateTrnIssue { get; set; }
        public DateTime DateTrnIn { get; set; }
        public DateTime DateTrnOut { get; set; }
        public DateTime DateTrnPrint { get; set; }
        public Guid CustomerID { get; set; }
        public Guid VehicleID { get; set; }
        public int Kilometers { get; set; }
        public string Comments { get; set; }
        public Guid UserID { get; set; }
    }
}
