using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace GUI
{
    class Extension
    {
        [JsonProperty("extensions")]
        public string extensions { get; set; }

        [JsonProperty("foldername")]
        public string foldername { get; set; }

        [JsonProperty("exceptions")]
        public string exceptions { get; set; }


        public Extension(){}

        public Extension(string ext, string fo, string excp)
        {
            extensions = ext;
            foldername = fo;
            exceptions = excp;
        }

        public bool create(Extension ext)
        {
            string json_path = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)).ToString() + "\\Program Files (x86)\\PFO\\Extensions\\extensions.json";
            try {
                List<Extension> list = new List<Extension>() { };
                string json = String.Empty;

                using (StreamReader r = new StreamReader(json_path))
                {
                    json = r.ReadToEnd();
                }

                list = JsonConvert.DeserializeObject<List<Extension>>(json);
                list.Add(ext);
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);                
                File.WriteAllText(json_path, convertedJson);
                return true;
            }
            catch (Exception ex)
            {
                return false;                
            }
        }

        public bool change(Extension exp, int index)
        {
            string json_path = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)).ToString() + "\\Program Files (x86)\\PFO\\Extensions\\extensions.json";
            try
            {
                List<Extension> list = new List<Extension>() { };
                string json = String.Empty;

                using (StreamReader r = new StreamReader(json_path))
                {
                    json = r.ReadToEnd();
                }

                list = JsonConvert.DeserializeObject<List<Extension>>(json);

                list[index] = exp;
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(json_path, convertedJson);
                return true;
            }
            catch (Exception)
            {
                return false;
            }           
        }

        public bool delete(int index)
        {
            string json_path = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)).ToString() + "\\Program Files (x86)\\PFO\\Extensions\\extensions.json";
            List<Extension> list = new List<Extension>() { };
            string json = String.Empty;

            using (StreamReader r = new StreamReader(json_path))
            {
                json = r.ReadToEnd();
            }

            list = JsonConvert.DeserializeObject<List<Extension>>(json);

            list.RemoveAt(index);
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(json_path, convertedJson);

            return false;
        }

        public override string ToString()
        {
            return $"extensions: {extensions}\nfolder name: {foldername}\nexceptions: {exceptions}";
        }

    }
}
