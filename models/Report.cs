using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.models
{
    abstract class Report
    {
        public string OwnerDpi { get; set; }
        public string OwnerName { get; set; }
        public string OwnerLastName { get; set; }
        public int PropertyNumber { get; set; }
    }
}
