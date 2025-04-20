using Algorithms.Graph.Representation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph.BFS
{
    public class BreadthFirstSearch
    {
        private List<int> result = new List<int>();

        Stack<int> stackObj = new Stack<int>();
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
            int startVertex = 4;
            stackObj.Push(startVertex);

            Console.WriteLine($"---    Breadth First Search ---- Starting Vertex: {startVertex} ");

            while (stackObj.Count() > 0)
            {
                var visitedItem = -1;
                bool lFound = false;
                if(stackObj.TryPeek(out visitedItem))
                {
                    if (!result.Contains(visitedItem))
                    {
                        result.Add(visitedItem);
                        Console.WriteLine(visitedItem);
                    }

                    foreach (var i in adjList.adjList[visitedItem])
                    {
                        
                        if (!stackObj.Contains(i) && !result.Contains(i))
                        {
                            stackObj.Push((int)i);
                            lFound = true;
                            break;
                        }
                    }
                    if (!lFound)
                        stackObj.Pop();
                }
            }
        }

    }
}
