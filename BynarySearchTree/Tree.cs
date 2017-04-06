using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node Root { get; set; }

        public Node Insert(Node root, int value, Node parent)
        {
            if (root == null)
            {
                root = new Node(value, null, null, parent);
            }
            else if (value < root.Value)
            {
                root.Left = Insert(root.Left, value, root);
            }
            else
            {
                root.Right = Insert(root.Right, value, root);
            }

            return root;
        }

        public void RemoveNode(int value)
        {
            Node current = FindNode(value, Root);
            if (current == null)
            {
                return;
            }

            if (current.Left == null && current.Right == null)
            {
                if (value < current.Parent.Value)
                {
                    current.Parent.Left = null;
                }
                else
                {
                    current.Parent.Right = null;
                }
            }
            else if (current.Right == null)
            {
                current.Parent.Right = current.Left;
            }
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;
                if (current.Right.Value < current.Parent.Value)
                {
                    current.Parent.Left = current.Right;
                }
                else
                {
                    current.Parent.Right = current.Right;
                }
            }
            else
            {
                Node leftMost = current.Right.Left;
                while (leftMost.Left != null)
                {
                    leftMost = leftMost.Left;
                }
                leftMost.Parent.Left = leftMost.Right;
                leftMost.Left = current.Left;
                leftMost.Right = current.Right;

                if (current.Parent == null)
                {
                    Root = leftMost;
                    return;
                }
                if (current.Parent.Value >= current.Value)
                {
                    current.Parent.Left = leftMost;
                }
                else
                {
                    current.Parent.Right = leftMost;
                }
            }
            FindHead(current.Parent);
        }

        private void FindHead(Node current)
        {
            while (current.Parent != null)
            {
                current = current.Parent;
            }
            Root = current;
        }

        public void Traverse(Node root)
        {
            while (true)
            {
                if (root == null)
                {
                    return;
                }

                Traverse(root.Left);
                root = root.Right;
            }
        }

        public bool IsValid(Node root)
        {
            IEnumerable<int> nodes = InOrder(root).ToList();
            var expected = nodes.OrderBy(x => x);
            return nodes.SequenceEqual(expected);
        }

        public Node FindNode(int value, Node root)
        {
            Node current = root;
            Node result = null;

            while (current != null)
            {
                if (value > current.Value)
                {
                    current = current.Right;
                }
                else if (value < current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    result = current;
                    break;
                }
            }
            return result;
        }

        private static IEnumerable<int> InOrder(Node root)
        {
            while (true)
            {
                if (root == null)
                {
                    yield break;
                }

                foreach (var n in InOrder(root.Left))
                {
                    yield return n;
                }

                yield return root.Value;

                root = root.Right;
            }
        }
    }
}
