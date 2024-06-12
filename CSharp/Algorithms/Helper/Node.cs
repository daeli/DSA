
namespace DSA.Algorithms.Helper
{
    public record Node<T>(T? data, Node<T>? left, Node<T>? right)
    {
        public Node<T>? Left { get; } = left;
        public Node<T>? Right { get; } = right;
        public T? Data { get; } = data;
    }
}
