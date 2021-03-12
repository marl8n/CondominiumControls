using CondominiumControls.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CondominiumControls.persistance.FileNames;

namespace CondominiumControls.persistance.person
{
    class PersonsToJson
    {
        public static void Save(IEnumerable<Person> people)
        {

            if (File.Exists(PersonFile))
            {
                File.Delete(PersonFile);
            }

            using (StreamWriter sw = new StreamWriter(PersonFile))
            {
                sw.Write(JsonConvert.SerializeObject(people));
            }

        }
    }
}
