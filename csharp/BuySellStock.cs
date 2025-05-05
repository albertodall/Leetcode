namespace Leetcode.CSharp.BuySellStock;

/// <summary>
/// <see cref="https://leetcode.com/problems/best-time-to-buy-and-sell-stock/"/>
/// Results: <see cref="https://leetcode.com/problems/best-time-to-buy-and-sell-stock/submissions/1626357910/"/>
/// </summary>
public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int profit = 0;
        int buy = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > buy) 
            { 
                profit = Math.Max(profit, prices[i] - buy);
            }
            else
            {
                buy = prices[i];
            }
        }

        return profit;
    }
}