using System.Collections.Generic;

namespace Program
{
    class Name
    {
        static void initializeSquareGraph(Graph g) {
            g.addEdge(1, 3);
            g.addEdge(1, 2);
            g.addEdge(3, 2);
            g.addEdge(3, 4);
            g.addEdge(4, 2);
            g.addEdge(1, 4);
        }
       static void Main(string[] args) {
           Graph g1 = new Graph();
           initializeSquareGraph(g1);

       }
    }
}