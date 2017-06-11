using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmProffesion : BaseViewModel
    {
        public Guid ProffesionID { get; set; }                            // ID       
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ
        public Guid UserID { get; set; }                            // ID ΧΕΙΡΙΣΤΗ 
    }
}
