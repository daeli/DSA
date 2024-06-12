using DSA.Algorithms.Helper;
using System.Diagnostics;

namespace DSA.Algorithms
{
    public class BreadthFirstSearch
    {
        public string Search<T>(Node<T> node)
        {
            var traversalPath = Traverse<T>(node);
            return traversalPath;
        }

        public string Traverse<T>(Node<T> node) 
        {
            string traversalPath = "";
            Queue<Node<T>> queue = new Queue<Node<T>>();

            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                traversalPath += node.data;
                Debug.WriteLine($"{node.data}");
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

            return traversalPath;
        }
    }
}
