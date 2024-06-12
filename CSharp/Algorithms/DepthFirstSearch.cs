using DSA.Algorithms.Helper;
using System.Diagnostics;

namespace DSA.Algorithms
{
    public class DepthFirstSearch
    {

        public void Search<T>(Node<T> node)
        {
            traverse<T>(node);
        }

        private void traverse<T>(Node<T> node)
        {
            if (node == null)
                return;

            Debug.WriteLine($"{node.data}");

            traverse<T>(node.Left);
            traverse<T>(node.Right);
        }
    }
}
