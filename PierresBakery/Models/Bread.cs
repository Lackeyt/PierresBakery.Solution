using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    private Dictionary<string, int> _breadPrice = new Dictionary<string, int> { {"white", 5}, {"sourdough", 8}, {"baguette", 3}, {"italian", 7} };
    public string BreadOrderNumberString { get; set; }
    public string BreadType { get; set; }
    public int BreadOrderInt;
    public int BreadCost { get; set; }

    public Bread(string breadType, string UserBreadOrder)
    {
      BreadOrderNumberString = UserBreadOrder;
      BreadType = breadType;
      BreadOrderInt = 0;
      BreadCost = 0;
    }

    public bool isBreadTypeValid()
    {
      switch (BreadType)
      {
        case "white":
          return true;
        case "sourdough":
          return true;
        case "baguette":
          return true;
        default:
          return false;
      }
    }

    public bool IsBreadOrderNumberValid()
    {
      bool isInt = int.TryParse(BreadOrderNumberString, out BreadOrderInt);
      return isInt;
    }

    public void BreadCostCalc()
    {
      int count = 1;
      while(count <= BreadOrderInt)
      {
        if (count % 21 == 0)
        {
          BreadCost -= 10;
          count += 1;
        }
        else if (count % 3 == 0)
        {
          count += 1;
        }
        else
        {
          BreadCost += 5;
          count += 1;
        }
      }
    }
  }
}