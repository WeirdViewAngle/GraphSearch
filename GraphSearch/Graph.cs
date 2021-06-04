using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearch
{
    class Graph<T>
    {

        List<GraphNode<T>> graphNodes = new List<GraphNode<T>>();

        #region Constractor
        public Graph()
        {
        }

        #endregion

        #region Properties

        public List<GraphNode<T>> GraphNodes
        {
            get { return graphNodes; }
        }

        #endregion

        #region Methods

        public bool AddNode(T newNode)
        {
            if (Find(newNode) != null)
            {
                // duplicate value
                return false;
            }
            else
            {
                graphNodes.Add(new GraphNode<T>(newNode));
                return true;
            }
        }

        public bool AddEdge(T graphId1, T graphId2)
        {
            GraphNode<T> node1 = Find(graphId1);
            GraphNode<T> node2 = Find(graphId2);

            if (node1 != null && node2 != null)
            {
                if (node1.Neighbours.Contains(node2))
                {
                    return false;
                }
                else
                {
                    node1.AddNeighbour(node2);
                    node2.AddNeighbour(node1);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void RemoveNode(GraphNode<T> node)
        {
            if (graphNodes.Contains(node))
            {
                graphNodes.Remove(node);
                foreach(GraphNode<T> otherNode in graphNodes)
                {
                    otherNode.RemoveNeighbour(node);
                }
            }
        }

        public GraphNode<T> Find(T value)
        {
            foreach(GraphNode<T> node in graphNodes)
            {
                if(node.Value.Equals(value))
                {
                    return node;
                }
            }
            return null;
        }

        public void Clear()
        {
            foreach(GraphNode<T> node in graphNodes)
            {
                node.RemoveAllNeighbours();
                graphNodes.Remove(node);
            }
        }

        #endregion
    }
}
