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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using static Wallpaper.FormMain;
using static Wallpaper.WallpaperManage;

namespace Wallpaper.Views {

    public partial class FormMain2 : Form {

        private readonly WallpaperManage manage;
        private System.Timers.Timer textChangeTimer;
        private readonly Dialog dialog;
        private bool dialogDisplay;
        private int moveOffset;

        public FormMain2() {
            InitializeComponent();
            manage = new WallpaperManage();
            string temp = Convert.ToString(manage.Config["SteamFoler"]);
            if (!string.IsNullOrEmpty(temp)) {
                folderText.Text = temp;
                manage.SteamFolder = temp;
            }
            temp = Convert.ToString(manage.Config["OutFile"]);
            if (!string.IsNullOrEmpty(temp)) {
                outText.Text = temp;
                // manage.SetOutFile(new FileInfo(temp));
            }
            dialogDisplay = false;
            dialog = new Dialog();
            dialog.Other.Name = "清空";
            dialog.Other.Callback = (sender, e) => dialog.Clear();
            dialog.CloseCallBack = (sender, e) => {
                e.Cancel = true;
                dialog?.Hide();
                dialogDisplay = false;
            };
            manage.Console = dialog;
            skipType.SetItemCheckState(0, CheckState.Checked);
            manage.BindCookie(cookieTable);
            int index = null == manage.Config["OutType"] ? 0 : Convert.ToInt32(manage.Config["OutType"]);
            outComboBox.SelectedIndex = index < outComboBox.Items.Count ? index : outComboBox.Items.Count - 1;
            index = null == manage.Config["LastTabIndex"] ? mainTabControl.TabCount - 1 : Convert.ToInt32(manage.Config["LastTabIndex"]);
            mainTabControl.SelectedIndex = index < mainTabControl.TabCount ? index : mainTabControl.TabCount - 1;
            originTreeView.Nodes.AddRange(manage.OriginTreeView);
            TabControlChange(null, null);
        }

        private void FolderTextChanged(object sender, EventArgs e) {
            textChangeTimer?.Dispose();
            string text = folderText.Text;
            if (!string.IsNullOrEmpty(text)) {
                textChangeTimer = new System.Timers.Timer(1000) {
                    AutoReset = false
                };
                textChangeTimer.Elapsed += (obj, args) => {
                    string temp = SteamUtil.GetBasePath(text);
                    string temp1 = SteamUtil.GetSoftwarePath(text);
                    string temp2 = SteamUtil.GetWorkshopPath(text);
                    if (!new DirectoryInfo(temp1).Exists) {
                        MessageBox.Show(string.Format("当前文件夹未找到wallpaper_engine文件夹:\n    {0}", temp), "错误", MessageBoxButtons.OK);
                        dialog.Append(string.Format("Steam路径{0},未找到wallpaper_engine文件夹\n", temp));
                        temp = temp2.Substring(0, temp2.IndexOf(WallpaperUtil.WorkshopPath) - 1);
                    }
                    if (!new DirectoryInfo(temp2).Exists) {
                        MessageBox.Show(string.Format("当前文件夹未找到431960文件夹:\n    {0}", temp), "错误", MessageBoxButtons.OK);
                        dialog.Append(string.Format("Steam路径{0},未找到431960文件夹\n", temp));
                        temp = temp1.Substring(0, temp1.IndexOf(WallpaperUtil.SoftwarePath) - 1);
                    }
                    manage.SteamFolder = temp;
                    folderText.Text = temp;
                };
                textChangeTimer.Start();
            }
        }

        private void FolderButtonClick(object sender, EventArgs e) {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog {
                Description = "请选择Steam文件夹"
            };
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes) {
                string path = folderDialog.SelectedPath;
                folderText.Text = path;
            }
        }

        private void OutComboBoxSelectChanged(object sender, EventArgs e) {
            manage.OutType = outComboBox.SelectedIndex;
            switch (manage.OutType) {
                case 0:
                    dialogDisplay = false;
                    outTextLabel.Hide();
                    outText.Hide();
                    outButton.Hide();
                    break;
                case 1:
                    outTextLabel.Show();
                    outText.Show();
                    outButton.Show();
                    break;
                default:
                    break;
            }
        }

        private void CloseEvent(object sender, FormClosingEventArgs e) {
            DialogResult dr = MessageBox.Show("是否退出?", "提示:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK) { //如果单击“是”按钮
                e.Cancel = false; //关闭窗体
                manage.Close();
            } else if (dr == DialogResult.Cancel) {
                e.Cancel = true; //不执行操作
            }
        }

        private void MoveEvent(object sender, EventArgs e) {
            if (null != dialog) {
                dialog.DesktopLocation = new Point(Location.X + moveOffset, Location.Y);
            }
        }

        private void TabControlChange(object sender, EventArgs e) {
            int index = mainTabControl.SelectedIndex;
            manage.Config["LastTabIndex"] = index;
            //SuspendLayout(); 
            switch (index) {
                case 0:
                    Height = 600;
                    Width = 800;
                    mainTabControl.Width = 784;
                    sourceDataGridView.Width = 770;
                    moveOffset = 790;
                    break;
                case 1:
                    Height = 600;
                    Width = 800; //1600;
                    mainTabControl.Width = 784; //1584;
                    sourceDataGridView.Width = 770; //1570;
                    moveOffset = 790; //1590;
                    break;
                case 2:
                    Height = 600;
                    Width = 800; //1600;
                    mainTabControl.Width = 784; //1584;
                    sourceDataGridView.Width = 770; //1570;
                    moveOffset = 790; //1590;
                    break;
                case 3:
                    Height = 236;
                    Width = 800;
                    mainTabControl.Width = 784;
                    sourceDataGridView.Width = 770;
                    moveOffset = 790;
                    break;
                default:
                    break;
            }
            if (null != dialog) dialog.DesktopLocation = new Point(Location.X + moveOffset, Location.Y);
            //ResumeLayout(false);
        }

        private void OutDisplayButtonClick(object sender, EventArgs e) {
            if (dialogDisplay) {
                dialog?.Hide();
                outDisplayButton.Text = "显示";
            } else {
                if (null != dialog) {
                    dialog.Show();
                    dialog.DesktopLocation = new Point(Location.X + moveOffset, Location.Y);
                }
                outDisplayButton.Text = "隐藏";
            }
            dialogDisplay = !dialogDisplay;
        }

        private void OutTextChanged(object sender, EventArgs e) {
            textChangeTimer?.Dispose();
            textChangeTimer = new System.Timers.Timer(1000) {
                AutoReset = false
            };
            textChangeTimer.Elapsed += (obj, args) => {
                string text = outText.Text;
                if (!string.IsNullOrEmpty(text)) {
                    FileInfo file = new FileInfo(text);
                    if (file.Exists) {
                        manage.OutFile = file;
                    } else {
                        MessageBox.Show(string.Format("输出文件不存在:\n    {0}", outText.Text), "错误", MessageBoxButtons.OK);
                        dialog.Append(string.Format("输出文件{0}不存在", outText.Text));
                    }
                }
            };
            textChangeTimer.Start();
        }

        private void OutButtonClick(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog {
                Title = "请选择输出的文本文件",
                Filter = "文本文件|*.txt|日志文件|*.log|所有文件类型|*.*" //过滤文件类型
            };
            if (DialogResult.OK == fileDialog.ShowDialog()) {
                outText.Text = fileDialog.FileName;
            }
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            DataGridView dataGridView = (DataGridView)sender;
            int index = e.RowIndex;
            object tag = dataGridView.Rows[index].Tag;
            if (null == tag) return;
            ExpandState state = (ExpandState)tag;
            if (ExpandState.Expand == state) {
                for (int i = index + 1; i < dataGridView.RowCount - 1; i++) {
                    if (ExpandState.None == (ExpandState)dataGridView.Rows[i].Tag) {
                        dataGridView.Rows[i].Visible = false;
                    } else {
                        break;
                    }
                }
                dataGridView.Rows[index].Tag = ExpandState.Collapse;
            } else if (ExpandState.Collapse == state) {
                for (int i = index + 1; i < dataGridView.RowCount - 1; i++) {
                    if (ExpandState.None == (ExpandState)dataGridView.Rows[i].Tag) {
                        dataGridView.Rows[i].Visible = true;
                    } else {
                        break;
                    }
                }
                dataGridView.Rows[index].Tag = ExpandState.Expand;
            }
        }

        private void RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
            DataGridView dataGridView = (DataGridView)sender;
            int index = e.RowIndex;
            object tag = dataGridView.Rows[index].Tag;
            if (null == tag) return;
            ExpandState state = (ExpandState)tag;
            switch (state) {
                case ExpandState.Collapse:
                    e.Graphics.DrawImage(Properties.Resources.Expand, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5, 15, 15);
                    break;
                case ExpandState.Expand:
                    e.Graphics.DrawImage(Properties.Resources.Collapse, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5, 15, 15);
                    break;
                default: break;
            }
        }

        private void LoadSourceButtonClick(object sender, EventArgs e) {
            HashSet<string> skipType = new HashSet<string>();
            CheckedListBox.CheckedItemCollection checkedItems = this.skipType.CheckedItems;
            for (int i = 0; i < checkedItems.Count; i++) {
                string value = Convert.ToString(checkedItems[i]);
                //string[] types = value.Split('|')[2].Split(' ');
                //foreach (string type in types)
                //{
                //    skipType.Add(type);
                //}
                skipType.Add(value.Split('|')[1]);
            }
            List<ProjectInfo> projectInfos = manage.LoadSource(skipType, true);
            projectInfos.BindDataView(sourceDataGridView);
            mainTabControl.SelectedIndex = 1;
        }

        private void CookieTableCellChange(object sender, DataGridViewCellEventArgs e) {
            if (cookieTable.DataSource is DataTable dataTable && e.ColumnIndex == 1) {
                DataRow row = dataTable.Rows[e.RowIndex];
                string key = row["name"] as string ?? string.Empty;
                string value = row["value"] as string ?? string.Empty;
                manage.SetCookie(key, value);
            }
        }

        private void RequestProxyTestButtonClick(object sender, EventArgs e) {
            TestWebBrow testWebBrow = new TestWebBrow();
            testWebBrow.SetUrl(WallpaperUtil.WorkshopUrl);
            //HashMap<string, object> map = manage.GetCookieMap();
            //testWebBrow.SetUrl(WallpaperUtil.WorkshopUrl, map);
            testWebBrow.Show();
        }

        private void CheckRepeatButtonClick(object sender, EventArgs e) {
            List<ProjectInfo> projectInfos = manage.CheckRepeatSource();
            projectInfos.BindDataView(sourceDataGridView);
        }

        private void CheckEXEButtonClick(object sender, EventArgs e) {
            List<ProjectInfo> projectInfos = manage.CheckEXESource();
            projectInfos.BindDataView(sourceDataGridView);
        }

        private void VerticalChangeButtonClick(object sender, EventArgs e) {
            manage.ChangeVertical();
        }

        private void UnSubscribeButtonClick(object sender, EventArgs e) {
            manage.UnSubscribe();
        }

        private void ShowSourceButtonClick(object sender, EventArgs e) {
            HashSet<string> skipType = new HashSet<string>();
            CheckedListBox.CheckedItemCollection checkedItems = this.skipType.CheckedItems;
            for (int i = 0; i < checkedItems.Count; i++) {
                string value = Convert.ToString(checkedItems[i]);
                skipType.Add(value.Split('|')[1]);
            }
            List<ProjectInfo> projectInfos = manage.LoadSource(skipType, false);
            projectInfos.BindDataView(sourceDataGridView);
            mainTabControl.SelectedIndex = 1;
        }

        private void LockOriginUseChange(object sender, TreeViewCancelEventArgs e) {
            TreeNode node = e.Node;
            if (e.Action != TreeViewAction.ByMouse) return;
            else if (0 == node.Level) e.Cancel = true;
            else if (!"Genre".Equals(node.Parent.Text)) {
                foreach (TreeNode item in node.Parent.Nodes) {
                    if (node != item) item.Checked = false;
                }
            }
        }

        private void LockOriginUseChange(object sender, TreeViewEventArgs e) {
            TreeNode node = e.Node;
            if (node.Checked) manage.OriginUseAdd(node.Parent.Text, node.Text);
            else manage.OriginUseRemove(node.Parent.Text, node.Text);
        }

        private void BeginScan(object sender, EventArgs e) {
            originDataGridView.Rows.Clear();
            manage.BeginScan((item) => {
                //int rows = originDataGridView.Rows.Add(item.GetValues());
                //originDataGridView.FirstDisplayedScrollingRowIndex = rows; //翻滚最后一条
                //return rows;
                //originDataGridView.Rows.Insert(0, item.GetValues()); //总是会刷新，变卡
                //return 0;
            });
        }
    }

}
