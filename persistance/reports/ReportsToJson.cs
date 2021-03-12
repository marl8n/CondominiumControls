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
        public static void save(IEnumerable<Report> reports, bool isOwner)
        {
            string fileName = FileNames.ReportsByProperty;
            if ( isOwner )
            {
                fileName = FileNames.ReportsByOwner;
            }

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using ( StreamWriter sw = new StreamWriter(fileName) )
            {
                sw.WriteAsync(JsonConvert.SerializeObject(reports));
            }
        }
    }
}
