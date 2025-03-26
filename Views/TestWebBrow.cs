using Microsoft.Web.WebView2.Core;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wallpaper.Model;
using Wallpaper.Util;

namespace Wallpaper.Views {

    public partial class TestWebBrow : Form {

        public TestWebBrow() {
            string appName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            WebUtil.SetWebBrowserFeatures(appName, 6000);
            InitializeComponent();
        }

        public void SetUrl(string url) {
            this.url.Text = url;
            Goto(null, null);
        }

        public void SetUrl(string url, List<WorkshopCookie> cookies) {
            SetUrl(url);
            //CoreWebView2Environment env = CoreWebView2Environment.CreateAsync().Result;
            //Task task = webView2.EnsureCoreWebView2Async(env).ContinueWith((obj) => {
            //});
            //foreach (WorkshopCookie cookie in cookies) {
            //    CoreWebView2Cookie temp = webView2.CoreWebView2.CookieManager.CreateCookie(cookie.Name, cookie.Value, cookie, "/");
            //    webView2.CoreWebView2.CookieManager.AddOrUpdateCookie(temp);
            //}
        }

        public void Execute(string script) {
            webView2.CoreWebView2.ExecuteScriptAsync(script);
        }

        private void Goto(object sender, EventArgs e) {
            string url = this.url.Text;
            if (!string.IsNullOrEmpty(url)) {
                try {
                    webView2.Source = new Uri(url);
                } catch (Exception) {
                    //throw e;
                }
            }
        }

        private void UrlKeyDown(object sender, KeyEventArgs e) {
            switch(e.KeyCode) {
                case Keys.Enter:
                    Goto(null, null);
                    break;
                default: break;
            }
        }
    }

}
