using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodingProblems
{
    public class LongestCommonPrefix
    {
        public string GetPrefix(string[] words) 
        {
            if (words.Length == 0 || words.Length > 200) return "";

            if (words.Where(w => w.Length == 0).Count() > 0) return "";

            if (words.Length == 1) return words[0];

            var first = words[0];
            for (int i = 1; i < first.Length + 1; i++)
            {
                for (int j = 1; j < words.Length; j++) 
                {
                    if ((i > words[j].Length) || (first.Substring(0, i) != words[j].Substring(0, i))) return first.Substring(0, i - 1);
                }
            }
            
            return first;
        }
            
    }
}
