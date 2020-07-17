using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string BreadOrderString { get; set; }
    public int BreadCost { get; set; }

    public Bread()
    {
      // BreadOrderString = UserBreadOrder;
      // BreadCost = 0;
    }
  }
}