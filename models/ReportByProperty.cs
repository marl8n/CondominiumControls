using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.models
{
    class ReportByProperty:Report
    {
        public double ManteinanceFee { get; set; }
        public ReportByProperty()
        {

        }
        public ReportByProperty(string ownerDpim, string ownerName, string ownerLastName, int propertyNumber, double mantainanceFee)
        {
            this.OwnerDpi = ownerDpim;
            this.OwnerName = ownerName;
            this.OwnerLastName = ownerLastName;
            this.PropertyNumber = propertyNumber;
            this.ManteinanceFee = mantainanceFee;
        }
    }
}
