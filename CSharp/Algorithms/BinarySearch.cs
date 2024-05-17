
namespace DSA.Algorithms
{
    public class BinarySearch
    {
        public BinarySearch() { }

        public int SearchSortedArray(int arraySize, int target) 
        {            
            int[] ary = new int[arraySize];
            for(int i = 0; i < ary.Length; i++)
            {
                ary[i] = i;
            }

            return SearchSortedArray(ary, target);
        }

        public int SearchSortedArray(int[] array, int target)
        {
            var result = SearchArray(array, target, 0, array.Length - 1);
            
            return result;
        }

        private int SearchArray(int[] array, int target, int startingIndex, int endingIndex) 
        {
            Console.WriteLine($"Starting search range {startingIndex}.");
            Console.WriteLine($"Ending search range {endingIndex}.");

            if (startingIndex == endingIndex && array[startingIndex] == target)
                return startingIndex;

            if (startingIndex == endingIndex && array[startingIndex] != target)
                return -1;

            var mid = ((endingIndex - startingIndex) / 2) + startingIndex;

            Console.WriteLine($"Middle of the search range is index {mid}.");

            if (array[mid] == target) 
            {
                return mid;
            }else if (array[mid] < target) 
            {
                Console.WriteLine($"Target was not found, but is on the right side of the search range.");
                
                return SearchArray(array, target, mid + 1, endingIndex);
            }else if (array[mid] > target) 
            {
                Console.WriteLine($"Target was not found, but is on the left side of the search range.");
                return SearchArray(array, target, startingIndex, mid - 1);
            }

            return -1;
        }
    }
}
