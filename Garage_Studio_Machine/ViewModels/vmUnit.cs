using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels 
{
    public class vmUnit : BaseViewModel
    {
        public Guid UnitID { get; set; }                            // ID 
        public string Code { get; set; }                            // ΚΩΔΙΚΟΣ
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ
        public Guid UserID { get; set; }                            // ID ΧΕΙΡΙΣΤΗ 
    }
}
