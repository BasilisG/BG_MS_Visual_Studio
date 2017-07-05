using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmVehicleType : BaseViewModel
    {
        public Guid VehicleTypeID { get; set; }                      // ID 
        public string Code { get; set; }                            // ΚΩΔΙΚΟΣ
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ        
    }
}
