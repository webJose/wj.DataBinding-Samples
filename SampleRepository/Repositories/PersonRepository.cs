using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SampleRepository.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository.Repositories
{
    public static class PersonRepository
    {
        public static List<Person> GetAll(int? numRecords = null)
        {
            string url = "https://my.api.mockaroo.com/persons.json"
                + (numRecords.HasValue ? $"?records={numRecords.Value}" : String.Empty);
            HttpWebRequest wReq = WebRequest.Create(url) as HttpWebRequest;
            wReq.Headers.Add("X-API-Key", "aa939930");
            wReq.Accept = "application/json";
            string jsonData;
            using (WebResponse wr = wReq.GetResponse())
            {
                using (Stream s = wr.GetResponseStream())
                {
                    using (TextReader tr = new StreamReader(s))
                    {
                        jsonData = tr.ReadToEnd();
                    }
                }
            }
            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(jsonData, new JsonSerializerSettings()
            {
                ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new CustomPropertyNamingStrategy(new LowerCaseNameProvider())
                }
            });
            return persons;
        }
    }
}
