using System;
using System.Collections.Generic;

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
      //PastryCost = PastryOrderInt * 2;
      // int count = 1;
      // while(count <= PastryOrderInt)
      // {
      //   if (count % 3 != 0)
      //   {
      //     PastryCost += 5;
      //     count += 1;
      //   }
      //   else
      //   {
      //     count += 1;
      //   }
      // }
    }
  }
}