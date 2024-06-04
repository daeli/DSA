using DSA.Algorithms;

namespace TestDSA
{
    [TestClass]
    public class TestAlgorithms
    {

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
