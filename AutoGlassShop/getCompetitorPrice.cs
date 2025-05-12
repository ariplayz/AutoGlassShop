using System.ComponentModel;

namespace AutoGlassShop;

public class GetCompetitorPrice
{
    public static double getGlassPrice(double competitorPrice)
    {
        double price;
        double tax;
        
        tax = competitorPrice * 0.086;

        price = competitorPrice - 55 - tax;

        return price;
    }
}