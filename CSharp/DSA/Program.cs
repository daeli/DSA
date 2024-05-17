
using System;



namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // new TwoSum().run();
            // new RomanToInt().Convert("MCMXCIV");
            // new ReverseString().Reverse("ABCDEFG");
            Console.WriteLine("Choose an algorithm to examine:");
            Console.WriteLine("Enter 1 for Binary Search");
            var s = Console.ReadLine();
            if(s != null) 
            {
                if (s == "1") 
                {
                    var result = ""; // new BinarySearch().SearchSortedArray(20, 19);
                    Console.WriteLine(result);
                }
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        
        }
    }
}
