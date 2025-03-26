using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wallpaper.Util;

namespace Wallpaper.Model {

    public class ProjectInfo {

        protected long id;
        protected string title;
        protected string cacheName;
        protected bool consistentTitle;
        protected string visibility;
        protected string direction;
        protected string alignment;
        protected string type;
        protected string path;
        protected string fileName;
        protected string fileSize;
        protected string description;
        protected List<ProjectInfo> group;
        protected ProjectSource[] source = new ProjectSource[1];

        public long ID { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string CacheName { get => cacheName; set => cacheName = value; }
        public bool ConsistentTitle { get => consistentTitle; set => consistentTitle = value; }
        public string Visibility { get => visibility; set => visibility = value; }
        public string Direction { get => direction; set => direction = value; }
        public string Alignment { get => alignment; set => alignment = value; }
        public string Type { get => type; set => type = value; }
        public string Path { get => path; set => path = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public string FileSize { get => fileSize; set => fileSize = value; }
        public string Description { get => description; set => description = value; }
        public List<ProjectInfo> Group { get => group; set => group = value; }
        public ProjectSource[] Source { get => source; set => source = value; }

        public object this[string name] {
            get {
                string _name = name.ToLower();
                switch (_name) {
                    case "id": return id;
                    case "title": return title;
                    case "cachename": return cacheName;
                    case "consistenttitle": return consistentTitle;
                    case "visibility": return visibility;
                    case "direction": return direction;
                    case "alignment": return alignment;
                    case "type": return type;
                    case "path": return path;
                    case "filename": return fileName;
                    //case "filesize": return fileSize;
                    case "filesize": return source[0].FileSize;
                    case "description": return description;
                    case "source": return source;
                    default: return null;
                }
            }
        }

    }

    public enum ExpandState {
        None,
        Expand,
        Collapse
    }

    public static class ProjectInfoExtend {

        public static bool BindToDataView(this IEnumerable<ProjectInfo> list, DataGridView dataGridView) {
            BindingList<ProjectInfo> binding = dataGridView.DataSource as BindingList<ProjectInfo>;
            binding.Clear();
            DataGridViewRowCollection rows = dataGridView.Rows;
            int row = -1;
            foreach (ProjectInfo info in list) {
                binding.Add(info);
                if (null != info.Group && info.Group.Count > 0) {
                    rows[++row].Tag = ExpandState.Collapse;
                    foreach (ProjectInfo child in info.Group) {
                        binding.Add(child);
                        rows[++row].Tag = ExpandState.None;
                        rows[row].Visible = false;
                    }
                } else {
                    rows[++row].Tag = ExpandState.None;
                }
            }
            return true;
        }

    }

}
