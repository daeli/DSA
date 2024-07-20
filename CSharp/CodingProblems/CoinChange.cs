using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodingProblems
{
    public class CoinChange
    {
        public int ChangeCoin(int[] coins, int amount)
        {
            if(coins.Length == 0) return -1;


            coins.Order();

            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;
            
            foreach(var coin in coins)
            {
                for (int i = coin; i <= amount; i++) {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }

            return dp[amount] > amount? -1 : dp[amount];
        }

        public int ChangeCoin_Tabulation(int[] coins, int amount) 
        {
            if (coins.Length == 0) return -1;
            int[] dp = new int[amount + 1];
            dp[0] = 0;
            foreach (var coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                }
            }

            return -1;
        }
    }
}
