public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int minPrice = int.MaxValue;
        for (int i = 0; i < prices.Length; i++) {
            minPrice = Math.Min(minPrice, prices[i]);
            profit = Math.Max(profit, prices[i] - minPrice);
        }
        return profit;
    }
}