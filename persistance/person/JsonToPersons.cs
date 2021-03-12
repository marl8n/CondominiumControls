using CondominiumControls.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumControls.persistance.person
{
    class JsonToPersons
    {
        public static IEnumerable<Person> GetPersonsOrNewIEnumerableOfPersons()
        {
            var Persons = new List<Person>();
            if (File.Exists(FileNames.PersonFile))
            {
                using ( StreamReader sr = new StreamReader(FileNames.PersonFile) )
                {
                    Persons = JsonConvert.DeserializeObject<List<Person>>(sr.ReadToEnd());
                }
            }
            return Persons;
        }
    }
}
