using DSA.Algorithms;
using DSA.Algorithms.Helper;

namespace TestDSA
{
    [TestClass]
    public class TestAlgorithms
    {
        [TestMethod]
        public void TestDFS()
        {
            var tree = new Node<string>("A",
                new Node<string>("B", new Node<string>("C", null, null), new Node<string>("D", null, null)),
                new Node<string>("E", new Node<string>("F", null, null), new Node<string>("G", new Node<string>("H", null, null), null))
                );
            new DepthFirstSearch().Search(tree);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestBFS()
        {
            var expected = "ABECDFGH";

            var tree = new Node<string>("A",
                new Node<string>("B", new Node<string>("C", null, null), new Node<string>("D", null, null)), 
                new Node<string>("E", new Node<string>("F", null, null), new Node<string>("G", new Node<string>("H", null, null), null))                
                );
            var traversalPath = new BreadthFirstSearch().Search(tree);

            Assert.AreEqual(expected, traversalPath);
        }

        [TestMethod]
        public void TestQuicksort()
        {
            int[] expected = [0,1,2,3,4,5,6,7,8,9];

            var result = new QuickSort().Sort([5, 8, 0, 7, 2, 6, 4, 1, 3, 9]);

            var isEqual = Enumerable.SequenceEqual(expected, result);

            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void TestBinarySearch()
        {
            int expected = 19;

            var result = new BinarySearch().SearchSortedArray(20, 19);

            Assert.AreEqual(expected, result);
        }
    }
}
