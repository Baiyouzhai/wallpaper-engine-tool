using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallpaper.Data {

    public static class TreeNodeExtend {

        public static List<TreeNode> GetNodes(this TreeNodeCollection treeNodeCollection, Func<TreeNode, bool> callback, bool hasChild = false) {
            List<TreeNode> checkeds = new List<TreeNode>();
            foreach (TreeNode node in treeNodeCollection) {
                if (callback(node)) {
                    checkeds.Add(node);
                    if (hasChild && node.Nodes.Count > 0) checkeds.AddRange(node.Nodes.GetNodes(callback, hasChild));
                }
            }
            return checkeds;
        }

        public static List<TreeNode> GetNodes(this TreeNodeCollection treeNodeCollection, string text, bool hasChild = false) {
            return treeNodeCollection.GetNodes((node) => node.Text.Equals(text), hasChild);
        }

        public static List<TreeNode> GetCheckeds(this TreeNodeCollection treeNodeCollection, bool hasChild = false) {
            List<TreeNode> checkeds = new List<TreeNode>();
            foreach (TreeNode node in treeNodeCollection) {
                if (node.Checked) {
                    checkeds.Add(node);
                    if (hasChild && node.Nodes.Count > 0) checkeds.AddRange(node.Nodes.GetCheckeds(hasChild));
                }
            }
            return checkeds;
        }

    }

}
