using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int> { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
            list = Quicksort.Sort(list, 0, list.Count - 1);

            Console.ReadKey();
        }
    }
}
