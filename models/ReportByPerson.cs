using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.models
{
    class ReportByPerson:Report
    {
        public double TotalManteinanceFee { get; set; }
        public int QuantityOfProperties { get; set; }
        public double AveragePropertiesFee { get; set; }
        public ReportByPerson()
        {

        }
        public ReportByPerson(string ownerDpim, string ownerName, string ownerLastName,
            int propertyNumber, double totalMantainanceFee, int properties = 1, double averageFee = 0.0)
        {
            this.OwnerDpi = ownerDpim;
            this.OwnerName = ownerName;
            this.OwnerLastName = ownerLastName;
            this.PropertyNumber = propertyNumber;
            this.TotalManteinanceFee = totalMantainanceFee;
            this.QuantityOfProperties = properties;
            this.AveragePropertiesFee = averageFee;
        }
    }
}
