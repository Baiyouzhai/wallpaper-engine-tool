using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Controller {

    public class SimpleConsole : IConsole {

        protected List<MessageWrap> messages;

        public SimpleConsole() {
            messages = new List<MessageWrap>();
            // System.Diagnostics.Trace.WriteLine(message);
        }

        public MessageWrap this[int index] {
            get => messages[index];
        }

        public void Info(string message) => Write(MessageType.Info, message + "\n");

        public List<MessageWrap> Infos => messages.FindAll(wrap => MessageType.Info == wrap.Type);

        public void Warn(string message) => Write(MessageType.Warn, message + "\n");

        public List<MessageWrap> Warns => messages.FindAll(wrap => MessageType.Warn == wrap.Type);

        public void Error(string message) => Write(MessageType.Error, message + "\n");

        public List<MessageWrap> Errors => messages.FindAll(wrap => MessageType.Error == wrap.Type);

        public void Write(MessageType type, string message) {
            MessageWrap wrap = new MessageWrap(type, DateTime.Now, message);
            messages.Add(wrap);
            System.Diagnostics.Trace.WriteLine(wrap.ToString());
        }

        public void Clear() {
            messages.Clear();
        }

        public int Count => messages.Count;

        public void Close() {
            Clear();
        }

    }

}
