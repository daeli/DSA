using System.Numerics;

namespace DSA.CodingProblems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    // Leetcode #1
    public class TwoSum
    {
        public TwoSum() {}

        /// <summary>
        /// Takes 2 list nodes, reverses the order of the values, sums the 2 values, and returns the sum in a linked list.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode SumTwoListNodes(ListNode l1, ListNode l2) 
        {
            string one = GetListNodeValuesAsString(l1);
            string two = GetListNodeValuesAsString(l2);
            string sum = StringSum(one, two);
            var result = ConvertToList(sum);
            return result;
        }

        public string GetListNodeValuesAsString(ListNode ln) {
            string stringValues = "";
            ListNode node = ln;
            while (node != null)
            {
                stringValues = $"{node.val}{stringValues}";
                node = node.next;
            }
            return stringValues;
        }

        private string StringSum(string stringValueOne, string stringValueTwo)
        {
            BigInteger intOne = 0;
            BigInteger intTwo = 0;
            BigInteger.TryParse(stringValueOne, out intOne);
            BigInteger.TryParse(stringValueTwo, out intTwo);
            return (intOne + intTwo).ToString();
        }

        private ListNode ConvertToList(string sum) {
            ListNode root = null;
            for (int i = sum.Length - 1; i > -1; i--)
            {
                int num;
                int.TryParse(sum.Substring(i, 1), out num);
                root = InsertNode(root, num);
            }
            return root;
        }

        private ListNode InsertNode(ListNode root, int data) { 
            ListNode temp = new ListNode();
            temp.val = data;
            temp.next = null;
            ListNode pointer;

            if (root == null)
            {
                root = temp;
            }
            else {
                pointer = root;
                while(pointer.next != null) {
                    pointer = pointer.next;
                }
                pointer.next = temp;
            }
            return root;
        }
    }
}
