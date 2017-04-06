namespace BinarySearchTree
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }

        public Node(int value, Node left, Node right, Node parent)
        {
            Value = value;
            Left = left;
            Right = right;
            Parent = parent;
        }
    }
}