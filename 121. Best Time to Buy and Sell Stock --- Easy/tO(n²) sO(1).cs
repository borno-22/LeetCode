public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length<2) return 0;

        int maxProfit=0;
        for(int i=0;i<prices.Length;i++){
            for(int j=i+1;j<prices.Length;j++){
                int profit=prices[j]-prices[i];
                if(profit>maxProfit){
                    maxProfit=profit;
                }
            }
        }
        return maxProfit;
    }
}