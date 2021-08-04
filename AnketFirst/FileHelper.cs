using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketFirst
{
    class FileHelper: Form1
    {
        
        public static void JsonSerialization<Anket>(ref List<Anket> Ankets, string filename)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"Ankenname: {filename}"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, Ankets);
                }
            }
        }

        public static void JsonDeserialize<Anket>(ref List<Anket> Ankets, string filename)
        {
            Ankets = null;
            var serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader($"Ankenname: {filename}"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    Ankets = serializer.Deserialize<List<Anket>>(jr);
                }
               
            }

        }
    }
}
