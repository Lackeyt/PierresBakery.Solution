namespace PierresBakery.Models
{
  public class Pastry
  {
    public string PastryOrderString { get; set; }
    public int PastryOrderInt;
    public int PastryCost { get; set; }

    public Pastry(string UserPastryOrder)
    {
      PastryOrderString = UserPastryOrder;
      PastryOrderInt = 0;
      PastryCost = 0;
    }

    public bool IsPastryOrderValid()
    {
      bool isInt = int.TryParse(PastryOrderString, out PastryOrderInt);
      return isInt;
    }

    public void PastryCostCalc()
    {
      int count = 1;
      while(count <= PastryOrderInt)
      {
        if (count % 3 != 0)
        {
          PastryCost += 2;
          count += 1;
        }
        else
        {
          PastryCost += 1;
          count += 1;
        }
      }
    }
  }
}