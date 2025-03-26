using HtmlAgilityPack;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Wallpaper.Data;
using Wallpaper.Model;

namespace Wallpaper.Util {


    public class SteamUtil : JsonUtil {

        public const string WorkshopUrl = "https://steamcommunity.com";
        public const string BaseFolder = "SteamLibrary\\steamapps";
        public const string Software = "common";
        public const string Workshop = "workshop\\content";

        static SteamUtil() {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls12;
            //return true;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.ServerCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => { return true; };
        }

        public static string SoftwarePath {
            get => Path.Combine(BaseFolder, Software);
        }

        public static string WorkshopPath {
            get => Path.Combine(BaseFolder, Workshop);
        }

        public static string GetBasePath(string folderPath) {
            if (!string.IsNullOrEmpty(folderPath)) {
                string[] split = folderPath.Split(Path.DirectorySeparatorChar);
                if (split.Length > 0) {
                    if (split[0].Contains(":")) {
                        if (split.Length == 2 && string.IsNullOrEmpty(split[1])) {
                            return Path.Combine(split[0], BaseFolder);
                        }
                        return folderPath;
                    }
                }
            }
            throw new ArgumentException(nameof(folderPath));
        }

        public static string CompletionPath(string folderPath, params string[] paths) {
            string[] split = GetBasePath(folderPath).Split(Path.DirectorySeparatorChar);
            List<string> path = new List<string>();
            string[] _paths = paths.Select(x => x.ToLower()).ToArray();
            int point = 0;
            for (int i = 0; i < split.Length; i++) {
                if (_paths[point].Equals(split[i].ToLower())) {
                    ++point;
                } else {
                    point = 0;
                }
                path.Add(split[i]);
            }
            if (1 == path.Count) {
                path.Add(BaseFolder);
            }
            for (int i = point; i < paths.Length; i++) {
                path.Add(paths[i]);
            }
            return string.Join("\\", path);
        }

        public static string GetSoftwarePath(string folderPath) {
            return CompletionPath(folderPath, SoftwarePath.Split(Path.DirectorySeparatorChar));
        }

        public static string GetWorkshopPath(string folderPath) {
            return CompletionPath(folderPath, WorkshopPath.Split(Path.DirectorySeparatorChar));
        }

        public static bool UnSubscribe(CookieContainer cookie, string sessionid, string appid, long workshopid) {
            try {
                HttpWebRequest request = WebRequest.CreateHttp("https://steamcommunity.com/sharedfiles/unsubscribe");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                if (null != cookie) request.CookieContainer = cookie;
                Encoding encoding = Encoding.UTF8;
                byte[] postData = encoding.GetBytes($"sessionid={sessionid}&appid=${appid}&id={workshopid}");
                request.ContentLength = postData.Length;
                using (Stream requestStream = request.GetRequestStream())
                    requestStream.Write(postData, 0, postData.Length);
                object obj = null;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader streamReader = new StreamReader(responseStream, encoding))
                    obj = Json2Object(streamReader.ReadToEnd());
                return true;
            } catch (Exception e) {
                // throw e;
                return false;
            }
        }

        public static WorkshopPager GetWorkshopPager(string html, int page, int size) {
            WorkshopPager pager = new WorkshopPager {
                Page = page,
                Size = size,
                Total = 0,
                Items = new List<object>()
            };
            if (string.IsNullOrEmpty(html)) return pager;
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNodeCollection profileBlockDivs = doc.DocumentNode.SelectNodes("//div[@id='profileBlock']/div[1]/div");
            if (profileBlockDivs.Count < 3) return pager;
            HtmlNode workshopBrowsePagingWithBG = profileBlockDivs[1];
            HtmlNodeCollection workshopBrowseItems = profileBlockDivs[2].SelectNodes("div");
            foreach (HtmlNode workshopBrowseItem in workshopBrowseItems) {
                HtmlNode a = workshopBrowseItem.SelectSingleNode("a[1]");
                long publishedfileid = Convert.ToInt64(a.GetAttributeValue("data-publishedfileid", "-1"));
                string url = a.GetAttributeValue("href", "").Split('&')[0];
                string workshopItemPreviewImage = a.SelectSingleNode("div[1]/img[1]").GetAttributeValue("src", "");
                string workshopItemTitle = workshopBrowseItem.SelectSingleNode("a[2]/div[1]").InnerText;
                string workshopItemAuthorName = workshopBrowseItem.SelectSingleNode("div[2]/a[1]").InnerText;
                string[] fileRating = workshopBrowseItem.SelectSingleNode("img[2]").GetAttributeValue("src", "").Split('?')[0].Split('/');
                string description = workshopBrowseItem.NextSibling.NextSibling.InnerText;
                description = new Regex("description\":\"(\\w|\\W)+\",{1}").Match(description).Value.Replace("description\":\"", string.Empty).Replace("\",$", string.Empty);
                pager.Items.Add(new BrowseItemPage {
                    PublishedFileId = publishedfileid,
                    WorkshopItemTitle = workshopItemTitle,
                    Url = url,
                    WorkshopItemPreviewImage = workshopItemPreviewImage,
                    WorkshopItemAuthorName = workshopItemAuthorName,
                    Description = Regex.Unescape(description),
                    FileRating = fileRating[fileRating.Length - 1].Contains("not-yet") ? -1 : Convert.ToInt32(fileRating[fileRating.Length - 1].Split('-')[0])
                });
            }
            string value = new Regex("(共|of){1}(\\s|\\d|,)+(项|entries){1}").Match(workshopBrowsePagingWithBG.InnerHtml).Value;
            int total = Convert.ToInt32(Regex.Replace(value, "共|of|项|entries|,", string.Empty).Trim());
            pager.Total = total;
            return pager;
        }

        private static string GetUrlParam(string appid, int p, int numperpage) {
            return new HashMap<string, object> {
                { "appid", appid },
                { "searchtext", "" },
                { "childpublishedfileid", "0" },
                { "browsesort", "mostrecent" }, //最热门|trend, 最新|mostrecent, 最后更新|lastupdated, 最多订阅totaluniquesubscribers
                { "section", "readytouseitems" },
                { "created_date_range_filter_start", "0" },
                { "created_date_range_filter_end", "0" },
                { "updated_date_range_filter_start", "0" },
                { "updated_date_range_filter_end", "0" },
                { "p", p },
                { "numperpage", numperpage }
            }.ToUrlParam();
        }

        private static string GetUrl(string appid, PageCondition condition, int p, int numperpage) {
            return string.Concat("https://steamcommunity.com/workshop/browse/?",
                GetUrlParam(appid, p, numperpage),
                null == condition ? string.Empty : condition.GetUrlParam());
        }

        public static WorkshopPager GetWorkshopBrowse(CookieContainer cookie, string appid, PageCondition condition, int p, int numperpage) {
            string url = GetUrl(appid, condition, p, numperpage);
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = "GET";
            if (null != cookie) request.CookieContainer = cookie;
            string html = string.Empty;
            try {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
                    html = streamReader.ReadToEnd();
            } catch (Exception e) {
                //throw e;
            }
            WorkshopPager pager = GetWorkshopPager(html, p, numperpage);
            pager.Url = url;
            pager.Condition = condition;
            return pager;
        }

        public static WorkshopPager GetWorkshopBrowse(CookieContainer cookie, string appid, string miscellaneous, string type, string ageRating, string genre, string resolution, string category, string assetType, string assetGenre, string scriptType) {
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
            return GetWorkshopBrowse(cookie, appid, condition, 1, 30);
        }

        public static FileDetailsPage GetFileDetails(string html, long publishedFileId) {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNodeCollection mainContentsDivs = doc.DocumentNode.SelectNodes("//div[@id='mainContents']/div");
            if (null == mainContentsDivs) return null;
            string visibilityNotificationPrivate = mainContentsDivs[2].SelectSingleNode("div[1]").InnerText;
            visibilityNotificationPrivate = visibilityNotificationPrivate.IndexOf("：") == -1 ? visibilityNotificationPrivate.Split(':')[1] : visibilityNotificationPrivate.Split('：')[1];
            string visibilityNotificationFriendsOnly = mainContentsDivs[3].SelectSingleNode("div[1]").InnerText;
            visibilityNotificationFriendsOnly = visibilityNotificationFriendsOnly.IndexOf("：") == -1 ? visibilityNotificationFriendsOnly.Split(':')[1] : visibilityNotificationFriendsOnly.Split('：')[1];
            string numRatings = mainContentsDivs[4].SelectSingleNode("div[1]/div[1]/div[2]")?.InnerText.Split(' ')[0];
            string workshopItemTitle = mainContentsDivs[4].SelectSingleNode("div[2]").InnerText;
            HtmlNodeCollection workshopItemPreviewArea = mainContentsDivs[9].SelectNodes("div[1]/div[2]/div");
            string size = workshopItemPreviewArea[workshopItemPreviewArea.Count - 1].SelectSingleNode("div[2]/div[1]").InnerText;
            string createTime = workshopItemPreviewArea[workshopItemPreviewArea.Count - 1].SelectSingleNode("div[2]/div[2]").InnerText;
            HtmlNodeCollection rightContents = mainContentsDivs[10].SelectNodes("div[1]/div[1]//table[1]/tr");
            //HtmlNodeCollection rightContents = mainContentsDivs[10].SelectNodes("//table[@class='stats_table']/tr");
            string uniqueVisitors = rightContents[0].SelectSingleNode("td[1]").InnerText;
            string currentSubscribers = rightContents[1].SelectSingleNode("td[1]").InnerText;
            string currentFavorites = rightContents[2].SelectSingleNode("td[1]").InnerText;
            FileDetailsPage fileDetails = new FileDetailsPage {
                PublishedFileId = publishedFileId,
                WorkshopItemTitle = workshopItemTitle,
                VisibilityNotificationPrivate = visibilityNotificationPrivate.Replace("&nbsp;", string.Empty),
                VisibilityNotificationFriendsOnly = visibilityNotificationFriendsOnly.Replace("&nbsp;", string.Empty),
                NumRatings = string.IsNullOrEmpty(numRatings) ? 0 : Convert.ToInt32(numRatings.Replace(",", string.Empty)),
                UniqueVisitors = Convert.ToInt32(uniqueVisitors.Replace(",", string.Empty)),
                CurrentSubscribers = Convert.ToInt32(currentSubscribers.Replace(",", string.Empty)),
                CurrentFavorites = Convert.ToInt32(currentFavorites.Replace(",", string.Empty)),
                Size = size,
                CreateTime = createTime,
            };
            HtmlNodeCollection rightDetailsBlock = workshopItemPreviewArea[0].SelectNodes("div");
            if (null == rightDetailsBlock) rightDetailsBlock = workshopItemPreviewArea[1].SelectNodes("div");
            foreach (HtmlNode div in rightDetailsBlock) {
                string key = div.SelectSingleNode("span[1]").InnerText;
                key = key.IndexOf("：") == -1 ? key.Split(':')[0] : key.Split('：')[0];
                string value = div.SelectSingleNode("a[1]").InnerText;
                fileDetails.Set(key, value);
            }
            return fileDetails;
        }

        public static FileDetailsPage GetFileDetails(CookieContainer cookie, long publishedFileId) {
            HttpWebRequest request = WebRequest.CreateHttp($"https://steamcommunity.com/sharedfiles/filedetails/?id={publishedFileId}");
            request.Method = "GET";
            if (null != cookie) request.CookieContainer = cookie;
            string html = string.Empty;
            try {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
                    html = streamReader.ReadToEnd();
            } catch (Exception e) {
                //throw e;
            }
            if (string.IsNullOrEmpty(html)) return null;
            return GetFileDetails(html, publishedFileId);
        }

        public static WorkshopPager[] GetWorkshopPages(DirectoryInfo folder) {
            WorkshopPager[] sources = folder.EnumerateFiles("*.json", SearchOption.TopDirectoryOnly)
                .Where(file => !file.Name.Contains("all")).Select(file => {
                    WorkshopPager pager = JsonFile2Object<WorkshopPager>(file.FullName);
                    return pager;
                }).OrderByDescending(item => item.ReadTime).ToArray();
            return sources;
        }

        public static FileDetailsPage GetFileDetailsPage(object item) {
            if (item is JObject jObject) {
                WorkshopItem temp = jObject.ToObject<WorkshopItem>();
                return temp.ToFileDetailsPage();
            }
            return null;
        }

    }

}
