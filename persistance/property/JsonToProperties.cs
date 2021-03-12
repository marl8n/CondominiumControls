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
    class JsonToProperties
    {
        public static IEnumerable<Property> GetPropertiesOrIEnumerableOfProperty()
        {
            var properties = new List<Property>();
            if (File.Exists(PropertyFile))
            {
                using (StreamReader sr = new StreamReader(PropertyFile))
                {
                    properties = JsonConvert.DeserializeObject<List<Property>>(sr.ReadToEnd());
                }
            }
            return properties;
        }
    }
}
