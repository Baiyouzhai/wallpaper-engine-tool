using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Data {

    public static class DictionaryExtend {

        public static DataTable ToDataTable<T>(this List<T> list) where T : class {
            Type type = typeof(T);
            DataTable dataTable = new DataTable();
            PropertyInfo[] propertyInfos = type.GetProperties();
            List<PropertyInfo> propertyMapping = new List<PropertyInfo>();
            foreach (PropertyInfo propertyInfo in propertyInfos) {
                Type declaringType = propertyInfo.PropertyType;
                if (declaringType.IsPrimitive || declaringType == typeof(string)) {
                    propertyMapping.Add(propertyInfo);
                    dataTable.Columns.Add(propertyInfo.Name, declaringType);
                }
            }
            if (null != list && list.Count > 0) {
                foreach (T temp in list) {
                    object[] values = propertyMapping.Select(property => property.GetValue(temp)).ToArray();
                    dataTable.Rows.Add(values);
                }
            }
            return dataTable;
        }

        public static DataTable ToDataTable(this List<Dictionary<string, object>> list) {
            DataTable dataTable = new DataTable();
            if (null != list && list.Count > 0) {
                HashSet<string> names = new HashSet<string>();
                foreach (Dictionary<string, object> map in list) {
                    string[] keys = map.Keys.ToArray();
                    foreach (string key in keys) {
                        if (!names.Contains(key)) {
                            names.Add(key);
                            dataTable.Columns.Add(key);
                        }
                    }
                }
                foreach (Dictionary<string, object> map in list) {
                    object[] values = names.Select(name => map.ContainsKey(name) ? map[name] : null).ToArray();
                    dataTable.Rows.Add(values);
                }
            }
            return dataTable;
        }
    }

}
