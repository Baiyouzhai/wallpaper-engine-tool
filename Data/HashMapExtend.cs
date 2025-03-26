using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Data {

    public static class HashMapExtend {

        public static HashMap<TKey, TSource> ToMap<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector) where TSource : class {
            return source.ToMap(keySelector, (obj) => obj, null); ;
        }

        public static HashMap<TKey, TSource> ToMap<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer) where TSource : class {
            return source.ToMap(keySelector, (obj) => obj, comparer);
        }

        public static HashMap<TKey, TElement> ToMap<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) where TElement : class {
            return source.ToMap(keySelector, elementSelector, null);
        }

        public static HashMap<TKey, TElement> ToMap<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) where TElement : class {
            if (source == null) throw new ArgumentNullException("source");
            if (keySelector == null) throw new ArgumentNullException("keySelector");
            if (elementSelector == null) throw new ArgumentNullException("elementSelector");
            HashMap<TKey, TElement> map = new HashMap<TKey, TElement>(comparer);
            foreach (TSource item in source) {
                map.Add(keySelector(item), elementSelector(item));
            }
            return map;
        }

        public static string ToUrlParam(this HashMap<string, object> data) {
            return string.Join("&", data.Select(kv => $"{kv.Key}={kv.Value}"));
        }

        public static DataTable ToDataTable(this List<HashMap<string, object>> list) {
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
