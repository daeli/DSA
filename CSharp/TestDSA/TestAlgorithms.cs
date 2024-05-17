using DSA.Algorithms;

namespace TestDSA
{
    [TestClass]
    public class TestAlgorithms
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            int expected = 19;

            var result = new BinarySearch().SearchSortedArray(20, 19);

            Assert.AreEqual(expected, result);
        }
    }
}
