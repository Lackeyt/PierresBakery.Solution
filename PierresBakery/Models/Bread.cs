namespace PierresBakery.Models
{
  public class Bread
  {
    public string BreadOrderString { get; set; }
    public int BreadOrderInt;
    public int BreadCost { get; set; }

    public string BreadErrorOutput { get; set; }

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
      if (IsBreadOrderValid())
      {
        int count = 1;
        while(count <= BreadOrderInt)
        {
          if (count % 3 != 0)
          {
            BreadCost += 5;
            count += 1;
          }
          else
          {
            count += 1;
          }
        }
      }
      else
      {
        BreadErrorOutput = "-invalid order- Please enter a whole number of bread loafs to order:";
      }
      
    }
  }
}