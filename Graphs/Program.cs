using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            // GPS test
            //Gps gps = new Gps();

            //gps.AddOrUpdate(1, 3);
            //gps.AddOrUpdate(2, 2);
            //gps.AddOrUpdate(1, 1);

            //Console.WriteLine(gps.PollClosestCity());
            //Console.WriteLine(gps.PollClosestCity());

            //Dijkstra 
            Dijktras dij = new Dijktras();
            Dictionary<char, int> aVertex = new Dictionary<char, int> {{'b', 7}, {'c', 9}, {'d', 14}};
            dij.add_vertex('a', aVertex);

            Dictionary<char, int> bVertex = new Dictionary<char, int> { { 'a', 7 }, { 'e', 15 }, { 'c', 10 } };
            dij.add_vertex('b', bVertex);

            Dictionary<char, int> cVertex = new Dictionary<char, int> { { 'a', 9 }, { 'b', 10 }, { 'd', 2 }, {'e', 11}};
            dij.add_vertex('c', cVertex);

            Dictionary<char, int> dVertex = new Dictionary<char, int> { { 'a', 14 }, { 'c', 2 }, { 'f', 9 } };
            dij.add_vertex('d', dVertex);

            Dictionary<char, int> eVertex = new Dictionary<char, int> { { 'b', 15 }, { 'c', 11 }, { 'f', 6 } };
            dij.add_vertex('e', eVertex);

            Dictionary<char, int> fVertex = new Dictionary<char, int> { { 'd', 9 }, { 'e', 6 }};
            dij.add_vertex('f', fVertex);

            List<char> shortestPath = dij.shortest_path('a', 'f');

            Console.ReadKey();
        }
    }
}
