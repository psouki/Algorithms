using System.Collections.Generic;

namespace NotBinarySearchTree
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
            Children = new HashSet<Node>();
        }
        public int Value { get; set; }
        public HashSet<Node> Children { get; set; }

        public void SetChild(Node node)
        {
            Children.Add(node);
        }

    }
}
