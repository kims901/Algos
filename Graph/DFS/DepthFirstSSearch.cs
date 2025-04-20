using Algorithms.Graph.Representation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph.DFS
{
    public class DepthFirstSSearch
    {
        private List<int> result = new List<int>();

        Queue<int> queue = new Queue<int>();
        List<List<int>> adjList = new List<List<int>>();


        public void main()
        {
            AdjancyList adjList = new AdjancyList(5);

            adjList.addEdge(0, 1);
            adjList.addEdge(0, 2);
            adjList.addEdge(0, 3);
            adjList.addEdge(1, 0);
            adjList.addEdge(1, 3);
            adjList.addEdge(2, 3);
            adjList.addEdge(3, 0);
            adjList.addEdge(3, 1);
            adjList.addEdge(3, 4);
            adjList.addEdge(4, 3);

            adjList.displayAdjancyList();


            //Start with Vertex 1
            int startVertex = 1;
            queue.Enqueue(startVertex);

            Console.WriteLine($"---    Depth First Search ---- Starting Vertex: {startVertex} ");

            while (queue.Count > 0)
            {
                var visitedItem = queue.Dequeue();

                result.Add(visitedItem);

                Console.WriteLine(visitedItem.ToString());

                foreach (var i in adjList.adjList[visitedItem])
                {
                    if (!queue.Contains(i) && !result.Contains(i))
                        queue.Enqueue((int)i);
                }
            }
        }

    }
}
