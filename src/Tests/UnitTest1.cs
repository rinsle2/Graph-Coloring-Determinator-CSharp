using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program.Tests {
    [TestClass]
    public class SquareGraphTest {

        private void initializeSquareGraph(Graph g) {
            g.addEdge(1, 3);
            g.addEdge(1, 2);
            g.addEdge(3, 2);
            g.addEdge(3, 4);
            g.addEdge(4, 2);
            g.addEdge(1, 4);
        }

        [TestMethod]
        public void squareTest() {
            Graph g = new Graph();
            initializeSquareGraph(g);
            Console.WriteLine(g.gcDeterminator(3));
        }
    }
}