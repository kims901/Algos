using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph.Representation
{
    public class AdjancyList
    {
        int Vertex;
        public List<List<int>> adjList;

        public AdjancyList(int pVertex)
        {
            Vertex = pVertex;
            adjList = new List<List<int>>(Vertex);
            for (int index = 0; index < Vertex; index++)
            {
                adjList.Add(new List<int>());
            }
        }
        public void addEdge(int x, int y)
        {            

            if(!adjList[x].Contains(y)) adjList[x].Add(y);
            if (!adjList[y].Contains(x)) adjList[y].Add(x);
        }

        public void displayAdjancyList()
        {
            Console.WriteLine("-----AdjancyList----- Begin");

            for ( int index=0; index < Vertex; index++)
            {
                Console.Write($"{index}: ==> ");

                foreach (var y in adjList[index])
                {
                    Console.Write(y + " -> ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-----AdjancyList----- End");
        }
    }

    public class AdjancyListMain()
    {
        public void main()
        {

            AdjancyList adjList = new AdjancyList(4);

            adjList.addEdge(0, 1);
            adjList.addEdge(1, 0);
            adjList.addEdge(1, 2);
            adjList.addEdge(1, 3);
            adjList.addEdge(2, 1);
            adjList.addEdge(2, 3);
            adjList.addEdge(3, 1);
            adjList.addEdge(3, 2);

            adjList.displayAdjancyList();


            
        }
    }
}
