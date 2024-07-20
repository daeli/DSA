
namespace DSA.CodingProblems
{
    // Leetcode #121
    public class MaxProfit
    {
        public int FindMaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buy = prices[0];
            for(int i = 1; i< prices.Length; i++)
            {
                var sell = prices[i];
                if (sell > buy)
                {
                    var profit = sell - buy;
                    if(profit > maxProfit)
                        maxProfit = profit;
                }
                else 
                { 
                    buy = prices[i];
                }
                
            }
            return maxProfit;
        }
    }
}
