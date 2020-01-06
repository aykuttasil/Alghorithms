using System;
using System.Collections.Generic;

namespace breadth_first_search
{
    class GraphNode
    {
        public int val;
        public GraphNode next;
        public GraphNode[] neighbors;
        public bool visited;

        public GraphNode(int x)
        {
            val = x;
        }

        public GraphNode(int x, GraphNode[] neighborNodes)
        {
            val = x;
            neighbors = neighborNodes;
        }

        override public string ToString()
        {
            return "value: " + this.val;
        }

    }

    class GraphNodeQueue
    {
        GraphNode first, last;

        public void Enqueue(GraphNode node)
        {
            if (first == null)
            {
                first = node;
                last = first;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }

        public GraphNode Dequeue()
        {
            first = first.next;
            // GraphNode gn = new GraphNode(1,);
            return first;
        }

        public void WriteAllNeigbors()
        {
            var temp = first;
            while (temp.next != null)
            {
                if (temp.neighbors != null)
                {
                    foreach (var item in temp.neighbors)
                    {
                        Console.Write(item.val + " ");
                    }
                    Console.WriteLine("---");
                }
                temp = temp.next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GraphNode n1 = new GraphNode(1);
            GraphNode n2 = new GraphNode(2);
            GraphNode n3 = new GraphNode(3);
            GraphNode n4 = new GraphNode(4);
            GraphNode n5 = new GraphNode(5);

            n1.neighbors = new GraphNode[] { n2, n3, n5 };
            n2.neighbors = new GraphNode[] { n1, n4 };
            n3.neighbors = new GraphNode[] { n1, n4, n5 };
            n4.neighbors = new GraphNode[] { n2, n3, n5 };
            n5.neighbors = new GraphNode[] { n1, n3, n4 };

            BFS(n1, 5);
        }

        public static void BFS(GraphNode root, int searchValue)
        {

        }
    }
}
