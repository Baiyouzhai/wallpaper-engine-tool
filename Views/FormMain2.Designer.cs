using System.Data;
using System.Windows.Forms;

namespace Wallpaper.Views {

    partial class FormMain2 {

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
            this.checkEXEButton = new System.Windows.Forms.Button();
            this.verticalChangeButton = new System.Windows.Forms.Button();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.checkRepeatButton = new System.Windows.Forms.Button();
            this.originViewPage = new System.Windows.Forms.TabPage();
            this.originViewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.originTreeView = new System.Windows.Forms.TreeView();
            this.originDataGridView = new System.Windows.Forms.DataGridView();
            this.originButtonPanel = new System.Windows.Forms.Panel();
            this.BeginScanButton = new System.Windows.Forms.Button();
            this.outSettingPage = new System.Windows.Forms.TabPage();
            this.outButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.folderText = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.outComboBox = new System.Windows.Forms.ComboBox();
            this.folderLabel = new System.Windows.Forms.Label();
            this.outLabel = new System.Windows.Forms.Label();
            this.outTextLabel = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cacheNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consistentTitleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visibilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedFileIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workshopItemTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workshopItemPreviewImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workshopItemAuthorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibilityNotificationPrivateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibilityNotificationFriendsOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numRatingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miscellaneousDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueVisitorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentSubscribersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentFavoritesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.originDataGridView)).BeginInit();
            this.originButtonPanel.SuspendLayout();
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
            this.cookieKey.DataPropertyName = "name";
            this.cookieKey.HeaderText = "名称";
            this.cookieKey.Name = "cookieKey";
            this.cookieKey.ReadOnly = true;
            this.cookieKey.Width = 200;
            // 
            // cookieValue
            // 
            this.cookieValue.DataPropertyName = "value";
            this.cookieValue.HeaderText = "值";
            this.cookieValue.Name = "cookieValue";
            this.cookieValue.Width = 200;
            // 
            // cookieTips
            // 
            this.cookieTips.DataPropertyName = "tips";
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
            this.sourceDataGridView.AutoGenerateColumns = false;
            this.sourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.cacheNameDataGridViewTextBoxColumn,
            this.consistentTitleDataGridViewCheckBoxColumn,
            this.visibilityDataGridViewTextBoxColumn,
            this.directionDataGridViewTextBoxColumn,
            this.alignmentDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.fileSizeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.sourceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.sourceDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.sourceDataGridView.Name = "sourceDataGridView";
            this.sourceDataGridView.RowTemplate.Height = 23;
            this.sourceDataGridView.Size = new System.Drawing.Size(776, 471);
            this.sourceDataGridView.TabIndex = 0;
            // 
            // sourceButtonPanel
            // 
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
            // checkEXEButton
            // 
            this.checkEXEButton.Location = new System.Drawing.Point(96, 0);
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
            this.originViewTableLayoutPanel.Controls.Add(this.originDataGridView, 1, 0);
            this.originViewTableLayoutPanel.Controls.Add(this.originButtonPanel, 0, 1);
            this.originViewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originViewTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.originViewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.originViewTableLayoutPanel.Name = "originViewTableLayoutPanel";
            this.originViewTableLayoutPanel.RowCount = 2;
            this.originViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.originTreeView.Size = new System.Drawing.Size(200, 471);
            this.originTreeView.TabIndex = 0;
            this.originTreeView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.LockOriginUseChange);
            this.originTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.LockOriginUseChange);
            // 
            // originDataGridView
            // 
            this.originDataGridView.AutoGenerateColumns = false;
            this.originDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publishedFileIdDataGridViewTextBoxColumn,
            this.workshopItemTitleDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.workshopItemPreviewImageDataGridViewTextBoxColumn,
            this.workshopItemAuthorNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.fileRatingDataGridViewTextBoxColumn,
            this.visibilityNotificationPrivateDataGridViewTextBoxColumn,
            this.visibilityNotificationFriendsOnlyDataGridViewTextBoxColumn,
            this.numRatingsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.miscellaneousDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn1,
            this.ageRatingDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.uniqueVisitorsDataGridViewTextBoxColumn,
            this.currentSubscribersDataGridViewTextBoxColumn,
            this.currentFavoritesDataGridViewTextBoxColumn});
            this.originDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originDataGridView.Location = new System.Drawing.Point(200, 0);
            this.originDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.originDataGridView.Name = "originDataGridView";
            this.originDataGridView.RowTemplate.Height = 23;
            this.originDataGridView.Size = new System.Drawing.Size(576, 471);
            this.originDataGridView.TabIndex = 1;
            // 
            // originButtonPanel
            // 
            this.originViewTableLayoutPanel.SetColumnSpan(this.originButtonPanel, 2);
            this.originButtonPanel.Controls.Add(this.BeginScanButton);
            this.originButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originButtonPanel.Location = new System.Drawing.Point(0, 471);
            this.originButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.originButtonPanel.Name = "originButtonPanel";
            this.originButtonPanel.Size = new System.Drawing.Size(776, 30);
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // cacheNameDataGridViewTextBoxColumn
            // 
            this.cacheNameDataGridViewTextBoxColumn.DataPropertyName = "CacheName";
            this.cacheNameDataGridViewTextBoxColumn.HeaderText = "CacheName";
            this.cacheNameDataGridViewTextBoxColumn.Name = "cacheNameDataGridViewTextBoxColumn";
            // 
            // consistentTitleDataGridViewCheckBoxColumn
            // 
            this.consistentTitleDataGridViewCheckBoxColumn.DataPropertyName = "ConsistentTitle";
            this.consistentTitleDataGridViewCheckBoxColumn.HeaderText = "ConsistentTitle";
            this.consistentTitleDataGridViewCheckBoxColumn.Name = "consistentTitleDataGridViewCheckBoxColumn";
            // 
            // visibilityDataGridViewTextBoxColumn
            // 
            this.visibilityDataGridViewTextBoxColumn.DataPropertyName = "Visibility";
            this.visibilityDataGridViewTextBoxColumn.HeaderText = "Visibility";
            this.visibilityDataGridViewTextBoxColumn.Name = "visibilityDataGridViewTextBoxColumn";
            // 
            // directionDataGridViewTextBoxColumn
            // 
            this.directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            this.directionDataGridViewTextBoxColumn.HeaderText = "Direction";
            this.directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            // 
            // alignmentDataGridViewTextBoxColumn
            // 
            this.alignmentDataGridViewTextBoxColumn.DataPropertyName = "Alignment";
            this.alignmentDataGridViewTextBoxColumn.HeaderText = "Alignment";
            this.alignmentDataGridViewTextBoxColumn.Name = "alignmentDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // fileSizeDataGridViewTextBoxColumn
            // 
            this.fileSizeDataGridViewTextBoxColumn.DataPropertyName = "FileSize";
            this.fileSizeDataGridViewTextBoxColumn.HeaderText = "FileSize";
            this.fileSizeDataGridViewTextBoxColumn.Name = "fileSizeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // publishedFileIdDataGridViewTextBoxColumn
            // 
            this.publishedFileIdDataGridViewTextBoxColumn.DataPropertyName = "PublishedFileId";
            this.publishedFileIdDataGridViewTextBoxColumn.HeaderText = "PublishedFileId";
            this.publishedFileIdDataGridViewTextBoxColumn.Name = "publishedFileIdDataGridViewTextBoxColumn";
            // 
            // workshopItemTitleDataGridViewTextBoxColumn
            // 
            this.workshopItemTitleDataGridViewTextBoxColumn.DataPropertyName = "WorkshopItemTitle";
            this.workshopItemTitleDataGridViewTextBoxColumn.HeaderText = "WorkshopItemTitle";
            this.workshopItemTitleDataGridViewTextBoxColumn.Name = "workshopItemTitleDataGridViewTextBoxColumn";
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // workshopItemPreviewImageDataGridViewTextBoxColumn
            // 
            this.workshopItemPreviewImageDataGridViewTextBoxColumn.DataPropertyName = "WorkshopItemPreviewImage";
            this.workshopItemPreviewImageDataGridViewTextBoxColumn.HeaderText = "WorkshopItemPreviewImage";
            this.workshopItemPreviewImageDataGridViewTextBoxColumn.Name = "workshopItemPreviewImageDataGridViewTextBoxColumn";
            // 
            // workshopItemAuthorNameDataGridViewTextBoxColumn
            // 
            this.workshopItemAuthorNameDataGridViewTextBoxColumn.DataPropertyName = "WorkshopItemAuthorName";
            this.workshopItemAuthorNameDataGridViewTextBoxColumn.HeaderText = "WorkshopItemAuthorName";
            this.workshopItemAuthorNameDataGridViewTextBoxColumn.Name = "workshopItemAuthorNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // fileRatingDataGridViewTextBoxColumn
            // 
            this.fileRatingDataGridViewTextBoxColumn.DataPropertyName = "FileRating";
            this.fileRatingDataGridViewTextBoxColumn.HeaderText = "FileRating";
            this.fileRatingDataGridViewTextBoxColumn.Name = "fileRatingDataGridViewTextBoxColumn";
            // 
            // visibilityNotificationPrivateDataGridViewTextBoxColumn
            // 
            this.visibilityNotificationPrivateDataGridViewTextBoxColumn.DataPropertyName = "VisibilityNotificationPrivate";
            this.visibilityNotificationPrivateDataGridViewTextBoxColumn.HeaderText = "VisibilityNotificationPrivate";
            this.visibilityNotificationPrivateDataGridViewTextBoxColumn.Name = "visibilityNotificationPrivateDataGridViewTextBoxColumn";
            // 
            // visibilityNotificationFriendsOnlyDataGridViewTextBoxColumn
            // 
            this.visibilityNotificationFriendsOnlyDataGridViewTextBoxColumn.DataPropertyName = "VisibilityNotificationFriendsOnly";
            this.visibilityNotificationFriendsOnlyDataGridViewTextBoxColumn.HeaderText = "VisibilityNotificationFriendsOnly";
            this.visibilityNotificationFriendsOnlyDataGridViewTextBoxColumn.Name = "visibilityNotificationFriendsOnlyDataGridViewTextBoxColumn";
            // 
            // numRatingsDataGridViewTextBoxColumn
            // 
            this.numRatingsDataGridViewTextBoxColumn.DataPropertyName = "NumRatings";
            this.numRatingsDataGridViewTextBoxColumn.HeaderText = "NumRatings";
            this.numRatingsDataGridViewTextBoxColumn.Name = "numRatingsDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // miscellaneousDataGridViewTextBoxColumn
            // 
            this.miscellaneousDataGridViewTextBoxColumn.DataPropertyName = "Miscellaneous";
            this.miscellaneousDataGridViewTextBoxColumn.HeaderText = "Miscellaneous";
            this.miscellaneousDataGridViewTextBoxColumn.Name = "miscellaneousDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            // 
            // ageRatingDataGridViewTextBoxColumn
            // 
            this.ageRatingDataGridViewTextBoxColumn.DataPropertyName = "AgeRating";
            this.ageRatingDataGridViewTextBoxColumn.HeaderText = "AgeRating";
            this.ageRatingDataGridViewTextBoxColumn.Name = "ageRatingDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // uniqueVisitorsDataGridViewTextBoxColumn
            // 
            this.uniqueVisitorsDataGridViewTextBoxColumn.DataPropertyName = "UniqueVisitors";
            this.uniqueVisitorsDataGridViewTextBoxColumn.HeaderText = "UniqueVisitors";
            this.uniqueVisitorsDataGridViewTextBoxColumn.Name = "uniqueVisitorsDataGridViewTextBoxColumn";
            // 
            // currentSubscribersDataGridViewTextBoxColumn
            // 
            this.currentSubscribersDataGridViewTextBoxColumn.DataPropertyName = "CurrentSubscribers";
            this.currentSubscribersDataGridViewTextBoxColumn.HeaderText = "CurrentSubscribers";
            this.currentSubscribersDataGridViewTextBoxColumn.Name = "currentSubscribersDataGridViewTextBoxColumn";
            // 
            // currentFavoritesDataGridViewTextBoxColumn
            // 
            this.currentFavoritesDataGridViewTextBoxColumn.DataPropertyName = "CurrentFavorites";
            this.currentFavoritesDataGridViewTextBoxColumn.HeaderText = "CurrentFavorites";
            this.currentFavoritesDataGridViewTextBoxColumn.Name = "currentFavoritesDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.originDataGridView)).EndInit();
            this.originButtonPanel.ResumeLayout(false);
            this.outSettingPage.ResumeLayout(false);
            this.outSettingPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button outDisplayButton;
        private System.Windows.Forms.Button loadSourceButton;
        private System.Windows.Forms.Panel mainBottomPanel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button showSourceButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage settingPage;
        private System.Windows.Forms.DataGridView cookieTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookieKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookieValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookieTips;
        private System.Windows.Forms.Label requestProxyLabel;
        private System.Windows.Forms.Button requestProxyTestButton;
        private System.Windows.Forms.Label skipTypeLabel;
        private System.Windows.Forms.CheckedListBox skipType;
        private System.Windows.Forms.TabPage sourceViewPage;
        private System.Windows.Forms.TableLayoutPanel sourceViewTableLayoutPanel;
        private System.Windows.Forms.DataGridView sourceDataGridView;
        private System.Windows.Forms.Panel sourceButtonPanel;
        private System.Windows.Forms.Button checkEXEButton;
        private System.Windows.Forms.Button verticalChangeButton;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button checkRepeatButton;
        private System.Windows.Forms.TabPage outSettingPage;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TextBox folderText;
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.ComboBox outComboBox;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label outTextLabel;
        private System.Windows.Forms.TabPage originViewPage;
        private System.Windows.Forms.TableLayoutPanel originViewTableLayoutPanel;
        private System.Windows.Forms.TreeView originTreeView;
        private System.Windows.Forms.DataGridView originDataGridView;
        private System.Windows.Forms.Panel originButtonPanel;
        private System.Windows.Forms.Button BeginScanButton;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cacheNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn consistentTitleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn visibilityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alignmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fileSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publishedFileIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workshopItemTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workshopItemPreviewImageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workshopItemAuthorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fileRatingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visibilityNotificationPrivateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visibilityNotificationFriendsOnlyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numRatingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn miscellaneousDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ageRatingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uniqueVisitorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentSubscribersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentFavoritesDataGridViewTextBoxColumn;
    }

}

