using System.IO;

using Wallpaper.Data;

namespace Wallpaper.Model {


    public class ProjectSource {

        protected DirectoryInfo folder;
        protected FileInfo jsonFile;
        protected HashMap<string, object> json;
        protected FileInfo file;
        protected long fileSize;
        protected string type;

        public DirectoryInfo Folder { get => folder; set => folder = value; }

        public FileInfo JsonFile { get => jsonFile; set => jsonFile = value; }

        public HashMap<string, object> Json { get => json; set => json = value; }

        public FileInfo File { get => file; set => file = value; }

        public long FileSize { get => fileSize; set => fileSize = value; }

        public string Type { get => type; set => type = value; }


    }

}
