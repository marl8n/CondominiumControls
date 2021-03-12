using CondominiumControls.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CondominiumControls.persistance.FileNames;

namespace CondominiumControls.persistance.property
{
    class PropertiesToJson
    {
        public static void Save(IEnumerable<Property> properties)
        {
            if ( File.Exists(PropertyFile) )
            {
                File.Delete(PropertyFile);
            }
            using (StreamWriter sr = new StreamWriter(PropertyFile))
            {
                sr.WriteAsync(JsonConvert.SerializeObject(properties));
            }
        }
    }
}
