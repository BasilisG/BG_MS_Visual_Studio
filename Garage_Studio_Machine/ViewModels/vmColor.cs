using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmColor : BaseViewModel
    {
        public Guid ColorID { get; set; }                            // ID 
        public string Description { get; set; }                     // ΠΕΡΙΓΡΑΦΗ        
    }
}
