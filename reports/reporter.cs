using CondominiumControls.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.reports
{
    class reporter
    {
        public static IEnumerable<ReportByProperty> MakeReportsByProperty(IEnumerable<Person> people, IEnumerable<Property> properties)
        {
            var reportsByProperty = new List<ReportByProperty>();
            foreach ( var person in people )
            {
                var propertiesOwned = properties.Where(property => property.OwnerDpi.Equals(person.Dpi) ).ToList();
                foreach ( var property in propertiesOwned )
                {
                    reportsByProperty.Add(
                        new ReportByProperty(
                            person.Dpi,
                            person.Name,
                            person.LastName,
                            property.Number,
                            property.ManteinanceFee
                            )
                        );
                }
            }
            return reportsByProperty;
        }
    }
}
