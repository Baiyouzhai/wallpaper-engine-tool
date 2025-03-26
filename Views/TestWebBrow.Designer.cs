using System.IO;

namespace Wallpaper.Views {

    partial class TestWebBrow {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.url = new System.Windows.Forms.TextBox();
            this.toUrl = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.mainContainer.SetColumnSpan(this.webView2, 2);
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView2.Location = new System.Drawing.Point(0, 0);
            this.webView2.Margin = new System.Windows.Forms.Padding(0);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(800, 427);
            this.webView2.Source = new System.Uri("https://www.baidu.com", System.UriKind.Absolute);
            this.webView2.TabIndex = 1;
            this.webView2.ZoomFactor = 1D;
            // 
            // url
            // 
            this.url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.url.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.url.Location = new System.Drawing.Point(0, 427);
            this.url.Margin = new System.Windows.Forms.Padding(0);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(725, 23);
            this.url.TabIndex = 2;
            this.url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlKeyDown);
            // 
            // toUrl
            // 
            this.toUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toUrl.Location = new System.Drawing.Point(725, 427);
            this.toUrl.Margin = new System.Windows.Forms.Padding(0);
            this.toUrl.Name = "toUrl";
            this.toUrl.Size = new System.Drawing.Size(75, 23);
            this.toUrl.TabIndex = 3;
            this.toUrl.Text = "跳 转";
            this.toUrl.UseVisualStyleBackColor = true;
            this.toUrl.Click += new System.EventHandler(this.Goto);
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 2;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.mainContainer.Controls.Add(this.webView2, 0, 0);
            this.mainContainer.Controls.Add(this.url, 0, 1);
            this.mainContainer.Controls.Add(this.toUrl, 1, 1);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 2;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.mainContainer.Size = new System.Drawing.Size(800, 450);
            this.mainContainer.TabIndex = 4;
            // 
            // TestWebBrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer);
            this.Name = "TestWebBrow";
            this.Text = "创意工坊预览";
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button toUrl;
        private System.Windows.Forms.TableLayoutPanel mainContainer;

    }

}
