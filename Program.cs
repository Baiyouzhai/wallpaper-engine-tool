using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wallpaper.Views;

namespace Wallpaper {
    internal static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            //string temp = WebUtility.UrlEncode("CN|a8cfe2a8a9c609423be2d07343c153d3");
            //Console.WriteLine(temp);
        }
    }
}
