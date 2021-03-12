using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CondominiumControls.persistance
{
    class FileNames
    {
        public static string localFile = "";
        public static string PersonFile = localFile + "persons.json";
        public static string PropertyFile = localFile + "properties.json";
        public static string ReportsByProperty = localFile + "reportsByProperty.json";
        public static string ReportsByOwner = localFile + "reportsByOwner.json";
    }
}
