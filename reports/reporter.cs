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

        public static IEnumerable<ReportByPerson> MakeReportsByPerson(IEnumerable<Person> people, IEnumerable<Property> properties)
        {
            var reportsByProperty = new List<ReportByPerson>();
            foreach (var person in people)
            {
                var propertiesOwned = properties.Where(property => property.OwnerDpi.Equals(person.Dpi)).ToList();
                double totalFee = propertiesOwned.Sum(p => p.ManteinanceFee);
                int totalProperties = properties.Count();
                double averageFee = Math.Round( totalFee / totalProperties, 2 );
                foreach (var property in propertiesOwned)
                {
                    reportsByProperty.Add(
                        new ReportByPerson(
                            person.Dpi,
                            person.Name,
                            person.LastName,
                            property.Number,
                            totalFee,
                            totalProperties,
                            averageFee
                            )
                        ) ;
                }
            }
            return reportsByProperty;
        }
    }
}
