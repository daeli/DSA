using System.Collections.Generic;

namespace DSA.CodingProblems
{
    public class RomanToInt
    {
        public int Convert(string romanNumeral) 
        {
            if (romanNumeral.Length <= 0 || romanNumeral.Length > 15) return 0;

            Dictionary<string, int> keyValues = new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 }, 
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 },
                { "IV",  4},
                { "IX",  9},
                { "XL",  40},
                { "XC",  90},
                { "CD",  400},
                { "CM",  900},
            };

            if (romanNumeral.Length == 1)
                return keyValues[romanNumeral];

            var total = 0;
            for(int i = 0; i < romanNumeral.Length; i++)
            {
                var currentCharacter = romanNumeral.Substring(i, 1);
                var nextCharacter = romanNumeral.Substring(i == romanNumeral.Length -1 ? i : i + 1, 1);
                if (keyValues[currentCharacter] < keyValues[nextCharacter])
                {
                    total += keyValues[$"{currentCharacter}{nextCharacter}"];
                    i++;
                }
                else 
                {
                    total += keyValues[currentCharacter];
                }
            }


            return total;
        }
    }
}
