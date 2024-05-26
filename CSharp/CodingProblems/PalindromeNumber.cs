using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodingProblems
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int num) 
        {
            if(num < 0) return false;

            var stringNum = num.ToString();
            var isEven = (stringNum.Length & 1) == 0;
            
            var numLength = stringNum.Length;

            if (numLength == 1) return true;

            var end = isEven ? numLength / 2 : (numLength - 1) / 2;
            var isPalindrome = true;
            for(int i = 0; i < end; i++)
            {
                if (stringNum.Substring(i, 1) != stringNum.Substring((numLength - (i + 1)), 1))
                {
                    isPalindrome = false; 
                    break;
                }
            }
            return isPalindrome;
        }
    }
}
