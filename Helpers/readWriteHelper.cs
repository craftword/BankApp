using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;


namespace Helpers
{
    public class ReadWriteHelper
    {
        public static void WriteJson(object Model, string PersonType)
        {
            string json = JsonConvert.SerializeObject(Model) + Environment.NewLine;

            File.AppendAllText($"C:/Users/craft/source/repos/BankApp/db/{PersonType}.json", json);

        }

        public static object ReadJson(string PersonType)
        {

            string readText = File.ReadAllText($"C:/Users/craft/source/repos/BankApp/db/{PersonType}.json");

            //RootObject json = JsonConvert.DeserializeObject<RootObject>(readText);
            //Console.WriteLine(json);
            ////return json;
            ///
            var objects = new List<RootObject>();

            var serializer = new JsonSerializer();

            using (var stringReader = new StringReader(readText))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;

                while (jsonReader.Read())
                {
                    var json = serializer.Deserialize<RootObject>(jsonReader);

                    objects.Add(json);
                }
            }

            return objects;
        }
    }
}