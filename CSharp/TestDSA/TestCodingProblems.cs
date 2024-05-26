using DSA.CodingProblems;

namespace TestDSA
{
    [TestClass]
    public class TestCodingProblems
    {

        [TestMethod]
        public void TestPalindromeNumber()
        { 
/*            var result = new PalindromeNumber().IsPalindrome(10);

            Assert.IsTrue(result);*/

            var result = new PalindromeNumber().IsPalindrome(-110);

            Assert.IsFalse(result);

/*            var result = new PalindromeNumber().IsPalindrome(10);

            Assert.IsFalse(result);*/
        }

        [TestMethod]
        public void TestReverseString()
        {
            string expected = "GFEDCBA";
            
            var reversed = new ReverseString().Reverse("ABCDEFG");

            Assert.AreEqual(expected, reversed.ToString());
        }

        [TestMethod]
        public void TestRomanToInt()
        {
            int expected = 1994;

            var conversion = new RomanToInt().Convert("MCMXCIV");

            Assert.AreEqual(expected, conversion);
        }

        [TestMethod]
        public void TestTwoSum()
        {
            var l1 = new ListNode(1,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1)))))))))))))))))))))))))))))));

            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            
            var twoSum = new TwoSum();
            var expected = "1000000000000000000000000000466";

            var sum = new TwoSum().SumTwoListNodes(l1, l2);

            var sumString = twoSum.GetListNodeValuesAsString(sum);

            Assert.AreEqual(expected, sumString);
        }
    }
}