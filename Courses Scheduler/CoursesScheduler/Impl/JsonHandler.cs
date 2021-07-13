using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CoursesScheduler.Impl {
    public class JsonHandler {

        private const string _JsonFile = "UniversityData.json";

        public JavaScriptSerializer serializer { get; set; }
        public string path { get; set; }
        public string data { get; set; }
        public University MyUniversity = new University();

        public JsonHandler() {
            serializer = new JavaScriptSerializer();
        }


        public void SerializeToJson(University objectToBeSerialized) {

            data = serializer.Serialize(objectToBeSerialized);

            path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            File.WriteAllText(path, data);
        }


        public University DeserializeFromJson() {

            path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            if (File.Exists(path)) {
                data = File.ReadAllText(path);
            }
            else {
                File.Create(path).Dispose();
                SerializeToJson(MyUniversity);
            }

            

            MyUniversity = serializer.Deserialize<University>(data);

            return MyUniversity;

        }

    }
}
