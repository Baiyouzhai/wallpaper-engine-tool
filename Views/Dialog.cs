using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wallpaper.Controller;

namespace Wallpaper.Views {

    public partial class Dialog : Form, IConsole {

        public const string NewLine = "\r\n";

        protected ButtonWrap confirmWrap;
        protected ButtonWrap cancelWrap;
        protected ButtonWrap otherWrap;
        private Action<object, FormClosingEventArgs> closeCallBack;
        protected List<MessageWrap> messages;

        public string Title {
            get => Text;
            set => Text = value ?? string.Empty;
        }

        public string Message {
            get => messageBox.Text;
            set => messageBox.Text = value ?? string.Empty;
        }

        public void Append(string message) {
            messageBox.Text += message;
            messageBox.ScrollToCaret();
        }

        public ButtonWrap Confirm { get => confirmWrap; set => confirmWrap = value ?? throw new ArgumentNullException(nameof(value)); }

        public ButtonWrap Cancel { get => cancelWrap; set => cancelWrap = value ?? throw new ArgumentNullException(nameof(value)); }

        public ButtonWrap Other { get => otherWrap; set => otherWrap = value ?? throw new ArgumentNullException(nameof(value)); }

        public Action<object, FormClosingEventArgs> CloseCallBack { get => closeCallBack; set => closeCallBack = value; }

        public List<MessageWrap> Infos => messages.FindAll(wrap => MessageType.Info == wrap.Type);

        public List<MessageWrap> Warns => messages.FindAll(wrap => MessageType.Warn == wrap.Type);

        public List<MessageWrap> Errors => messages.FindAll(wrap => MessageType.Error == wrap.Type);

        public int Count => messages.Count;

        public MessageWrap this[int index] {
            get => messages[index];
        }

        public Dialog() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            confirmWrap = new ButtonWrap(confirm, (sender, e) => { });
            cancelWrap = new ButtonWrap(cancel, (sender, e) => { });
            otherWrap = new ButtonWrap(other, (sender, e) => { });
            messages = new List<MessageWrap>();
        }

        private void ConfirmClick(object sender, EventArgs e) {
            confirmWrap?.Callback.Invoke(sender, e);
        }

        private void CancelClick(object sender, EventArgs e) {
            cancelWrap?.Callback.Invoke(sender, e);
        }

        private void OtherClick(object sender, EventArgs e) {
            otherWrap?.Callback.Invoke(sender, e);
        }

        private void CloseEvent(object sender, FormClosingEventArgs e) {
            closeCallBack.Invoke(sender, e);
        }

        public void Info(string message) => Write(MessageType.Info, message + NewLine);

        public void Warn(string message) => Write(MessageType.Warn, message + NewLine);

        public void Error(string message) => Write(MessageType.Error, message + NewLine);

        public void Write(MessageType type, string message) {
            MessageWrap wrap = new MessageWrap(type, DateTime.Now, message);
            lock (messages) {
                messages.Add(wrap);
            }
            messageBox.Text += message + NewLine;
            messageBox.Select(messageBox.TextLength, 0);
            messageBox.ScrollToCaret();
        }

        public void Clear() {
            messageBox.Text = string.Empty;
            messages.Clear();
        }

    }

}
