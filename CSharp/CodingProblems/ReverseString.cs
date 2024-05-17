
namespace DSA.CodingProblems
{
    public class ReverseString
    {
        public string Reverse(string s) 
        {
            if(s.Length <= 1) return s;

            var reversed = "";
            var totalStringIndex = s.Length -1;
            for (int i = 0; i < s.Length; i++) {
                reversed += s.Substring((totalStringIndex - i), 1);
            }

            return reversed;
        }
    }
}
