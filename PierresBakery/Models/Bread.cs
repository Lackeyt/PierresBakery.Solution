namespace PierresBakery.Models
{
  public class Bread
  {
    public string BreadOrderString { get; set; }
    public int BreadOrderInt;
    public int BreadCost { get; set; }

    public Bread(string UserBreadOrder)
    {
      BreadOrderString = UserBreadOrder;
      BreadOrderInt = 0;
      BreadCost = 0;
    }

    public bool IsBreadOrderValid()
    {
      bool isInt = int.TryParse(BreadOrderString, out BreadOrderInt);
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