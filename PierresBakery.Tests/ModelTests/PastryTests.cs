using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastryOrder = new Pastry("test");
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod]
    public void IsPastryOrderValid_ReturnsTrueForValidIntegerPastryOrder_True()
    {
      Pastry newPastryOrder = new Pastry("5");
      Assert.AreEqual(true, newPastryOrder.IsPastryOrderValid());
    }

    [TestMethod]
    public void IsPastryOrderValid_ReturnsFalseForInvalidIntegerPastryOrder_False()
    {
      Pastry newPastryOrder = new Pastry("Five");
      Assert.AreEqual(false, newPastryOrder.IsPastryOrderValid());
    }

    [TestMethod]
    public void PastryCostCalc_EachPastryCosts2_4()
    {
      Pastry newPastryOrder = new Pastry("2");
      newPastryOrder.IsPastryOrderValid();
      newPastryOrder.PastryCostCalc();
      Assert.AreEqual(4, newPastryOrder.PastryCost);
    }

    [TestMethod]
    public void PastryCostCalc_EveryThirdPastryCosts1_5()
    {
      Pastry newPastryOrder = new Pastry("3");
      newPastryOrder.IsPastryOrderValid();
      newPastryOrder.PastryCostCalc();
      Assert.AreEqual(5, newPastryOrder.PastryCost);
    }
  }
}