using System.ComponentModel;

namespace AutoGlassShop;

class Program
{
    static void Main(string[] args)
    {
        bool continueCalculating = true;
        
        while (continueCalculating)
        {
            double competitorPrice;
            bool answer;
            Console.WriteLine("Do you need the glass price? (true or false)");
            answer = bool.Parse(Console.ReadLine());
            
            if(answer == true) {
                Console.WriteLine("What is the competitor's price?");
                competitorPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("The glass price is: $" + GetCompetitorPrice.getGlassPrice(competitorPrice));
            }
            else
            {
                double totalPrice;
                double glassPrice;
                double tax;
               
                Console.WriteLine("What is the glass price?");
                
                glassPrice = double.Parse(Console.ReadLine());
                
                tax = glassPrice * 0.086;
                totalPrice = glassPrice + 55 + tax;
                
                Console.WriteLine("The glass price is: $" + totalPrice);
            }

            Thread.Sleep(2000); // Wait for 2 seconds
            Console.WriteLine("Press Enter to calculate another price");
            Console.ReadLine();
        }
    }
}