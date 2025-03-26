using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

using Wallpaper.Util;

namespace Wallpaper.Model {

    public class PageCondition {

        protected string miscellaneous;
        protected string type;
        protected string ageRating;
        protected string genre;
        protected string resolution;
        protected string category;
        protected string assetType;
        protected string assetGenre;
        protected string scriptType;

        public string Miscellaneous { get => miscellaneous; set => miscellaneous = value; }
        public string Type { get => type; set => type = value; }
        public string AgeRating { get => ageRating; set => ageRating = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Resolution { get => resolution; set => resolution = value; }
        public string Category { get => category; set => category = value; }
        public string AssetType { get => assetType; set => assetType = value; }
        public string AssetGenre { get => assetGenre; set => assetGenre = value; }
        public string ScriptType { get => scriptType; set => scriptType = value; }

        public string GetUrlParam() {
            return string.Concat((string.IsNullOrEmpty(miscellaneous) ? string.Empty : $"&requiredtags[]={miscellaneous}"),
            (string.IsNullOrEmpty(type) ? string.Empty : $"&requiredtags[]={type}"),
            (string.IsNullOrEmpty(ageRating) ? string.Empty : $"&requiredtags[]={ageRating}"),
            (string.IsNullOrEmpty(genre) ? string.Empty : $"&requiredtags[]={genre}"),
            (string.IsNullOrEmpty(resolution) ? string.Empty : $"&requiredtags[]={resolution}"),
            (string.IsNullOrEmpty(category) ? string.Empty : $"&requiredtags[]={category}"),
            (string.IsNullOrEmpty(assetType) ? string.Empty : $"&requiredtags[]={assetType}"),
            (string.IsNullOrEmpty(assetGenre) ? string.Empty : $"&requiredtags[]={assetGenre}"),
            (string.IsNullOrEmpty(scriptType) ? string.Empty : $"&requiredtags[]={scriptType}"));
        }

    }

    public class WorkshopPager {

        protected string name;
        protected string lastTime;
        protected string readTime;
        protected int page;
        protected int size;
        protected int total;
        protected int pages;
        protected string url;
        protected PageCondition condition;
        protected List<object> items;

        public string Name { get => name; set => name = value; }
        public string LastTime { get => lastTime; set => lastTime = value; }
        public string ReadTime { get => readTime; set => readTime = value; }
        public int Page {
            get => page;
            set => page = value > 0 ? value : throw new ArgumentException("页码<1无意义");
        }
        public int Size {
            get => size;
            set => size = value > 0 ? value : throw new ArgumentException("每页条数<1无意义");
        }
        public int Total { get => total; set => total = value; }
        public int Pages {
            get => 0 == total ? 0 : (int)Math.Ceiling(new decimal(total) / size);
        }
        public string Url { get => url; set => url = value; }
        public PageCondition Condition { get => condition; set => condition = value; }
        public virtual List<object> Items { get => items; set => items = value; }

        public bool IsEmpty {
            get => 0 == total;
        }

        public bool Next {
            get => page < Pages;
        }

        public WorkshopPager NextPage(CookieContainer cookie, string appid) {
            WorkshopPager pager = SteamUtil.GetWorkshopBrowse(cookie, appid, condition, page + 1, size);
            if (pager.IsEmpty && Next) { //TODO 当前页读取空(失败?)
                pager.page = page + 1;
                pager.total = total;
            }
            return pager;
        }

    }

}
