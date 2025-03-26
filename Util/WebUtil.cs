using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Util {

    public class WebUtil {

        /// <summary>
        /// 修改注册表信息来兼容当前程序
        /// </summary>
        public static void SetWebBrowserFeatures(string appName, uint ieVersion) {
            // don't change the registry if running in-proc inside Visual Studio
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
                return;
            //得到浏览器的模式的值
            uint ieMode = GeoEmulationModee(ieVersion);
            var featureControlRegKey = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\";
            //设置浏览器对应用程序（appName）以什么模式（ieMode）运行  
            Registry.SetValue(featureControlRegKey + "FEATURE_BROWSER_EMULATION", appName, ieMode, RegistryValueKind.DWord);
            // enable the features which are "On" for the full Internet Explorer browser
            //不晓得设置有什么用
            Registry.SetValue(featureControlRegKey + "FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", appName, 1, RegistryValueKind.DWord);
            //Registry.SetValue(featureControlRegKey + "FEATURE_AJAX_CONNECTIONEVENTS", appName, 1, RegistryValueKind.DWord);
            //Registry.SetValue(featureControlRegKey + "FEATURE_GPU_RENDERING", appName, 1, RegistryValueKind.DWord);
            //Registry.SetValue(featureControlRegKey + "FEATURE_WEBOC_DOCUMENT_ZOOM", appName, 1, RegistryValueKind.DWord);
            //Registry.SetValue(featureControlRegKey + "FEATURE_NINPUT_LEGACYMODE", appName, 0, RegistryValueKind.DWord);  
        }

        public static void SetWebBrowserFeatures(uint ieVersion) => SetWebBrowserFeatures(Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName), ieVersion);

        /// <summary>
        /// 获取浏览器的版本
        /// </summary>
        public static int GetBrowserVersion() {
            int browserVersion = 0;
            using (var ieKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer",
                RegistryKeyPermissionCheck.ReadSubTree,
                System.Security.AccessControl.RegistryRights.QueryValues)) {
                var version = ieKey.GetValue("svcVersion");
                if (null == version) {
                    version = ieKey.GetValue("Version");
                    if (null == version)
                        throw new ApplicationException("Microsoft Internet Explorer is required!");
                }
                int.TryParse(version.ToString().Split('.')[0], out browserVersion);
            }
            //如果小于7
            if (browserVersion < 7) {
                throw new ApplicationException("不支持的浏览器版本!");
            }
            return browserVersion;
        }

        /// <summary>
        /// 通过版本得到浏览器模式的值
        /// </summary>
        public static uint GeoEmulationModee(uint browserVersion) {
            switch (browserVersion) {
                case 7: return 7000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode.
                case 8: return 8000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode.
                case 9: return 9000; // Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode.
                case 10: return 10000; // Internet Explorer 10.
                case 11: return 11000; // Internet Explorer 11
                default: return browserVersion;
            }
        }

    }

}
