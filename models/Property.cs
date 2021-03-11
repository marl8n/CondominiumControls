using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.models
{
    class Property
    {
        public int Number { get; set; }
        public string OwnerDpi { get; set; }
        public double ManteinanceFee { get; set; }
        public Property()
        {

        }
        public Property(int number, string ownerDpi, double manteinanceFee)
        {
            this.Number = number;
            this.OwnerDpi = ownerDpi;
            this.ManteinanceFee = manteinanceFee;
        }
    }
}
