using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodingProblems
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            
            if (n < 1 || n > 45) return 0;

            if (n == 1) return 1;

            int stairs = n;

            int previous = 1;
            int current  = 1;
            int paths = 1;
            
            for (int stair = 2; stair <= stairs; stair++)
            {                
                paths = current + previous;
                previous = current;
                current = paths;                
            }
            return paths;
        }
    }
}
