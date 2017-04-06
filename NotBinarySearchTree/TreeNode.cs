using System.Collections.Generic;

namespace NotBinarySearchTree
{
    public class TreeNode
    {
        public Node RootNode { get; set; }
        public HashSet<Node> LevelNodes { get; set; }

        public TreeNode(Node data)
        {
            RootNode = data;
            LevelNodes = new HashSet<Node>();
        }

        public ICollection<Node> FindChildrenForLevel(int level)
        {
            LevelNodes.Clear();
            PopulateLevelNodes(RootNode, level);
            return LevelNodes;
        }

        public void PopulateLevelNodes(Node root, int level, int h = 0)
        {
            h++;
            foreach (Node n in root.Children)
            {
                if (h == level)
                {
                    LevelNodes.Add(n);
                }
                else
                {
                    PopulateLevelNodes(n, level, h);
                }
            }
        }
    }
}
