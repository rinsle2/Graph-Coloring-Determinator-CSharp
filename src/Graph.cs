using System.Collections;

namespace Program {
    public class Graph
    {
        private Dictionary<int, List<int>> nodes = new Dictionary<int, List<int>>();
        private int nodeCount = 0;
        private int colors = -1;
        private List<bool> checks = new List<bool>();

        // Public methods
        Graph() {
            
        }

        public void addNode(int n) {
            nodes.Add(n, new List<int>());
            nodeCount += 1;
        }

        public void addEdge(int s, int d) {
            if(!nodes.ContainsKey(s)) {
                addNode(s);
            }
            if(!nodes.ContainsKey(d)) {
                addNode(d);
            }
            nodes[s].Add(d);
            nodes[d].Add(s);
        }

        public bool gcDeterminator(int color) {
            // Validate all nodes
            foreach (var item in nodes) {
                rowCounts(item.Value);
            }
            addIntoCheckList();
            // set field here to avoid excessive calling
            colors = color;
            // check each row in the matrix to see if it satisfies the two conditions 
            foreach (var item in nodes)
            {
                checkMatrixRow(item.Value);
            }
            return rowTrue() && ratioTrue();
        }
        //Private methods

        private void addIntoCheckList() {
            foreach(var k in nodes.Keys) {
                checks.Add(true);
            }
        }

        private void setFalse() {
            foreach(var b in checks) {
                if(b) {
                    b = false;
                    break;
                }
            }
        }
        
        //Something is wrong here, swap the >= for a > and what do you get?
        private bool config1(int length) {
            return (length == nodeCount-1 || nodeCount > color) && length >= color;
        }
        // This should not return only false
        private bool config2(int length) {
            return false;
        }

        //check the row of the matrix based on a condition
        private void checkMatrixRow(List<int> li) {
            int len = li.Length;
            if(len == 0) return;
            if(config1(len) || config2(len)) {
                setFalse();
            }
        }

        private bool rowTrue() {
            var falses = 0;
            foreach(var b in checks) {
                falses = b? falses:falses++;
                if(falses > colors) return false;
            }
            return true;
        }

        private bool ratioTrue() {
            var falses, trues = 0;
            foreach(var b in checks) {
                var trash = b? trues++: falses++;
            }
            return falses <= trues;
        }

        private void rowCounts(List<int> li) {nodeCount = li.isEmpty() ? nodeCount-1: nodeCount; }

    }
}