using System;
using System.Data;
using System.Windows.Forms;

namespace Wallpaper.Views {

    partial class FormMain {

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.loadSourceButton = new System.Windows.Forms.Button();
            this.mainBottomPanel = new System.Windows.Forms.Panel();
            this.showSourceButton = new System.Windows.Forms.Button();
            this.outDisplayButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.settingPage = new System.Windows.Forms.TabPage();
            this.cookieTable = new System.Windows.Forms.DataGridView();
            this.cookieKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookieValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookieTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestProxyLabel = new System.Windows.Forms.Label();
            this.requestProxyTestButton = new System.Windows.Forms.Button();
            this.skipTypeLabel = new System.Windows.Forms.Label();
            this.skipType = new System.Windows.Forms.CheckedListBox();
            this.sourceViewPage = new System.Windows.Forms.TabPage();
            this.sourceViewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sourceDataGridView = new System.Windows.Forms.DataGridView();
            this.sourceButtonPanel = new System.Windows.Forms.Panel();
            this.checkDeleteButton = new System.Windows.Forms.Button();
            this.checkEXEButton = new System.Windows.Forms.Button();
            this.verticalChangeButton = new System.Windows.Forms.Button();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.checkRepeatButton = new System.Windows.Forms.Button();
            this.originViewPage = new System.Windows.Forms.TabPage();
            this.originViewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.originTreeView = new System.Windows.Forms.TreeView();
            this.originTable = new System.Windows.Forms.DataGridView();
            this.originPublishedFileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originWorkshopItemTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originWorkshopItemPreviewImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originWorkshopItemAuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originFileRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originVisibilityNotificationPrivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originVisibilityNotificationFriendsOnly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originNumRatings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originMiscellaneous = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originAgeRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originResolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originUniqueVisitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originCurrentSubscribers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originCurrentFavorites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originButtonPanel = new System.Windows.Forms.Panel();
            this.BeginScanButton = new System.Windows.Forms.Button();
            this.browseTable = new System.Windows.Forms.DataGridView();
            this.browseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseLastTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseReadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browsePage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browsePages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseIsEmpty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseNext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outSettingPage = new System.Windows.Forms.TabPage();
            this.outButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.folderText = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.outComboBox = new System.Windows.Forms.ComboBox();
            this.folderLabel = new System.Windows.Forms.Label();
            this.outLabel = new System.Windows.Forms.Label();
            this.outTextLabel = new System.Windows.Forms.Label();
            this.sourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceCacheName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceConsistentTitle = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sourceVisibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceAlignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainBottomPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.settingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cookieTable)).BeginInit();
            this.sourceViewPage.SuspendLayout();
            this.sourceViewTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDataGridView)).BeginInit();
            this.sourceButtonPanel.SuspendLayout();
            this.originViewPage.SuspendLayout();
            this.originViewTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originTable)).BeginInit();
            this.originButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browseTable)).BeginInit();
            this.outSettingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadSourceButton
            // 
            this.loadSourceButton.Location = new System.Drawing.Point(0, 0);
            this.loadSourceButton.Margin = new System.Windows.Forms.Padding(0);
            this.loadSourceButton.Name = "loadSourceButton";
            this.loadSourceButton.Size = new System.Drawing.Size(96, 30);
            this.loadSourceButton.TabIndex = 1;
            this.loadSourceButton.Text = "加载资源";
            this.loadSourceButton.UseVisualStyleBackColor = true;
            this.loadSourceButton.Click += new System.EventHandler(this.LoadSourceButtonClick);
            // 
            // mainBottomPanel
            // 
            this.mainBottomPanel.Controls.Add(this.showSourceButton);
            this.mainBottomPanel.Controls.Add(this.loadSourceButton);
            this.mainBottomPanel.Controls.Add(this.outDisplayButton);
            this.mainBottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBottomPanel.Location = new System.Drawing.Point(0, 531);
            this.mainBottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainBottomPanel.Name = "mainBottomPanel";
            this.mainBottomPanel.Size = new System.Drawing.Size(784, 30);
            this.mainBottomPanel.TabIndex = 2;
            // 
            // showSourceButton
            // 
            this.showSourceButton.Location = new System.Drawing.Point(96, 0);
            this.showSourceButton.Margin = new System.Windows.Forms.Padding(0);
            this.showSourceButton.Name = "showSourceButton";
            this.showSourceButton.Size = new System.Drawing.Size(96, 30);
            this.showSourceButton.TabIndex = 8;
            this.showSourceButton.Text = "显示资源";
            this.showSourceButton.UseVisualStyleBackColor = true;
            this.showSourceButton.Click += new System.EventHandler(this.ShowSourceButtonClick);
            // 
            // outDisplayButton
            // 
            this.outDisplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outDisplayButton.Location = new System.Drawing.Point(688, 0);
            this.outDisplayButton.Margin = new System.Windows.Forms.Padding(0);
            this.outDisplayButton.Name = "outDisplayButton";
            this.outDisplayButton.Size = new System.Drawing.Size(96, 30);
            this.outDisplayButton.TabIndex = 7;
            this.outDisplayButton.Text = "显示输出";
            this.outDisplayButton.UseVisualStyleBackColor = true;
            this.outDisplayButton.Click += new System.EventHandler(this.OutDisplayButtonClick);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.mainTabControl, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.mainBottomPanel, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(784, 561);
            this.mainTableLayoutPanel.TabIndex = 8;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.settingPage);
            this.mainTabControl.Controls.Add(this.sourceViewPage);
            this.mainTabControl.Controls.Add(this.originViewPage);
            this.mainTabControl.Controls.Add(this.outSettingPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(784, 531);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlChange);
            // 
            // settingPage
            // 
            this.settingPage.Controls.Add(this.cookieTable);
            this.settingPage.Controls.Add(this.requestProxyLabel);
            this.settingPage.Controls.Add(this.requestProxyTestButton);
            this.settingPage.Controls.Add(this.skipTypeLabel);
            this.settingPage.Controls.Add(this.skipType);
            this.settingPage.Location = new System.Drawing.Point(4, 26);
            this.settingPage.Margin = new System.Windows.Forms.Padding(0);
            this.settingPage.Name = "settingPage";
            this.settingPage.Size = new System.Drawing.Size(776, 501);
            this.settingPage.TabIndex = 0;
            this.settingPage.Text = "加载设置";
            this.settingPage.UseVisualStyleBackColor = true;
            // 
            // cookieTable
            // 
            this.cookieTable.AllowUserToAddRows = false;
            this.cookieTable.AllowUserToDeleteRows = false;
            this.cookieTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cookieTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cookieKey,
            this.cookieValue,
            this.cookieTips});
            this.cookieTable.Location = new System.Drawing.Point(70, 85);
            this.cookieTable.Name = "cookieTable";
            this.cookieTable.RowTemplate.Height = 23;
            this.cookieTable.Size = new System.Drawing.Size(698, 211);
            this.cookieTable.TabIndex = 8;
            this.cookieTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CookieTableCellChange);
            // 
            // cookieKey
            // 
            this.cookieKey.DataPropertyName = "Name";
            this.cookieKey.HeaderText = "名称";
            this.cookieKey.Name = "cookieKey";
            this.cookieKey.ReadOnly = true;
            this.cookieKey.Width = 200;
            // 
            // cookieValue
            // 
            this.cookieValue.DataPropertyName = "Value";
            this.cookieValue.HeaderText = "值";
            this.cookieValue.Name = "cookieValue";
            this.cookieValue.Width = 200;
            // 
            // cookieTips
            // 
            this.cookieTips.DataPropertyName = "Tips";
            this.cookieTips.HeaderText = "提示";
            this.cookieTips.Name = "cookieTips";
            this.cookieTips.ReadOnly = true;
            this.cookieTips.Width = 200;
            // 
            // requestProxyLabel
            // 
            this.requestProxyLabel.AutoSize = true;
            this.requestProxyLabel.Location = new System.Drawing.Point(8, 85);
            this.requestProxyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.requestProxyLabel.Name = "requestProxyLabel";
            this.requestProxyLabel.Size = new System.Drawing.Size(56, 17);
            this.requestProxyLabel.TabIndex = 7;
            this.requestProxyLabel.Text = "请求代理";
            // 
            // requestProxyTestButton
            // 
            this.requestProxyTestButton.Location = new System.Drawing.Point(70, 302);
            this.requestProxyTestButton.Name = "requestProxyTestButton";
            this.requestProxyTestButton.Size = new System.Drawing.Size(75, 23);
            this.requestProxyTestButton.TabIndex = 2;
            this.requestProxyTestButton.Text = "测试连接";
            this.requestProxyTestButton.UseVisualStyleBackColor = true;
            this.requestProxyTestButton.Click += new System.EventHandler(this.RequestProxyTestButtonClick);
            // 
            // skipTypeLabel
            // 
            this.skipTypeLabel.AutoSize = true;
            this.skipTypeLabel.Location = new System.Drawing.Point(8, 3);
            this.skipTypeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.skipTypeLabel.Name = "skipTypeLabel";
            this.skipTypeLabel.Size = new System.Drawing.Size(56, 17);
            this.skipTypeLabel.TabIndex = 1;
            this.skipTypeLabel.Text = "忽略类型";
            // 
            // skipType
            // 
            this.skipType.CheckOnClick = true;
            this.skipType.FormattingEnabled = true;
            this.skipType.Items.AddRange(new object[] {
            "壁纸|scene|.pkg",
            "视频|video|.mp4 .webm",
            "网页|html|.html .htm",
            "程序|exe|.exe .apk"});
            this.skipType.Location = new System.Drawing.Point(70, 3);
            this.skipType.Name = "skipType";
            this.skipType.Size = new System.Drawing.Size(170, 76);
            this.skipType.TabIndex = 0;
            // 
            // sourceViewPage
            // 
            this.sourceViewPage.Controls.Add(this.sourceViewTableLayoutPanel);
            this.sourceViewPage.Location = new System.Drawing.Point(4, 26);
            this.sourceViewPage.Margin = new System.Windows.Forms.Padding(0);
            this.sourceViewPage.Name = "sourceViewPage";
            this.sourceViewPage.Size = new System.Drawing.Size(776, 501);
            this.sourceViewPage.TabIndex = 2;
            this.sourceViewPage.Text = "资源浏览";
            this.sourceViewPage.UseVisualStyleBackColor = true;
            // 
            // sourceViewTableLayoutPanel
            // 
            this.sourceViewTableLayoutPanel.ColumnCount = 1;
            this.sourceViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sourceViewTableLayoutPanel.Controls.Add(this.sourceDataGridView, 0, 0);
            this.sourceViewTableLayoutPanel.Controls.Add(this.sourceButtonPanel, 0, 1);
            this.sourceViewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceViewTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sourceViewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sourceViewTableLayoutPanel.Name = "sourceViewTableLayoutPanel";
            this.sourceViewTableLayoutPanel.RowCount = 2;
            this.sourceViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sourceViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.sourceViewTableLayoutPanel.Size = new System.Drawing.Size(776, 501);
            this.sourceViewTableLayoutPanel.TabIndex = 1;
            // 
            // sourceDataGridView
            // 
            this.sourceDataGridView.AllowUserToAddRows = false;
            this.sourceDataGridView.AllowUserToDeleteRows = false;
            this.sourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sourceId,
            this.sourceTitle,
            this.sourceCacheName,
            this.sourceConsistentTitle,
            this.sourceVisibility,
            this.sourceDirection,
            this.sourceAlignment,
            this.sourceType,
            this.sourcePath,
            this.sourceFileName,
            this.sourceFileSize,
            this.sourceDescription});
            this.sourceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.sourceDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.sourceDataGridView.MultiSelect = false;
            this.sourceDataGridView.Name = "sourceDataGridView";
            this.sourceDataGridView.ReadOnly = true;
            this.sourceDataGridView.RowTemplate.Height = 23;
            this.sourceDataGridView.Size = new System.Drawing.Size(776, 471);
            this.sourceDataGridView.TabIndex = 0;
            this.sourceDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
            this.sourceDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.RowPostPaint);
            // 
            // sourceButtonPanel
            // 
            this.sourceButtonPanel.Controls.Add(this.checkDeleteButton);
            this.sourceButtonPanel.Controls.Add(this.checkEXEButton);
            this.sourceButtonPanel.Controls.Add(this.verticalChangeButton);
            this.sourceButtonPanel.Controls.Add(this.unsubscribeButton);
            this.sourceButtonPanel.Controls.Add(this.checkRepeatButton);
            this.sourceButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceButtonPanel.Location = new System.Drawing.Point(0, 471);
            this.sourceButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sourceButtonPanel.Name = "sourceButtonPanel";
            this.sourceButtonPanel.Size = new System.Drawing.Size(776, 30);
            this.sourceButtonPanel.TabIndex = 1;
            // 
            // checkDeleteButton
            // 
            this.checkDeleteButton.Location = new System.Drawing.Point(96, 0);
            this.checkDeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.checkDeleteButton.Name = "checkDeleteButton";
            this.checkDeleteButton.Size = new System.Drawing.Size(96, 30);
            this.checkDeleteButton.TabIndex = 11;
            this.checkDeleteButton.Text = "删除标记检查";
            this.checkDeleteButton.UseVisualStyleBackColor = true;
            this.checkDeleteButton.Click += new System.EventHandler(this.CheckDeleteButtonClick);
            // 
            // checkEXEButton
            // 
            this.checkEXEButton.Location = new System.Drawing.Point(192, 0);
            this.checkEXEButton.Margin = new System.Windows.Forms.Padding(0);
            this.checkEXEButton.Name = "checkEXEButton";
            this.checkEXEButton.Size = new System.Drawing.Size(96, 30);
            this.checkEXEButton.TabIndex = 10;
            this.checkEXEButton.Text = "exe检查";
            this.checkEXEButton.UseVisualStyleBackColor = true;
            this.checkEXEButton.Click += new System.EventHandler(this.CheckEXEButtonClick);
            // 
            // verticalChangeButton
            // 
            this.verticalChangeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.verticalChangeButton.Enabled = false;
            this.verticalChangeButton.Location = new System.Drawing.Point(584, 0);
            this.verticalChangeButton.Margin = new System.Windows.Forms.Padding(0);
            this.verticalChangeButton.Name = "verticalChangeButton";
            this.verticalChangeButton.Size = new System.Drawing.Size(96, 30);
            this.verticalChangeButton.TabIndex = 8;
            this.verticalChangeButton.Text = "一键竖屏";
            this.verticalChangeButton.UseVisualStyleBackColor = true;
            this.verticalChangeButton.Click += new System.EventHandler(this.VerticalChangeButtonClick);
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.unsubscribeButton.Enabled = false;
            this.unsubscribeButton.Location = new System.Drawing.Point(680, 0);
            this.unsubscribeButton.Margin = new System.Windows.Forms.Padding(0);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(96, 30);
            this.unsubscribeButton.TabIndex = 9;
            this.unsubscribeButton.Text = "取消订阅";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.UnSubscribeButtonClick);
            // 
            // checkRepeatButton
            // 
            this.checkRepeatButton.Location = new System.Drawing.Point(0, 0);
            this.checkRepeatButton.Margin = new System.Windows.Forms.Padding(0);
            this.checkRepeatButton.Name = "checkRepeatButton";
            this.checkRepeatButton.Size = new System.Drawing.Size(96, 30);
            this.checkRepeatButton.TabIndex = 2;
            this.checkRepeatButton.Text = "重复检查";
            this.checkRepeatButton.UseVisualStyleBackColor = true;
            this.checkRepeatButton.Click += new System.EventHandler(this.CheckRepeatButtonClick);
            // 
            // originViewPage
            // 
            this.originViewPage.Controls.Add(this.originViewTableLayoutPanel);
            this.originViewPage.Location = new System.Drawing.Point(4, 26);
            this.originViewPage.Margin = new System.Windows.Forms.Padding(0);
            this.originViewPage.Name = "originViewPage";
            this.originViewPage.Size = new System.Drawing.Size(776, 501);
            this.originViewPage.TabIndex = 3;
            this.originViewPage.Text = "原始浏览";
            this.originViewPage.UseVisualStyleBackColor = true;
            // 
            // originViewTableLayoutPanel
            // 
            this.originViewTableLayoutPanel.ColumnCount = 2;
            this.originViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.originViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.originViewTableLayoutPanel.Controls.Add(this.originTreeView, 0, 0);
            this.originViewTableLayoutPanel.Controls.Add(this.originTable, 1, 0);
            this.originViewTableLayoutPanel.Controls.Add(this.originButtonPanel, 0, 2);
            this.originViewTableLayoutPanel.Controls.Add(this.browseTable, 1, 1);
            this.originViewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originViewTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.originViewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.originViewTableLayoutPanel.Name = "originViewTableLayoutPanel";
            this.originViewTableLayoutPanel.RowCount = 3;
            this.originViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.originViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.originViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.originViewTableLayoutPanel.Size = new System.Drawing.Size(776, 501);
            this.originViewTableLayoutPanel.TabIndex = 0;
            // 
            // originTreeView
            // 
            this.originTreeView.CheckBoxes = true;
            this.originTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originTreeView.Location = new System.Drawing.Point(0, 0);
            this.originTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.originTreeView.Name = "originTreeView";
            this.originViewTableLayoutPanel.SetRowSpan(this.originTreeView, 2);
            this.originTreeView.Size = new System.Drawing.Size(200, 470);
            this.originTreeView.TabIndex = 0;
            this.originTreeView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.LockOriginUseChange);
            this.originTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.LockOriginUseChange);
            // 
            // originTable
            // 
            this.originTable.AllowUserToAddRows = false;
            this.originTable.AllowUserToDeleteRows = false;
            this.originTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.originPublishedFileId,
            this.originWorkshopItemTitle,
            this.originUrl,
            this.originWorkshopItemPreviewImage,
            this.originWorkshopItemAuthorName,
            this.originDescription,
            this.originFileRating,
            this.originVisibilityNotificationPrivate,
            this.originVisibilityNotificationFriendsOnly,
            this.originNumRatings,
            this.originSize,
            this.originCreateTime,
            this.originMiscellaneous,
            this.originType,
            this.originAgeRating,
            this.originGenre,
            this.originResolution,
            this.originCategory,
            this.originUniqueVisitors,
            this.originCurrentSubscribers,
            this.originCurrentFavorites});
            this.originTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originTable.Location = new System.Drawing.Point(200, 0);
            this.originTable.Margin = new System.Windows.Forms.Padding(0);
            this.originTable.Name = "originTable";
            this.originTable.RowTemplate.Height = 23;
            this.originTable.Size = new System.Drawing.Size(576, 282);
            this.originTable.TabIndex = 1;
            // 
            // originPublishedFileId
            // 
            this.originPublishedFileId.DataPropertyName = "PublishedFileId";
            this.originPublishedFileId.HeaderText = "PublishedFileId";
            this.originPublishedFileId.Name = "originPublishedFileId";
            this.originPublishedFileId.ReadOnly = true;
            // 
            // originWorkshopItemTitle
            // 
            this.originWorkshopItemTitle.DataPropertyName = "WorkshopItemTitle";
            this.originWorkshopItemTitle.HeaderText = "WorkshopItemTitle";
            this.originWorkshopItemTitle.Name = "originWorkshopItemTitle";
            this.originWorkshopItemTitle.ReadOnly = true;
            // 
            // originUrl
            // 
            this.originUrl.DataPropertyName = "Url";
            this.originUrl.HeaderText = "Url";
            this.originUrl.Name = "originUrl";
            this.originUrl.ReadOnly = true;
            // 
            // originWorkshopItemPreviewImage
            // 
            this.originWorkshopItemPreviewImage.DataPropertyName = "WorkshopItemPreviewImage";
            this.originWorkshopItemPreviewImage.HeaderText = "WorkshopItemPreviewImage";
            this.originWorkshopItemPreviewImage.Name = "originWorkshopItemPreviewImage";
            this.originWorkshopItemPreviewImage.ReadOnly = true;
            // 
            // originWorkshopItemAuthorName
            // 
            this.originWorkshopItemAuthorName.DataPropertyName = "WorkshopItemAuthorName";
            this.originWorkshopItemAuthorName.HeaderText = "WorkshopItemAuthorName";
            this.originWorkshopItemAuthorName.Name = "originWorkshopItemAuthorName";
            this.originWorkshopItemAuthorName.ReadOnly = true;
            // 
            // originDescription
            // 
            this.originDescription.DataPropertyName = "Description";
            this.originDescription.HeaderText = "Description";
            this.originDescription.Name = "originDescription";
            this.originDescription.ReadOnly = true;
            // 
            // originFileRating
            // 
            this.originFileRating.DataPropertyName = "FileRating";
            this.originFileRating.HeaderText = "FileRating";
            this.originFileRating.Name = "originFileRating";
            this.originFileRating.ReadOnly = true;
            // 
            // originVisibilityNotificationPrivate
            // 
            this.originVisibilityNotificationPrivate.DataPropertyName = "VisibilityNotificationPrivate";
            this.originVisibilityNotificationPrivate.HeaderText = "VisibilityNotificationPrivate";
            this.originVisibilityNotificationPrivate.Name = "originVisibilityNotificationPrivate";
            this.originVisibilityNotificationPrivate.ReadOnly = true;
            // 
            // originVisibilityNotificationFriendsOnly
            // 
            this.originVisibilityNotificationFriendsOnly.DataPropertyName = "VisibilityNotificationFriendsOnly";
            this.originVisibilityNotificationFriendsOnly.HeaderText = "VisibilityNotificationFriendsOnly";
            this.originVisibilityNotificationFriendsOnly.Name = "originVisibilityNotificationFriendsOnly";
            this.originVisibilityNotificationFriendsOnly.ReadOnly = true;
            // 
            // originNumRatings
            // 
            this.originNumRatings.DataPropertyName = "NumRatings";
            this.originNumRatings.HeaderText = "NumRatings";
            this.originNumRatings.Name = "originNumRatings";
            this.originNumRatings.ReadOnly = true;
            // 
            // originSize
            // 
            this.originSize.DataPropertyName = "Size";
            this.originSize.HeaderText = "Size";
            this.originSize.Name = "originSize";
            this.originSize.ReadOnly = true;
            // 
            // originCreateTime
            // 
            this.originCreateTime.DataPropertyName = "CreateTime";
            this.originCreateTime.HeaderText = "CreateTime";
            this.originCreateTime.Name = "originCreateTime";
            this.originCreateTime.ReadOnly = true;
            // 
            // originMiscellaneous
            // 
            this.originMiscellaneous.DataPropertyName = "Miscellaneous";
            this.originMiscellaneous.HeaderText = "Miscellaneous";
            this.originMiscellaneous.Name = "originMiscellaneous";
            this.originMiscellaneous.ReadOnly = true;
            // 
            // originType
            // 
            this.originType.DataPropertyName = "Type";
            this.originType.HeaderText = "Type";
            this.originType.Name = "originType";
            this.originType.ReadOnly = true;
            // 
            // originAgeRating
            // 
            this.originAgeRating.DataPropertyName = "AgeRating";
            this.originAgeRating.HeaderText = "AgeRating";
            this.originAgeRating.Name = "originAgeRating";
            this.originAgeRating.ReadOnly = true;
            // 
            // originGenre
            // 
            this.originGenre.DataPropertyName = "Genre";
            this.originGenre.HeaderText = "Genre";
            this.originGenre.Name = "originGenre";
            this.originGenre.ReadOnly = true;
            // 
            // originResolution
            // 
            this.originResolution.DataPropertyName = "Resolution";
            this.originResolution.HeaderText = "Resolution";
            this.originResolution.Name = "originResolution";
            this.originResolution.ReadOnly = true;
            // 
            // originCategory
            // 
            this.originCategory.DataPropertyName = "Category";
            this.originCategory.HeaderText = "Category";
            this.originCategory.Name = "originCategory";
            this.originCategory.ReadOnly = true;
            // 
            // originUniqueVisitors
            // 
            this.originUniqueVisitors.DataPropertyName = "UniqueVisitors";
            this.originUniqueVisitors.HeaderText = "UniqueVisitors";
            this.originUniqueVisitors.Name = "originUniqueVisitors";
            this.originUniqueVisitors.ReadOnly = true;
            // 
            // originCurrentSubscribers
            // 
            this.originCurrentSubscribers.DataPropertyName = "CurrentSubscribers";
            this.originCurrentSubscribers.HeaderText = "CurrentSubscribers";
            this.originCurrentSubscribers.Name = "originCurrentSubscribers";
            this.originCurrentSubscribers.ReadOnly = true;
            // 
            // originCurrentFavorites
            // 
            this.originCurrentFavorites.DataPropertyName = "CurrentFavorites";
            this.originCurrentFavorites.HeaderText = "CurrentFavorites";
            this.originCurrentFavorites.Name = "originCurrentFavorites";
            this.originCurrentFavorites.ReadOnly = true;
            // 
            // originButtonPanel
            // 
            this.originViewTableLayoutPanel.SetColumnSpan(this.originButtonPanel, 2);
            this.originButtonPanel.Controls.Add(this.BeginScanButton);
            this.originButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originButtonPanel.Location = new System.Drawing.Point(0, 470);
            this.originButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.originButtonPanel.Name = "originButtonPanel";
            this.originButtonPanel.Size = new System.Drawing.Size(776, 31);
            this.originButtonPanel.TabIndex = 2;
            // 
            // BeginScanButton
            // 
            this.BeginScanButton.Location = new System.Drawing.Point(0, 0);
            this.BeginScanButton.Margin = new System.Windows.Forms.Padding(0);
            this.BeginScanButton.Name = "BeginScanButton";
            this.BeginScanButton.Size = new System.Drawing.Size(96, 30);
            this.BeginScanButton.TabIndex = 0;
            this.BeginScanButton.Text = "开始扫描";
            this.BeginScanButton.UseVisualStyleBackColor = true;
            this.BeginScanButton.Click += new System.EventHandler(this.BeginScan);
            // 
            // browseTable
            // 
            this.browseTable.AllowUserToAddRows = false;
            this.browseTable.AllowUserToDeleteRows = false;
            this.browseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.browseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.browseName,
            this.browseLastTime,
            this.browseReadTime,
            this.browsePage,
            this.browseSize,
            this.browseTotal,
            this.browsePages,
            this.browseUrl,
            this.browseIsEmpty,
            this.browseNext});
            this.browseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseTable.Location = new System.Drawing.Point(200, 282);
            this.browseTable.Margin = new System.Windows.Forms.Padding(0);
            this.browseTable.Name = "browseTable";
            this.browseTable.RowTemplate.Height = 23;
            this.browseTable.Size = new System.Drawing.Size(576, 188);
            this.browseTable.TabIndex = 3;
            this.browseTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LoadWorkshopPage);
            // 
            // browseName
            // 
            this.browseName.DataPropertyName = "Name";
            this.browseName.HeaderText = "Name";
            this.browseName.Name = "browseName";
            this.browseName.ReadOnly = true;
            // 
            // browseLastTime
            // 
            this.browseLastTime.DataPropertyName = "LastTime";
            this.browseLastTime.HeaderText = "LastTime";
            this.browseLastTime.Name = "browseLastTime";
            this.browseLastTime.ReadOnly = true;
            // 
            // browseReadTime
            // 
            this.browseReadTime.DataPropertyName = "ReadTime";
            this.browseReadTime.HeaderText = "ReadTime";
            this.browseReadTime.Name = "browseReadTime";
            this.browseReadTime.ReadOnly = true;
            // 
            // browsePage
            // 
            this.browsePage.DataPropertyName = "Page";
            this.browsePage.HeaderText = "Page";
            this.browsePage.Name = "browsePage";
            this.browsePage.ReadOnly = true;
            // 
            // browseSize
            // 
            this.browseSize.DataPropertyName = "Size";
            this.browseSize.HeaderText = "Size";
            this.browseSize.Name = "browseSize";
            this.browseSize.ReadOnly = true;
            // 
            // browseTotal
            // 
            this.browseTotal.DataPropertyName = "Total";
            this.browseTotal.HeaderText = "Total";
            this.browseTotal.Name = "browseTotal";
            this.browseTotal.ReadOnly = true;
            // 
            // browsePages
            // 
            this.browsePages.DataPropertyName = "Pages";
            this.browsePages.HeaderText = "Pages";
            this.browsePages.Name = "browsePages";
            this.browsePages.ReadOnly = true;
            // 
            // browseUrl
            // 
            this.browseUrl.DataPropertyName = "Url";
            this.browseUrl.HeaderText = "Url";
            this.browseUrl.Name = "browseUrl";
            this.browseUrl.ReadOnly = true;
            // 
            // browseIsEmpty
            // 
            this.browseIsEmpty.DataPropertyName = "IsEmpty";
            this.browseIsEmpty.HeaderText = "IsEmpty";
            this.browseIsEmpty.Name = "browseIsEmpty";
            this.browseIsEmpty.ReadOnly = true;
            // 
            // browseNext
            // 
            this.browseNext.DataPropertyName = "Next";
            this.browseNext.HeaderText = "Next";
            this.browseNext.Name = "browseNext";
            this.browseNext.ReadOnly = true;
            // 
            // outSettingPage
            // 
            this.outSettingPage.Controls.Add(this.outButton);
            this.outSettingPage.Controls.Add(this.folderButton);
            this.outSettingPage.Controls.Add(this.folderText);
            this.outSettingPage.Controls.Add(this.outText);
            this.outSettingPage.Controls.Add(this.outComboBox);
            this.outSettingPage.Controls.Add(this.folderLabel);
            this.outSettingPage.Controls.Add(this.outLabel);
            this.outSettingPage.Controls.Add(this.outTextLabel);
            this.outSettingPage.Location = new System.Drawing.Point(4, 26);
            this.outSettingPage.Margin = new System.Windows.Forms.Padding(0);
            this.outSettingPage.Name = "outSettingPage";
            this.outSettingPage.Size = new System.Drawing.Size(776, 501);
            this.outSettingPage.TabIndex = 1;
            this.outSettingPage.Text = "输出文件";
            this.outSettingPage.UseVisualStyleBackColor = true;
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(525, 88);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(38, 25);
            this.outButton.TabIndex = 8;
            this.outButton.Text = "…";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.OutButtonClick);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(525, 26);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(38, 25);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "…";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.FolderButtonClick);
            // 
            // folderText
            // 
            this.folderText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.folderText.Location = new System.Drawing.Point(139, 25);
            this.folderText.Name = "folderText";
            this.folderText.Size = new System.Drawing.Size(380, 25);
            this.folderText.TabIndex = 1;
            this.folderText.TextChanged += new System.EventHandler(this.FolderTextChanged);
            // 
            // outText
            // 
            this.outText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.outText.Location = new System.Drawing.Point(139, 87);
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(380, 25);
            this.outText.TabIndex = 7;
            this.outText.TextChanged += new System.EventHandler(this.OutTextChanged);
            // 
            // outComboBox
            // 
            this.outComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outComboBox.FormattingEnabled = true;
            this.outComboBox.Items.AddRange(new object[] {
            "控制台",
            "文件"});
            this.outComboBox.Location = new System.Drawing.Point(139, 56);
            this.outComboBox.Name = "outComboBox";
            this.outComboBox.Size = new System.Drawing.Size(114, 25);
            this.outComboBox.TabIndex = 4;
            this.outComboBox.SelectedIndexChanged += new System.EventHandler(this.OutComboBoxSelectChanged);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(30, 30);
            this.folderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(103, 17);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "steam文件夹位置";
            this.folderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(77, 92);
            this.outLabel.Margin = new System.Windows.Forms.Padding(3);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(56, 17);
            this.outLabel.TabIndex = 3;
            this.outLabel.Text = "输出方式";
            this.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outTextLabel
            // 
            this.outTextLabel.AutoSize = true;
            this.outTextLabel.Location = new System.Drawing.Point(77, 59);
            this.outTextLabel.Margin = new System.Windows.Forms.Padding(3);
            this.outTextLabel.Name = "outTextLabel";
            this.outTextLabel.Size = new System.Drawing.Size(56, 17);
            this.outTextLabel.TabIndex = 6;
            this.outTextLabel.Text = "文件路径";
            this.outTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sourceId
            // 
            this.sourceId.DataPropertyName = "ID";
            this.sourceId.HeaderText = "ID";
            this.sourceId.Name = "sourceId";
            this.sourceId.ReadOnly = true;
            // 
            // sourceTitle
            // 
            this.sourceTitle.DataPropertyName = "Title";
            this.sourceTitle.HeaderText = "Title";
            this.sourceTitle.Name = "sourceTitle";
            this.sourceTitle.ReadOnly = true;
            // 
            // sourceCacheName
            // 
            this.sourceCacheName.DataPropertyName = "CacheName";
            this.sourceCacheName.HeaderText = "CacheName";
            this.sourceCacheName.Name = "sourceCacheName";
            this.sourceCacheName.ReadOnly = true;
            // 
            // sourceConsistentTitle
            // 
            this.sourceConsistentTitle.DataPropertyName = "ConsistentTitle";
            this.sourceConsistentTitle.HeaderText = "ConsistentTitle";
            this.sourceConsistentTitle.Name = "sourceConsistentTitle";
            this.sourceConsistentTitle.ReadOnly = true;
            // 
            // sourceVisibility
            // 
            this.sourceVisibility.DataPropertyName = "Visibility";
            this.sourceVisibility.HeaderText = "Visibility";
            this.sourceVisibility.Name = "sourceVisibility";
            this.sourceVisibility.ReadOnly = true;
            // 
            // sourceDirection
            // 
            this.sourceDirection.DataPropertyName = "Direction";
            this.sourceDirection.HeaderText = "Direction";
            this.sourceDirection.Name = "sourceDirection";
            this.sourceDirection.ReadOnly = true;
            // 
            // sourceAlignment
            // 
            this.sourceAlignment.DataPropertyName = "Alignment";
            this.sourceAlignment.HeaderText = "Alignment";
            this.sourceAlignment.Name = "sourceAlignment";
            this.sourceAlignment.ReadOnly = true;
            // 
            // sourceType
            // 
            this.sourceType.DataPropertyName = "Type";
            this.sourceType.HeaderText = "Type";
            this.sourceType.Name = "sourceType";
            this.sourceType.ReadOnly = true;
            // 
            // sourcePath
            // 
            this.sourcePath.DataPropertyName = "Path";
            this.sourcePath.HeaderText = "Path";
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.ReadOnly = true;
            // 
            // sourceFileName
            // 
            this.sourceFileName.DataPropertyName = "FileName";
            this.sourceFileName.HeaderText = "FileName";
            this.sourceFileName.Name = "sourceFileName";
            this.sourceFileName.ReadOnly = true;
            // 
            // sourceFileSize
            // 
            this.sourceFileSize.DataPropertyName = "FileSize";
            this.sourceFileSize.HeaderText = "FileSize";
            this.sourceFileSize.Name = "sourceFileSize";
            this.sourceFileSize.ReadOnly = true;
            // 
            // sourceDescription
            // 
            this.sourceDescription.DataPropertyName = "Description";
            this.sourceDescription.HeaderText = "Description";
            this.sourceDescription.Name = "sourceDescription";
            this.sourceDescription.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Wallpaper小工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseEvent);
            this.Move += new System.EventHandler(this.MoveEvent);
            this.mainBottomPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.settingPage.ResumeLayout(false);
            this.settingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cookieTable)).EndInit();
            this.sourceViewPage.ResumeLayout(false);
            this.sourceViewTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceDataGridView)).EndInit();
            this.sourceButtonPanel.ResumeLayout(false);
            this.originViewPage.ResumeLayout(false);
            this.originViewTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originTable)).EndInit();
            this.originButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browseTable)).EndInit();
            this.outSettingPage.ResumeLayout(false);
            this.outSettingPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button outDisplayButton;
        private Button loadSourceButton;
        private Panel mainBottomPanel;
        private TableLayoutPanel mainTableLayoutPanel;
        private Button showSourceButton;
        private TabControl mainTabControl;
        private TabPage settingPage;
        private DataGridView cookieTable;
        private DataGridViewTextBoxColumn cookieKey;
        private DataGridViewTextBoxColumn cookieValue;
        private DataGridViewTextBoxColumn cookieTips;
        private Label requestProxyLabel;
        private Button requestProxyTestButton;
        private Label skipTypeLabel;
        private CheckedListBox skipType;
        private TabPage sourceViewPage;
        private TableLayoutPanel sourceViewTableLayoutPanel;
        private DataGridView sourceDataGridView;
        private Panel sourceButtonPanel;
        private Button checkEXEButton;
        private Button verticalChangeButton;
        private Button unsubscribeButton;
        private Button checkRepeatButton;
        private TabPage outSettingPage;
        private Button outButton;
        private Button folderButton;
        private TextBox folderText;
        private TextBox outText;
        private ComboBox outComboBox;
        private Label folderLabel;
        private Label outLabel;
        private Label outTextLabel;
        private TabPage originViewPage;
        private TableLayoutPanel originViewTableLayoutPanel;
        private TreeView originTreeView;
        private DataGridView originTable;
        private DataGridViewTextBoxColumn originPublishedFileId;
        private DataGridViewTextBoxColumn originWorkshopItemTitle;
        private DataGridViewTextBoxColumn originUrl;
        private DataGridViewTextBoxColumn originWorkshopItemPreviewImage;
        private DataGridViewTextBoxColumn originWorkshopItemAuthorName;
        private DataGridViewTextBoxColumn originDescription;
        private DataGridViewTextBoxColumn originFileRating;
        private DataGridViewTextBoxColumn originVisibilityNotificationPrivate;
        private DataGridViewTextBoxColumn originVisibilityNotificationFriendsOnly;
        private DataGridViewTextBoxColumn originNumRatings;
        private DataGridViewTextBoxColumn originSize;
        private DataGridViewTextBoxColumn originCreateTime;
        private DataGridViewTextBoxColumn originMiscellaneous;
        private DataGridViewTextBoxColumn originType;
        private DataGridViewTextBoxColumn originAgeRating;
        private DataGridViewTextBoxColumn originGenre;
        private DataGridViewTextBoxColumn originResolution;
        private DataGridViewTextBoxColumn originCategory;
        private DataGridViewTextBoxColumn originUniqueVisitors;
        private DataGridViewTextBoxColumn originCurrentSubscribers;
        private DataGridViewTextBoxColumn originCurrentFavorites;
        private Panel originButtonPanel;
        private Button BeginScanButton;
        private DataGridView browseTable;
        private DataGridViewTextBoxColumn browseName;
        private DataGridViewTextBoxColumn browseLastTime;
        private DataGridViewTextBoxColumn browseReadTime;
        private DataGridViewTextBoxColumn browsePage;
        private DataGridViewTextBoxColumn browseSize;
        private DataGridViewTextBoxColumn browseTotal;
        private DataGridViewTextBoxColumn browsePages;
        private DataGridViewTextBoxColumn browseUrl;
        private DataGridViewTextBoxColumn browseIsEmpty;
        private DataGridViewTextBoxColumn browseNext;
        private Button checkDeleteButton;
        private DataGridViewTextBoxColumn sourceId;
        private DataGridViewTextBoxColumn sourceTitle;
        private DataGridViewTextBoxColumn sourceCacheName;
        private DataGridViewCheckBoxColumn sourceConsistentTitle;
        private DataGridViewTextBoxColumn sourceVisibility;
        private DataGridViewTextBoxColumn sourceDirection;
        private DataGridViewTextBoxColumn sourceAlignment;
        private DataGridViewTextBoxColumn sourceType;
        private DataGridViewTextBoxColumn sourcePath;
        private DataGridViewTextBoxColumn sourceFileName;
        private DataGridViewTextBoxColumn sourceFileSize;
        private DataGridViewTextBoxColumn sourceDescription;
    }

}

