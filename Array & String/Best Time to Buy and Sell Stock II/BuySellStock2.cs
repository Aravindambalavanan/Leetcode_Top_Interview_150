public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        for (int i = 1; i < prices.Length; i++)
            profit += prices[i] > prices[i-1] ? prices[i]-prices[i-1] : 0;
        return profit;
    }
}