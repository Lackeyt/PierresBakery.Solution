using System;

namespace PierresBakery.Models
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("What type of bread would you like to add to your order? (white, sourdough, baguette, italian)");
      string breadType = Console.ReadLine();
      Console.WriteLine("How many loaves of bread ($5 each) would you like? (Buy 2 get your 3rd free)");
      Bread newBread = new Bread(breadType, Console.ReadLine());
      while (!newBread.IsBreadOrderNumberValid())
      {
        Console.WriteLine("-invalid input- Please enter a whole number of bread loafs ($5 each) to order (Buy 2 get your 3rd free):");
        newBread.BreadOrderNumberString = Console.ReadLine();
      }
      Console.WriteLine("How many pastries ($2 each, three for $5) would you like? ");
      Pastry newPastry = new Pastry(Console.ReadLine());
      while (!newPastry.IsPastryOrderValid())
      {
        Console.WriteLine("-invalid input- Please enter a whole number of pastries ($2 each, three for $5) to order:");
        newPastry.PastryOrderString = Console.ReadLine();
      }
      newBread.BreadCostCalc();
      newPastry.PastryCostCalc();
      int total = (newBread.BreadCost + newPastry.PastryCost);
      Console.WriteLine($"Cost of bread loaves: ${newBread.BreadCost}");
      Console.WriteLine($"Cost of pastries: ${newPastry.PastryCost}");
      Console.WriteLine($"Order Total: ${total}");
      Console.WriteLine("Would you like to make another order? (Y/N)");
      string newOrder = Console.ReadLine();
      if (newOrder == "Y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thank you for visiting Pierre's Bakery! Have a nice day.");
      }
    }
  }
}
