using System;

namespace PierresBakery.Models
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("How many loaves of bread ($5 each) would you like? (Buy 2 get your 3rd free)");
      Bread newBread = new Bread(Console.ReadLine());
      while (!newBread.IsBreadOrderValid())
      {
        Console.WriteLine("-invalid input- Please enter a whole number of bread loafs ($5 each) to order (Buy 2 get your 3rd free):");
        newBread.BreadOrderString = Console.ReadLine();
      }
      Console.WriteLine("How many pastries ($2 each, three for $5) would you like? ");
      Pastry newPastry = new Pastry(Console.ReadLine());
      while (!newPastry.IsPastryOrderValid())
      {
        Console.WriteLine("-invalid inpud- Please enter a whole number of pastries ($2 each, three for $5) to order:");
        newPastry.PastryOrderString = Console.ReadLine();
      }
      newBread.BreadCostCalc();
      newPastry.PastryCostCalc();
      int total = (newBread.BreadCost + newPastry.PastryCost);
      Console.WriteLine($"Your bread loaves cost ${newBread.BreadCost}");
      Console.WriteLine($"Your pastries cost ${newPastry.PastryCost}");
      Console.WriteLine($"Your order total is ${total}");
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
