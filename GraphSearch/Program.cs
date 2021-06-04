using System;

namespace GraphSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting.......");

            Graph<int> graph = BuildGraph();
        }



        static Graph<int> BuildGraph()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddNode(1);
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddNode(7);
            graph.AddNode(10);
            graph.AddNode(11);
            graph.AddNode(12);
            graph.AddNode(42);

            graph.AddEdge(1, 5);
            graph.AddEdge(4, 11);
            graph.AddEdge(4, 42);
            graph.AddEdge(5, 11);
            graph.AddEdge(5, 12);
            graph.AddEdge(5, 42);
            graph.AddEdge(7, 10);
            graph.AddEdge(7, 11);
            graph.AddEdge(10, 11);
            graph.AddEdge(11, 42);
            graph.AddEdge(12, 42);

            return graph;
        }
    }
}
