using System;
using System.Collections.Generic;

namespace NotBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(50);
            Node c1 = new Node(100);
            Node c2 = new Node(10);
            Node c3 = new Node(-5);
            Node c4 = new Node(0);
            Node c5 = new Node(33);
            Node c6 = new Node(1);
            Node c7 = new Node(2);
            Node c8 = new Node(3);
            Node c9 = new Node(300);
            Node c10 = new Node(350);


            root.SetChild(c1);
            root.SetChild(c2);
            c2.SetChild(c3);
            c3.SetChild(c4);
            c3.SetChild(c5);
            c3.SetChild(c6);
            c3.SetChild(c7);
            c3.SetChild(c8);

            c1.SetChild(c9);
            c1.SetChild(c10);

            TreeNode teste = new TreeNode(root);
            ICollection<Node> h1 = teste.FindChildrenForLevel(1);
            TreeNode teste1 = new TreeNode(root);
            ICollection<Node> h2 = teste1.FindChildrenForLevel(2);
            TreeNode teste2 = new TreeNode(root);
            ICollection<Node> h3 = teste2.FindChildrenForLevel(3);

            Console.ReadKey();
        }
    }
}
