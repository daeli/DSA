
namespace DSA.CodingProblems
{
    public class WordLadder
    {
        /*
                        hit
			            hot
		            dot - lot
	            dog			dot
            cog					dog
				            cog		log
							            cog
         */
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var wordListHash = new HashSet<string>(wordList);
            if (!wordListHash.Contains(endWord)) return 0;

            if (beginWord.Length != endWord.Length) return 0;

            if (wordListHash.Count < 1 || wordListHash.Count > 5000) return 0;

            if (beginWord == endWord) return 0;

            var visited = new HashSet<string>();

            var queue = new Queue<(string word, int count)>();

            queue.Enqueue((beginWord, 1));
            visited.Add(beginWord);

            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            while (queue.Count > 0)
            {
                var queueItem = queue.Dequeue();

                for(int i = 0; i < queueItem.word.Length; i++)
                {
                    char[] wordArray = queueItem.word.ToCharArray();
                    for(int j = 0; j < letters.Length; j++)
                    {
                        wordArray[i] = letters[j];
                        var newWord = string.Join("", wordArray);
                        if(wordListHash.Contains((newWord)) && !visited.Contains(newWord) && newWord != queueItem.word)
                        {
                            if(endWord == newWord) return queueItem.count + 1;

                            queue.Enqueue((newWord, queueItem.count + 1));
                            visited.Add(newWord);
                        }
                    }
                }

            }
            return 0;
        }
    }
}
