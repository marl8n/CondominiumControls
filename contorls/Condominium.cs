using CondominiumControls.models;
using CondominiumControls.persistance.person;
using CondominiumControls.persistance.property;
using CondominiumControls.persistance.reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.contorls
{
    class Condominium
    {
        public static List<Person> People = JsonToPersons.GetPersonsOrNewIEnumerableOfPersons().ToList();
        public static List<Property> Properties = JsonToProperties.GetPropertiesOrIEnumerableOfProperty().ToList();
        public static List<Report> ReportsByPerson = JsonToReports.GetReportsOrIEnumerableOfReports(true).ToList();
        public static List<Report> ReportsByProperty = JsonToReports.GetReportsOrIEnumerableOfReports(false).ToList();
    }
}
