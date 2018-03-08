using System;
using System.Collections.Generic;

namespace Graph
{
    public class GraphNode<T>
    {
        public T Data { get; set; }

        public IList<Edge<T>> Edges { get; set; }
    }
}
