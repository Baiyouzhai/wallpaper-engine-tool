using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.Controller {

    /// <summary>
    /// 消息类型
    /// </summary>
    public enum MessageType {
        /// <summary>
        /// 一般
        /// </summary>
        Info,
        /// <summary>
        /// 警告
        /// </summary>
        Warn,
        /// <summary>
        /// 异常
        /// </summary>
        Error
    }

    /// <summary>
    /// 消息封装类
    /// </summary>
    public class MessageWrap {

        /// <summary>
        /// 消息类型
        /// </summary>
        protected MessageType type;
        /// <summary>
        /// 时间
        /// </summary>
        protected DateTime date;
        /// <summary>
        /// 消息
        /// </summary>
        protected string message;

        public MessageWrap(MessageType type, DateTime date, string message) {
            this.type = type;
            this.date = date;
            this.message = message;
        }

        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType Type { get => type; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Date { get => date; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get => message; }

        public new string ToString() {
            return string.Format("{0} {1} {2}", date.ToString("yyyy-MM-dd HH:mm:ss"), type, message);
        }

    }

    public interface IConsole {

        /// <summary>
        /// 信息
        /// </summary>
        /// <param name="message"></param>
        void Info(string message);

        /// <summary>
        /// 所有信息
        /// </summary>
        List<MessageWrap> Infos { get; }

        /// <summary>
        /// 警告
        /// </summary>
        /// <param name="message"></param>
        void Warn(string message);

        /// <summary>
        /// 所有警告
        /// </summary>
        List<MessageWrap> Warns { get; }

        /// <summary>
        /// 异常
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);

        /// <summary>
        /// 所有异常
        /// </summary>
        List<MessageWrap> Errors { get; }

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        void Write(MessageType type, string message);

        /// <summary>
        /// 输出列表
        /// </summary>
        /// <param name="index"></param>
        MessageWrap this[int index] { get; }

        /// <summary>
        /// 清空
        /// </summary>
        void Clear();

        /// <summary>
        /// 记录数
        /// </summary>
        int Count { get; }

        void Close();

    }

}
