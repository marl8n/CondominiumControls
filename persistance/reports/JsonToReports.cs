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
        public static IEnumerable<Report> GetReportsOrIEnumerableOfReports( bool isOwner )
        {
            var reports = new List<Report>();
            string fileName = FileNames.ReportsByProperty;
            if ( isOwner)
            {
                fileName = FileNames.ReportsByOwner;
            }
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    reports = JsonConvert.DeserializeObject<List<Report>>(sr.ReadToEnd());
                }
            }

            return reports;
        }
    }
}
