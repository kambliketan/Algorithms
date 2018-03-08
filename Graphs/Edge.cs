namespace Graph
{
    public class Edge<T>
    {
        public GraphNode<T> Source { get; set; }

        public GraphNode<T> Destination { get; set; }
    }
}