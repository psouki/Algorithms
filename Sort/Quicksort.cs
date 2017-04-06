using System;
using System.Collections.Generic;

namespace Sort
{
    public class Quicksort
    {
        public static IList<T> Sort<T>(IList<T> list, int left, int right) where T : IComparable<T>
        {
            while (true)
            {
                int i = left;
                int j = right;
                T pivot = list[(left + right)/2];

                while (i <= j)
                {
                    while (list[i].CompareTo(pivot) < 0)
                        i++;

                    while (list[j].CompareTo(pivot) > 0)
                        j--;

                    if (i > j) continue;

                    T tmp = list[i];
                    list[i] = list[j];
                    list[j] = tmp;

                    i++;
                    j--;
                }

                if (left < j)
                    Sort(list, left, j);

                if (i < right)
                {
                    left = i;
                    continue;
                }
                break;
            }

            return list;
        }
    }
}
