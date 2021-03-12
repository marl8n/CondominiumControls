using CondominiumControls.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.persistance.reports
{
    class JsonToReports
    {
        public static IEnumerable<ReportByPerson> GetReportsOrIEnumerableOfReportsByPerson()
        {
            var reports = new List<ReportByPerson>();
            string fileName = FileNames.ReportsByOwner;
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    reports = JsonConvert.DeserializeObject<List<ReportByPerson>>(sr.ReadToEnd());
                }
            }

            return reports;
        }

        public static IEnumerable<ReportByProperty> GetReportsOrIEnumerableOfReportsByProperty()
        {
            var reports = new List<ReportByProperty>();
            string fileName = FileNames.ReportsByProperty;
            
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    reports = JsonConvert.DeserializeObject<List<ReportByProperty>>(sr.ReadToEnd());
                }
            }

            return reports;
        }
    }
}
