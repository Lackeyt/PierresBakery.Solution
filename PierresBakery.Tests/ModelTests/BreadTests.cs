using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread("5");
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void IsBreadOrderValid_ReturnsTrueForValidIntegerBreadOrder_True()
    {
      Bread newBreadOrder = new Bread("5");
      Assert.AreEqual(true, newBreadOrder.IsBreadOrderValid());
    }

    // [TestMethod]
    // public void BreadCostCalc_EachBreadCosts5_10()
    // {
    //   Bread newBreadOrder = new Bread("2");
    //   newBreadOrder.BreadCostCalc();
    //   Assert.AreEqual(10, newBreadOrder.BreadCost);
    // }
  }
}