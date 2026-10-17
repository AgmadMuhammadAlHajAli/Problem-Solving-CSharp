public class Solution {
     public int MaxProfit(int[] prices)
 {
     
     int maxProfit = 0, minprice = prices[0];
     for (int i = 0; i < prices.Length; i++)
     {
         if (prices[i] < minprice)
         {
             minprice = prices[i];
         }
        else if ((prices[i] - minprice) > maxProfit)
         {
             maxProfit = prices[i] - minprice;
         }
     }
     return maxProfit ;
     
 }
}