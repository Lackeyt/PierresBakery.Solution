using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string BreadOrderString { get; set; }
    public int BreadCost { get; set; }

    public Bread(string UserBreadOrder)
    {
      BreadOrderString = UserBreadOrder;
      BreadCost = 0;
    }

    public bool IsBreadOrderValid()
    {
      return false;
    }

    public void BreadCostCalc()
    {

    }
  }
}