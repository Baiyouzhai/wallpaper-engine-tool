using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Wallpaper.Data;

namespace Wallpaper.Model {

    public class WorkshopCookie {

        protected string name;
        protected string value;
        protected string tips;

        public string Name { get => name; set => name = value; }
        public string Value { get => value; set => this.value = value; }
        public string Tips { get => tips; set => tips = value; }

        public static WorkshopCookie Convert(HashMap<string, object> map) {
            if (null == map) return null;
            return new WorkshopCookie {
                Name = map["Name"] as string,
                Value = map["Value"] as string,
                Tips = map["Tips"] as string
            };
        }

    }

    public static class WorkshopCookieExtend {

        public static void Set(this WorkshopCookie cookie, HashMap<string, object> map) {
            cookie.Name = map["Name"] as string ?? string.Empty;
            cookie.Value = map["Value"] as string ?? string.Empty;
            cookie.Tips = map["Tips"] as string ?? string.Empty;
        }

        public static Cookie ToCookie(this WorkshopCookie cookie) {
            if (string.IsNullOrEmpty(cookie.Name)) return null;
            if (string.IsNullOrEmpty(cookie.Value)) return null;
            string domain = WallpaperData.Ga.Equals(cookie.Name) ? ".steamcommunity.com" : "steamcommunity.com";
            //Cookie cookie = new Cookie(cookie.Name, WebUtility.UrlEncode(cookie.Value), "/", domain);
            Cookie _cookie = new Cookie(cookie.Name, cookie.Value, "/", domain);
            //if (Sessionid.Equals(cookie.Name)) _cookie.Secure = true;
            //else if (SteamLoginSecure.Equals(cookie.Name)) {
            //    _cookie.HttpOnly = true;
            //    _cookie.Secure = true;
            //    _cookie.Expires = DateTime.Now;
            //}
            return _cookie;
        }

        public static CookieContainer ToCookieContainer(this List<WorkshopCookie> cookies) {
            CookieContainer cookieContainer = new CookieContainer();
            foreach (WorkshopCookie cookie in cookies) {
                Cookie _cookie = cookie.ToCookie();
                if (null != _cookie) cookieContainer.Add(_cookie);
            }
            return cookieContainer;
        }

    }

}
