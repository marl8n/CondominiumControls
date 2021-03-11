using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.models
{
    class Person
    {
        public string Dpi { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person()
        {

        }
        public Person(string dpi, string name, string lastName)
        {
            this.Dpi = dpi;
            this.Name = name;
            this.LastName = lastName;
        }
    }
}
