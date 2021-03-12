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
    class ReportsToJson
    {
        public static void SaveReportsByPerson(IEnumerable<ReportByPerson> reports)
        {
            string fileName = fileName = FileNames.ReportsByOwner;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using ( StreamWriter sw = new StreamWriter(fileName) )
            {
                sw.WriteAsync(JsonConvert.SerializeObject(reports));
            }
        }

        public static void SaveReportsByProperty(IEnumerable<ReportByProperty> reports)
        {
            string fileName = fileName = FileNames.ReportsByProperty;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteAsync(JsonConvert.SerializeObject(reports));
            }
        }

    }
}
