using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Data {

    public class KeyValue<K, V> {

        protected K key;
        protected V value;

        public KeyValue() { }
        public KeyValue(K key, V value) {
            this.key = key;
            this.value = value;
        }

        public K Key { get => key; set => key = value; }
        public V Value { get => value; set => this.value = value; }

    }

}
