public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length<2) return 0; // If there are fewer than 2 prices, we can't make any transaction

        int minPrice=prices[0];
        int maxProfit=0;

        foreach(int price in prices){
            if(price<minPrice){  //find the minimum price
                minPrice=price;
            }
            else{
                int profit= price-minPrice;  // if min price is not updated, check current profit
                if(profit>maxProfit){  //compare profit with maxprofit
                    maxProfit=profit;
                }
            }
        }
        return maxProfit;
    }
}