using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wallpaper.Data;
using Wallpaper.Model;
using Wallpaper.Util;

namespace Wallpaper.Controller {

    public class WallpaperManage {

        protected HashMap<string, object> config;
        protected OutManage outManage;
        protected WallpaperData data;
        protected HashMap<string, Task<bool>> taskQueue;
        protected string orderName;

        public WallpaperManage() {
            outManage = new OutManage();
            data = new WallpaperData();
            taskQueue = new HashMap<string, Task<bool>>();
            orderName = string.Empty;
        }

        public string SteamFolder {
            get => data.SteamFolder?.FullName;
            set {
                string path = SteamUtil.GetBasePath(value);
                DirectoryInfo folder = new DirectoryInfo(path);
                if (folder.Exists) {
                    data.SteamFolder = folder;
                    config["SteamFoler"] = path;
                    return;
                }
                throw new ArgumentException(string.Format("不是Steam存储路径"));
            }
        }

        public FileInfo OutFile {
            get => outManage.OutFile;
            set {
                outManage.OutFile = value;
                config["OutFile"] = value.FullName;
            }
        }

        public int OutType {
            get => null == config["OutType"] ? 0 : Convert.ToInt32(config["OutType"]);
            set => config["OutType"] = value;
        }

        public IConsole Console {
            get => outManage.Console;
            set => outManage.Console = value;
        }

        public void Clear() => outManage.Clear();

        public HashMap<string, object> Config {
            get => GetConfig();
            set => config = value ?? throw new ArgumentNullException(nameof(value));
        }

        public bool OriginUseAdd(string tag, string value) {
            HashMap<string, object> origin = config["Origin"] as HashMap<string, object>;
            HashMap<string, object> use = origin["use"] as HashMap<string, object>;
            (use[tag] as List<object>).Add(value);
            return true;
        }

        public bool OriginUseRemove(string tag, string value) {
            HashMap<string, object> origin = config["Origin"] as HashMap<string, object>;
            HashMap<string, object> use = origin["use"] as HashMap<string, object>;
            (use[tag] as List<object>).Remove(value);
            return true;
        }

        public TreeNode[] OriginTreeView {
            get => GetOriginTreeView();
        }

        public TreeNode[] GetOriginTreeView() {
            HashMap<string, object> origin = config["Origin"] as HashMap<string, object>;
            HashMap<string, object> tags = origin["tags"] as HashMap<string, object>;
            HashMap<string, object> use = origin["use"] as HashMap<string, object>;
            TreeNode[] roots = tags.Select(kv => {
                TreeNode rootNode = new TreeNode {
                    Tag = kv,
                    Text = kv.Key
                };
                HashSet<string> hashSet = (use[kv.Key] as List<object>).Select(obj => obj.ToString()).Where(str => !string.IsNullOrEmpty(str)).ToHashSet();
                if (hashSet.Count > 0) rootNode.Expand();
                TreeNode[] array = (kv.Value as List<object>).Select(obj => obj.ToString()).Where(str => !string.IsNullOrEmpty(str)).Select(str => {
                    TreeNode temp = new TreeNode(str);
                    if (hashSet.Contains(str)) {
                        temp.Checked = true;
                    }
                    return temp;
                }).ToArray();
                rootNode.Nodes.AddRange(array);
                return rootNode;
            }).ToArray();
            return roots;
        }

        public void SetWallpaperConfig(HashMap<string, object> wallpaperConfig) {
            HashMap<string, object> userConfig = wallpaperConfig[SysUtil.UserName] as HashMap<string, object>;
            data.Wproperties = userConfig["wproperties"] as HashMap<string, object>;
            data.Browser = (userConfig["general"] as HashMap<string, object>)["browser"] as HashMap<string, object>;
            data.Lastselectedmonitor = data.Browser["lastselectedmonitor"] as string;
            data.WallpaperConfig = wallpaperConfig;
        }

        public void SetWallpaperCache(HashMap<string, object> wallpaperCache) {
            List<object> list = wallpaperCache.Get("wallpapers") as List<object>;
            data.Wallpapers = list.Select(item => item as HashMap<string, object>).ToMap(item => Convert.ToInt64(item["workshopid"]), item => item);
            data.WallpaperCache = wallpaperCache;
        }

        public bool LoadWallpaperConfig() => LoadWallpaperConfig(true);

        public bool LoadWallpaperConfig(bool reload) {
            if (reload || null == config) {
                HashMap<string, object> wallpaperConfig = WallpaperUtil.GetConfig(SteamFolder);
                if (null == wallpaperConfig) {
                    WriteLine(string.Format("{0}未读取到wallpaper配置文件", WallpaperUtil.GetConfigPath(SteamFolder)), Controller.OutType.InfoFile);
                    return false;
                }
                HashMap<string, object> wallpaperCache = WallpaperUtil.GetWorkshopCache(SteamFolder);
                if (null == wallpaperCache) {
                    WriteLine(string.Format("{0}未读取到wallpaper 缓存文件", WallpaperUtil.GetWorkshopCachePath(SteamFolder)), Controller.OutType.InfoFile);
                    return false;
                }
                SetWallpaperConfig(wallpaperConfig);
                SetWallpaperCache(wallpaperCache);
            }
            return true;
        }

        public HashMap<string, object> GetConfig() => GetConfig(false);

        public HashMap<string, object> GetConfig(bool reload) {
            if (reload || null == config) {
                FileInfo defInfo = new FileInfo(WallpaperData.ConfigDefault);
                FileInfo info = new FileInfo(WallpaperData.Config);
                if (!info.Exists) info = defInfo.CopyTo(WallpaperData.Config);
                config = JsonUtil.JsonFile2HashMap(info.FullName);
                if (string.IsNullOrEmpty(config["OutFile"] as string)) {
                    FileInfo temp = new FileInfo($"{Directory.GetCurrentDirectory()}\\out.txt");
                    if (!temp.Exists) temp.Create().Close();
                    config["OutFile"] = temp.FullName;
                }
                HashMap<string, object> defData = JsonUtil.JsonFile2HashMap(defInfo.FullName)["Data"] as HashMap<string, object>;
                if (!(config["Data"] is HashMap<string, object> data)) {
                    config.Put("Data", defData);
                    data = defData;
                }
                List<WorkshopCookie> defCookies = (defData["Cookies"] as List<object>).Select(item => WorkshopCookie.Convert(item as HashMap<string, object>)).Where(item => null != item).ToList();
                List<WorkshopCookie> cookies = (data["Cookies"] as List<object>).Select(item => WorkshopCookie.Convert(item as HashMap<string, object>)).Where(item => null != item).ToList();
                HashMap<string, WorkshopCookie> mapping = cookies.ToMap(cookie => cookie.Name, cookie => cookie);
                cookies = defCookies.Select(cookie => {
                    WorkshopCookie temp = mapping[cookie.Name];
                    if (null == temp) return cookie;
                    if (string.IsNullOrEmpty(temp.Value)) temp.Value = cookie.Value;
                    if (string.IsNullOrEmpty(temp.Tips)) temp.Tips = cookie.Tips;
                    return temp;
                }).ToList();
                data.Put("Cookies", cookies);
                this.data.CookieContainer = cookies.ToCookieContainer();
                cookies.ForEach(cookie => {
                    if (WallpaperData.Sessionid.Equals(cookie.Name)) this.data.SessionId = cookie.Value;
                });
                if (!data.ContainsKey("Resolutions")) data.Add("Resolutions", defData["Resolutions"]);
                WallpaperData.Resolutions = (data["Resolutions"] as List<object>).Select(resolution => resolution as string).ToList();
                if (!data.ContainsKey("Resolution")) data.Add("Resolution", defData["Resolution"]);
                WallpaperData.Resolution = data["Resolution"] as string;
                if (!data.ContainsKey("Vertical")) data.Add("Vertical", defData["Vertical"]);
                WallpaperData.Vertical = (data["Vertical"] as List<object>).Select(resolution => resolution as string).ToList();
                if (!data.ContainsKey("Alignment")) data.Add("Alignment", defData["Alignment"]);
                WallpaperData.Alignment = (data["Alignment"] as List<object>).Select(resolution => resolution as string).ToList();
                if (!data.ContainsKey("WaitUnSubscribe")) data.Add("WaitUnSubscribe", defData["WaitUnSubscribe"]);
                this.data.WaitUnSubscribe = JsonConvert.DeserializeObject<IntervalValue>(JsonUtil.Object2Json(data["WaitUnSubscribe"]));
                if (!data.ContainsKey("WaitOriginScan")) data.Add("WaitOriginScan", defData["WaitOriginScan"]);
                this.data.WaitOriginScan = JsonConvert.DeserializeObject<IntervalValue>(JsonUtil.Object2Json(data["WaitOriginScan"]));
            }
            return config;
        }

        public void SaveConfig() {
            FileInfo info = new FileInfo(WallpaperData.Config);
            JsonUtil.HashMap2File(config, info.FullName);
        }

        public void WriteLine(string message) {
            switch (OutType) {
                case 0:
                    outManage.Console.Info(message);
                    break;
                case 1:
                    outManage.FileWriter.WriteLine(message);
                    break;
                default:
                    break;
            }
        }

        public void WriteLine(string message, OutType outType) => outManage.WriteLine(message, outType);

        public ProjectInfo[] LoadSource(HashSet<string> skipType, bool reload) {
            Dictionary<string, int> _skipType = null == skipType ? new Dictionary<string, int>() : skipType.ToDictionary(item => item, item => 0);
            if (!reload) return data.ProjectInfos ?? Array.Empty<ProjectInfo>();
            if (null == data.SteamFolder) {
                WriteLine(string.Format("没有设置Steam目录"), Controller.OutType.InfoFile);
                // throw new ArgumentNullException(string.Format("没有设置workshop目录"));
                return data.ProjectInfos;
            }
            DateTime begin = DateTime.Now;
            WriteLine(string.Format("正在加载数据文件({0}, {1})……", WallpaperUtil.Config, WallpaperUtil.WorkshopCache), Controller.OutType.InfoFile);
            LoadWallpaperConfig(true);
            string path = WallpaperUtil.GetWorkshopPath(SteamFolder);
            WriteLine(string.Format("正在从 {0} 检索数据", path), Controller.OutType.InfoFile);
            ProjectSource[] projectSources = WallpaperUtil.GetSources(new DirectoryInfo(path));
            List<ProjectSource> errorSource = new List<ProjectSource>();
            projectSources = projectSources.Where(source => {
                if (null == source.File) {
                    errorSource.Add(source);
                    return false;
                }
                return true;
            }).ToArray();
            if (errorSource.Count > 0) {
                WriteLine(string.Format("检查到无效资源……共计{0}个", errorSource.Count), Controller.OutType.InfoFile);
                errorSource.ForEach(source => {
                    if (null == source.Json) WriteLine(string.Format($"  {0} 未找到json文件", source.Folder.Name), Controller.OutType.InfoFile);
                    else WriteLine(string.Format("  {0} 未找到文件 {1}", source.Folder.Name, source.Json["file"]), Controller.OutType.InfoFile);
                });
            }
            if (skipType.Count > 0) {
                WriteLine(string.Format("忽略{0}", string.Join(",", skipType)), Controller.OutType.InfoFile);
                data.ProjectSources = projectSources.Where(source => {
                    source.FileSize = source.File.Length;
                    if (skipType.Contains(source.Type)) {
                        _skipType[source.Type] += 1;
                        return false;
                    }
                    return true;
                }).ToArray();
                foreach (string skip in skipType) {
                    WriteLine(string.Format("  {0}类型,忽略文件{1}个", skip, _skipType[skip]), Controller.OutType.InfoFile);
                }
            }
            DateTime end = DateTime.Now;
            WriteLine(string.Format("检索文件结束, 共检索{0}个文件, 本次共用时{1}秒", projectSources.Length + errorSource.Count, (int)Math.Round((end - begin).TotalSeconds), 0), Controller.OutType.InfoFile);
            ProjectInfo[] projectInfos = data.ProjectSources.Select(WallpaperUtil.Source2Info).ToArray();
            ExpandInfo(projectInfos); //TODO ProjectInfo扩展属性
            data.ProjectInfos = projectInfos;
            return projectInfos;
        }

        public ProjectInfo[] CheckRepeatSource() {
            DateTime begin = DateTime.Now;
            WriteLine(string.Format("重复检查开始……"), Controller.OutType.InfoFile);
            HashMap<long, ProjectInfo> idMapping = new HashMap<long, ProjectInfo>();
            HashMap<long, List<ProjectInfo>> sizeGroup = new HashMap<long, List<ProjectInfo>>();
            foreach (ProjectInfo info in data.ProjectInfos) {
                idMapping.Add(info.ID, info);
                long fileSize = info.Source[0].FileSize;
                if (!sizeGroup.ContainsKey(fileSize)) sizeGroup.Add(fileSize, new List<ProjectInfo>());
                sizeGroup[fileSize].Add(info);
            }
            ProjectInfo[] infos = sizeGroup.Select(kv => {
                List<ProjectInfo> list = kv.Value.ToList();
                long id = list.Min(temp => temp.ID);
                ProjectInfo info = idMapping[id];
                list.Remove(idMapping[id]);
                info.Group = list.OrderBy(temp => temp.ID).ToList();
                return info;
            }).Where(info => info.Group.Count > 0).ToArray();
            WriteLine(string.Format("筛查完成, 共发现{0}个重复项{1}个文件", infos.Length, infos.Sum(info => info.Group.Count)), Controller.OutType.InfoFile);
            int count = 0;
            const string n = "\t";
            foreach (ProjectInfo info in infos) {
                WriteLine(++count + n + string.Format(@"{0}<-->{1}<-->{2}<-->{3}", info.ID, info.Title, info.Visibility, info.FileName));
                foreach (ProjectInfo temp in info.Group) {
                    WriteLine(n + n + string.Format(@"{0}<-->{1}<-->{2}<-->{3}", temp.ID, temp.Title, temp.Visibility, temp.FileName));
                }
            }
            DateTime end = DateTime.Now;
            WriteLine(string.Format("重复检查结束, 本次共用时{0}秒", (int)Math.Round((end - begin).TotalSeconds), 0), Controller.OutType.InfoFile);
            return infos;
        }

        public ProjectInfo[] CheckDeleteSource() {
            DateTime begin = DateTime.Now;
            WriteLine(string.Format("删除标记检查开始……"), Controller.OutType.InfoFile);
            HashMap<long, HashMap<string, object>> wallpapers = data.Wallpapers;
            ProjectInfo[] infos = data.ProjectInfos.Where(item => !wallpapers.ContainsKey(item.ID)).ToArray();
            if (infos.Length > 0) {
                WriteLine(string.Format("检查到删除标记资源……共计{0}个", infos.Length), Controller.OutType.InfoFile);
                foreach (ProjectInfo info in infos) {
                    WriteLine(string.Format("  {0}", info.ID), Controller.OutType.InfoFile);
                }
            }
            DateTime end = DateTime.Now;
            WriteLine(string.Format("删除标记检查结束, 本次共用时{0}秒", (int)Math.Round((end - begin).TotalSeconds), 0), Controller.OutType.InfoFile);
            return infos;
        }

        public ProjectInfo[] CheckEXESource() {
            ProjectInfo[] projectInfos = data.ProjectSources.Where(item => "exe".Equals(item.Type.ToLower())).Select(WallpaperUtil.Source2Info).ToArray();
            if (0 == projectInfos.Length) WriteLine(string.Format("未找到.exe文件"), Controller.OutType.InfoFile);
            ExpandInfo(projectInfos);
            return projectInfos;
        }

        public void ExpandInfo(IEnumerable<ProjectInfo> infos) {
            foreach (ProjectInfo info in infos) {
                if (data.Wallpapers.ContainsKey(info.ID)) {
                    HashMap<string, object> map = data.Wallpapers.Get(info.ID);
                    info.CacheName = map["title"] as string;
                    info.ConsistentTitle = info.Title.Equals(info.CacheName);
                    if (!string.IsNullOrEmpty(info.Direction)) continue;
                    string tag = (map["tags"] as string).Split(',')[3];
                    info.Direction = (WallpaperData.Resolutions.FirstOrDefault(resolution => resolution.Contains(tag)) ?? WallpaperData.Resolution);
                }
                string path = info.Path.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                info.Alignment = WallpaperData.Alignment[0];
                if (data.Wproperties.ContainsKey(path)) {
                    HashMap<string, object> display = (data.Wproperties[path] as HashMap<string, object>)[data.Lastselectedmonitor] as HashMap<string, object>;
                    if (display.ContainsKey("alignment")) info.Alignment = WallpaperData.Alignment[Convert.ToInt32(display["alignment"])];
                }
                if (null != info.Group) ExpandInfo(info.Group);
            }
        }

        public void Close() {
            SaveConfig();
            outManage.Close();
        }

        public List<WorkshopCookie> Cookie {
            get => (config["Data"] as HashMap<string, object>)["Cookies"] as List<WorkshopCookie>;
        }

        public BindingList<FileDetailsPage> OriginData {
            get => data.OriginData;
        }

        public BindingList<WorkshopPager> BrowseData {
            get => data.BrowseData;
        }

        public BindingList<ProjectInfo> CheckCache {
            get => data.CheckCache;
        }

        public IntervalValue WaitUnSubscribe {
            get => data.WaitUnSubscribe;
        }

        public IntervalValue WaitOriginScan {
            get => data.WaitOriginScan;
        }

        public void CookieChange(WorkshopCookie cookie) {
            if (WallpaperData.Sessionid.Equals(cookie.Name)) data.SessionId = cookie.Value;
            data.CookieContainer = Cookie.ToCookieContainer();
        }

        public bool ChangeVertical() {
            string configPath = WallpaperUtil.GetConfigPath(SteamFolder);
            File.Copy(configPath, $"{configPath}.bak.tool", true);
            HashMap<string, object> config = WallpaperUtil.GetConfig(SteamFolder);
            SetWallpaperConfig(config);
            data.ProjectInfos.Where(info => WallpaperData.Vertical.Contains(info.Direction)).Select(info => {
                string path = info.Path.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                if (data.Wproperties.ContainsKey(path)) {
                    HashMap<string, object> temp = data.Wproperties[path] as HashMap<string, object>;
                    if (!temp.ContainsKey(data.Lastselectedmonitor)) temp.Add(data.Lastselectedmonitor, new HashMap<string, object>());
                    temp = temp[data.Lastselectedmonitor] as HashMap<string, object>;
                    if (temp.ContainsKey("alignment")) temp["alignment"] = 1;
                    else temp.Add("alignment", 1);
                } else {
                    data.Wproperties.Add(path, new HashMap<string, object> {
                        { data.Lastselectedmonitor, new HashMap<string, object>{
                            { "alignment", 1 }
                        } }
                    });
                }
                return true;
            });
            JsonUtil.HashMap2File(config, configPath);
            return true;
        }

        public bool UnSubscribe(int min = 1, int max = 1) {
            if (taskQueue.ContainsKey("UnSubscribe")) {
                WriteLine(string.Format("取消订阅任务已存在, 请等待执行完成……"), Controller.OutType.InfoFile);
                return false;
            }
            DateTime now = DateTime.Now;
            Random random = new Random();
            int count = data.CheckCache.Where(item => null != item.Group).Select(item => item.Group.Count).Sum();
            WriteLine(string.Format("批量取消订阅开始, 预计时间{0}秒 - {1}秒", count * min, count * max), Controller.OutType.InfoFile);
            count = 0;
            const string n = "\t";
            Task<bool> task = Task.Run(() => {
                try {
                    foreach (ProjectInfo info in data.CheckCache) {
                        List<ProjectInfo> group = info.Group;
                        if (null != group && group.Count > 0) {
                            List<ProjectInfo> repets = group.Where(repet => {
                                Thread.Sleep(random.Next(min * 1000, max * 1000));
                                bool go = SteamUtil.UnSubscribe(data.CookieContainer, data.SessionId, WallpaperUtil.Appid, repet.ID);
                                WriteLine(++count + n + string.Format("{0}取消订阅{1}", repet.ID, go ? "完成" : "失败"), Controller.OutType.InfoFile);
                                return go;
                            }).ToList();
                            repets.ForEach(repet => group.Remove(repet));
                        }
                    }
                    WriteLine(string.Format("批量取消订阅结束, 本次共用时{0}秒", (int)Math.Round((DateTime.Now - now).TotalSeconds), 0), Controller.OutType.InfoFile);
                    taskQueue.Remove("UnSubscribe");
                    return true;
                } catch (Exception e) {
                    //throw e;
                    WriteLine(string.Format("批量取消订阅错误: {0}, 本次执行{1}秒", e.Message, (int)Math.Round((DateTime.Now - now).TotalSeconds), 0), Controller.OutType.InfoFile);
                    return false;
                }
            });
            taskQueue.Add("UnSubscribe", task);
            return true;
        }

        public bool DeleteSourceFolder() {
            HashMap<long, ProjectSource> mapping = data.ProjectSources.ToMap(item => long.Parse(item.Folder.Name), item => item);
            List<ProjectInfo> list = data.CheckCache.Select(item => item).ToList();
            list.ForEach(item => {
                if (mapping.ContainsKey(item.ID)) {
                    ProjectSource source = mapping[item.ID];
                    source.Folder.Delete(true);
                    data.CheckCache.Remove(item);
                }
            });
            return data.CheckCache.Count == 0;
        }

        public bool BeginScan(int min = 1, int max = 1) {
            HashMap<string, object> origin = config["Origin"] as HashMap<string, object>;
            HashMap<string, object> use = origin["use"] as HashMap<string, object>;
            string[] miscellaneous = (use["Miscellaneous"] as List<object>).Select(item => item.ToString()).ToArray();
            string[] type = (use["Type"] as List<object>).Select(item => item.ToString()).ToArray();
            string[] ageRating = (use["Age_Rating"] as List<object>).Select(item => item.ToString()).ToArray();
            string[] genre = (use["Genre"] as List<object>).Select(item => item.ToString()).ToArray();
            string[] resolution = (use["Resolution"] as List<object>).Select(item => item.ToString()).ToArray();
            string[] category = (use["Category"] as List<object>).Select(item => item.ToString()).ToArray();
            string[] assetType = (use["Asset_Type"] as List<object>).Select(item => item.ToString()).ToArray();
            string[] assetGenre = (use["Asset_Genre"] as List<object>).Select(item => item.ToString()).ToArray();
            string[] scriptType = (use["Script_Type"] as List<object>).Select(item => item.ToString()).ToArray();
            Random random = new Random();
            DateTime now = DateTime.Now;
            string nowStr = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            data.BrowseData.Clear();
            foreach (string _genre in genre) {
                string name = $"{type[0]}_{ageRating[0]}_{_genre}";
                if (taskQueue.ContainsKey(_genre)) {
                    WriteLine(string.Format("已存在{0}任务执行, 请等待……", name), Controller.OutType.InfoFile);
                    continue;
                }
                int detailConut = 0, browseCount = 0;
                Task<bool> task = Task.Run(() => {
                    PageCondition condition = new PageCondition {
                        Type = type[0],
                        AgeRating = ageRating[0],
                        Genre = _genre
                    };
                    WorkshopPager pager = WallpaperUtil.GetWorkshopBrowse(data.CookieContainer, condition);
                    if (pager.IsEmpty) {
                        WriteLine(string.Format("未能查询到{0}有效数据……", name), Controller.OutType.InfoFile);
                        taskQueue.Remove(_genre);
                        return false;
                    }
                    pager.GetType().GetField("page", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(pager, 0);
                    WriteLine(string.Format("开始收集{0}数据, 共{1}个文件, 预计时间{2}秒 - {3}秒", name, pager.Total, pager.Total * min, pager.Total * max), Controller.OutType.InfoFile);
                    try {
                        while ((pager = pager.NextPage(data.CookieContainer, WallpaperUtil.Appid)).Next) {
                            pager.Name = $"{name}_{pager.Page}";
                            pager.LastTime = nowStr;
                             List<object> items = pager.Items.Select(obj => {
                                BrowseItemPage browseItemPage = obj as BrowseItemPage;
                                Thread.Sleep(random.Next(min * 1000, max * 1000));
                                 FileDetailsPage detailsPage = SteamUtil.GetFileDetails(data.CookieContainer, browseItemPage.PublishedFileId);
                                 //lock (data.OriginData) {
                                 //    data.OriginData.Add(detailsPage);
                                 //}
                                 ++detailConut;
                                 return new WorkshopItem {
                                     PublishedFileId = browseItemPage.PublishedFileId,
                                     WorkshopItemTitle = browseItemPage.WorkshopItemTitle,
                                     Url = browseItemPage.Url,
                                     Borwse = browseItemPage.ToBrowseItem(),
                                     Details = detailsPage?.ToFileDetail()
                                 } as object;
                             }).ToList();
                            ++browseCount;
                            pager.Items = items;
                            pager.ReadTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                            //lock (data.BrowseData) {
                            //    data.BrowseData.Add(pager);
                            //}
                            JsonUtil.Json2File(pager, Path.Combine(origin["folderName"] as string, $"{pager.Name}.json"));
                            WriteLine(string.Format("{0}收集结束, 总共用时{1}秒", pager.Name, (long)(DateTime.Now - now).TotalSeconds), Controller.OutType.InfoFile);
                        }
                    } catch (Exception e) {
                        //throw e;
                        WriteLine(string.Format("发生错误: {0}, {1}即将结束……", e.Message, name), Controller.OutType.InfoFile);
                    }
                    WriteLine(string.Format("{0}收集结束, 共{1}页{2}项, 扫描到{3}页第{4}个文件, 用时{5}秒", name, pager.Pages, pager.Total, browseCount, detailConut, (long)(DateTime.Now - now).TotalSeconds), Controller.OutType.InfoFile);
                    taskQueue.Remove(_genre);
                    return true;
                });
                taskQueue.Add(_genre, task);
            }
            return true;
        }

        public WorkshopPager[] LoadWorkshopPages(HashSet<string> genres) {
            data.BrowseData.Clear();
            HashMap<string, object> origin = config["Origin"] as HashMap<string, object>;
            DirectoryInfo folder = new DirectoryInfo(origin["folderName"] as string);
            WorkshopPager[] list = SteamUtil.GetWorkshopPages(folder);
            if (list.Length > 0) {
                foreach (WorkshopPager item in list)
                    if (genres.Contains(item.Condition.Genre)) data.BrowseData.Add(item);
                if (data.BrowseData.Count > 0) LoadFileDetailsPages(data.BrowseData[0].Name);
                else data.OriginData.Clear();
            }
            return list;
        }

        public FileDetailsPage[] LoadFileDetailsPages(string name) {
            data.OriginData.Clear();
            WorkshopPager pager = data.BrowseData.FirstOrDefault(item => item.Name.Equals(name));
            if (null == pager) {
                HashMap<string, object> origin = config["Origin"] as HashMap<string, object>;
                string fileName = Path.Combine(origin["folderName"] as string, name, ".json");
            }
            FileDetailsPage[] list = pager.Items.Select(SteamUtil.GetFileDetailsPage).ToArray();
            foreach (FileDetailsPage item in list)
                data.OriginData.Add(item);
            return list;
        }

        public List<ProjectInfo> OrderBy(string name) {
            if (orderName.Equals(name)) {
                orderName = string.Empty;
                return data.ProjectInfos.OrderByDescending(item => item[name]).ToList();
            } else {
                orderName = name;
                return data.ProjectInfos.OrderBy(item => item[name]).ToList();
            }
        }

    }

}
