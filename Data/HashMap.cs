using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Data {

    public class HashMap<K, V> : Dictionary<K, V> where V : class {

        public HashMap() : base() {
        }

        public HashMap(IDictionary<K, V> dictionary) : base(dictionary) {
        }

        public HashMap(IEqualityComparer<K> comparer) : base(comparer) {
        }

        public HashMap(int capacity) : base(capacity) {
        }

        public HashMap(IDictionary<K, V> dictionary, IEqualityComparer<K> comparer) : base(dictionary, comparer) {
        }

        public HashMap(int capacity, IEqualityComparer<K> comparer) : base(capacity, comparer) {
        }

        /// <summary>
        /// 覆盖了方法
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>旧值,不存在为null</returns>
        public new V this[K key] {
            get => ContainsKey(key) ? base[key] : default;
            set {
                if (ContainsKey(key)) {
                    base[key] = value;
                } else {
                    Add(key, value);
                }
            }
        }

        public new HashSet<K> Keys {
            get => base.Keys.ToHashSet();
        }

        public new List<V> Values {
            get => base.Values.ToList();
        }

        public new V Remove(K key) {

            if (ContainsKey(key)) {
                V old = base[key];
                base.Remove(key);
                return old;
            }
            return default;
        }

        public virtual V Put(K key, V value) {
            if (ContainsKey(key)) {
                V old = base[key];
                base[key] = value;
                return old;
            } else {
                Add(key, value);
                return default;
            }
        }

        public virtual V Get(K key) {
            return ContainsKey(key) ? base[key] : default;
        }

        public virtual R Get<R>(K key) where R : V {
            return (R)(ContainsKey(key) ? this[key] : default);
        }

        public virtual bool IsEmpty {
            get => Count > 0;
        }

        public virtual List<KeyValuePair<K, V>> EntrySet {
            get => this.ToList();
        }

        public virtual string toString() {
            return ToString("{ ", " }", (kv) => kv.Key + "=" + kv.Value, ", ");
        }

        public virtual string ToString(string begin, string end, Func<KeyValuePair<K, V>, string> format, string join) {
            return new StringBuilder(begin)
                .Append(string.Join(join, this.Select(kv => format.Invoke(kv)).ToArray()))
                .Append(end).ToString();
        }

    }

}
