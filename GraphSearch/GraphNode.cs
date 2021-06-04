using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearch
{
    class GraphNode<T>
    {
        #region Values

        T value;
        List<GraphNode<T>> neighbours;

        #endregion

        #region Constructor

        public GraphNode(T value)
        {
            this.value = value;
            neighbours = new List<GraphNode<T>>();
        }

        #endregion

        #region Properties

        public T Value
        {
            get { return value; }
        }

        public List<GraphNode<T>> Neighbours
        {
            get { return neighbours; }
        }

        #endregion

        #region Methods

        public bool AddNeighbour(GraphNode<T> neighbourNode)
        {
            if (neighbours.Contains(neighbourNode))
            {
                return false;
            }
            else
            {
                
                neighbours.Add(neighbourNode);
                return true;
            }
        }

        public bool RemoveNeighbour(GraphNode<T> neighbourNode)
        {
            if (neighbours.Contains(neighbourNode))
            {
                neighbours.Remove(neighbourNode);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAllNeighbours()
        {
            foreach(GraphNode<T> neighbour in neighbours)
            {
                neighbours.Remove(neighbour);
            }
        }

        #endregion
    }


}
