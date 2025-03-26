using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Util {

    public class SysUtil {

        public static string UserName {
            get => Environment.UserName;
        }

    }

    public static class StringExtend {

        public static string UrlEncode(this string str, Encoding encoder) {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = encoder.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++) {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 默认是System.Text.Encoding.Default.GetBytes(str)
        /// </summary>
        public static string UrlEncode(this string str) => UrlEncode(str, Encoding.Default);

        public static T ToEnum<T>(this string value) where T : Enum {
            return (T)Enum.Parse(typeof(T), value, true);
        }

    }

    public static class IntExtend {

        public static T ToEnum<T>(this int value) where T : Enum {
            Type type = typeof(T);
            if (type.IsEnum) {
                Array array = type.GetEnumValues();
                for (int i = 0; i < array.Length; i++) {
                    object _value = array.GetValue(i);
                    if (value == Convert.ToInt32(_value)) return (T)_value;
                }
            }
            throw new Exception($"{value}不是enum");
        }

    }

    public static class EnumExtend {

        public static int ToInt32(this Enum value) {
            return Convert.ToInt32(value);
        }

    }

}
