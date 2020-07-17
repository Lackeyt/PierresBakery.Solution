using System;

namespace PierresBakery.Models
{
  class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.ForegroundColor = ConsoleColor.Black;
      string title = "Welcome to Pierre's Bakery";
      Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title).PadRight(Console.WindowWidth));
      Console.WriteLine("What type of bread would you like to add to your order? (white ($5), sourdough ($8), baguette ($3), italian ($7))");
      string breadType = Console.ReadLine();
      Console.WriteLine("How many loaves of bread would you like? (Buy 2 get your 3rd free)");
      Bread newBread = new Bread(breadType, Console.ReadLine());
      while (!newBread.isBreadTypeValid())
      {
        Console.WriteLine("-invalid input- Please choose a valid bread type (white, sourdough, baguette, italian)");
        newBread.BreadType = Console.ReadLine();
      }
      while (!newBread.IsBreadOrderNumberValid())
      {
        Console.WriteLine("-invalid input- Please enter a whole number of bread loafs ($5 each) to order (Buy 2 get your 3rd free, or buy 21 and two of them will be free):");
        newBread.BreadOrderNumberString = Console.ReadLine();
      }
      Console.WriteLine("How many pastries ($2 each, three for $5, 12 for $18) would you like? ");
      Pastry newPastry = new Pastry(Console.ReadLine());
      while (!newPastry.IsPastryOrderValid())
      {
        Console.WriteLine("-invalid input- Please enter a whole number of pastries ($2 each, three for $5, 12 for $18) to order:");
        newPastry.PastryOrderString = Console.ReadLine();
      }
      newBread.BreadCostCalc();
      newPastry.PastryCostCalc();
      int total = (newBread.BreadCost + newPastry.PastryCost);
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Your Order Details:");
      Console.WriteLine($"{newBread.BreadType} loaves: ${newBread.BreadCost}");
      Console.WriteLine($"Pastries: ${newPastry.PastryCost}");
      Console.WriteLine($"Total: ${total}");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine("Would you like to make another order? (Y/N)");
      string newOrder = Console.ReadLine();
      if (newOrder == "Y")
      {
        Main();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Thank you for visiting Pierre's Bakery! Have a nice day.");
      }
      Console.ResetColor();
    }
  }
}
