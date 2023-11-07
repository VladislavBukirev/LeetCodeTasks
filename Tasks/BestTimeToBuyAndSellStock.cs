namespace LeetCodeTasks;

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length <= 1)
            return 0;

        var firstBuy = int.MinValue;  
        var firstSell = 0;           
        var secondBuy = int.MinValue; 
        var secondSell = 0;          

        foreach (var price in prices)
        {
            firstBuy = Math.Max(firstBuy, -price);
            firstSell = Math.Max(firstSell, firstBuy + price);
            
            secondBuy = Math.Max(secondBuy, firstSell - price);
            secondSell = Math.Max(secondSell, secondBuy + price);
        }

        return secondSell;
    }
}