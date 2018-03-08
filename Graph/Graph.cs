﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Graph<T>
    {
        public IList<T> GraphNodes { get; set; }

        public IList<Edge<T>> Edges { get; set; }
    }
}
