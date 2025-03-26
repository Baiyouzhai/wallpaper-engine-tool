using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Wallpaper.Data;

namespace Wallpaper.Model {

    public class WallpaperData {

        public const string ConfigDefault = "config_default.json";
        public const string Config = "config.json";
        public const string Sessionid = "sessionid";
        public const string SteamLoginSecure = "steamLoginSecure";
        public const string RecentlyVisitedAppHubs = "recentlyVisitedAppHubs";
        public const string TimezoneOffset = "timezoneOffset";
        public const string Ga = "_ga";
        public static readonly HashSet<string> CookieNames = new HashSet<string> {
            Sessionid, SteamLoginSecure, RecentlyVisitedAppHubs, TimezoneOffset, Ga
        };
        private static List<string> resolutions;
        private static string resolution;
        private static List<string> vertical;
        private static List<string> alignment;

        static WallpaperData() {
            resolutions = new List<string>();
            resolution = "其它分辨率";
        }

        public static List<string> Resolutions {
            get => resolutions;
            set => resolutions = value ?? throw new ArgumentNullException(nameof(value));
        }
        public static string Resolution {
            get => resolution;
            set => resolution = string.IsNullOrEmpty(value) ? throw new ArgumentNullException(nameof(value)) : value;
        }
        public static List<string> Vertical {
            get => vertical;
            set => vertical = value ?? throw new ArgumentNullException(nameof(value));
        }
        public static List<string> Alignment {
            get => alignment;
            set => alignment = value ?? throw new ArgumentNullException(nameof(value));
        }

        protected DirectoryInfo steamFoler;
        protected HashMap<string, object> wallpaperConfig;
        protected HashMap<string, object> browser;
        protected string lastselectedmonitor;
        protected HashMap<string, object> wproperties;
        protected HashMap<string, object> wallpaperCache;
        protected HashMap<long, HashMap<string, object>> wallpapers;
        protected ProjectSource[] projectSources;
        protected ProjectInfo[] projectInfos;
        protected BindingList<ProjectInfo> checkCache;
        protected string sessionId;
        protected CookieContainer cookieContainer;
        protected BindingList<FileDetailsPage> originData;
        protected BindingList<WorkshopPager> browseData;
        protected IntervalValue waitUnSubscribe;
        protected IntervalValue waitOriginScan;

        public WallpaperData() {
            projectSources = Array.Empty<ProjectSource>();
            projectInfos = Array.Empty<ProjectInfo>();
            checkCache = new BindingList<ProjectInfo>();
            cookieContainer = new CookieContainer();
            originData = new BindingList<FileDetailsPage>();
            browseData = new BindingList<WorkshopPager>();
        }

        public DirectoryInfo SteamFolder { get => steamFoler; set => steamFoler = value; }
        public HashMap<string, object> WallpaperConfig { get => wallpaperConfig; set => wallpaperConfig = value; }
        public HashMap<string, object> Browser { get => browser; set => browser = value; }
        public string Lastselectedmonitor { get => lastselectedmonitor; set => lastselectedmonitor = value; }
        public HashMap<string, object> Wproperties { get => wproperties; set => wproperties = value; }
        public HashMap<string, object> WallpaperCache { get => wallpaperCache; set => wallpaperCache = value; }
        public HashMap<long, HashMap<string, object>> Wallpapers { get => wallpapers; set => wallpapers = value; }
        public ProjectSource[] ProjectSources { get => projectSources; set => projectSources = value; }
        public ProjectInfo[] ProjectInfos { get => projectInfos; set => projectInfos = value; }
        public BindingList<ProjectInfo> CheckCache { get => checkCache; set => checkCache = value; }
        public string SessionId { get => sessionId; set => sessionId = value; }
        public CookieContainer CookieContainer { get => cookieContainer; set => cookieContainer = value; }
        public BindingList<FileDetailsPage> OriginData { get => originData; set => originData = value; }
        public BindingList<WorkshopPager> BrowseData { get => browseData; set => browseData = value; }
        public IntervalValue WaitUnSubscribe { get => waitUnSubscribe; set => waitUnSubscribe = value; }
        public IntervalValue WaitOriginScan { get => waitOriginScan; set => waitOriginScan = value; }

    }

}
