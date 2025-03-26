using System;
using System.IO;
using System.Text;

namespace Wallpaper.Controller {

    public class FileWriter {

        protected FileInfo outFile;
        protected StreamWriter streamWriter;

        public string Path {
            get => outFile?.FullName;
            set => OutFile = new FileInfo(value);
        }

        public FileInfo OutFile {
            get => outFile;
            set {
                if (null == value) throw new ArgumentNullException(nameof(value));
                if (outFile != value) streamWriter?.Close();
                outFile = value;
                streamWriter = new StreamWriter(new FileStream(outFile.FullName, FileMode.Truncate, FileAccess.Write), Encoding.UTF8) {
                    AutoFlush = true
                };
            }
        }

        public void WriteLine(string message) =>streamWriter?.WriteLine(message);

        public void Clear() {
            streamWriter?.Close();
            streamWriter = new StreamWriter(new FileStream(outFile.FullName, FileMode.Truncate, FileAccess.Write), Encoding.UTF8) {
                AutoFlush = true
            };
        }

        public void Close() {
            streamWriter?.Close();
        }

    }

}
