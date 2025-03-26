using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wallpaper.Util;

namespace Wallpaper.Controller {

    public enum OutType {
        File,
        Info,
        Warn,
        Error,
        InfoFile,
        WarnFile,
        ErrorFile
    }

    public class OutManage {

        protected OutType outType;
        protected IConsole console;
        protected FileWriter fileWriter;

        public OutManage() {
            fileWriter = new FileWriter();
            console = new SimpleConsole();
        }

        public IConsole Console {
            get {
                if (null == console) console = new SimpleConsole();
                return console;
            }
            set {
                console?.Close();
                console = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public FileWriter FileWriter {
            get {
                if (null == fileWriter) fileWriter = new FileWriter();
                return fileWriter;
            }
            set {
                fileWriter?.Close();
                fileWriter = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public FileInfo OutFile {
            get => fileWriter.OutFile;
            set => fileWriter.OutFile = value;
        }

        public void WriteLine(string message, OutType outType) {
            switch (outType) {
                case OutType.File: FileWriter.WriteLine(message); break;
                case OutType.Info: Console.Info($"{message}\r\n"); break;
                case OutType.Warn: Console.Warn(message); break;
                case OutType.Error: Console.Error(message); break;
                case OutType.InfoFile:
                case OutType.WarnFile:
                case OutType.ErrorFile:
                    Console.Write((outType.ToInt32() - 4).ToEnum<MessageType>(), message);
                    FileWriter.WriteLine(message);
                    break;
                default:
                    break;
            }
        }

        public void Clear() {
            console.Clear();
            fileWriter.Clear();
        }

        public void Close() {
            console.Close();
            fileWriter.Close();
        }

    }

}
