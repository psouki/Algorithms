using System;
using System.Diagnostics;
using System.Linq;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node root = null;
            Tree bst = new Tree {Root = null};

            const int size = 19;
            //int[] a = new int[size];
            //const int valueToFindIndex = 31;
            int valueToFind =0;

            Console.WriteLine($"Generating random array with {size} values ...");

            Random random = new Random();
            Stopwatch watch = Stopwatch.StartNew();
            int[] a = { 8, 4, 15, 2, 6, 11, 17, 1, 3, 5, 7, 9, 13, 16, 18, 10, 12, 14, 19 };

            //for (int i = 0; i < size; i++)
            //{
            //    int nextNumber = random.Next(19);
            //    while (a.Contains(nextNumber))
            //    {
            //        nextNumber = random.Next(20);
            //    }
            //    a[i] = nextNumber;
            //    //if (i == valueToFindIndex)
            //    //{
            //    //    valueToFind = a[i];
            //    //}
            //}

            watch.Stop();

            Console.WriteLine($"Done. Took {watch.ElapsedMilliseconds / 1000.0} seconds");
            Console.WriteLine();
            Console.WriteLine($"Filling the tree with {size} nodes ...");

            watch = Stopwatch.StartNew();

            for (int i = 0; i < size; i++)
            {
               bst.Root = bst.Insert(bst.Root, a[i], null);
            }

            watch.Stop();

            Console.WriteLine($"Done. Took {watch.ElapsedMilliseconds / 1000.0} seconds");
            Console.WriteLine();
            Console.WriteLine($"Traversing all {size} nodes in the tree ...");

            watch = Stopwatch.StartNew();

            bst.Traverse(bst.Root);

            watch.Stop();

            Console.WriteLine($"Done. Took {watch.ElapsedMilliseconds / 1000.0} seconds");
            Console.WriteLine();
            Console.WriteLine($"Verifying if the binary tree is valid ...");

            watch = Stopwatch.StartNew();

            bool valid = bst.IsValid(bst.Root);

            watch.Stop();

            string validationResult = valid ? "valid" : "invalid";
            Console.WriteLine($"Done. Took {watch.ElapsedMilliseconds / 1000.0} seconds to validate that the tree is {validationResult}");
            Console.WriteLine();

            bst.RemoveNode(13);
            //bst.RemoveNode(6);
            //valueToFind = 1231231231;
            Node foundNode = bst.FindNode(valueToFind, bst.Root);

            string findResult = foundNode != null
                ? $"Node found: value - {foundNode.Value}, left value {foundNode.Left?.Value}, right value {foundNode.Right?.Value} "
                : "Node not found";
            Console.WriteLine(findResult);

            Console.ReadKey();
        }
    }
}