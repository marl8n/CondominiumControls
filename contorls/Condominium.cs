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
        public static List<ReportByPerson> ReportsByPerson = JsonToReports.GetReportsOrIEnumerableOfReportsByPerson().ToList();
        public static List<ReportByProperty> ReportsByProperty = JsonToReports.GetReportsOrIEnumerableOfReportsByProperty().ToList();


        public static void GenerateReports()
        {
            ReportsByPerson = reports.reporter.MakeReportsByPerson(People, Properties).ToList();
            ReportsByProperty = reports.reporter.MakeReportsByProperty(People, Properties).ToList();
        }


        public static void SavePersons()
        {
            PersonsToJson.Save(People);
        }

        public static void SaveProperties()
        {
            PropertiesToJson.Save(Properties);
        }

        public static void SaveReports()
        {
            GenerateReports();
            ReportsToJson.SaveReportsByPerson(ReportsByPerson);
            ReportsToJson.SaveReportsByProperty(ReportsByProperty);
        }

        public static void SaveAll()
        {
            SavePersons();
            SaveProperties();
            SaveReports();
        }
    }
}
 