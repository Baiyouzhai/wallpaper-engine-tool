using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallpaper.Data;

namespace Wallpaper.Util {

    public class JsonUtil {

        public static object Json2Object(object data) {
            if (data is string str) {
                try {
                    object temp = JsonConvert.DeserializeObject(str);
                    return temp is string ? temp : Json2Object(temp);
                } catch (Exception e) {
                    // throw e;
                    return str;
                }
            }
            if (data is List<object> list) return list.Select(Json2Object).ToList();
            if (data is Dictionary<string, object> dictionary) return dictionary.ToMap(kv => kv.Key, kv => Json2Object(kv.Value));
            if (data is JToken token) return JToken2Object(token);
            return data;
        }

        public static object JToken2Object(JToken token) {
            if (token is JValue val) return val.Value;
            if (token is JProperty prop) return new HashMap<string, object> { { prop.Name, JToken2Object(prop.Value) } };
            if (token is JArray array) return array.Select(item => JToken2Object(item)).ToList();
            if (token is JObject obj) return obj.Children<JProperty>().ToMap(item => item.Name, item => JToken2Object(item.Value));
            return token;
        }

        public static HashMap<string, object> JsonFile2HashMap(string filePath) {
            HashMap<string, object> map = null;
            using (StreamReader sr = File.OpenText(filePath)) {
                string jsonString = sr.ReadToEnd();
                map = Json2Object(jsonString) as HashMap<string, object>;
            }
            return map;
        }

        public static T JsonFile2Object<T>(string filePath) {
            using (StreamReader sr = File.OpenText(filePath)) {
                string str = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(str);
            }
        }

        public static void HashMap2File(HashMap<string, object> map, string filePath) {
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8)) {
                sw.AutoFlush = true;
                string jsonString = JsonConvert.SerializeObject(map, Formatting.Indented);
                sw.WriteLine(jsonString);
            }
        }

        public static void Json2File(object data, string filePath) {
            FileInfo file = new FileInfo(filePath);
            if (!file.Directory.Exists) file.Directory.Create();
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8)) {
                sw.AutoFlush = true;
                string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
                sw.WriteLine(jsonString);
            }
        }

        public static string Object2Json(object obj) {
            return JsonConvert.SerializeObject(obj);
        }

    }

}
