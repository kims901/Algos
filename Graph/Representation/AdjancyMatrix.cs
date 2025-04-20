using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph.Representation
{
    public class AdjancyMatrix
    {
        static int Vertex = 4;
        int[,] adjMat = new int[Vertex, Vertex];

        
        private void addEdge(int x, int y)
        {
            x = x - 1;
            y= y - 1;

            adjMat[x, y] = 1;
            adjMat[y, x] = 1;
        }

        private void displayMatrix()
        {
            Console.WriteLine("-----AdjancyMatrix----- Begin");
            for (int x = 0; x < Vertex; x++)
            {
                for(int y =0; y < Vertex; y++)
                {
                    Console.WriteLine(adjMat[x, y]);
                }
                Console.WriteLine("----------");
            }
            Console.WriteLine("-----AdjancyMatrix----- End");
        }

        public void main()
        {
            addEdge(1, 2);
            addEdge(2, 4);
            addEdge(2, 3);
            addEdge(3, 4);

            displayMatrix();

        }





    }
}
