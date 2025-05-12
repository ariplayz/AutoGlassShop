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
            Console.WriteLine("Do you need the glass price? (Y/N)");
            string input = Console.ReadLine()?.ToUpper() ?? "N";
            
            if(input == "Y") {
                Console.WriteLine("What is the competitor's price?");
                competitorPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("The glass price is: $" + getGlassPrice(competitorPrice));
            }
            else if(input == "N")
            {
                double totalPrice;
                double glassPrice;
                double tax;
               
                Console.WriteLine("What is the glass price?");
                
                glassPrice = double.Parse(Console.ReadLine());
                
                tax = Math.Round(glassPrice * 0.086, 2);
                totalPrice = Math.Round(glassPrice + 55 + tax, 2);
                
                Console.WriteLine("The glass price is: $" + totalPrice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
                continue;
            }

            Thread.Sleep(2000);
            Console.WriteLine("Press Enter to calculate another price");
            Console.ReadLine();
        }
    }
    
    static double getGlassPrice(double competitorPrice)
    {
        double price;
        double tax;
        
        tax = Math.Round(competitorPrice * 0.086, 2);
        price = competitorPrice - 55 - tax;

        return Math.Round(price, 2);
    }
}