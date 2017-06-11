using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
        public class BaseViewModel
        {
            public bool Deleted { get; set; }
            public string ErrorMessage { get; set; }
            public Nullable<RecordMode> RowStatus { get; set; }          //0:Unchanged, 1:Added, 2:Modified, 3:Deleted
            public Nullable<bool> Selected { get; set; }
            public object Tag { get; set; }
        }

        public enum RecordMode { Unchanged = 0, Added, Modified, Deleted, ViewOnly }
}
