using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

using Wallpaper.Data;
using Wallpaper.Model;

namespace Wallpaper.Util {

    public class WallpaperUtil : SteamUtil {

        public const string Appid = "431960";
        public new const string WorkshopUrl = "https://steamcommunity.com/app/" + Appid + "/workshop/";
        public new const string Software = "common\\wallpaper_engine";
        public new const string Workshop = "workshop\\content\\" + Appid;
        public const string Config = "config.json";
        public const string WorkshopCache = "workshopcache.json";

        static WallpaperUtil() {
        }

        public static new string SoftwarePath {
            get => Path.Combine(BaseFolder, Software);
        }

        public static new string WorkshopPath {
            get => Path.Combine(BaseFolder, Workshop);
        }

        public static string ConfigPath {
            get => Path.Combine(BaseFolder, Software, Config);
        }

        public static string WorkshopCachePath {
            get => Path.Combine(BaseFolder, Software, "bin", WorkshopCache);
        }

        public static new string GetSoftwarePath(string folderPath) {
            return CompletionPath(folderPath, SoftwarePath.Split(Path.DirectorySeparatorChar));
        }

        public static new string GetWorkshopPath(string folderPath) {
            return CompletionPath(folderPath, WorkshopPath.Split(Path.DirectorySeparatorChar));
        }

        public static string GetConfigPath(string folderPath) {
            return CompletionPath(folderPath, ConfigPath.Split(Path.DirectorySeparatorChar));
        }

        public static string GetWorkshopCachePath(string folderPath) {
            return CompletionPath(folderPath, WorkshopCachePath.Split(Path.DirectorySeparatorChar));
        }

        public static HashMap<string, object> GetConfig(string folderPath) {
            return JsonFile2HashMap(GetConfigPath(folderPath));
        }

        public static HashMap<string, object> GetWorkshopCache(string folderPath) {
            return JsonFile2HashMap(GetWorkshopCachePath(folderPath));
        }

        public static ProjectSource[] GetSources(DirectoryInfo folder) {
            ProjectSource[] sources = folder.EnumerateDirectories("*", SearchOption.TopDirectoryOnly).Select(_folder => {
                ProjectSource source = new ProjectSource() {
                    Folder = _folder
                };
                FileInfo[] files = _folder.GetFiles("project.json", SearchOption.TopDirectoryOnly);
                if (null != files && files.Length > 0) {
                    HashMap<string, object> json = JsonFile2HashMap(files[0].FullName);
                    string type = (json["type"] as string)?.ToLower();
                    string name = json["file"] as string;
                    switch (type) {
                        case "scene":
                            string[] array = name.Split('.');
                            array[array.Length - 1] = "pkg";
                            name = string.Join(".", array);
                            break;
                        default:
                            break;
                    }
                    FileInfo[] target = _folder.GetFiles(name, SearchOption.TopDirectoryOnly);
                    source.JsonFile = files[0];
                    source.Json = json;
                    source.File = (null != target && target.Length > 0) ? target[0] : null;
                    source.Type = type;
                }
                return source;
            }).ToArray();
            return sources;
        }

        public static ProjectInfo Source2Info(ProjectSource source) {
            decimal size = source.FileSize / 1024 / 1024;
            ProjectInfo info = new ProjectInfo {
                ID = long.Parse(source.Folder.Name),
                Description = source.Json["description"] as string ?? string.Empty,
                Path = source.File.FullName,
                FileName = source.File.Name,
                FileSize = size > 1024 ? $"{size / 1024:#0.00}G" : $"{size}M",
                Title = source.Json["title"] as string,
                Type = source.Json["type"] as string,
                Visibility = source.Json["visibility"] as string,
                ConsistentTitle = true,
                Source = new ProjectSource[] { source }
            };
            return info;
        }

        public static WorkshopPager GetWorkshopBrowse(CookieContainer cookie, string miscellaneous, string type, string ageRating, string genre, string resolution, string category, string assetType, string assetGenre, string scriptType, int p, int numperpage) {
            PageCondition condition = new PageCondition {
                Miscellaneous = miscellaneous,
                Type = type,
                AgeRating = ageRating,
                Genre = genre,
                Resolution = resolution,
                Category = category,
                AssetType = assetType,
                AssetGenre = assetGenre,
                ScriptType = scriptType
            };
            return GetWorkshopBrowse(cookie, Appid, condition, p, numperpage);
        }

        public static WorkshopPager GetWorkshopBrowse(CookieContainer cookie, PageCondition condition, int p, int numperpage) {
            return GetWorkshopBrowse(cookie, Appid, condition, p, numperpage);
        }

        public static WorkshopPager GetWorkshopBrowse(CookieContainer cookie, PageCondition condition) {
            return GetWorkshopBrowse(cookie, Appid, condition, 1, 30);
        }

    }

}
